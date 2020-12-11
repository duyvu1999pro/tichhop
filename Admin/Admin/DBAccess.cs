using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    class DBAccess
    {
        //private static string connVu =
        //  "Data Source = DESKTOP-VES4POV\\MSSQLSERVER03;Database =ASSISTANT; Integrated Security=SSPI;";
        private static string connVu = "Data Source = (local)\\MSSQLSERVER03;Database =SHOPBANTHUOCAPI2020; Integrated Security=SSPI;";

        public static SqlConnection connection = new SqlConnection(connVu);
        private static SqlDataAdapter adapter;
        private static SqlCommand command;
        private static DataTable dataTable;

        //   MessageBox.Show(ASSISTANT.checkCon().ToString());
        public bool checkCon()
        {
            if (connection.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }
        public void pushGridview(string query, DataGridView gridview)//get
        {

            try
            {
                connection.Open();

                DataTable data = new DataTable();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                gridview.DataSource = data;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString(), "ERROR", MessageBoxButtons.OK);
            }
            finally
            {
                connection.Close();

            }
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

        public string autoID(string name_table)
        {
            command = new SqlCommand("SELECT MAX(id) AS MAX FROM " + name_table);
            dataTable = new DataTable();
            pushDataTable(command, dataTable);
            int id = 0;
            if (dataTable.Rows[0]["MAX"].ToString() == "")
            {
                id++;
                return id.ToString();
            }
            id = Convert.ToInt32(dataTable.Rows[0]["MAX"].ToString()) + 1;
            return id.ToString();
        }
        public void pushComboBox(string query, ComboBox cbo, string inn, string outt)
        {

            command = new SqlCommand(query);
            DataTable table = new DataTable();
            pushDataTable(command, table);


            cbo.ValueMember = inn; //Trường giá trị
            cbo.DisplayMember = outt; //Trường hiển thị
            cbo.DataSource = table;



        }
        #region phần chữa cháy
        public string autoIDSANPHAM(string name_table)
        {
            command = new SqlCommand("SELECT MAX(MaSP) AS MAX FROM " + name_table);
            dataTable = new DataTable();
            pushDataTable(command, dataTable);
            int id = 0;
            if (dataTable.Rows[0]["MAX"].ToString() == "")
            {
                id++;
                return id.ToString();
            }
            id = Convert.ToInt32(dataTable.Rows[0]["MAX"].ToString()) + 1;
            return id.ToString();
        }
     
      
        #endregion
    }
}
