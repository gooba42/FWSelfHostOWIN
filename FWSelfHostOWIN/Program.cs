using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace FWSelfHostOWIN {
    public class Program {
        private static void Main() {
            var baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(baseAddress)) {
                // Create HttpClient and make a request to api/values 
                var client = new HttpClient();

                var response = client.GetAsync(baseAddress + "api/json").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }
        }
    }
}