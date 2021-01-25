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

        //================================= Get =================================\\
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

        [Route("api/ServiceController/getSoDuKH")]
        [HttpGet]
        public IHttpActionResult getSoDuKH(string TenDN)
        {
            var param = new Dictionary<string, object>() {
                { "TenDN", TenDN }
            };
            DataTable kq = Database.Read_Table_SP("SP_GetKhachHangTheoTenDN", param);
            if (kq != null && kq.Rows.Count >= 1)
                return Ok(kq.Rows[0][6]);
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
        public IHttpActionResult getHoaDonTheoKH(string MaKH)
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

        [Route("api/ServiceController/getHoaDonDaTTTheoKH")]
        [HttpGet]
        public IHttpActionResult getHoaDonDaTTTheoKH(string MaKH)
        {
            var param = new Dictionary<string, object>() {
                { "MaKH", MaKH }
            };
            DataTable kq = Database.Read_Table_SP("SP_GetDHDaTTTheoKH", param);
            if (kq != null && kq.Rows.Count >= 0)
                return Ok(kq);
            else
                return NotFound();
        }

        [Route("api/ServiceController/getHoaDonChuaTTTheoKH")]
        [HttpGet]
        public IHttpActionResult getHoaDonChuaTTTheoKH(string MaKH)
        {
            var param = new Dictionary<string, object>() {
                { "MaKH", MaKH }
            };
            DataTable kq = Database.Read_Table_SP("SP_GetDHChuaTTTheoKH", param);
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
        public IHttpActionResult getYeuThichTheoKH(string MaKH)
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


        [Route("api/ServiceController/getMonAnTheoTuKhoa")]
        [HttpGet]
        public IHttpActionResult getMonAnTheoTuKhoa(string Keyword)
        {
            Keyword = "%" + Keyword + "%";
            var param = new Dictionary<string, object>() {
                { "Keyword", Keyword }
            };
            DataTable kq = Database.Read_Table_SP("SP_SearchMonAn", param);
            if (kq != null && kq.Rows.Count >= 0)
                return Ok(kq);
            else
                return NotFound();
        }

        [Route("api/ServiceController/getMonGiamGia")]
        [HttpGet]
        public IHttpActionResult getMonGiamGia()
        {
            DataTable kq = Database.Read_Table_SP("SP_GetMonGiamGia");
            if (kq != null && kq.Rows.Count >= 0)
                return Ok(kq);
            else
                return NotFound();
        }

        [Route("api/ServiceController/getMonMuaNhieu")]
        [HttpGet]
        public IHttpActionResult getMonMuaNhieu()
        {
            DataTable kq = Database.Read_Table_SP("SP_GetMonMuaNhieu");
            if (kq != null && kq.Rows.Count >= 0)
                return Ok(kq);
            else
                return NotFound();
        }

        [Route("api/ServiceController/getMonMoi")]
        [HttpGet]
        public IHttpActionResult getMonMoi()
        {
            DataTable kq = Database.Read_Table_SP("SP_GetMonMoi");
            if (kq != null && kq.Rows.Count >= 0)
                return Ok(kq);
            else
                return NotFound();
        }
        //================================= Check =================================\\
        [Route("api/ServiceController/checkDangNhap")]
        [HttpGet]
        public IHttpActionResult checkDangNhap(string TenDN, string MatKhau)
        {
            var param = new Dictionary<string, object>() {
                { "TenDN", TenDN }
            };
            DataTable kq = Database.Read_Table_SP("SP_GetKhachHangTheoTenDN", param);
            if (kq != null && kq.Rows.Count > 0 && kq.Rows[0][1].ToString()==MatKhau)
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
            DataTable kq = Database.Read_Table_SP("SP_GetKhachHangTheoTenDN", param);
            if (kq == null || kq.Rows.Count == 0)
                return Ok(false);
            else
                return Ok(true);
        }

        //================================= Create =================================\\
        [Route("api/ServiceController/createKhachHang")]
        [HttpGet]
        public IHttpActionResult createKhachHang(
            string MaKH,
            string MatKhau,
            string HoTen,
            string Email,
            string DiaChi,
            string Sdt)
        {
            var param = new Dictionary<string, object>() {
                { "MaKH", MaKH },
                { "MatKhau", MatKhau },
                { "HoTen", HoTen },
                { "Email", Email },
                { "DiaChi", DiaChi },
                { "Sdt", Sdt },
            };
            DataTable kq = Database.Read_Table_SP("SP_CreateKhachHang", param);
            if (kq != null)
                return Ok(true);
            else
                return NotFound();
        }

        [Route("api/ServiceController/createHoaDon")]
        [HttpGet]
        public IHttpActionResult createHoaDon(string MaKH)
        {
            var param = new Dictionary<string, object>() {
                { "MaKH", MaKH },
            };
            DataTable kq = Database.Read_Table_SP("SP_CreateHoaDon", param);
            if (kq != null)
                return Ok(kq);
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
            string MaKH,
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

        //================================= Update =================================\\
        [Route("api/ServiceController/updateTrangThaiHD")]
        [HttpGet]
        public IHttpActionResult updateTrangThaiHD(
            int MaHD,
            int TrangThai)
        {
            var param = new Dictionary<string, object>() {
                { "MaHD", MaHD },
                { "TrangThai", TrangThai },
            };
            DataTable kq = Database.Read_Table_SP("SP_UpdateTrangThaiHD", param);
            if (kq != null)
                return Ok(true);
            else
                return NotFound();
        }

        [Route("api/ServiceController/updateCTHD")]
        [HttpGet]
        public IHttpActionResult updateCTHD(int MaHD, int MaMA, int SoLuong)
        {
            var param = new Dictionary<string, object>() {
                { "MaHD", MaHD },
                { "MaMA", MaMA },
                { "SoLuong", SoLuong },
            };
            DataTable kq = Database.Read_Table_SP("SP_UpdateCTHD", param);
            if (kq != null)
                return Ok(true);
            else
                return NotFound();
        }

        [Route("api/ServiceController/updateSoDuKH")]
        [HttpGet]
        public IHttpActionResult updateSoDuKH(string MaKH, decimal SoDuNew)
        {
            var param = new Dictionary<string, object>() {
                { "MaKH", MaKH },
                { "SoDuNew", SoDuNew },
            };
            DataTable kq = Database.Read_Table_SP("SP_UpdateSoDuKH", param);
            if (kq != null)
                return Ok(true);
            else
                return NotFound();
        }

        //================================= Delete =================================\\
        [Route("api/ServiceController/deleteCTHD")]
        [HttpGet]
        public IHttpActionResult deleteCTHD(int MaHD, int MaMA)
        {
            var param = new Dictionary<string, object>() {
                { "MaHD", MaHD },
                { "MaMA", MaMA },
            };
            DataTable kq = Database.Read_Table_SP("SP_DeleteCTHD", param);
            if (kq != null)
                return Ok(true);
            else
                return NotFound();
        }
    }
}
