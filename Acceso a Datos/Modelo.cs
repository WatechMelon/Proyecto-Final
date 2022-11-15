using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Negocio;
using Org.BouncyCastle.Asn1.X509;

namespace Acceso_a_Datos
{
    public class Modelo
    {
        ClienteEmpresa clienteEmpresa = new ClienteEmpresa();
        
        public int Huerta(Planta he)
        {
            
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql = "INSERT INTO Planta (ID_HE, NombreCultivo, MetaCultivos, FechaCultivo, EstadoCultivo, CantidadCosecha) VALUES (@ID_HE, @NombreCultivo, @MetaCultivos, @FechaCultivo, @EstadoCultivo, @CantidadCosecha)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID_HE", he.ID_HE);
            command.Parameters.AddWithValue("@NombreCultivo", he.Especie);
            command.Parameters.AddWithValue("@MetaCultivos", he.MetaCultivo);
            command.Parameters.AddWithValue("@FechaCultivo", he.FechaCultivo);
            command.Parameters.AddWithValue("@EstadoCultivo", he.EstadoCultivo);
            command.Parameters.AddWithValue("@CantidadCosecha", he.CantidadCosecha);


            int Resultado = command.ExecuteNonQuery();

            return Resultado;
        }

        public int HuertaU(Planta he)
        {
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();
            string sql = "UPDATE Planta SET MetaCultivos= @MetaCultivos, EstadoCultivo= @EstadoCultivo, CantidadCosecha = @CantidadCosecha WHERE NombreCultivo LIKE @NombreCultivo AND ID_HE LIKE @ID_HE";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@MetaCultivos", he.MetaCultivo);
            command.Parameters.AddWithValue("@EstadoCultivo", he.EstadoCultivo);
            command.Parameters.AddWithValue("@CantidadCosecha", he.CantidadCosecha);
            command.Parameters.AddWithValue("@NombreCultivo", he.Especie);
            command.Parameters.AddWithValue("@ID_HE", he.ID_HE);
            int Resultado = command.ExecuteNonQuery();

            return Resultado;
        }

        public int ActualizarEstado(Esta esta)
        {
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();
            string sql = "UPDATE esta set FechaFin = @FechaFin WHERE NumPedido LIKE @NumPedido ORDER BY `esta`.`ID_Estado` DESC LIMIT 1";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NumPedido", esta.NumPedido);
            command.Parameters.AddWithValue("@FechaFin", DateTime.Today);

            int Resultado = command.ExecuteNonQuery();

            return Resultado;

        }


        public int Hace(Hace hace)
        {
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql1 = "SELECT NumPedido FROM `pedido` ORDER BY `pedido`.`NumPedido` DESC LIMIT 1";
            MySqlCommand comando = new MySqlCommand(sql1, connection);

            int numPedido = Convert.ToInt32(comando.ExecuteScalar());

            string sql = "INSERT INTO hace (NumPedido, CantProducto, Producto, RUT ) VALUES (@NumPedido, @CantProducto ,@Producto, @RUT)";
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@NumPedido", numPedido);
            command.Parameters.AddWithValue("@RUT", hace.Rut);
            command.Parameters.AddWithValue("@CantProducto", hace.Cantunitaria);
            command.Parameters.AddWithValue("@Producto", hace.Productounitario);
            
            int Resultado = command.ExecuteNonQuery();

            return Resultado;

        }

        public int Realiza(Realiza realiza)
        {
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql1 = "SELECT NumPedido FROM `pedido` ORDER BY `pedido`.`NumPedido` DESC LIMIT 1";
            MySqlCommand comando = new MySqlCommand(sql1, connection);

            int numPedido = Convert.ToInt32(comando.ExecuteScalar());

            string sql = "INSERT INTO realiza (NumPedido, CantProducto, Producto, CI ) VALUES (@NumPedido, @CantProducto ,@Producto, @CI)";
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@NumPedido", numPedido);
            command.Parameters.AddWithValue("@CI", realiza.CI);
            command.Parameters.AddWithValue("@CantProducto", realiza.Cantunitaria);
            command.Parameters.AddWithValue("@Producto", realiza.Productounitario);

            int Resultado = command.ExecuteNonQuery();

            return Resultado;

        }


        public int PedidoE(Hace pedido)
        {
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql1 = "SELECT NumPedido FROM `pedido` ORDER BY `pedido`.`NumPedido` DESC LIMIT 1";
            MySqlCommand comando = new MySqlCommand(sql1, connection);
            
            int numPedido = 1 + Convert.ToInt32(comando.ExecuteScalar());

            string sql = "INSERT INTO Pedido (NumPedido, MetodoPago, FechaPedido, FechaEntrega) VALUES (@NumPedido, @MetodoPago, @FechaPedido, @FechaEntrega)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NumPedido", numPedido);
            command.Parameters.AddWithValue("@MetodoPago", pedido.MetodoPago);
            command.Parameters.AddWithValue("@FechaEntrega", pedido.FechaEntrega);
            command.Parameters.AddWithValue("@FechaPedido", pedido.FechaPedido);



