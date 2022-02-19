﻿using System.Web.Http;
using Owin;

namespace FWSelfHostOWIN {
    public class Startup {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder) {
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new {id = RouteParameter.Optional}
            );
            SwaggerConfig.Register(config);

            appBuilder.UseWebApi(config);
        }
    }
}