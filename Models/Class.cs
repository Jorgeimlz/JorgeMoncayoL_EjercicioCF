using System.ComponentModel.DataAnnotations;

namespace JorgeMoncayoL_EjercicioCF.Models
{
    public class Class
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }

    }
}
