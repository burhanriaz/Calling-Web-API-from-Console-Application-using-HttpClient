using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace Calling_Web_API_from_Console_Application_using_HttpClient
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World! 1");
            CallWebAPIAsync().Wait();

            Console.WriteLine("******************************************");
            Console.WriteLine("******************************************");
            Console.WriteLine("Hello World! 2 ");

            CallWebAPIAsync2().Wait();

            Console.WriteLine("******************************************");
            Console.WriteLine("******************************************");
            Console.WriteLine("Hello World! 3 ");
            //Program program = new Program();
            //program.Disaply();
        }
        static async Task CallWebAPIAsync()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("User-Agent", ".NET");
                var data = await client.GetStringAsync("https://fcc-weather-api.glitch.me/api/current?lat=35&lon=139");
                if (data != null)
                {

                    JObject jObject = JObject.Parse(data);
                    Console.Write(jObject);
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
        }
        static async Task CallWebAPIAsync2()
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://fcc-weather-api.glitch.me/api/current?lat=35&lon=139");

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("User-Agent", ".NET");

                HttpResponseMessage response = await client.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();                  
                    JObject jObject = JObject.Parse(data);
                    Console.Write(jObject);
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }

            }
        }

        //public async void Disaply()
        //{
        //    RootObject rootObject = await this.GetRequest();
        //    Console.WriteLine("City name is" + rootObject.name);
        //    Console.WriteLine("Temprature in K is" + rootObject.main.temp);
        //}

        //public async Task<RootObject> GetRequest()
        //{
        //    using (var client = new HttpClient())
        //    {
        //       try
        //        {

        //            var respose = await client.GetAsync(new Uri("https://fcc-weather-api.glitch.me/api/current?lat=35&lon=139"));
        //            var result = await respose.Content.ReadAsStringAsync();
        //            var serializer = new DataContractJsonSerializer(typeof(RootObject));
        //            var MemoryStream = new MemoryStream(Encoding.UTF8.GetBytes(result));
        //            var FinalData = serializer.ReadObject(MemoryStream) as RootObject;
        //            return FinalData;
        //        }
        //        catch (Exception ex)
        //        {

        //            throw ex;
        //        }
                

        //    }

       // }

    }
}
