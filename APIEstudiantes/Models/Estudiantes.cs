using System.ComponentModel.DataAnnotations;

namespace APIEstudiantes.Models
{
    public class Estudiante
    {
        public Guid Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Nombre { get; set; }

        [Range(1, 100)]
        public int Edad { get; set; }

        public bool Activo { get; set; }
    }

}
