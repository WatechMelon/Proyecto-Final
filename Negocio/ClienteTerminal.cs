using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteTerminal
    {
        private String cI;
        private String barrio;
        private String calle;
        private String email;
        private String esquina;
        private int numero;
        private int telefono;
        private String pass;
        private String primerNombre;
        private String segundoNombre;
        private String primerApellido;
        private String segundoApellido;

        public string CI { get => cI; set => cI = value; }
        public string Barrio { get => barrio; set => barrio = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Email { get => email; set => email = value; }
        public string Esquina { get => esquina; set => esquina = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Pass { get => pass; set => pass = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }

        public ClienteTerminal()
        {

        }

        public ClienteTerminal(string cI, string barrio, string calle, string email, string esquina, int numero, int telefono, string pass, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            CI = cI;
            Barrio = barrio;
            Calle = calle;
            Email = email;
            Esquina = esquina;
            Numero = numero;
            Telefono = telefono;
            Pass = pass;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
        }
    }
}
