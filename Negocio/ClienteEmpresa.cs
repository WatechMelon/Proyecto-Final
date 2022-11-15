using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteEmpresa
    {
        private int rut;
        private int numero;
        private int telefono;
        private String calle;
        private String barrio;
        private String pass;
        private String email;
        private String esquina;

        public int Rut { get => rut; set => rut = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Barrio { get => barrio; set => barrio = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Email { get => email; set => email = value; }
        public string Esquina { get => esquina; set => esquina = value; }

        public ClienteEmpresa()
        {

        }

        public ClienteEmpresa(int rut, int numero, int telefono, string calle, string barrio, string pass, string email, string esquina)
        {
            Rut = rut;
            Numero = numero;
            Telefono = telefono;
            Calle = calle;
            Barrio = barrio;
            Pass = pass;
            Email = email;
            Esquina = esquina;
        }
    }

    
}
