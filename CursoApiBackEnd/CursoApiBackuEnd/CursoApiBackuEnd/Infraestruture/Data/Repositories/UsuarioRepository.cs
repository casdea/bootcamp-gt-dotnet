﻿using CursoApiBackuEnd.Business.Entities;
using CursoApiBackuEnd.Business.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CursoApiBackuEnd.Infraestruture.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CursoDbContext _contexto;

        public UsuarioRepository(CursoDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public async Task<Usuario> ObterUsuarioAsync(string login)
        {
            return await _contexto.Usuario.FirstOrDefaultAsync(u => u.Login == login);
        }
    }
}
