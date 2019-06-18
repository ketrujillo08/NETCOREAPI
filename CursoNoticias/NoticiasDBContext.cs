using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoNoticias.Models;
using Microsoft.EntityFrameworkCore;
namespace CursoNoticias
{
    public class NoticiasDBContext:DbContext
    {
        public NoticiasDBContext(DbContextOptions opciones) : base(opciones) { }

        public virtual DbSet<Noticia> Noticia { set; get; }
        public virtual DbSet<Autor> Autor { set; get; }

        protected override void OnModelCreating(ModelBuilder modelB)
        {
            new Noticia.Map(modelB.Entity<Noticia>());
            new Autor.Map(modelB.Entity<Autor>());
            base.OnModelCreating(modelB);
        }

    }
}
