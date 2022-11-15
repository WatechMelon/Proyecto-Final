using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Planta: HuertaE
    {
        private String especie;
        private String estadoCultivo;
        private String metaCultivo;
        private DateTime fechaCultivo;
        private int cantidadCosecha;

        public string Especie { get => especie; set => especie = value; }
        public string EstadoCultivo { get => estadoCultivo; set => estadoCultivo = value; }
        public string MetaCultivo { get => metaCultivo; set => metaCultivo = value; }
        public DateTime FechaCultivo { get => fechaCultivo; set => fechaCultivo = value; }
        public int CantidadCosecha { get => cantidadCosecha; set => cantidadCosecha = value; }

        public Planta()
        {

        }

        public Planta(int iD_HE, string tamanio, string especie, string estadoCultivo, string metaCultivo, DateTime fechaCultivo, int cantidadCosecha) : base(iD_HE, tamanio)
        {
            Especie = especie;
            EstadoCultivo = estadoCultivo;
            MetaCultivo = metaCultivo;
            FechaCultivo = fechaCultivo;
            CantidadCosecha = cantidadCosecha;
        }
    }
}
