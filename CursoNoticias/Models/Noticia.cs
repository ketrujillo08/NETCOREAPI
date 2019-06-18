﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders

namespace CursoNoticias.Models
{    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { set; get; }
        public string Descripcion { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public Autor Autor { get; set; }

        public class Map
        {
            public Map(EntityTypeBuilder<Noticia> ebNoticia)
            {
                ebNoticia.HasKey(x => x.NoticiaId);
                ebNoticia.Property(x => x.Titulo).HasColumnName("Titulo").HasMaxLength(50);
                ebNoticia.Property(x => x.Descripcion).HasColumnName("Descripcion").HasMaxLength(100);
                ebNoticia.Property(x => x.Contenido).HasColumnName("Contenido").HasMaxLength(100);
                ebNoticia.Property(x => x.Fecha).HasColumnName("Fecha").HasColumnType("Datetime");
                ebNoticia.HasOne(x => x.Autor).WithMany(x => x.Noticias).HasForeignKey(x => x.Autor);
            }
        }
    }
}
