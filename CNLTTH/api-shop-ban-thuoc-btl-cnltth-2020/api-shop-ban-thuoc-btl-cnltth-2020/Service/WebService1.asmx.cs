using api_shop_ban_thuoc_btl_cnltth_2020.Models;
using System;
using System.Collections.Generic;
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
        private static string conn = "Data Source = (local)\\MSSQLSERVER03;Database =SHOPBANTHUOCAPI2020; Integrated Security=SSPI;";

        public static SqlConnection connection = new SqlConnection(conn);
        private static SqlDataAdapter adapter;
        private static SqlCommand command;
        private static DataTable dataTable;
        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}
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
        public bool SelectHasRow(string query)
        {

            try
            {
                connection.Open();
                command = new SqlCommand(query);
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                SqlDataReader dataread = command.ExecuteReader();
                if (dataread.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

        }
        public void ExecuteProcedure(SqlCommand cmd)
        {
            try
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();

            }

        }
        public string FirstKind()
        {
            MyDBContext db = new MyDBContext();
            string id = "";
            SANPHAM a = db.SANPHAMs.FirstOrDefault();
            return a.MaDM.ToString();
        }
        
    }
}
