using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.WebApi.Data;
using ProEventos.WebApi.Models;

namespace ProEventos.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        /*public IEnumerable<Evento> _evento = new Evento[]{
             new Evento(){
                EventoId = 1,
                Tema = "Angular 16 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
             new Evento(){
                EventoId = 2,
                Tema = "Angular 16 e suas propriedades",
                Local = "São Paulo",
                Lote = "2º lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"
            },

        };*/
        private readonly DataContext _context;
        public EventosController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }
        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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
