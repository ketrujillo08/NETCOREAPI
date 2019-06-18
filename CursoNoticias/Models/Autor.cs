using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoNoticias.Models
{
    public class Autor
    {
        public int AutorId { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }

        public List<Noticia> Noticias { get; set; }

        public class Map
        {
            public Map(EntityTypeBuilder<Autor> ebAutor)
            {
                ebAutor.HasKey(x => x.AutorId);
                ebAutor.Property(x => x.Nombre).HasColumnName("Nombre").HasMaxLength(50);
                ebAutor.Property(x => x.Apellido).HasColumnName("Apellido").HasMaxLength(50);
            }
        }
    }
}
