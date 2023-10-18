using System.ComponentModel.DataAnnotations;

namespace JorgeMoncayoL_EjercicioCF.Models
{
    public class Burguer
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 15.99)]
        public decimal Precio { get; set; }

        public List<Promo>? Promo { get; set; } // El list hace que una hamburguesa pueda estar en varias promociones

    }
}
