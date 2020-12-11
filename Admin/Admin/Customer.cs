using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Customer : Form
    {
        public string baseAddress = "https://localhost:44373/api/";
        //DBAccess model = new DBAccess();
        //SqlCommand cmd;
        DataTable data = new DataTable();
        string id_temp = "";
        public Customer()
        {
            InitializeComponent();
            loadGridview();    
        }
        #region Load
        private DataTable GetDataTable(string request)
        {
            DataTable temp = new DataTable();        
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
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
        private void loadGridview()
        {
            data = new DataTable();         
            data = GetDataTable("khachhang/getData");
            gridView.DataSource = GetDataTable("khachhang/getView");
          //  model.pushGridview("select MaKH,HoTen from KHACHHANG;", gridView);
        }
        #endregion
        #region changeForm
        private void clear()
        {
            ten.Clear();
            sdt.Clear();
            matkhau.Clear();
            email.Clear();
            diachi.Clear();           
        }
        private void AddForm()
        {

            clear();
            label1.Text = "Mật khẩu";
            but_add.Visible = true;
            but_back.Visible = false;
            pan_edit.Visible = false;
        }
        private void EditForm()
        {
            label1.Text = "Đổi mật khẩu";
            clear();
            but_add.Visible = false;
            but_back.Visible = true;
            pan_edit.Visible = true;
        }

        #endregion
        #region CRUD
        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)//not header           
            {
                EditForm();
                ten.Text = this.gridView.CurrentRow.Cells[1].Value.ToString();
                id_temp = this.gridView.CurrentRow.Cells[0].Value.ToString();

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (data.Rows[i]["MaKH"].ToString() == id_temp)
                    {

                        sdt.Text = data.Rows[i]["SDT"].ToString();
                        matkhau.Text = data.Rows[i]["MatKhau"].ToString();
                        email.Text = data.Rows[i]["Email"].ToString();
                        diachi.Text = data.Rows[i]["Diachi"].ToString();
                     
                        break;
                    }
                }

            }
        }
        private void them(object sender, EventArgs e)
        {

            //cmd = new SqlCommand("InsertKHACHHANG");
            //cmd.Parameters.AddWithValue("@SDT", sdt.Text);
            //cmd.Parameters.AddWithValue("@HoTen", ten.Text);
            //cmd.Parameters.AddWithValue("@Email", email.Text);
            //cmd.Parameters.AddWithValue("@MatKhau", matkhau.Text);
            //cmd.Parameters.AddWithValue("@Diachi", diachi.Text);
            //   model.ExecuteProcedure(cmd);
            if(condition())
            {    
            KHACHHANG kh = new KHACHHANG();
            kh.SDT = sdt.Text;
            kh.HoTen = ten.Text;
            kh.Email = email.Text;
            kh.MatKhau = matkhau.Text;
            kh.Diachi = diachi.Text;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                var resp = client.PostAsJsonAsync("khachhang/addkhachhang", kh);
                resp.Wait();
                var rs = resp.Result;
                //if (rs.IsSuccessStatusCode)
                //    MessageBox.Show("Add Success.");
                //else
                //    MessageBox.Show("Error");
            }          
            clear();
            loadGridview();
             }

        }
        private void sua(object sender, EventArgs e)
        {
             if (condition())
             {
            //cmd = new SqlCommand("UpdateKHACHHANG");
            //cmd.Parameters.AddWithValue("@MaKH", id_temp);
            //cmd.Parameters.AddWithValue("@SDT", sdt.Text);
            //cmd.Parameters.AddWithValue("@HoTen", ten.Text);
            //cmd.Parameters.AddWithValue("@Email", email.Text);
            //cmd.Parameters.AddWithValue("@MatKhau", matkhau.Text);
            //cmd.Parameters.AddWithValue("@Diachi", diachi.Text);
            //model.ExecuteProcedure(cmd);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                KHACHHANG kh = new KHACHHANG();
                kh.MaKH = Convert.ToInt32(id_temp);
                kh.SDT = sdt.Text;
                kh.HoTen = ten.Text;
                kh.Email = email.Text;
                kh.MatKhau = matkhau.Text;
                kh.Diachi = diachi.Text;
                var putTask = client.PutAsJsonAsync("khachhang/updateKhachHang", kh).Result;
                //if (putTask.IsSuccessStatusCode)               
                //    MessageBox.Show("Update Success.");                  
                
                //else
                //    MessageBox.Show("Error");
                
            }
            AddForm();
            loadGridview();
              }
        }
        private void xoa(object sender, EventArgs e)
        {
            //cmd = new SqlCommand("DeleteKHACHHANG");
            //cmd.Parameters.AddWithValue("@id", id_temp);
            //model.ExecuteProcedure(cmd);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                var deleteTask = client.DeleteAsync("khachhang/delKhachHang/" + id_temp).Result;

               // if (deleteTask.IsSuccessStatusCode)               
               //     MessageBox.Show("Delete Success.");                                
               // else
               //MessageBox.Show("Error");
              
            }
            AddForm();
            loadGridview();
        }
        private void but_back_Click(object sender, EventArgs e)
        {
            AddForm();
        }
        #endregion
        #region search
        private void search_but_Click(object sender, EventArgs e)
        {
            if (search_box.Visible == true)
            {
                search_box.Visible = false;
            }
            else
            {
                search_box.Visible = true;
            }
        }
        private void search_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_box.Visible = false;
            }
        }
        #endregion
        #region Điều kiện
        private bool condition()
        {
            //
            return true;
        }
        #endregion

    }
}
