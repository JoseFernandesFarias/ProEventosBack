using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model); 
        Task<Evento> UpdateEvento(int  eventoId, Evento model); 
        Task<Evento> DeleteEvento(int eventoId); 
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento> GetEventoByIdAsync(int EventoId,  bool includePalestrantes = false);
    }
}