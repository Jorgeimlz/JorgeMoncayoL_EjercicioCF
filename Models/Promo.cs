namespace JorgeMoncayoL_EjercicioCF.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        public string PromoName { get; set;}
        public string PromoDescription { get; set;}

        public int Id {  get; set; }

        public Burguer? Burguer {  get; set; } 
    }
}
