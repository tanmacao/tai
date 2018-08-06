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
    public partial class DanhMuc_HienThi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LayDanhMuc();
            }
        }

        private void LayDanhMuc()
        {
            DataTable dt = new DataTable();
            dt = DanhMuc.Thongtin_Danhmuc();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrDanhMuc.Text += @" 
            <tr>
            <td class='cotMa1'>"+dt.Rows[i]["MaDM"]+ @"</td>
            <td class='cotTen1'>" + dt.Rows[i]["TenDM"] + @"</td>
            <td class='cotAnh1'>
                    <img class='anhDaiDien' src=/pic/AnhSanPham/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                    <img class='anhDaiDienHover' src=/pic/AnhSanPham/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                </td>
            <td class='cotThuTu1'>" + dt.Rows[i]["ThuTu"] + @"</td>
            <td class='cotCongCu1'>
                <a href='#' class='dmcon' title='Xem danh mục con'></a>
                <a href='#' class='sua' title='sửa'></a>
                <a href='#' class='xoa' title='xóa'></a>
            </td>
        </tr>
";
            }
        }
    }
}