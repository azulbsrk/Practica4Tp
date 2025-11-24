namespace WpfProductos
{
    public class Product
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Product(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
