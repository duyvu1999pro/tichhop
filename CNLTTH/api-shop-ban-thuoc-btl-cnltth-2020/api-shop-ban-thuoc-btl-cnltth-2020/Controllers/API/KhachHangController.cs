using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using api_shop_ban_thuoc_btl_cnltth_2020.Models;

namespace api_shop_ban_thuoc_btl_cnltth_2020.Controllers.API
{
    [RoutePrefix("api/khachhang")]
    public class KhachHangController : ApiController
    {
        //lấy tất cả khach hang
        WebService1 service = new WebService1();

        [HttpGet]
        [Route("getData")]
        public IHttpActionResult GetData()
        {
            DataTable data = new DataTable();
            SqlCommand cmd = new SqlCommand("select *from KHACHHANG;");
            if (!ModelState.IsValid)
                return BadRequest();
             service.pushDataTable(cmd, data);
            return Json(data);
        }
        [HttpGet]
        [Route("getView")]
        public IHttpActionResult GetView()
        {
            DataTable data = new DataTable();
            SqlCommand cmd = new SqlCommand("select MaKH,HoTen from KHACHHANG;");
            if (!ModelState.IsValid)
                return BadRequest();
            service.pushDataTable(cmd, data);
            return Json(data);
        }
        [HttpGet]
        [Route("getlistkhachhang")]
        public IEnumerable<KHACHHANG> GetListsKhachHang()
        {           
            using (MyDBContext context = new MyDBContext())
            {
                return context.KHACHHANGs.ToList();
            }
        }

        //lấy theo mã khachhang
        [HttpGet]
        [Route("getkhachhang/{id}")]
        public KHACHHANG GetKhachHang(int id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                return context.KHACHHANGs.Find(id);
            }
        }

        [HttpGet]
        [Route("getkhachhangsdt/{sdt}")]
        public KHACHHANG GetKhachHangsdt(string sdt)
        {
            using (MyDBContext context = new MyDBContext())
            {
                return context.KHACHHANGs.Where(x=>x.SDT==sdt).FirstOrDefault();
            }
        }

        [HttpPost]
        [Route("addkhachhang")]
        public bool ThemKhachHang(KHACHHANG dc)
        {
            try
            {
                MyDBContext context = new MyDBContext();
                context.KHACHHANGs.Add(dc);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        [Route("updateKhachHang")]
        public bool SuaKhachHang(KHACHHANG dc)
        {
            try
            {
                MyDBContext context = new MyDBContext();
                KHACHHANG DC = context.KHACHHANGs.Find(dc.MaKH);
                if (DC == null) return false;
                DC.HoTen = dc.HoTen;
                DC.SDT = dc.SDT;
                DC.Email = dc.Email;
                DC.MatKhau = dc.MatKhau;
                DC.Diachi = dc.Diachi;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpDelete]
        [Route("delKhachHang/{id}")]
        public bool DelKhachHang(int id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                var dc = context.KHACHHANGs.Find(id);
                if (dc == null)
                    return false;
                else
                {
                    context.KHACHHANGs.Remove(dc);
                    context.SaveChanges();
                    return true;
                }

            }
        }

    }
}