using Newtonsoft.Json; 
using Newtonsoft.Json.Serialization; 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 


namespace TestMVC_Converver.Helpers
{
    public class JsonHelper
    {
        /// <summary> 
        /// Helper method to serialize data with camelCase property names 
        /// that work nicer with javascript 
        /// </summary> 
        public static string SerializeObject(object data)
        {
            var jsonSerializerSettings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            return JsonConvert.SerializeObject(data, jsonSerializerSettings);
        }
    }

}