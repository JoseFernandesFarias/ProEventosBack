using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace ProEventos.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
  
        [HttpGet]
        public string Get()
        {
            return "return method Get";
        }
        [HttpGet("{id}")]
        public string GetById(int id)
        {
            return "Return method Get id = " + id.ToString();
        }

        [HttpPost]
        public string Post()
        {
            return "Retorno do médoto Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Retorno do médoto Put id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Retorno do médoto Delete id = {id}";
        }


    }
}
