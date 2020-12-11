using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Product : Form
    {
        DBAccess model = new DBAccess();
        SqlCommand cmd;
        DataTable data = new DataTable();
        string id_temp = "";
        public Product()
        {
            InitializeComponent();
            loadComboBox();
           
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }
        #region Load
        private void loadComboBox()
        {
            model.pushComboBox(@"select *from DANHMUC", kind, "MaDM", "TenDM");
        }
        private void loadGridview()
        {
            data = new DataTable();
            cmd = new SqlCommand("select *from SANPHAM where MaDM=" + kind.SelectedValue.ToString());
            model.pushDataTable(cmd, data);
            model.pushGridview("select MaSP,TenSP from SANPHAM where MaDM=" + kind.SelectedValue.ToString(), gridView);
        }
        #endregion
        #region changeForm
        private void clear()
        {
            tenthuoc.Clear();
            thanhphan.Clear();
            lieuluong.Clear();
            congdung.Clear();
           dangthuoc.Clear();
            dongia.Clear();
            donvi.Clear();
            urlanh.Clear();
            mota.Clear();
           
        }
        private void AddForm()
        {

            clear();
            but_add.Visible = true;
            but_back.Visible = false;
            pan_edit.Visible = false;
        }
        private void EditForm()
        {

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
                tenthuoc.Text = this.gridView.CurrentRow.Cells[1].Value.ToString();
                id_temp = this.gridView.CurrentRow.Cells[0].Value.ToString();

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (data.Rows[i]["MaSP"].ToString() == id_temp)
                    {

                        thanhphan.Text = data.Rows[i]["ThanhPhan"].ToString();
                       congdung.Text = data.Rows[i]["CongDung"].ToString();
                        lieuluong.Text = data.Rows[i]["LieuLuong"].ToString();
                        donvi.Text = data.Rows[i]["DonVi"].ToString();
                        dangthuoc.Text = data.Rows[i]["DangThuoc"].ToString();
                        urlanh.Text = data.Rows[i]["HinhAnh"].ToString();
                        mota.Text = data.Rows[i]["MoTa"].ToString();
                       dongia.Text = data.Rows[i]["GiaBan"].ToString();
                        break;
                    }
                }

            }
        }
        private void them(object sender, EventArgs e)
        {
            // if (condition())@MaSP INT,
                // {
                cmd = new SqlCommand("InsertSANPHAM");
                cmd.Parameters.AddWithValue("@MaSP", model.autoIDSANPHAM("SANPHAM"));
                cmd.Parameters.AddWithValue("@MaDM", kind.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@TenSP", tenthuoc.Text);
                cmd.Parameters.AddWithValue("@ThanhPhan", thanhphan.Text);
                cmd.Parameters.AddWithValue("@CongDung", congdung.Text);
                cmd.Parameters.AddWithValue("@LieuLuong", lieuluong.Text);
                cmd.Parameters.AddWithValue("@DonVi", donvi.Text);
                cmd.Parameters.AddWithValue("@DangThuoc", dangthuoc.Text);
                cmd.Parameters.AddWithValue("@HinhAnh", urlanh.Text);
                cmd.Parameters.AddWithValue("@MoTa", mota.Text);
                cmd.Parameters.AddWithValue("@GiaBan", dongia.Text);
                
                
                model.ExecuteProcedure(cmd);
            clear();
                loadGridview();
           // }

        }
        private void sua(object sender, EventArgs e)
        {
           // if (condition())
           // {
                cmd = new SqlCommand("UpdateSANPHAM");
                cmd.Parameters.AddWithValue("@id", id_temp);
            cmd.Parameters.AddWithValue("@TenSP", tenthuoc.Text);
            cmd.Parameters.AddWithValue("@ThanhPhan", thanhphan.Text);
            cmd.Parameters.AddWithValue("@CongDung", congdung.Text);
            cmd.Parameters.AddWithValue("@LieuLuong", lieuluong.Text);
            cmd.Parameters.AddWithValue("@DonVi", donvi.Text);
            cmd.Parameters.AddWithValue("@DangThuoc", dangthuoc.Text);
            cmd.Parameters.AddWithValue("@HinhAnh", urlanh.Text);
            cmd.Parameters.AddWithValue("@MoTa", mota.Text);
            cmd.Parameters.AddWithValue("@GiaBan", dongia.Text);
            model.ExecuteProcedure(cmd);
                AddForm();
                loadGridview();
          //  }
        }
        private void xoa(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DeleteSANPHAM");
            cmd.Parameters.AddWithValue("@id", id_temp);
            model.ExecuteProcedure(cmd);
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
        #region kind
        private void open_kind(object sender, EventArgs e)
        {
            if (kind_add.Text == "+")
            {
                kind_add.Text = "-";
                text_add.Visible = true;
            }
            else
            {

                kind_add.Text = "+";
                text_add.Visible = false;
            }
        }
        private void kind_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGridview();
            AddForm();
            if (!model.SelectHasRow("select *from SANPHAM where MaDM=" + kind.SelectedValue.ToString()))
            {
                kind_del.Visible = true;
            }
            else
            {
                kind_del.Visible = false;
            }



        }

        private void del_kind(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DeleteDANHMUC");
            cmd.Parameters.AddWithValue("@id", kind.SelectedValue.ToString());
            model.ExecuteProcedure(cmd);
            loadComboBox();

        }
        private void add_kind(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && text_add.Text != "")
            {
                cmd = new SqlCommand("InsertDANHMUC");
               
                cmd.Parameters.AddWithValue("@ten", text_add.Text);
                model.ExecuteProcedure(cmd);
                text_add.Clear();
                text_add.Visible = false;
                kind_add.Text = "+";               
                loadComboBox();
               
            }
        }
        #endregion
      
    }
}
