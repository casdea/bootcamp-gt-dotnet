using CursoApiBackuEnd.Business.Entities;
using System.Collections.Generic;

namespace CursoApiBackuEnd.Business.Repositories
{
    public interface ICursoRepository
    {
        void Adicionar(Curso curso);
        void Commit();

        IList<Curso> ObterPorUsuario(int codigoUsuario);
    }
}
