using CursoApiBackuEnd.Business.Entities;
using System.Threading.Tasks;

namespace CursoApiBackuEnd.Business.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        void Commit();
        Task<Usuario> ObterUsuarioAsync(string login);
    }
}
