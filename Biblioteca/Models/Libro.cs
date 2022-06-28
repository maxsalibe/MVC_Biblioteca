using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Modelo
{
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("libroId")]
        public int libroId { set; get; }
        [Column("titulo")]
        [DisplayName("Título")]
        [StringLength(80)]
        public string titulo { set; get; }
        [Column("edicion")]
        [DisplayName("Edición")]
        public int edicion { set; get; }

        [Column("rutaimagen")]
        [DisplayName("Ruta de la imagen")]
        [StringLength(80)]
        public string rutaimagen { set; get; }
    }
}
