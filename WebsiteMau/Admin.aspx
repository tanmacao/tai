<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebsiteMau.Admin" %>

<%@ Register Src="~/cms/admin/AdminControl1.ascx" TagPrefix="uc1" TagName="AdminControl1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/cssAdmin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--Header-->
            <div id="header">
                <div class="container">
                <div class="logo">Chèn Logo ơ đây</div>
                <div class="accountMenu">Thông tin tài khoản</div>

            </div>
                </div>

            <!--Menu chính-->
            <div class="MenuChinh">
                <div class="container">
                <ul>
                    <li><a href="/Admin.aspx" title="Trang chủ">Trang chủ</a></li>
                    <li><a href="/Admin.aspx?modul=sp" title="San phẩm">Sản phẩm</a></li>
                    <li><a href="/Admin.aspx?modul=tk" title="Tài khoản">Tài khoản</a></li>
                </ul>
                    </div>
            </div>
            
                       <%--phần nội dung trang--%>
            <uc1:AdminControl1 runat="server" ID="AdminControl1" />
        </div>
    </form>
</body>
</html>
