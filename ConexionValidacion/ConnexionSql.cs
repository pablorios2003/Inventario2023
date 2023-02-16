

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Configuration;

namespace MVCinventario
{
    public class ConnexionSql
    {

        SqlConnection conexion = new SqlConnection("Server=ORUAM;Database=Inventario; integrated security= true");



        #region Login_Validaciones
        public int CambioPassword(string strEmail, string strNombre)
        {
            //CONSULTAMOS LA EXISTENCIA DEL USUARIO
            string consulta = "select * from Cuentas where Email='" + strEmail + "' and NameUser = '" + strNombre + "'";
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conexion.Close();

            //GUARDAMOS EL RESULTADO PARA RETORNARLO Y PODER HACER VALIDACION
            int result = dt.Rows.Count;
            return result;
        }

        public void UpdatePassword(string strEmail, string strPassword)
        {
            string update = "Update Cuentas  set Pass = @Pass where Email = @Email";
            conexion.Open();
            SqlCommand comando = new SqlCommand(update, conexion);
            comando.Parameters.AddWithValue("@Pass", strPassword);
            comando.Parameters.AddWithValue("@Email", strEmail);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        //ValidarCredenciales
        public int ValidarCredenciales(string strUser, string strPass)
        {
            //CONSULTAMOS LA EXISTENCIA DEL USUARIO
            string consulta = "select * from Cuentas where NameUser='" + strUser + "' and Pass = '" + strPass + "'";
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conexion.Close();

            //GUARDAMOS EL RESULTADO PARA RETORNARLO Y PODER HACER VALIDACION
            int result = dt.Rows.Count;
            return result;
        }
        #endregion
        #region CRUD_usuario
        public int ExistenciaUsuario(string cc)
        {
            string consulta = "Select * from usuario where Cedula='" + cc + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            int resultado = dt.Rows.Count;
            return resultado;

        }
        public int FiltrarUsuario(string Cedula, DataGridView vista)
        {
            string consulta = "select * from usuario where Cedula like '" + Cedula + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            int resultado = adaptador.Fill(dt);
            vista.DataSource = dt;
            return resultado;


        }
        public void insertUser(string Cedula, string nomU, string apelliU, string celular, string emailU, string Rol)
        {
            //INSERTAMOS EN LA TABLA USUARIO DE LA BASE DE DATOS
            string Registro = "INSERT INTO usuario(Cedula,nomU,apelliU,celular,emailU,id_rol) VALUES (@Cedula,@nomU,@apelliU,@celular,@emailU,@id_rol)";
            conexion.Open();

            SqlCommand comando = new SqlCommand(Registro, conexion);
            comando.Parameters.AddWithValue("@Cedula", Cedula);
            comando.Parameters.AddWithValue("@nomU", nomU);
            comando.Parameters.AddWithValue("@apelliU", apelliU);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.Parameters.AddWithValue("@emailU", emailU);

            if (Rol == "Instructor")
            {
                Rol = "2";
                comando.Parameters.AddWithValue("@id_rol", Rol);
            }
            else if (Rol == "Aprendiz")
            {
                Rol = "1";
                comando.Parameters.AddWithValue("@id_rol", Rol);
            }
            else if (Rol == "Practicante")
            {
                Rol = "3";
                comando.Parameters.AddWithValue("@id_rol", Rol);
            }

            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void LIstaUsuarios(DataGridView vista)
        {
            string consulta = "Select * from usuario";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            vista.DataSource = dt;
            vista.Columns["Cedula"].DisplayIndex = 0;
            vista.Columns["nomU"].DisplayIndex = 1;
            vista.Columns["apelliU"].DisplayIndex = 2;
            vista.Columns["celular"].DisplayIndex = 3;
            vista.Columns["emailU"].DisplayIndex = 4;
            vista.Columns["id_rol"].DisplayIndex = 5;
        }

        public void UpdateUser(string nomU, string apelliU, string celular, string gmail, string Rol, string cedula)
        {
            string Registro = "UPDATE  usuario set nomU = @nomU,apelliU = @apelliU,celular=@celular,emailU=emailU,id_rol=@id_rol where Cedula ='" + cedula + "'";
            conexion.Open();

            SqlCommand comando = new SqlCommand(Registro, conexion);
            comando.Parameters.AddWithValue("@nomU", nomU);
            comando.Parameters.AddWithValue("@apelliU", apelliU);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.Parameters.AddWithValue("@emailU", gmail);

            if (Rol == "Instructor")
            {
                Rol = "2";
                comando.Parameters.AddWithValue("@id_rol", Rol);
            }
            else if (Rol == "Aprendiz")
            {
                Rol = "1";
                comando.Parameters.AddWithValue("@id_rol", Rol);
            }
            else if (Rol == "Practicante")
            {
                Rol = "3";
                comando.Parameters.AddWithValue("@id_rol", Rol);
            }
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public void DeleteUser(string cedula)
        {
            string delete = " delete from usuario where Cedula =  '" + cedula + "'";
            conexion.Open();
            SqlCommand comando = new SqlCommand(delete, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
        #region CRUD_producto
        public int ExistenciaProducto(string code)
        {
            string consulta = "Select * from producto where codigoP='" + code + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            int resultado = dt.Rows.Count;
            return resultado;

        }

        public int InsertProducto(string code, string nombre, string cant, string categoria)
        {
            string insert = "insert into producto (codigoP,nomP,stock,categoria) values (@code,@nomP,@stock,@cate)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(insert, conexion);
            comando.Parameters.AddWithValue("@code", code);
            comando.Parameters.AddWithValue("@nomP", nombre);
            comando.Parameters.AddWithValue("@stock", cant);
            comando.Parameters.AddWithValue("@cate", categoria);
            int intAfectados = comando.ExecuteNonQuery();
            conexion.Close();
            return intAfectados;
        }
        public void LIstaProducto(DataGridView vista)
        {
            string consulta = "Select * from producto";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            vista.DataSource = dt;
            vista.Columns["codigoP"].DisplayIndex = 0;
            vista.Columns["nomP"].DisplayIndex = 1;
            vista.Columns["stock"].DisplayIndex = 2;
            vista.Columns["categoria"].DisplayIndex = 3;
        }
        public void UpdateProducto(string code, string nombre, string cant, string categoria)
        {
            string insert = "update producto set nomP =@nomP,stock=@stock,categoria=@cate where codigoP = '" + code + "'";
            conexion.Open();
            SqlCommand comando = new SqlCommand(insert, conexion);
            comando.Parameters.AddWithValue("@nomP", nombre);
            comando.Parameters.AddWithValue("@stock", cant);
            comando.Parameters.AddWithValue("@cate", categoria);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void DeleteProdu(string code)
        {

            string delete = " delete from producto where codigoP =  '" + code + "'";
            conexion.Open();
            SqlCommand comando = new SqlCommand(delete, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Prestamo

        public DataTable TraerProducto(string Buscar)
        {
            string consulta = "Select * from producto where codigoP = '" + Buscar + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;

        }
        public DataTable TraerUsuario(string Buscar)
        {
            string consulta = "Select  * from usuario where Cedula = '" + Buscar + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;

        }

        public void insertPrestamo(string fecha, string cedu, DataGridView productos)
        {
            int id = 0;
            conexion.Open();
            SqlCommand comando = new SqlCommand(null, conexion);
            comando.CommandText = "InsertPrestamo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fechaP", fecha);
            comando.Parameters.AddWithValue("@cedu", cedu);
            comando.Parameters.AddWithValue("@idP", SqlDbType.Int).Direction = ParameterDirection.Output;

            int result = comando.ExecuteNonQuery();
            if (result > 0)
            {
                id = Convert.ToInt32(comando.Parameters["@idp"].Value);
                Console.WriteLine("Exitos, id:" + id.ToString());

            }
            conexion.Close();
            conexion.Open();
            int Contador = 0;
            foreach (DataGridViewRow row in productos.Rows)
            {
                SqlCommand commando = new SqlCommand(null, conexion);
                commando.CommandText = "InsertDetPrestamo";
                commando.CommandType = CommandType.StoredProcedure;
                commando.Parameters.AddWithValue("@idP", id);
                commando.Parameters.AddWithValue("@cant", Convert.ToInt32(row.Cells["Cantidad"].Value));
                commando.Parameters.AddWithValue("@idProd", Convert.ToInt32(row.Cells["Codigo"].Value));
                int Fila = commando.ExecuteNonQuery();
                Contador += Fila;
            };
            if (Contador > 0)
            {
                Console.WriteLine("Exitos, cantidad:" + Contador.ToString());
            }

            conexion.Close();

        }

        public void LIstaPrestamo(DataGridView vista)
        {
            string consulta = "Select * from Completa";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            vista.DataSource = dt;
            vista.Columns["Cedula"].DisplayIndex = 0;
            vista.Columns["Nombre"].DisplayIndex = 1;
            vista.Columns["Apellido"].DisplayIndex = 2;
            vista.Columns["Codigo"].DisplayIndex = 3;
            vista.Columns["Producto"].DisplayIndex = 4;
            vista.Columns["Cantidad"].DisplayIndex = 5;
            vista.Columns["Fecha_Prestamo"].DisplayIndex = 6;
            vista.Columns["Eliminar"].DisplayIndex = 7;
            #endregion 
        }
        public int BuscarPrestamo(DataGridView vista, string buscar)
        {
            string consulta = "Select Fecha_Prestamo,Cedula,Nombre,cantidad,Codigo,Producto from Completa where Cedula = '" + buscar + "' or Codigo = '" + buscar + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
           int Resultado= adaptador.Fill(dt);

            vista.DataSource = dt;
            vista.Columns["Cedula"].DisplayIndex = 0;
            vista.Columns["Nombre"].DisplayIndex = 1;
            vista.Columns["Codigo"].DisplayIndex = 2;
            vista.Columns["Producto"].DisplayIndex = 3;
            vista.Columns["cantidad"].DisplayIndex = 4;
            vista.Columns["Fecha_Prestamo"].DisplayIndex = 5; //s

            return Resultado;
        }

        public DataTable TraerDatos(DataGridView vista,string buscar)
        {
            string consulta = "Select * from Devolver where Cedula = '"+buscar+"' or Codigo = '"+buscar+"'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;
        }

        public void InsertDevolucion(string Id,string cantD,string fecha,string idP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(null, conexion);
            comando.CommandText = "SP_SumStock";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idP", Id);
            comando.Parameters.AddWithValue("@CantD", cantD);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@idProdcut", idP);

            comando.ExecuteNonQuery();

            conexion.Close();
        }
    }

}
