using Productos.Models;
using Productos.Pages;

namespace Productos.Services
{
    public class ProductoService
    {
        private readonly List<Productos.Models.Producto> _productos = new List<Productos.Models.Producto>
    {
        new Productos.Models.Producto { Id = 1, Nombre = "Crédito Auto", Tipo = "Personal", TasaInteres = 4, Status = true },
        new Productos.Models.Producto { Id = 2, Nombre = "Crédito Personal", Tipo = "Personal", TasaInteres = 5, Status = true },
        new Productos.Models.Producto { Id = 3, Nombre = "Crédito Vivienda", Tipo = "Negocio", TasaInteres = 6, Status = false },
    };

        public IReadOnlyList<Productos.Models.Producto> ObtenerProductos() => _productos.AsReadOnly();

        public void AgregarProducto(Productos.Models.Producto nuevo)
        {
            var maxId = _productos.Any() ? _productos.Max(p => p.Id) : 0;
            nuevo.Id = maxId + 1;
            _productos.Add(nuevo);
        }

        public void EditarProducto(Productos.Models.Producto nuevo)
        {
            var productoEditar = _productos.FirstOrDefault(p => p.Id == nuevo.Id);

            if (productoEditar != null)
            {
                productoEditar.Nombre = nuevo.Nombre;
                productoEditar.Tipo = nuevo.Tipo;
                productoEditar.TasaInteres = nuevo.TasaInteres;
                productoEditar.Status = nuevo.Status;
            }
        }


    }
}
