using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
        //GERAL
         void Add<T>(T entity) where T: class;
         void Update<T>(T entity) where T:class;
         void Delete<T> (T entity) where T: class;
         void DeleteRange<T>(T[] entity) where T: class;
         Task<bool> SaveChangesAsync();

         //EVENTOS
         Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
         Task<Evento[]> GetAllEventos(bool includePalestrantes);
         Task<Evento> GetEventoByIdAsync(int EventoId,  bool includePalestrantes);

         //PALESTRANTE 
         #region palestrante
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string tema, bool includeEventos);
         Task<Palestrante[]> GetAllPalestrantes(bool includeEventos);
         Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId,  bool includeEventos);
         #endregion
    }
}