using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleientRestApiRealization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpPost]
        public string Post()
        {
            return "this is Post";
        }

        [HttpPost]
        public string Get()
        {
            return "this is get";
        }

        [HttpPut]
        public string Put()
        {
            return "this is put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "this is delete";
        }
    }
}