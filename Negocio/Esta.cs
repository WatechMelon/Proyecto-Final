using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Esta
    {
        private int iD_Estado;
        private int numPedido;
        private DateTime fechaInicio;
        private DateTime fechaFin;

 
        public Esta()
        {

        }

        public int ID_Estado { get => iD_Estado; set => iD_Estado = value; }
        public int NumPedido { get => numPedido; set => numPedido = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }

        public Esta(int iD_Estado, int numPedido, DateTime fechaInicio, DateTime fechaFin)
        {
            ID_Estado = iD_Estado;
            NumPedido = numPedido;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }
    }
}
