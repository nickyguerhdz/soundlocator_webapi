using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SoundLocator_WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
//        [HttpGet]
//        [Route("api/values/getcolor")]
//        public async Task<IHttpActionResult> getcolor()
//        {
//            using (HttpClient httpClient = new HttpClient()) 
//            {
//                string API = "https://freesound.org/apiv2/search/text/?query=piano&token=O09cmoxpCd9unINsDZerc7jUjO9xJemOc4T2vXbc";
//                //string API = "https://palett.es/API/v1/palette";

//                try
//                {
//                    HttpResponseMessage response = await httpClient.GetAsync(API);

//                    if (response.IsSuccessStatusCode)
//                    {
//                        var responseData = await response.Content.ReadAsAsync<object>();

//                        return Ok(responseData);
//                    }
//                    else
//                    {
//                        return BadRequest("Error");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    return InternalServerError(ex);
//                }
//            }

//        }
//    }
//}
