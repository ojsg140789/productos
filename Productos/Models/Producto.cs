namespace Productos.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal TasaInteres { get; set; }
        public bool Status { get; set; }
    }
}
