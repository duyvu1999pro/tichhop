using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using api_shop_ban_thuoc_btl_cnltth_2020.Models;
namespace api_shop_ban_thuoc_btl_cnltth_2020.Controllers.API
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        //lấy tất cả thuốc
        // GET: api/Thuoc
        [HttpGet]
        [Route("getlistthuoc")]
        public IEnumerable<SANPHAM> GetThuocLists()
        {
            using (MyDBContext context = new MyDBContext())
            {
                //return context.SANPHAMs.Where(X => X.TenSP != null).ToList();
                return context.SANPHAMs.ToList();
            }
        }

        //lấy sản phẩm theo mã
        [HttpGet]
        [Route("getProductbyID/{id}")]
        public SANPHAM getProductbyID(string id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                return context.SANPHAMs.Where(X => X.MaSP == id).FirstOrDefault();
            }
        }

        //lấy danh sách theo mã danh mục
        [HttpGet]
        [Route("getProductbyIDcategory/{id}")]
        public IEnumerable<SANPHAM> getProductbyIDcategory(int id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                return context.SANPHAMs.Where(X => X.MaDM == id).ToList();
            }
        }

        //lấy danh sách sản phẩm theo mã danh mục ngoại trừ sản phẩm
        [HttpGet]
        [Route("getProductCategoryExceptID/{mathuoc}")]
        public IEnumerable<SANPHAM> getProductCategoryExceptID(String mathuoc)
        {
            using (MyDBContext context = new MyDBContext())
            {
                SANPHAM sp = context.SANPHAMs.Find(mathuoc); // lấy sản phẩm có id.
                int madm =(int) sp.MaDM;
                return context.SANPHAMs.Where(X => X.MaSP != mathuoc && X.MaDM == madm).ToList();
            }
        }



        //tìm thuốc theo tên & công dụng
        [HttpGet]
        [Route("searchthuoc")]
        public IEnumerable<SANPHAM> searchthuoc(String search)
        {
            using (MyDBContext context = new MyDBContext())
            {
                return context.SANPHAMs.Where(X => X.TenSP.Contains(search) || X.CongDung.Contains(search)).ToList();
            }
        }

        [HttpPost]
        [Route("addthuoc")]
        public bool ThemThuoc(SANPHAM thuoc)
        {
            try
            {
                MyDBContext context = new MyDBContext();
                context.SANPHAMs.Add(thuoc);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /*[HttpPut] // bỏ
        [Route("updateSLT/{id}/{sl}")]
        public bool SuaSLThuoc(string id, int sl)
        {
            try
            {
                MyDBContext context = new MyDBContext();
                SANPHAM Thuoc = context.SANPHAMs.Find(id);
                if (Thuoc == null) return false;
                Thuoc.SoLuongTon = Thuoc.SoLuongTon - sl;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }*/

        [HttpPut]
        [Route("updatethuoc")]
        public bool SuaThuoc(SANPHAM thuoc)
        {
            try
            {
                MyDBContext context = new MyDBContext();
                SANPHAM Thuoc = context.SANPHAMs.Find(thuoc.MaSP);
                if (Thuoc == null) return false;
                Thuoc.TenSP = thuoc.TenSP;
                Thuoc.ThanhPhan = thuoc.ThanhPhan;
                //Thuoc.SoLuongTon = thuoc.SoLuongTon;
                Thuoc.MaDM = thuoc.MaDM;
                Thuoc.LieuLuong = thuoc.LieuLuong;
                Thuoc.HinhAnh = thuoc.HinhAnh;
                Thuoc.MoTa = thuoc.MoTa;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpDelete]
        [Route("delthuoc/{id}")]
        public bool DeleteThuoc(string id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                var thuoc = context.SANPHAMs.Find(id);
                if (thuoc == null)
                    return false;
                else
                    context.SANPHAMs.Remove(thuoc);
                context.SaveChanges();
                return true;
            }
        }

      

      
    }
}