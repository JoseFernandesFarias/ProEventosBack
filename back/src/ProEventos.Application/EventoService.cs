using System;
using System.Threading.Tasks;
using ProEventos.Application.Contratos;
using ProEventos.Domain;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Application
{
    public class EventoService : IEventoService
    {
        private readonly IGeralPersist _geralPersist;
        private readonly IEventoPersist _eventoPersist;
        public EventoService(IGeralPersist geralPersist, IEventoPersist eventoPersist)
        {
            this._eventoPersist = eventoPersist;
            this._geralPersist = geralPersist;

        }
        public async Task<Evento> AddEventos(Evento model)
        {
            try
            {
                _geralPersist.Add<Evento>(model);
                if(await _geralPersist.SaveChangesAsync())
                {
                    return await _eventoPersist.GetEventoByIdAsync(model.Id,false);
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            throw new System.NotImplementedException();
        }

        public Task<Evento> DeleteEvento(int eventoId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrantes = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento> UpdateEvento(int eventoId, Evento model)
        {
            throw new System.NotImplementedException();
        }
    }
}