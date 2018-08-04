using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteMau.cms.admin
{
    public partial class AdminControl1 : System.Web.UI.UserControl
    {
       private string modul = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];
            switch (modul)
            {
                case "sp":
                    plLoad.Controls.Add(LoadControl("SanPham/SanPhamControl.ascx"));
                    break;
                case "tk":
                    plLoad.Controls.Add(LoadControl("TaiKhoan/TaiKhoanControl.ascx"));
                    break;
            }
        }
    }
}