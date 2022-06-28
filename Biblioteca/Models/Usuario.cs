using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Models;

namespace Biblioteca.Modelo
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("usuarioId")]
        public int UsuarioId { get; set; }
        [Column("usuario")]
        [StringLength(20)]
        [Required(ErrorMessage = "El usuario es obligatorio")]
        public string usuario { get; set; }

        [Column("email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(128)]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string email { get; set; }

        [Column("clave")]
        [DataType(DataType.Password)]
        [StringLength(20)]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string clave { set; get; }

        [Column("Apellido")]
        [StringLength(60)]
        public String Apellido { set; get; }
        [Column("Nombre")]
        [StringLength(60)]
        public String Nombre { set; get; }

        [Column("Domicilio")]
        [StringLength(60)]
        public String Domicilio { set; get; }

        [Column("Localidad")]
        [StringLength(50)]
        public String Localidad { set; get; }

        [EnumDataType(typeof(ProvinciasEnum))]
        [Column("Provincia")]
        public ProvinciasEnum Provincia { set; get; }
    }

}
