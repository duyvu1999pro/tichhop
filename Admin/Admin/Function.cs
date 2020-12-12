using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    class Function
    {
        public static string GetUri()
        { return "https://localhost:44373/api/"; }
        public static DataTable GetDataTable(string request)
        {
            DataTable temp = new DataTable();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetUri());
                var resp = client.GetAsync(request);
                resp.Wait();
                var rs = resp.Result;
                if (rs.IsSuccessStatusCode)
                {
                    var readTask = rs.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    return readTask.Result;
                }
                return temp;
            }
        }
        public static DataTable GetDataTableWithValue(string request,string value)
        {
            DataTable temp = new DataTable();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetUri());
           
                    var resp = client.GetAsync(request + "/"+ value);
                resp.Wait();
                var rs = resp.Result;
                if (rs.IsSuccessStatusCode)
                {
                    var readTask = rs.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    return readTask.Result;
                }
                return temp;
            }
        }
        public static void pushComboBox(DataTable table,ComboBox cbo, string inn, string outt)
        {      
            cbo.ValueMember = inn; //Trường giá trị
            cbo.DisplayMember = outt; //Trường hiển thị
            cbo.DataSource = table;
        }
        #region CRUD
        public static void Add(string request,Object obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetUri());
                var resp = client.PostAsJsonAsync(request, obj);
                resp.Wait();
                var rs = resp.Result;

            }
        }
        public static bool HasRow( DataTable temp)
        {
            if (temp.Rows.Count>0)
            {
                return true;    
            }
            else
            {

                return false;
            }
        }
       


     
        public static void Edit(string request, Object obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetUri());
                var putTask = client.PutAsJsonAsync(request, obj).Result;
            }
        }
        public static void Delete(string request, string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetUri());
                var deleteTask = client.DeleteAsync(request+"/" + id).Result;
            }
        }
        #endregion

    }
}
