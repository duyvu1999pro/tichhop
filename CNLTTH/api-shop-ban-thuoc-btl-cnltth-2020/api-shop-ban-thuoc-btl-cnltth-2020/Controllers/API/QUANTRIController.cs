using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;
using api_shop_ban_thuoc_btl_cnltth_2020.Models;

namespace api_shop_ban_thuoc_btl_cnltth_2020.Controllers.API
{
    [RoutePrefix("api/quantri")]
    public class QUANTRIController : ApiController
    {
        private MyDBContext context = new MyDBContext();
        // GET: QUANTRI
        [HttpPost]
        [Route("check")]
        public IHttpActionResult Check(QUANTRI account)
        {
            QUANTRI model = null;          
            model = context.QUANTRIs.Where(X => X.SDT == account.SDT && X.MatKhau == account.MatKhau).FirstOrDefault();
            if (model != null)                        
                    return Ok(model.HoTen.ToString());             
            else            
                return NotFound(); 
        }

       
        
    }
}