using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Hace: ClienteEmpresa
    {
        private DateTime fechaEntrega;
        private DateTime fechaPedido = DateTime.Today;
        private string metodoPago;
        private int numPedido;
        private List<String> cantProductos = new List<String>();
        private List<String> producto = new List<String>();
        private string productounitario;
        private string cantunitaria;

        public Hace()
        {

        }

        public Hace(string cantunitaria, string productounitario,List<string> cantProductos, List<string> producto,int rut, int numero, int telefono, string calle, string barrio, string pass, string email, string esquina, DateTime fechaEntrega, DateTime fechaPedido, string metodoPago, int numPedido) : base(rut, numero, telefono, calle, barrio, pass, email, esquina)
        {
            FechaEntrega = fechaEntrega;
            FechaPedido = fechaPedido;
            MetodoPago = metodoPago;
            NumPedido = numPedido;
            CantProductos = cantProductos;
            Producto = producto;
            Productounitario = productounitario;
            Cantunitaria = cantunitaria;
        }

        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public int NumPedido { get => numPedido; set => numPedido = value; }
        public List<string> CantProductos { get => cantProductos; set => cantProductos = value; }
        public List<string> Producto { get => producto; set => producto = value; }
        public string Productounitario { get => productounitario; set => productounitario = value; }
        public string Cantunitaria { get => cantunitaria; set => cantunitaria = value; }
    }
}
