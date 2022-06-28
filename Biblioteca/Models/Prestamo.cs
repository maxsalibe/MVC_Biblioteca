using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelo
{
    public class Prestamo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int prestamoId { get; set; }
        
        [Column("FechaHora")]
        [Required]
        public DateTime fechaHora { get; set; }

        [ForeignKey("Lector")]
        [Column("lectorId")]
        [Required]
        public Lector lector { get; set; }

        [ForeignKey("Libro")]
        [Column("libroId")]
        [Required]
        public Libro libro { get; set; }
        
        [ForeignKey("Usuario")]
        [Column("usuarioId")]
        [Required]
        public Usuario usuario { get; set; }
        
        [Column("devolucion")]
        public bool devolucion { get; set; }
    }
}
