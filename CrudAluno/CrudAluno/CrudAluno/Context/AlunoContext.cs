using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudAluno.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudAluno.Context
{
    public class AlunoContext : DbContext
    {
        public AlunoContext(DbContextOptions<AlunoContext> options) : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
