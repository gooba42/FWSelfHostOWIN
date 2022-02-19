using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using OWIN_Selenium;

namespace FWSelfHostOWIN {
    public class JSONController : ApiController {
        // GET api/json 
        public string Get() {
            return "Please see http://localhost:9000/swagger/ui/index for documentation.";
        }

        // POST api/json 
        public JObject Post([FromBody] JObject value) {
            DriverHelp driverhelp = new DriverHelp();
            var myUrl = value["SITE"]["URL"].ToString();

            foreach (var action in value["Actions"]) {
                Console.WriteLine(action.ToString());
            }

        driverhelp.navigate(myUrl);
            return value;

        }
        
    }
}