using Microsoft.AspNetCore.Mvc;

namespace CleientRestApi.Controllers
{
    [ApiController]
    [Route("api/rest/")]
    public class RestController : ControllerBase
    {
        [HttpGet("Get")]
        public string Get()
        {
            return "Succesfully called RESTful Get method";
        }

        [HttpPost("Post/{id}")]
        public string Post([FromBody] int id)
        { 
            return $"Id = {id}, is successfully Posted/Inserted";
        }
                
        [HttpPut("Put/{id}")]
        public string Put([FromBody] int id)
        {
            return $"Id = {id}, is successfully Put/Updated";
        }

        [HttpDelete("Delete/{id}")]
        public string Delete(int id)
        {
            return $"Id = {id}, is successfully Deleted";
        }
    }
}