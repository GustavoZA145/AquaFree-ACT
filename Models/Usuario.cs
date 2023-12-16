using AquaFree.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaFree.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Contraseña { get; set; }
        [Required]
        public string? CorreoElectronico { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public RolEnum Rol { get; set; }
    }
}
