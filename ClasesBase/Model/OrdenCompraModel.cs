using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using ClasesBase;

namespace ClasesBase
{
    public class OrdenCompraModel
    {
        //Este metodo listarProveedor trae todo los roles de la tabla roles.
        public static DataTable listarProveedor()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM proveedor";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }//fin-listarProveedor

        //traer a todos los usuarios: es usado para hacer el login de los diferntes usuarios
        public static Orden_Compra traer_orden(string u)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Orden_Compra where usr_username=@u";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@u", u);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Orden_Compra oOrden = null;
            if (reader.Read() == true)
            {
                /*oUsuario = new Usuario();

                oUsuario.Usr_UserName = (string)reader["usr_username"];
                oUsuario.Usr_Nombre = (string)reader["usr_nombre"];
                oUsuario.Usr_Apellido = (string)reader["usr_apellido"];
                oUsuario.Usr_Password = (string)reader["usr_password"];
                oUsuario.Rol_Id = (int)reader["rol_id"];
                oUsuario.Usr_Email = (string)reader["usr_email"];*/

            }
            cnn.Close();
            return oOrden;
        }

        //El metodo insertarOrdenCompra nos permite guardar un regsitro
        //a la base de datos pasteleriaDB.
        public static void insertarOrdenCompra(Orden_Compra ordenCompra)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Orden_Compra(prov_id,oc_fecha,pagada) values(@prov,@fecha,@pag)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@prov", ordenCompra.Prov_Id);
            cmd.Parameters.AddWithValue("@fecha", ordenCompra.Oc_fecha);
            cmd.Parameters.AddWithValue("@pag", ordenCompra.Pagada);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }//fin-insertarOredenCompra


        /*     //El metodo insertarOrdenCompra nos permite guardar un regsitro
        //a la base de datos pasteleriaDB.
        public static void obtenerOcId(Orden_Compra ordenCompra)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select max(id) from Orden_Compra";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }//fin-insertarOredenCompra*/


        //Este metodo listarArticulos trae todo los articulos de la tabla Articulos.
        public static DataTable listarArticulo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM articulo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds.Tables[0];
        }//fin-listarProveedor

        //El metodo insertarItemsOrdenCompra nos permite guardar un regsitro
        //a la base de datos pasteleriaDB.
        public static void insertarItemsOrdenCompra(Items_Orden_Compra itemsOrdenCompra)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Items_Orden_Compra(oc_id,art_id,costo,cantidad,importe) values(@oc,@art,@costo,@cant,@imp)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@oc", itemsOrdenCompra.Oc_id);
            cmd.Parameters.AddWithValue("@art", itemsOrdenCompra.Art_id);
            cmd.Parameters.AddWithValue("@costo", itemsOrdenCompra.Costo);
            cmd.Parameters.AddWithValue("@cant", itemsOrdenCompra.Cantidad);
            cmd.Parameters.AddWithValue("@imp", itemsOrdenCompra.Importe);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }//fin-insertarOredenCompra



        //Este metodo listarProveedor trae todo los roles de la tabla roles.
        public static DataTable listarItemsOrdenCompra()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT";
            cmd.CommandText += " item_oc_id as 'Id', ";
            cmd.CommandText += " costo as 'Costo', ";
            cmd.CommandText += " cantidad as 'Cantidad', ";
            cmd.CommandText += " importe as 'Importe', ";
            cmd.CommandText += " art_descrip as 'Articulo', ";
            cmd.CommandText += " OC.oc_id as 'Id Compra'";
            cmd.CommandText += " FROM Items_Orden_Compra as IC";

            cmd.CommandText += " LEFT JOIN Articulo as A ON (A.art_id=IC.art_id)";
            cmd.CommandText += " LEFT JOIN Orden_Compra as OC ON (OC.oc_id=IC.oc_id)";
            //cmd.CommandText += " FROM Usuario as U";
            //cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_id=U.rol_id)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }//fin-listarProveedor

        //Este metodo listarProveedor trae todo los roles de la tabla roles.
        public static DataTable listarOrdenCompra()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM orden_compra";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }//fin-listarProveedor


    }
}
