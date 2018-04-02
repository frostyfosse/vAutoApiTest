using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Newtonsoft.Json;

namespace vAuto
{
    public class Processor
    {
        const string BaseUrlPath = @"http://vautointerview.azurewebsites.net";

        public Processor()
        {
        }

        void Log(string message)
        {
                Console.WriteLine(message);
        }
        
        List<VehicleResponse> FetchVehicles(string dataSetId)
        {
            var api = new VehiclesApi(BaseUrlPath);
            var vehicles = new List<VehicleResponse>();

            Log("Fetching Vehicle Ids");

            var ids = api.VehiclesGetIds(dataSetId);

            if (ids == null || ids.VehicleIds == null || ids.VehicleIds.Count == 0)
                return vehicles;

            var cleanIds = ids.VehicleIds?.Where(x => x.HasValue)?
                                          .Select(x => x.Value)
                                          .Distinct();

            Log($"{cleanIds.Count()} received");

            Log("Fetching Vehicles");

            foreach (var id in cleanIds)
            {
                var vehicle = api.VehiclesGetVehicle(dataSetId, id);

                if (vehicle == null)
                {
                    Log($"Server could not find vehicle with id '{id}'");
                    continue;
                }

                vehicles.Add(vehicle);
            }

            return vehicles;
        }

        List<DealerAnswer> FetchDealers(string dataSetId, IEnumerable<int> ids)
        {
            var api = new DealersApi(BaseUrlPath);
            var dealers = new List<DealerAnswer>();

            Log("Fetching Dealers");

            foreach (var id in ids)
            {
                var dealer = api.DealersGetDealer(dataSetId, id);

                if (dealer == null)
                {
                    Log($"Unable to find dealer by id '{id}'");
                    continue;
                }

                dealers.Add(new DealerAnswer(dealer.DealerId, dealer.Name));
            }

            return dealers;
        }        

        void OutputResults(AnswerResponse response)
        {
            Log("Server Results");

            var successResult = response.Success.HasValue ? response.Success.Value.ToString() : "N/A";
            Log($"{nameof(response.Success)}: {successResult}");

            var timeResult = response.TotalMilliseconds.HasValue ? Convert.ToString(response.TotalMilliseconds.Value) : "N/A";
            Log($"{nameof(response.TotalMilliseconds)}: {timeResult}");

            Log($"{nameof(response.Message)}: '{response.Message}'");

            var json = JsonConvert.SerializeObject(response);
            var responseFilePath = Path.Combine(Environment.CurrentDirectory, "Answer.json");

            Log($"Outputting results to file in '{responseFilePath}'");

            File.WriteAllText(responseFilePath, json);
        }

        public void Process()
        {
            var dataSetApi = new DataSetApi(BaseUrlPath);

            var dataSetResponse = dataSetApi.DataSetGetDataSetId();
            var dataSetId = dataSetResponse.DatasetId;

            var vehicles = FetchVehicles(dataSetId);

            var dealerIds = vehicles?.Where(x => x.DealerId.HasValue)?
                                     .Select(x => x.DealerId.Value)
                                     .Distinct();
            var dealers = FetchDealers(dataSetId, dealerIds);

            foreach (var dealer in dealers)
            {
                dealer.Vehicles = new List<VehicleAnswer>();

                var dealerVehicles = vehicles.Where(x => x.DealerId.HasValue && x.DealerId.Value == dealer.DealerId);

                foreach (var vehicle in dealerVehicles)
                {
                    dealer.Vehicles.Add(new VehicleAnswer(vehicle.VehicleId, vehicle.Year, vehicle.Make, vehicle.Model));
                }
            }

            Log("Posting Answer");

            var response = dataSetApi.DataSetPostAnswer(dataSetId, new Answer(dealers));

            OutputResults(response);
        }
    }
}
