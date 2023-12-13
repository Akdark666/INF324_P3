using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hola a todos";
    }

    [WebMethod]
    public DataSet tblAlumno()
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter ada = new SqlDataAdapter();
        con.ConnectionString = "Data Source=IVAN_PC\\SQLEXPRESS;Initial Catalog=academico;Integrated Security=True";
        ada.SelectCommand = new SqlCommand();
        ada.SelectCommand.Connection = con;
        ada.SelectCommand.CommandText = "select * from alumno";
        ada.SelectCommand.CommandType = CommandType.Text;
        DataSet ds = new DataSet();
        ada.Fill(ds, "alumno");
        return ds;
    }

    [WebMethod]
    public void insAlumno(String ci, String nom, String pat, String depto, int pra)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=IVAN_PC\\SQLEXPRESS;Initial Catalog=academico;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        string sql = string.Empty;
        sql = sql + "insert into alumno values ('" + ci + "','" + nom + "','" + pat + "','" + depto + "','" + pra + "')";
        cmd.CommandText = sql;
        cmd.CommandText = sql;
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

    [WebMethod]
    public void actAlumno(String ci, String nom, String pat, String depto, int pra)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=IVAN_PC\\SQLEXPRESS;Initial Catalog=academico;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        string sql = string.Empty;
        sql = sql + "update alumno set nom='" + nom + "', pat='" + pat + "', depto='" + depto + "', pra="+ pra +" where ci='" + ci + "';";
        cmd.CommandText = sql;
        cmd.CommandText = sql;
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

    [WebMethod]
    public void eliAlumno(String ci)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=IVAN_PC\\SQLEXPRESS;Initial Catalog=academico;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        string sql = string.Empty;
        sql = sql + "delete from alumno where ci='" + ci + "';";
        cmd.CommandText = sql;
        cmd.CommandText = sql;
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}
