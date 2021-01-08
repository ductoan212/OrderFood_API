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
        [Route("api/ServiceController/getKhachHangTheoTenDN")]
        [HttpGet]
        public IHttpActionResult getKhachHangTheoTenDN(string TenDN)
        {
            var param = new Dictionary<string, object>() {
                { "TenDN", TenDN }
            };
            DataTable kq = Database.Read_Table_SP("SP_GetKhachHangTheoTenDN", param);
            if (kq != null && kq.Rows.Count >= 0)
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

        [Route("api/ServiceController/getHoaDonTheoKH")]
        [HttpGet]
        public IHttpActionResult getHoaDonTheoKH(int MaKH)
        {
            var param = new Dictionary<string, object>() {
                { "MaKH", MaKH }
            };
            DataTable kq = Database.Read_Table_SP("SP_GetHoaDonTheoKH", param);
            if (kq != null && kq.Rows.Count >= 0)
                return Ok(kq);
            else
                return NotFound();
        }

        [Route("api/ServiceController/getCTHDTheoHD")]
        [HttpGet]
        public IHttpActionResult getCTHDTheoHD(int MaHD)
        {
            var param = new Dictionary<string, object>() {
                { "MaHD", MaHD }
            };
            DataTable kq = Database.Read_Table_SP("SP_GetCTHDTheoHD", param);
            if (kq != null && kq.Rows.Count >= 0)
                return Ok(kq);
            else
                return NotFound();
        }

        [Route("api/ServiceController/getYeuThichTheoKH")]
        [HttpGet]
        public IHttpActionResult getYeuThichTheoKH(int MaKH)
        {
            var param = new Dictionary<string, object>() {
                { "MaKH", MaKH }
            };
            DataTable kq = Database.Read_Table_SP("SP_GetYeuThichTheoKH", param);
            if (kq != null && kq.Rows.Count >= 0)
                return Ok(kq);
            else
                return NotFound();
        }

        [Route("api/ServiceController/checkDangNhap")]
        [HttpGet]
        public IHttpActionResult checkDangNhap(string TenDN, string MatKhau)
        {
            var param = new Dictionary<string, object>() {
                { "TenDN", TenDN },
                { "MatKhau", MatKhau }
            };
            DataTable kq = Database.Read_Table_SP("SP_CheckDangNhap", param);
            if (kq != null && kq.Rows.Count > 0)
                return Ok(true);
            else
                return Ok(false);
        }

        [Route("api/ServiceController/checkTenDNTonTai")]
        [HttpGet]
        public IHttpActionResult checkTenDNTonTai(string TenDN)
        {
            var param = new Dictionary<string, object>() {
                { "TenDN", TenDN }
            };
            DataTable kq = Database.Read_Table_SP("SP_CheckTenDNTonTai", param);
            if (kq == null || kq.Rows.Count == 0)
                return Ok(false);
            else
                return Ok(true);
        }

        [Route("api/ServiceController/createKhachHang")]
        [HttpGet]
        public IHttpActionResult createKhachHang(
            string TenDN,
            string MatKhau,
            string HoTen,
            string Email,
            string DiaChi,
            int Tuoi,
            string Sdt,
            bool GioiTinh)
        {
            var param = new Dictionary<string, object>() {
                { "TenDN", TenDN },
                { "MatKhau", MatKhau },
                { "HoTen", HoTen },
                { "Email", Email },
                { "DiaChi", DiaChi },
                { "Tuoi", Tuoi },
                { "Sdt", Sdt },
                { "GioiTinh", GioiTinh },
            };
            DataTable kq = Database.Read_Table_SP("SP_CreateKhachHang", param);
            if (kq != null)
                return Ok(true);
            else
                return NotFound();
        }

        [Route("api/ServiceController/createHoaDon")]
        [HttpGet]
        public IHttpActionResult createHoaDon(
            int MaKH)
        {
            var param = new Dictionary<string, object>() {
                { "MaKH", MaKH },
            };
            DataTable kq = Database.Read_Table_SP("SP_CreateHoaDon", param);
            if (kq != null)
                return Ok(true);
            else
                return NotFound();
        }

        [Route("api/ServiceController/createCTHD")]
        [HttpGet]
        public IHttpActionResult createCTHD(
            int MaHD,
            int MaMA,
            int SoLuong)
        {
            var param = new Dictionary<string, object>() {
                { "MaHD", MaHD },
                { "MaMA", MaMA },
                { "SoLuong", SoLuong },
            };
            DataTable kq = Database.Read_Table_SP("SP_CreateCTHD", param);
            if (kq != null)
                return Ok(true);
            else
                return NotFound();
        }

        [Route("api/ServiceController/createYeuThich")]
        [HttpGet]
        public IHttpActionResult createYeuThich(
            int MaKH,
            int MaMA,
            string GhiChu)
        {
            var param = new Dictionary<string, object>() {
                { "MaKH", MaKH },
                { "MaMA", MaMA },
                { "GhiChu", GhiChu },
            };
            DataTable kq = Database.Read_Table_SP("SP_CreateYeuThich", param);
            if (kq != null)
                return Ok(true);
            else
                return NotFound();
        }

        [Route("api/ServiceController/updateTrangThaiHD")]
        [HttpGet]
        public IHttpActionResult updateTrangThaiHD(
            int MaHD)
        {
            var param = new Dictionary<string, object>() {
                { "MaHD", MaHD },
            };
            DataTable kq = Database.Read_Table_SP("SP_UpdateTrangThaiHD", param);
            if (kq != null)
                return Ok(true);
            else
                return NotFound();
        }
    }
}
