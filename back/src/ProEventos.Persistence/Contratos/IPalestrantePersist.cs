using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
         #region palestrante
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string tema, bool includeEventos);
         Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);
         Task<Palestrante> GetPalestranteByIdAsync(int palestranteId,  bool includeEventos);
         #endregion
    }
}