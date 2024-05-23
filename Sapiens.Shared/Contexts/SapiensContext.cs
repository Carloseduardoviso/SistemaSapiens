using Microsoft.EntityFrameworkCore;
using Sapiens.Shared.Entities;

namespace Sapiens.Shared.Contexts
{
    public class SapiensContext : DbContext
    {
        public SapiensContext(DbContextOptions<SapiensContext> options) : base(options) { }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Coordenador> Coordenadores { get; set; }
    }
}