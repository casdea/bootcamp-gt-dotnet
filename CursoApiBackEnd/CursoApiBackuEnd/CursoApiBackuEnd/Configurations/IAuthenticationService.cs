using CursoApiBackuEnd.Models.Usuarios;

namespace CursoApiBackuEnd.Configurations
{
    public interface IAuthenticationService
    {
        string GerarToken(UsuarioViewModelOutput usuarioViewModelOutput);
    }
}
