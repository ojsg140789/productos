using Productos.Models;
using Productos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.test
{
    public class ProductoServiceTest
    {
        [Fact]
        public void Agregar_Producto()
        {
            //Arrange
            var servicio = new ProductoService();
            var nuevo = new Productos.Models.Producto
            {
                Nombre = "Contrato",
                Tipo = "Individual",
                TasaInteres = 4,
                Status = true
            };

            //Act
            servicio.AgregarProducto(nuevo);

            //Assert
            var lista = servicio.ObtenerProductos();
            Assert.Contains(lista, p => p.Nombre == "Contrato");
        }
    }
}
