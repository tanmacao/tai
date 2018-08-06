using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebsiteMau.DataCs;

namespace WebsiteMau.cms.admin.SanPham.QuanLyDanhMuc
{
    public partial class DanhMuc_ThemMoi : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {       
            if (!IsPostBack)
            {
                LayDanhMucCha();
            }
        }
      
        private void LayDanhMucCha()
        {
            
            DataTable dt = new DataTable();
            dt = DanhMuc.Thongtin_Danhmuc(); 
            ddlDanhMucCha.Items.Clear();
            ddlDanhMucCha.Items.Add(new ListItem("Danh mục gốc", "0"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlDanhMucCha.Items.Add(new ListItem(dt.Rows[i]["TenDM"].ToString(), dt.Rows[i]["MaDM"].ToString()));
            }
        }

        protected void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (flAnhDaiDien.FileContent.Length > 0)//kiểm tra có file ảnh hay không
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/AnhSanPham/")+ flAnhDaiDien.FileName);
                }
            }
           DanhMuc.Danhmuc_Inser(txtTenDanhMuc.Text, flAnhDaiDien.FileName, txtThuTu.Text, ddlDanhMucCha.SelectedValue, "");

            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong'>Đã tạo danh mục >>" + txtTenDanhMuc.Text+"</div>";

            if(cbThemNhieuDanhMuc.Checked)
            {
                //viết code sử lý xóa danh sách text đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }
            else
            {
                //đẩy trang về trang danh sách các danh mục đã tạo
                Response.Redirect("/Admin.aspx?modul=sp&modulphu=qldm");
            }
        }

        private void ResetControl()
        {
            txtTenDanhMuc.Text = "";
            txtThuTu.Text = "";
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}









