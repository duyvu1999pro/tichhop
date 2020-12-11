using api_shop_ban_thuoc_btl_cnltth_2020.Models;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace api_shop_ban_thuoc_btl_cnltth_2020.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        private MyDBContext context = new MyDBContext();

        public ActionResult Account()
        {
            KHACHHANG auth = null;
            auth = (KHACHHANG)Session["LoginKH"];

             return View(auth);

        }
        public ActionResult Dangxuat()
        {

            Session["LoginKH"] = null;
            return RedirectToAction("index", "home");
            //return Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(KHACHHANG acc)
        {
            KHACHHANG model = null;
            model = context.KHACHHANGs.Where(X => X.SDT.Contains(acc.SDT)).FirstOrDefault();
            
            

            if (model != null )
            {
                Boolean check = BCrypt.Net.BCrypt.Verify(acc.MatKhau, model.MatKhau.Trim());
                if (check)
                {
                    Session["LoginKH"] = model;
                    TempData["success"] = "Đăng nhập thành công!";
                    return Redirect(Request.UrlReferrer.ToString());
                }
                else
                {
                    TempData["error"] = "Tài khoản hoặc mật khẩu không đúng!" ;
                    return RedirectToAction("login");
                }
            }
            else
            {
                TempData["error"] = "Tài khoản hoặc mật khẩu không đúng!";
                return RedirectToAction("login");
            }
        }
        public ActionResult logincart()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Logincart(KHACHHANG acc)
        {
            KHACHHANG model = null;
            model = context.KHACHHANGs.Where(X => X.SDT.Contains(acc.SDT)).FirstOrDefault();



            if (model != null)
            {
                Boolean check = BCrypt.Net.BCrypt.Verify(acc.MatKhau, model.MatKhau.Trim());
                if (check)
                {
                    Session["LoginKH"] = model;
                    TempData["success"] = "Đăng nhập thành công!";
                    return RedirectToAction("payment", "Cart");
                }
                else
                {
                    TempData["error"] = "Tài khoản hoặc mật khẩu không đúng!";
                    return RedirectToAction("logincart");
                }
            }
            else
            {
                TempData["error"] = "Tài khoản hoặc mật khẩu không đúng!";
                return RedirectToAction("logincart");
            }
        }

        //
        public ActionResult Regiter()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Regiter(KHACHHANG kh)
        {
            var regiter = context.KHACHHANGs.Where(x => x.SDT == kh.SDT).FirstOrDefault();
            if(regiter == null)
            {
                try
                {
                    //HTTP POST
                    using (var client = new HttpClient())
                    {
                        //gọi api thêm khascch hàng
                        client.BaseAddress = new Uri("https://localhost:44373/api/");
                        //Mã hóa
                        kh.MatKhau = BCrypt.Net.BCrypt.HashPassword(kh.MatKhau, 14);
                        var postTask = await client.PostAsJsonAsync<KHACHHANG>("khachhang/addkhachhang", kh);
                        if (postTask.IsSuccessStatusCode)
                        {
                            TempData["success"] = "Đăng ký tài khoản thành công!";
                        }
                        else
                        {
                            TempData["error"] = "Đăng ký tài khoản thất bại!";
                            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
                        }

                    }
                }
                catch (Exception ex)
                {
                    //ghi loi
                    return RedirectToAction("Error", "Cart");
                }
            }
            else
            {
                TempData["error"] = "Số điện thoại đã được sử dụng!";
            }
            return View("Regiter");
        }

        [HttpPost]
        public ActionResult ChangeInfo(KHACHHANG kh)
        {
            var khachhang = context.KHACHHANGs.Where(x => x.MaKH == kh.MaKH).FirstOrDefault();
            if (khachhang.SDT == kh.SDT) // Số điện thoại không thay đổi
            {
                khachhang.HoTen = kh.HoTen;
                khachhang.Email = kh.Email;
                khachhang.Diachi = kh.Diachi;
                context.SaveChanges();
                TempData["success"] = "Cập nhật thành công!";
            }
            else
            {
                var sdt = context.KHACHHANGs.Where(x => x.SDT == kh.SDT).FirstOrDefault();
                if(sdt == null)// nếu số đt chưa được dùng
                {
                    khachhang.HoTen = kh.HoTen;
                    khachhang.Email = kh.Email;
                    khachhang.SDT = kh.SDT;
                    khachhang.Diachi = kh.Diachi;
                    context.SaveChanges();
                    TempData["success"] = "Cập nhật thành công!";
                }
                else
                {
                    TempData["error"] = "Số điện thoại đã được sử dụng!";
                }
            }
            return RedirectToAction("Account");
        }
        public ActionResult ChangePassword(KHACHHANG kh, String matkhaucu)
        {
            var khachhang = context.KHACHHANGs.Where(x => x.MaKH == kh.MaKH).FirstOrDefault();
            Boolean check = BCrypt.Net.BCrypt.Verify(matkhaucu, khachhang.MatKhau.Trim());
            if (check)
            {
                kh.MatKhau = BCrypt.Net.BCrypt.HashPassword(kh.MatKhau, 14);
                khachhang.MatKhau = kh.MatKhau;
                context.SaveChanges();
                TempData["success"] = "Cập nhật mật khẩu thành công!";
            }
            else
            {
                TempData["error"] = "Mật khẩu hiện tại không đúng!";
            }
            return RedirectToAction("Account");
        }
        
    }
}