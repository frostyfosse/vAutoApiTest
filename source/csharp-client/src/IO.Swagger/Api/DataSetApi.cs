/* 
 * DealersAndVehicles
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataSetApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get correct answer for dataset (cheat)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>Answer</returns>
        Answer DataSetGetCheat (string datasetId);

        /// <summary>
        /// Get correct answer for dataset (cheat)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>ApiResponse of Answer</returns>
        ApiResponse<Answer> DataSetGetCheatWithHttpInfo (string datasetId);
        /// <summary>
        /// Creates new dataset and returns its ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DatasetIdResponse</returns>
        DatasetIdResponse DataSetGetDataSetId ();

        /// <summary>
        /// Creates new dataset and returns its ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DatasetIdResponse</returns>
        ApiResponse<DatasetIdResponse> DataSetGetDataSetIdWithHttpInfo ();
        /// <summary>
        /// Submit answer for dataset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="answer"></param>
        /// <returns>AnswerResponse</returns>
        AnswerResponse DataSetPostAnswer (string datasetId, Answer answer);

        /// <summary>
        /// Submit answer for dataset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="answer"></param>
        /// <returns>ApiResponse of AnswerResponse</returns>
        ApiResponse<AnswerResponse> DataSetPostAnswerWithHttpInfo (string datasetId, Answer answer);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get correct answer for dataset (cheat)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>Task of Answer</returns>
        System.Threading.Tasks.Task<Answer> DataSetGetCheatAsync (string datasetId);

        /// <summary>
        /// Get correct answer for dataset (cheat)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>Task of ApiResponse (Answer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Answer>> DataSetGetCheatAsyncWithHttpInfo (string datasetId);
        /// <summary>
        /// Creates new dataset and returns its ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DatasetIdResponse</returns>
        System.Threading.Tasks.Task<DatasetIdResponse> DataSetGetDataSetIdAsync ();

        /// <summary>
        /// Creates new dataset and returns its ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DatasetIdResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DatasetIdResponse>> DataSetGetDataSetIdAsyncWithHttpInfo ();
        /// <summary>
        /// Submit answer for dataset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="answer"></param>
        /// <returns>Task of AnswerResponse</returns>
        System.Threading.Tasks.Task<AnswerResponse> DataSetPostAnswerAsync (string datasetId, Answer answer);

        /// <summary>
        /// Submit answer for dataset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="answer"></param>
        /// <returns>Task of ApiResponse (AnswerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnswerResponse>> DataSetPostAnswerAsyncWithHttpInfo (string datasetId, Answer answer);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataSetApi : IDataSetApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataSetApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DataSetApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get correct answer for dataset (cheat) 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>Answer</returns>
        public Answer DataSetGetCheat (string datasetId)
        {
             ApiResponse<Answer> localVarResponse = DataSetGetCheatWithHttpInfo(datasetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get correct answer for dataset (cheat) 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>ApiResponse of Answer</returns>
        public ApiResponse< Answer > DataSetGetCheatWithHttpInfo (string datasetId)
        {
            // verify the required parameter 'datasetId' is set
            if (datasetId == null)
                throw new ApiException(400, "Missing required parameter 'datasetId' when calling DataSetApi->DataSetGetCheat");

            var localVarPath = "/api/{datasetId}/cheat";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datasetId != null) localVarPathParams.Add("datasetId", Configuration.ApiClient.ParameterToString(datasetId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DataSetGetCheat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Answer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Answer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Answer)));
        }

        /// <summary>
        /// Get correct answer for dataset (cheat) 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>Task of Answer</returns>
        public async System.Threading.Tasks.Task<Answer> DataSetGetCheatAsync (string datasetId)
        {
             ApiResponse<Answer> localVarResponse = await DataSetGetCheatAsyncWithHttpInfo(datasetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get correct answer for dataset (cheat) 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>Task of ApiResponse (Answer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Answer>> DataSetGetCheatAsyncWithHttpInfo (string datasetId)
        {
            // verify the required parameter 'datasetId' is set
            if (datasetId == null)
                throw new ApiException(400, "Missing required parameter 'datasetId' when calling DataSetApi->DataSetGetCheat");

            var localVarPath = "/api/{datasetId}/cheat";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datasetId != null) localVarPathParams.Add("datasetId", Configuration.ApiClient.ParameterToString(datasetId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DataSetGetCheat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Answer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Answer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Answer)));
        }

        /// <summary>
        /// Creates new dataset and returns its ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DatasetIdResponse</returns>
        public DatasetIdResponse DataSetGetDataSetId ()
        {
             ApiResponse<DatasetIdResponse> localVarResponse = DataSetGetDataSetIdWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates new dataset and returns its ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DatasetIdResponse</returns>
        public ApiResponse< DatasetIdResponse > DataSetGetDataSetIdWithHttpInfo ()
        {

            var localVarPath = "/api/datasetId";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DataSetGetDataSetId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DatasetIdResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DatasetIdResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DatasetIdResponse)));
        }

        /// <summary>
        /// Creates new dataset and returns its ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DatasetIdResponse</returns>
        public async System.Threading.Tasks.Task<DatasetIdResponse> DataSetGetDataSetIdAsync ()
        {
             ApiResponse<DatasetIdResponse> localVarResponse = await DataSetGetDataSetIdAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates new dataset and returns its ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DatasetIdResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DatasetIdResponse>> DataSetGetDataSetIdAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/datasetId";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DataSetGetDataSetId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DatasetIdResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DatasetIdResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DatasetIdResponse)));
        }

        /// <summary>
        /// Submit answer for dataset 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="answer"></param>
        /// <returns>AnswerResponse</returns>
        public AnswerResponse DataSetPostAnswer (string datasetId, Answer answer)
        {
             ApiResponse<AnswerResponse> localVarResponse = DataSetPostAnswerWithHttpInfo(datasetId, answer);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submit answer for dataset 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="answer"></param>
        /// <returns>ApiResponse of AnswerResponse</returns>
        public ApiResponse< AnswerResponse > DataSetPostAnswerWithHttpInfo (string datasetId, Answer answer)
        {
            // verify the required parameter 'datasetId' is set
            if (datasetId == null)
                throw new ApiException(400, "Missing required parameter 'datasetId' when calling DataSetApi->DataSetPostAnswer");
            // verify the required parameter 'answer' is set
            if (answer == null)
                throw new ApiException(400, "Missing required parameter 'answer' when calling DataSetApi->DataSetPostAnswer");

            var localVarPath = "/api/{datasetId}/answer";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "text/html", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datasetId != null) localVarPathParams.Add("datasetId", Configuration.ApiClient.ParameterToString(datasetId)); // path parameter
            if (answer != null && answer.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(answer); // http body (model) parameter
            }
            else
            {
                localVarPostBody = answer; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DataSetPostAnswer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnswerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnswerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnswerResponse)));
        }

        /// <summary>
        /// Submit answer for dataset 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="answer"></param>
        /// <returns>Task of AnswerResponse</returns>
        public async System.Threading.Tasks.Task<AnswerResponse> DataSetPostAnswerAsync (string datasetId, Answer answer)
        {
             ApiResponse<AnswerResponse> localVarResponse = await DataSetPostAnswerAsyncWithHttpInfo(datasetId, answer);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submit answer for dataset 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="answer"></param>
        /// <returns>Task of ApiResponse (AnswerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnswerResponse>> DataSetPostAnswerAsyncWithHttpInfo (string datasetId, Answer answer)
        {
            // verify the required parameter 'datasetId' is set
            if (datasetId == null)
                throw new ApiException(400, "Missing required parameter 'datasetId' when calling DataSetApi->DataSetPostAnswer");
            // verify the required parameter 'answer' is set
            if (answer == null)
                throw new ApiException(400, "Missing required parameter 'answer' when calling DataSetApi->DataSetPostAnswer");

            var localVarPath = "/api/{datasetId}/answer";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "text/html", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datasetId != null) localVarPathParams.Add("datasetId", Configuration.ApiClient.ParameterToString(datasetId)); // path parameter
            if (answer != null && answer.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(answer); // http body (model) parameter
            }
            else
            {
                localVarPostBody = answer; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DataSetPostAnswer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnswerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnswerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnswerResponse)));
        }

    }
}
