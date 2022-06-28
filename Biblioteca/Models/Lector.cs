using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Biblioteca.Models;

namespace Biblioteca.Modelo
{
    public class Lector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("lectorId")]
        public int lectorId { set; get; }
        [Column ("Apellido")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(60)]
        public String Apellido { set; get; }
        [Column("Nombre")]
        [StringLength(60)]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public String Nombre { set; get; }

        [Column("Domicilio")]
        [StringLength(60)]
        public String Domicilio { set; get; }

        [Column("Localidad")]
        [StringLength(60)]
        public String Localidad { set; get; }

        [EnumDataType(typeof(ProvinciasEnum))]
        [Column("Provincia")]
        public ProvinciasEnum Provincia { set; get; }
    }
}
