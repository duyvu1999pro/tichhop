﻿using System;
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
    [RoutePrefix("api/danhmuc")]
    public class DanhMucController : ApiController
    {

        WebService1 service = new WebService1();
     
        [HttpGet]
        [Route("getData")]
        public IHttpActionResult GetData()
        {
            DataTable data = new DataTable();
            SqlCommand cmd = new SqlCommand("select *from DANHMUC");
            if (!ModelState.IsValid)
                return BadRequest();
            service.pushDataTable(cmd, data);
            return Json(data);
        }
        //lấy tất cả danh mục
        // GET: api/danhmuc
        [HttpGet]
        [Route("getlistdanhmuc")]
        public IEnumerable<DANHMUC> GetListsDanhMuc()
        {
            using (MyDBContext context = new MyDBContext())
            {
                return context.DANHMUCs.ToList();
            }
        }

        //lấy theo mã danh muc
        [HttpGet]
        [Route("getdanhmuc/{id}")]
        public DANHMUC GetDanhMuc(int id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                return context.DANHMUCs.Find(id);
            }
        }

        [HttpPost]
        [Route("adddanhmuc")]
        public bool ThemDanhMuc(DANHMUC danhmuc)
        {
            try
            {
                MyDBContext context = new MyDBContext();
                context.DANHMUCs.Add(danhmuc);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        [Route("updatedanhmuc")]
        public bool SuaDanhMuc(DANHMUC danhmuc)
        {
            try
            {
                MyDBContext context = new MyDBContext();
                DANHMUC DM = context.DANHMUCs.Find(danhmuc.MaDM);
                if (DM == null)
                    return false;
                else
                {
                    DM.TenDM = danhmuc.TenDM;
                    DM.GhiChu = danhmuc.GhiChu;
                }
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpDelete]
        [Route("deldanhmuc/{id}")]
        public bool DelDanhMuc(int id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                var dm = context.DANHMUCs.Find(id);
                if (dm == null)
                    return false;
                else
                {
                    var temp = context.SANPHAMs.Where(X => X.MaDM == id).ToList();
                    foreach (var it in temp)
                    {
                        it.MaDM = null;
                    }
                    context.DANHMUCs.Remove(dm);
                    context.SaveChanges();
                    return true;
                }

            }
        }
    }
}