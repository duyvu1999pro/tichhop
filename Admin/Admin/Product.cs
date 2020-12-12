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
        public string baseAddress = Function.GetUri();    
        DataTable data = new DataTable();
        string id_temp = "";
        public Product()
        {
            InitializeComponent();
            loadComboBox();         
        }
        #region Load
        private void loadComboBox()
        {
            DataTable table = new DataTable();           
            table = Function.GetDataTable("danhmuc/getData");
            Function.pushComboBox(table, kind, "MaDM", "TenDM");          
        }
        private void loadGridview()
        {
            
            data = new DataTable();
            data = Function.GetDataTableWithValue("product/getData", kind.SelectedValue.ToString());
            if (Function.HasRow(data))
            {
                gridView.DataSource = Function.GetDataTableWithValue("product/getView", kind.SelectedValue.ToString());                           
            }
            else
            {
                for (int i = gridView.Rows.Count-1; i >= 0; i--)
                {
                    gridView.Rows.RemoveAt(i);
                                     
                }
            }
               
            
            

        }
        #endregion
        #region hiệu ứng
                
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
             if (condition())
                 {
               
                SANPHAM sp = new SANPHAM();
                sp.MaDM = Convert.ToInt32(kind.SelectedValue.ToString());
                sp.TenSP = tenthuoc.Text;
                sp.ThanhPhan = thanhphan.Text;
                sp.CongDung  = congdung.Text;
                sp.LieuLuong = lieuluong.Text;
                sp.DonVi     = donvi.Text;
                sp.DangThuoc = dangthuoc.Text;
                sp.HinhAnh   = urlanh.Text;
                sp.MoTa      = mota.Text;
                sp.GiaBan    = Convert.ToInt32(dongia.Text);
                Function.Add("product/addthuoc", sp);
         
            clear();
                loadGridview();
           }

        }
        private void sua(object sender, EventArgs e)
        {
            if (condition())
            {

                SANPHAM sp = new SANPHAM();
                sp.MaSP = id_temp;
                sp.MaDM = Convert.ToInt32(kind.SelectedValue.ToString());
                sp.TenSP = tenthuoc.Text;
                sp.ThanhPhan = thanhphan.Text;
                sp.CongDung = congdung.Text;
                sp.LieuLuong = lieuluong.Text;
                sp.DonVi = donvi.Text;
                sp.DangThuoc = dangthuoc.Text;
                sp.HinhAnh = urlanh.Text;
                sp.MoTa = mota.Text;
                sp.GiaBan = Convert.ToInt32(dongia.Text);
                Function.Edit("product/updatethuoc", sp);
           
            AddForm();
                loadGridview();
            }
        }
        private void xoa(object sender, EventArgs e)
        {
            Function.Delete("product/delthuoc", id_temp);          
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
            if (!Function.HasRow(data))                              
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
            Function.Delete("danhmuc/deldanhmuc", kind.SelectedValue.ToString());            
            loadComboBox();

        }
        private void add_kind(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && text_add.Text != "")
            {              
                DANHMUC dm = new DANHMUC();
                dm.TenDM = text_add.Text;
                Function.Add("danhmuc/adddanhmuc", dm);
                text_add.Clear();
                text_add.Visible = false;
                kind_add.Text = "+";               
                loadComboBox();
               
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
