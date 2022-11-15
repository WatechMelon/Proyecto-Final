using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Realiza: ClienteTerminal
    {
        private DateTime fechaEntrega;
        private DateTime fechaPedido = DateTime.Today;
        private string metodoPago;
        private int numPedido;
        private List<String> cantProductos = new List<String>();
        private List<String> producto = new List<String>();
        private string productounitario;
        private string cantunitaria;



        public Realiza()
        {

        }

        public Realiza(string cantunitaria, string productounitario, string cI, string barrio, string calle, string email, string esquina, int numero, int telefono, string pass, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, DateTime fechaEntrega, DateTime fechaPedido, string metodoPago, int numPedido, List<string> cantProductos, List<string> producto) : base(cI, barrio, calle, email, esquina, numero, telefono, pass, primerNombre, segundoNombre, primerApellido, segundoApellido)
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