            int Resultado = command.ExecuteNonQuery();

            return Resultado;

        }

        public int PedidoT(Realiza pedido)
        {
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql1 = "SELECT NumPedido FROM `pedido` ORDER BY `pedido`.`NumPedido` DESC LIMIT 1";
            MySqlCommand comando = new MySqlCommand(sql1, connection);

            int numPedido = 1 + Convert.ToInt32(comando.ExecuteScalar());

            string sql = "INSERT INTO Pedido (NumPedido, MetodoPago, FechaPedido, FechaEntrega) VALUES (@NumPedido, @MetodoPago, @FechaPedido, @FechaEntrega)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NumPedido", numPedido);
            command.Parameters.AddWithValue("@MetodoPago", pedido.MetodoPago);
            command.Parameters.AddWithValue("@FechaEntrega", pedido.FechaEntrega);
            command.Parameters.AddWithValue("@FechaPedido", pedido.FechaPedido);



            int Resultado = command.ExecuteNonQuery();

            return Resultado;

        }

        public int EstadoPedido(Esta esta)
        {
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();
            string sql = "INSERT INTO esta (NumPedido, FechaInicio, ID_Estado, FechaFin) VALUES (@NumPedido, @FechaInicio, @ID_Estado, @FechaFin)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NumPedido", esta.NumPedido);
            command.Parameters.AddWithValue("@FechaInicio", esta.FechaInicio);
            command.Parameters.AddWithValue("@ID_Estado", esta.ID_Estado);
            command.Parameters.AddWithValue("@FechaFin", esta.FechaFin);

            int Resultado = command.ExecuteNonQuery();

            return Resultado;


          
        }
        public int RegistroTerminal(ClienteTerminal clienteTerminal)
        {
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql = "INSERT INTO ClienteTerminal (CI, Email, Pass, Telefono, Barrio, Numero, Esquina, Calle, PrimerNombre, PrimerApellido, SegundoNombre, SegundoApellido) VALUES (@CI, @Email, @Pass, @Telefono, @Barrio, @Numero, @Esquina, @Calle, @PrimerNombre, @PrimerApellido, @SegundoNombre, @SegundoApellido) ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CI", clienteTerminal.CI);
            command.Parameters.AddWithValue("@Email", clienteTerminal.Email);
            command.Parameters.AddWithValue("@Pass", clienteTerminal.Pass);
            command.Parameters.AddWithValue("@Telefono", clienteTerminal.Telefono);
            command.Parameters.AddWithValue("@Barrio", clienteTerminal.Barrio);
            command.Parameters.AddWithValue("@Numero", clienteTerminal.Numero);
            command.Parameters.AddWithValue("@Esquina", clienteTerminal.Esquina);
            command.Parameters.AddWithValue("@Calle", clienteTerminal.Calle);
            command.Parameters.AddWithValue("@PrimerNombre", clienteTerminal.PrimerNombre);
            command.Parameters.AddWithValue("@PrimerApellido", clienteTerminal.PrimerApellido);
            command.Parameters.AddWithValue("@SegundoNombre", clienteTerminal.SegundoNombre);
            command.Parameters.AddWithValue("@SegundoApellido", clienteTerminal.SegundoApellido);

            int Resultado = command.ExecuteNonQuery();

            return Resultado;

        }

        public int RegistroEmpresa(ClienteEmpresa clienteEmrpesa)
        {
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql = "INSERT INTO ClienteEmpresa (RUT, Email, Pass, Telefono, Calle, Barrio, Numero, Esquina) VALUES (@RUT, @Email, @Pass, @Telefono, @Calle, @Barrio, @Numero, @Esquina)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RUT", clienteEmrpesa.Rut);
            command.Parameters.AddWithValue("@Email", clienteEmrpesa.Email);
            command.Parameters.AddWithValue("@Pass", clienteEmrpesa.Pass);
            command.Parameters.AddWithValue("@Telefono", clienteEmrpesa.Telefono);
            command.Parameters.AddWithValue("@Calle", clienteEmrpesa.Calle);
            command.Parameters.AddWithValue("@Barrio", clienteEmrpesa.Barrio);
            command.Parameters.AddWithValue("@Numero", clienteEmrpesa.Numero);
            command.Parameters.AddWithValue("@Esquina", clienteEmrpesa.Esquina);

            int Resultado = command.ExecuteNonQuery();

            return Resultado;

        }

        public DataTable verTabla(int NumPedido)
        {
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();
            DataTable data;
            try
            {
                string sql = "SELECT e.NumPedido, NombreEstado, e.ID_Estado, FechaInicio FROM esta e, pedido p, estadopedido ep WHERE e.NumPedido = p.NumPedido AND ep.ID_Estado = e.ID_Estado AND e.NumPedido = @NumPedido";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@NumPedido", NumPedido);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los datos");
                return data = new DataTable();
            }
            finally
            {
                connection.Close();
            }
        }

        public bool existePlanta(int iD_HE, String especie)
        {
            MySqlDataReader reader;
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql = "SELECT ID_HE, NombreCultivo FROM Planta WHERE ID_HE LIKE @ID_HE AND NombreCultivo LIKE @NombreCultivo";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID_HE", iD_HE);
            command.Parameters.AddWithValue("@NombreCultivo", especie);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool existeHuerta(int ID_HE)
        {
            MySqlDataReader reader;
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql = "SELECT ID_HE FROM he WHERE ID_HE LIKE @ID_HE";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID_HE", ID_HE);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public HuertaE porHuerta(int ID_HE)
        {
            MySqlDataReader reader;
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();
            string sql = "SELECT ID_HE, Tamanio FROM he WHERE ID_HE LIKE @ID_HE";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID_HE", ID_HE);

            reader = command.ExecuteReader();

            HuertaE clt = null;

            while (reader.Read())
            {
                clt = new HuertaE();
                clt.ID_HE = int.Parse(reader["ID_HE"].ToString());
                clt.Tamanio = reader["Tamanio"].ToString();


            }
            return clt;


        }


        public Repartidor porRepartidor(int ID_Repartidor)
        {
            MySqlDataReader reader;
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql = "SELECT ID_Repartidor, ID_Sucursal, Contrasena FROM Repartidor WHERE ID_Repartidor LIKE @ID_Repartidor";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID_Repartidor", ID_Repartidor);

            reader = command.ExecuteReader();

            Repartidor clt = null;
            while (reader.Read())
            {
                clt = new Repartidor();
                clt.ID_Repartidor = int.Parse(reader["ID_Repartidor"].ToString());
                clt.Pass = reader["Contrasena"].ToString();
                clt.ID_Sucursal = int.Parse(reader["ID_Sucursal"].ToString());


            }
            return clt;
        }

        public bool estadoRepetido(int NumPedido, DateTime FechaInicio, int ID_Estado)
        {
            MySqlDataReader reader;
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql = "SELECT NumPedido, FechaInicio, ID_Estado FROM esta WHERE NumPedido = @NumPedido AND FechaInicio = @FechaInicio AND ID_Estado = @ID_Estado";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NumPedido", NumPedido);
            command.Parameters.AddWithValue("@FechaInicio", FechaInicio);
            command.Parameters.AddWithValue("@ID_Estado", ID_Estado);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        public bool existeClienteTerminal(String CI)
        {
            MySqlDataReader reader;
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql = "SELECT CI FROM ClienteTerminal WHERE CI LIKE @CI";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CI", CI);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool existeClienteEmpresa(int RUT)
        {
            MySqlDataReader reader;
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql = "SELECT RUT FROM ClienteEmpresa WHERE RUT LIKE @RUT";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RUT", RUT);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public ClienteTerminal porClienteTerminal(String CI)
        {
            MySqlDataReader reader;
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql = "SELECT CI, Email, Pass, Telefono, Barrio, Numero, Esquina, Calle, PrimerNombre, PrimerApellido, SegundoNombre, SegundoApellido FROM ClienteTerminal WHERE CI LIKE @CI";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CI", CI);

            reader = command.ExecuteReader();

            ClienteTerminal clt = null;
            while (reader.Read())
            {
                clt = new ClienteTerminal();
                clt.Email = reader["Email"].ToString();
                clt.Pass = reader["Pass"].ToString();
                clt.Numero = int.Parse(reader["Numero"].ToString());
                clt.Esquina = reader["Esquina"].ToString();
                clt.Telefono = int.Parse(reader["Telefono"].ToString());
                clt.Barrio = reader["Barrio"].ToString();
                clt.Calle = reader["Calle"].ToString();
                clt.CI = reader["CI"].ToString();
                clt.PrimerNombre = reader["PrimerNombre"].ToString();
                clt.PrimerApellido = reader["PrimerApellido"].ToString();
                clt.SegundoNombre = reader["SegundoNombre"].ToString();
                clt.SegundoApellido = reader["SegundoApellido"].ToString();

            }
            return clt;
        }
        public ClienteEmpresa porClienteEmpresa(int RUT)
        {
            MySqlDataReader reader;
            MySqlConnection connection = Conexion.getConnection();
            connection.Open();

            string sql = "SELECT RUT, Email, Pass, Telefono, Calle, Barrio, Numero, Esquina FROM ClienteEmpresa WHERE RUT LIKE @RUT";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RUT", RUT);

            reader = command.ExecuteReader();

            ClienteEmpresa clt = null;
            while (reader.Read())
            {
                clt = new ClienteEmpresa();
                clt.Email = reader["Email"].ToString();
                clt.Pass = reader["Pass"].ToString();
                clt.Numero = int.Parse(reader["Numero"].ToString());
                clt.Esquina = reader["Esquina"].ToString();
                clt.Telefono = int.Parse(reader["Telefono"].ToString());
                clt.Barrio = reader["Barrio"].ToString();
                clt.Calle = reader["Calle"].ToString();
                clt.Rut = int.Parse(reader["RUT"].ToString());


            }
            return clt;
        }


    }
}
