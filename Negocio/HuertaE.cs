using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class HuertaE
    {
        private int iD_HE;
        private string tamanio;

        public int ID_HE { get => iD_HE; set => iD_HE = value; }
        public string Tamanio { get => tamanio; set => tamanio = value; }

        public HuertaE()
        {

        }
        public HuertaE(int iD_HE, string tamanio)
        {
            ID_HE = iD_HE;
            Tamanio = tamanio;
        }
    }
}
