<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhMucControl.ascx.cs" Inherits="WebsiteMau.cms.admin.SanPham.QuanLyDanhMuc.DanhMucControl" %>
<%@ Register Src="~/cms/admin/SanPham/QuanLyDanhMuc/DanhMuc_ThemMoi.ascx" TagPrefix="uc1" TagName="DanhMuc_ThemMoi" %>

<asp:PlaceHolder ID="plLoad" runat="server"></asp:PlaceHolder>
<uc1:DanhMuc_ThemMoi runat="server" ID="DanhMuc_ThemMoi" />
