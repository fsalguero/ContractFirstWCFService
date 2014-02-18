using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoClient.Service;
using System.ServiceModel;

namespace DemoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Service.DemoServiceClient();

            try
            {
                var t = client.Test(new TestRequest
                {
                    number = 60
                });

                Console.WriteLine(t.result1);
            }
            catch (FaultException exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.ReadKey();
        }
    }
}
