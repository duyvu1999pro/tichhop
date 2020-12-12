using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;

using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Admin.Properties;
//using System.Net.Http.Formatting.dll;

namespace Admin
{
    public partial class Menu : Form
    {
        public string baseAddress = "https://localhost:44373/api/";
        public Menu()
        {          
            InitializeComponent();
         
           
        }
      
        private void but_child_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            switch (but.Name)
            {
                case "orders":
                    board_main.Controls.Clear();
                    Orders formOrders = new Orders();
                    call_form(formOrders);
                    label_pos.Text = "Đơn hàng";
                    break;
                case "product":
                    board_main.Controls.Clear();
                    Product formProduct = new Product();
                    call_form(formProduct);
                    label_pos.Text = "Sản phẩm";
                    break;              
                case "customer":
                    board_main.Controls.Clear();
                    Customer formCustomer = new Customer();
                    call_form(formCustomer);
                    label_pos.Text = "Khách hàng";
                    break;
            }
            }
     


        
      
    
     
       
       

        #region hàm hiệu ứng
        private void call_form(Form child_form)
        {
            child_form.TopLevel = false;
            board_main.Controls.Add(child_form);
            child_form.Dock = DockStyle.Fill;
            child_form.Show();
        }
      
        private void resize_but_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void board_bar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void board_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void board_bar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
        #region hàm cho nút mở rộng
        /*  private int indexBut = 1;
         *  private void but_parent_Click(object sender, EventArgs e)
            {
                Button but = (Button)sender;
                switch (but.Name)
                {
                    case "but1":
                        autoCloseBut(3);
                        indexBut = 1;
                        timer1.Start();
                        break;
                    case "but2":
                        autoCloseBut(3);
                        indexBut = 2;
                        timer1.Start();
                        break;
                    case "but3":
                        autoCloseBut(3);
                        indexBut = 3;
                        timer1.Start();
                        break;
                    case "but4":
                        autoCloseBut(3);
                        indexBut = 4;
                        timer1.Start();
                        break;

                }
            }
              private void resizeBut(int index, Panel p, Button b)
            {

                if (!isExpand[index])//mở ra
                {
                    b.Image = Resources.up_arrow;
                    p.Height += 10;
                    if (p.Size.Height == p.MaximumSize.Height)
                    {
                        timer1.Stop();
                        isExpand[index] = true;
                    }
                }
                else  //thu lại
                {
                    b.Image = Resources.down_arrow;
                    p.Height -= 10;
                    if (p.Size.Height == p.MinimumSize.Height)
                    {
                        timer1.Stop();
                        isExpand[index] = false;
                    }

                }
            }
            private bool[] isExpand = { false, false, false, false, false };
            private void autoCloseBut(int max)
            {
                int dem = 0;
                for (int i = 1; i < isExpand.Length; i++)
                {
                    if (isExpand[i] == true)
                    {
                        dem++;
                    }
                }

                if (dem > max - 1)
                {
                    //but1.Image = Resources.down_arrow;
                    // p1.Height = p1.MinimumSize.Height;
                    // isExpand[1] = false;
                    // but2.Image = Resources.down_arrow;
                    // p2.Height = p2.MinimumSize.Height; 
                    // isExpand[2] = false;
                    // but3.Image = Resources.down_arrow;
                    // p3.Height = p3.MinimumSize.Height;
                    //   isExpand[3] = false;
                    //  but4.Image = Resources.down_arrow;                                                                   
                    //  p4.Height = p4.MinimumSize.Height;          
                    //   isExpand[4] = false;




                }
            }*/
        private void timer1_Tick(object sender, EventArgs e)
        {

            //switch (indexBut)
            //{
            //    case 1:

            //        resizeBut(indexBut,p1,but1);
            //        break;
            //    case 2:

            //        resizeBut(indexBut, p2, but2);                
            //        break;
            //    case 3:

            //        resizeBut(indexBut, p3, but3);                  
            //        break;
            //    case 4:

            //        resizeBut(indexBut, p4, but4);                  
            //        break;

            //}
        }
        #endregion
        #region phần đăng nhập 
       
      
        private void btnLogin_Click(object sender, EventArgs e)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                QUANTRI account = new QUANTRI
                {
                    SDT = tk.Text.Trim(),
                    MatKhau = mk.Text.Trim()
                };


                var resp = client.PostAsJsonAsync("quantri/check", account);
                resp.Wait();
                var rs = resp.Result;

                if (rs.IsSuccessStatusCode)
                {
                    var readTask = rs.Content.ReadAsAsync<string>();
                    WELCOME.Text = "Hi, Admin: " + readTask.Result;

                    panel_choice.Enabled = true;
                    board_main.Controls.Clear();
                    Orders formOrders = new Orders();
                    call_form(formOrders);
                    label_pos.Text = "Đơn hàng";

                }
                else
                {
                    MessageBox.Show("Error occured! Please try again.");

                }

            }

        }


        #endregion
    }
}
