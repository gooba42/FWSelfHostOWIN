﻿using System.Web.Http;
using Swashbuckle.Application;

namespace FWSelfHostOWIN {
    public class SwaggerConfig {
        public static void Register(HttpConfiguration config) {
            config.EnableSwagger(c => {
                c.SingleApiVersion("v1", "Name.API"); }).EnableSwaggerUi(c => { });
            
        }
    }
}