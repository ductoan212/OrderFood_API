using OrderFood_API.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderFood_API.Controllers
{
    public class ServiceController : ApiController
    {
        [Route("api/ServiceController/DemoAPI")]
        [HttpGet]
        public IHttpActionResult DemoAPI(string name)
        {
            return Ok("Xin chao " + name);
        }

        [Route("api/ServiceController/getKhachHang")]
        [HttpGet]
        public IHttpActionResult getKhachHang()
        {
            DataTable kq = Database.Read_Table("KHACHHANG");
            if (kq != null && kq.Rows.Count > 0)
                return Ok(kq);
            else
                return NotFound();
        }

        [Route("api/ServiceController/getLoaiMon")]
        [HttpGet]
        public IHttpActionResult getLoaiMon()
        {
            DataTable kq = Database.Read_Table("LOAIMON");
            if (kq != null && kq.Rows.Count >= 0)
                return Ok(kq);
            else
                return NotFound();
        }

        [Route("api/ServiceController/getMonAn")]
        [HttpGet]
        public IHttpActionResult getMonAn()
        {
            DataTable kq = Database.Read_Table("MONAN");
            if (kq != null && kq.Rows.Count >= 0)
                return Ok(kq);
            else
                return NotFound();
        }

        [Route("api/ServiceController/getMonAnTheoLoai")]
        [HttpGet]
        public IHttpActionResult getMonAnTheoLoai(int MaLM)
        {
            var param = new Dictionary<string, object>() {
                { "MaLM", MaLM }
            };
            DataTable kq = Database.Read_Table_SP("SP_GetMonTheoLoai", param);
            if (kq != null && kq.Rows.Count >= 0)
                return Ok(kq);
            else
                return NotFound();
        }
    }
}
