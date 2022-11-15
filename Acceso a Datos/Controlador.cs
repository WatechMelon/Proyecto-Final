using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Acceso_a_Datos
{
    public class Controlador
    {
        public String ctrlRepartidor(int ID_Repartidor, String Pass)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Repartidor datosRepartidor = null;

            if (string.IsNullOrEmpty(Convert.ToString(ID_Repartidor)) || string.IsNullOrEmpty(Pass))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosRepartidor = modelo.porRepartidor(ID_Repartidor);

                if (datosRepartidor == null)
                {
                    respuesta = "El cliente no existe";
                }

            }
            return respuesta;
        }






        public String ctrlHuerta(Planta he)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (modelo.existePlanta(he.ID_HE, he.Especie))
            {
                modelo.HuertaU(he);
            }
            else
            {
                modelo.Huerta(he);
            }
            return respuesta;

        }
        
        public String ctrlEstadoPedido(Esta esta)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if(modelo.estadoRepetido(esta.NumPedido, esta.FechaInicio, esta.ID_Estado))
            {
                respuesta = "No ha actualizado ningun estado";
            }
            else
            {
                modelo.ActualizarEstado(esta);
                modelo.EstadoPedido(esta);
            }
            return respuesta;


        }
        public String ctrlRegistroTerminal(ClienteTerminal clienteTerminal)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (modelo.existeClienteTerminal(clienteTerminal.CI))
            {
                respuesta = "El usuario ya existe";
            }
            else
            {
                clienteTerminal.Pass = EncriptadoTerminal(clienteTerminal.Pass);
                modelo.RegistroTerminal(clienteTerminal);
            }
            return respuesta;
        }

        public String ctrlRegistroEmpresa(ClienteEmpresa clienteEmpresa)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (modelo.existeClienteEmpresa(clienteEmpresa.Rut))
            {
                respuesta = "El usuario ya existe";
            }
            else
            {
                clienteEmpresa.Pass = EncriptadoEmpresa(clienteEmpresa.Pass);
                modelo.RegistroEmpresa(clienteEmpresa);
            }
            return respuesta;
        }
        public String ctrlElegirHuerta(int ID_HE)
        {
            Modelo modelo = new Modelo();
            string Respuesta = "";
            HuertaE datosHuerta = null;

            if (string.IsNullOrEmpty(Convert.ToString(ID_HE)))
            {
                Respuesta = "No puede estar el campo vacio";
            }
            else
            {
                datosHuerta = modelo.porHuerta(ID_HE);
                if (datosHuerta == null)
                {
                    Respuesta = "La huerta no existe";
                }

            }
            return Respuesta;
        }
        public String ctrlLoginTerminal(String CI, String Pass)
        {
            Modelo modelo = new Modelo();
            string Respuesta = "";
            ClienteTerminal datosClienteTerminal = null;

            if (string.IsNullOrEmpty(Convert.ToString(CI)) || string.IsNullOrEmpty(Pass))
            {
                Respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosClienteTerminal = modelo.porClienteTerminal(CI);

                if (datosClienteTerminal == null)
                {
                    Respuesta = "El cliente no existe";
                }
                else
                {
                    if (datosClienteTerminal.Pass != EncriptadoTerminal(Pass))
                    {
                        Respuesta = "El cliente y/o contraseña no coinciden ";
                    }
                }

            }
            return Respuesta;
        }

        public String ctrlLoginEmpresa(int Rut, String Pass)
        {
            Modelo modelo = new Modelo();
            string Respuesta = "";
            ClienteEmpresa datosClienteEmpresa = null;

            if (string.IsNullOrEmpty(Convert.ToString(Rut)) || string.IsNullOrEmpty(Pass))
            {
                Respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosClienteEmpresa = modelo.porClienteEmpresa(Rut);

                if (datosClienteEmpresa == null)
                {
                    Respuesta = "El cliente no existe";
                }
                else
                {
                    if (datosClienteEmpresa.Pass != EncriptadoEmpresa(Pass))
                    {
                        Respuesta = "El cliente y/o contraseña no coinciden";

                    }
                }

            }
            return Respuesta;
        }


        private string EncriptadoTerminal(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }

        private string EncriptadoEmpresa(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }

    }
}
