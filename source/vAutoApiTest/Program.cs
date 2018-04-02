using System;

namespace vAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new Processor();

            try
            {
                processor.Process();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
