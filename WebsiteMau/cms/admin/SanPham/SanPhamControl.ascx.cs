using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteMau.cms.admin.SanPham
{
    public partial class SanPhamControl : System.Web.UI.UserControl
    {
        string modulphu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modulphu"] != null)
                modulphu = Request.QueryString["modulphu"];

            switch (modulphu)
            {
                case "qldm":
                    plLaod.Controls.Add(LoadControl("QuanLyDanhMuc/DanhMucControl.ascx"));
                    break;
                case "qlm":
                    plLaod.Controls.Add(LoadControl("QuanLyMau/MauControl.ascx"));
                    break;
                case "qlcl":
                    plLaod.Controls.Add(LoadControl("QuanLyChatLieu/ChatLieuControl.ascx"));
                    break;
                case "qlsp":
                    plLaod.Controls.Add(LoadControl("QuanLySanPham/SanPhamLaodControl.ascx"));
                    break;
                case "qlnsp":
                    plLaod.Controls.Add(LoadControl("QuanLyNhomSanPham/NhomSanPhamControl.ascx"));
                    break;
                case "qls":
                    plLaod.Controls.Add(LoadControl("QuanLySize/SizeControl.ascx"));
                    break;
                case "pdg":
                    plLaod.Controls.Add(LoadControl("DonHangControl/PhienDauGiaControl.ascx"));
                    break;
                case "qldh":
                    plLaod.Controls.Add(LoadControl("DonHang/DonHangControl.ascx"));
                    break;
                default:
                    plLaod.Controls.Add(LoadControl("QuanLySanPham/SanPhamLaodControl.ascx"));
                    break;

            }
        }

        protected string DanhDau(string tenModul, string tenModulPhu, string tenThaoTac)
        {
            string s = "";

            /*Lấy giá trị querystring modul, modulphu, thaotac*/
            string modul = "";
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];

            string modulphu = "";
            if (Request.QueryString["modulphu"] != null)
                modulphu = Request.QueryString["modulphu"];

            string thaotac = "";
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];

            /*So sánh nếu querystring bằng tên modul, modulphu, thaotac truyền vào thì trả về current --> đánh dấu là menu hiện tại*/
            if (modul == tenModul && modulphu == tenModulPhu && thaotac == tenThaoTac)
                s = "current";
            return s;
        }
    }
}