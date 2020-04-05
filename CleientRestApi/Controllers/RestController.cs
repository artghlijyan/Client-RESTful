using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace CleientRestApi.Controllers
{
    [ApiController]
    [Route("api/rest/")]
    public class RestController : ControllerBase
    {
        [HttpPost("Post/{id}")]
        public string Post([FromBody] int id)
        {
            return $"Id = {id}, is successfully Posted/Inserted";
        }

        [HttpGet("Get")]
        public string Get()
        {
            return "Succesfully called RESTful Get method";
        }
                
        [HttpPut("Put/{id}")]
        public string Put([FromBody] int id)
        {
            return $"Id = {id}, is successfully Put/Updated";
        }

        [HttpDelete("Delete/{id}")]
        public string Delete([FromUri] int id)
        {
            return $"Id = {id}, is successfully Deleted";
        }
    }
}