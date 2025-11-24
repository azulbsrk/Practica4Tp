using System.Collections.Generic;
using System.Windows;

namespace WpfProductos
{
    public partial class MainWindow : Window
    {
        List<Product> productos = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                productos.Add(new Product(txtNombre.Text, precio));
                Refrescar();
            }
        }

        private void Refrescar()
        {
            listaProductos.ItemsSource = null;
            listaProductos.ItemsSource = productos;
        }

        private void QuickSort_Click(object sender, RoutedEventArgs e)
        {
            productos = Sorter.QuickSort(productos);
            Refrescar();
        }

        private void MergeSort_Click(object sender, RoutedEventArgs e)
        {
            productos = Sorter.MergeSort(productos);
            Refrescar();
        }
    }
}
