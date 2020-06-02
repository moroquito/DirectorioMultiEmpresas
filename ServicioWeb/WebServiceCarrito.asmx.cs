using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
namespace ServicioWeb
{
    /// <summary>
    /// Descripción breve de WebServiceCarrito
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]

    public class WebServiceCarrito : System.Web.Services.WebService
    {

        SqlConnection cn = new SqlConnection(
                    "Data Source = DESKTOP-8CVQUPI;" +
                     "Initial Catalog = CarritoAndroid;" +
                    "Integrated Security = True;" +
                    "Connect Timeout = 30;" +
                    "Encrypt=False;" +
                    "TrustServerCertificate=False;" +
                    "ApplicationIntent=ReadWrite;" + 
                    "MultiSubnetFailover=False");

 
        public SqlConnection Cn { get => cn; set => cn = value; }
        //public SqlConnection CnProyectsV13 { get => CnProyectsV13; set => CnProyectsV13 = value; }

        [WebMethod]
        public Clientes [] ListaDeClientes()
        {
            Clientes[] clientes = null;
                    cn.Open();
                    string query = "select * from Clientes";
                    SqlCommand cmdClientes = new SqlCommand(query, cn);
            SqlDataReader dr;
            dr = cmdClientes.ExecuteReader();
            List<Clientes> Lclientes = new List<Clientes>();
            while (dr.Read())
            {
                Lclientes.Add(new Clientes(
                    dr.GetString (0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString (3),
                    dr.GetString (4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetDecimal(7),
                    dr.GetDecimal(8),
                    dr.GetString(9)
                    ));
            }
            clientes = Lclientes.ToArray();
            cn.Close();
            return clientes;
        }
        [WebMethod]
        public Productos [] ListarProducto()
        {
            Productos[] producto = null;
            cn.Open();
            string query = "select * from productos";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr ;
            dr = cmd.ExecuteReader();
            List<Productos> lista = new List<Productos>();
            while (dr.Read())
            {
                lista.Add(new Productos(
                    dr.GetString(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetInt32(3),
                    dr.GetDecimal(4),
                    dr.GetString(5)
                    ));
            }
            producto = lista.ToArray();
            cn.Close();
            return producto;
        }
    }
}
