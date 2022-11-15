using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Repartidor
    {
        private int iD_Repartidor;
        private int iD_Sucursal;
        private String pass;

        public int ID_Repartidor { get => iD_Repartidor; set => iD_Repartidor = value; }
        public int ID_Sucursal { get => iD_Sucursal; set => iD_Sucursal = value; }
        public string Pass { get => pass; set => pass = value; }


        public Repartidor()
        {

        }

        public Repartidor(int iD_Repartidor, int iD_Sucursal, string pass)
        {
            ID_Repartidor = iD_Repartidor;
            ID_Sucursal = iD_Sucursal;
            Pass = pass;
        }
    }
}
