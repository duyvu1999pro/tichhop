using api_shop_ban_thuoc_btl_cnltth_2020.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace api_shop_ban_thuoc_btl_cnltth_2020
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //private static string conn = "Data Source = (local)\\MSSQLSERVER03;Database =SHOPBANTHUOCAPI2020; Integrated Security=SSPI;";
        private static string conn =System.Configuration.ConfigurationManager. ConnectionStrings["MyDBContext"].ConnectionString;
        public static SqlConnection connection = new SqlConnection(conn); 
        public void pushDataTable(SqlCommand dbCommand, DataTable data)//đẩy dữ liệu vào dataTable
        {
            
            try
            {

                connection.Open();
                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(dbCommand);
                adapter.Fill(data);

            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

        }
       
     
        
    }
}
