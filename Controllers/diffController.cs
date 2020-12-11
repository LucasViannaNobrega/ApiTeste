using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

using ApiLucas.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiLucas.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class diffController : ControllerBase
    { 
        string jsonStrRight = "";  // string para gravar o resultado left apra comparação.
        string jsonStrLeft = ""; // string para gravar o resultado left apra comparação.     
        // GET api/diff
        // END point que irá retornar o resultado da comparação
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            /*
                *não consegui fazer comparação compilar
            */

            //jsonStrRight.s.BeEquivalentTo(jsonStrLeft); //

            return new string[] { "value1", "value2" };
        }

        // GET api/diff/5
     
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // ENDPOINT RIGHT
        [HttpGet("Right/{id}")]
        public ActionResult<string> Right(string jsonStr)
        {
            jsonStrRight = JsonConvert.DeserializeObject<string>(jsonStr); 
            return jsonStrRight;
        }

        // ENDPOINT LEFT
        [HttpGet("Left/{id}")]
        public ActionResult<string> Left(string jsonStr)
        {
            jsonStrLeft = JsonConvert.DeserializeObject<string>(jsonStr); 
            return jsonStrLeft;
        }
        
        // POST api/diff
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/diff/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
