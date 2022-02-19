using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace FWSelfHostOWIN {
    public class JSONController : ApiController {
        // GET api/json 
        public string Get() {
            return "Please see http://localhost:9000/swagger/ui/index for documentation.";
        }

        // POST api/json 
        public JObject Post([FromBody] JObject value) {
            return value;

        }
        
    }
}