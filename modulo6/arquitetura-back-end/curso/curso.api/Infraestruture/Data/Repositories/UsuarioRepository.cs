
using curso.api.Business.Entities;
using curso.api.Business.Repositories;

using Microsoft.EntityFrameworkCore;

namespace curso.api.Infraestruture.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CursoDbContext _context;

        public UsuarioRepository(CursoDbContext context)
        {
            _context = context;

            var migracoesPendentes = context.Database.GetPendingMigrations();
            if(migracoesPendentes.Count() > 0)
            {
                context.Database.Migrate();
            }
        }

        public void Adicionar(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Usuario ObterUsuario(string login)
        {
            return _context.Usuario.FirstOrDefault(u => u.Login == login);
        }
    }
}
