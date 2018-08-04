<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SanPhamControl.ascx.cs" Inherits="WebsiteMau.cms.admin.SanPham.SanPhamControl" %>
<div class="container">
    <div style="clear: both; height: 20px"></div>
    <div class="cotTrai">
        <div class="head">Quản lý</div>

        <ul>
            <li><a class="<%=DanhDau("SanPham","qldm","") %>" href="Admin.aspx?modul=sp&modulphu=qldm">Danh mục sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","qlsp","") %>" href="Admin.aspx?modul=sp&modulphu=qlsp">Danh sách sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","qlm","") %>" href="Admin.aspx?modul=sp&modulphu=qlm">Màu sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","qlcl","") %>" href="Admin.aspx?modul=sp&modulphu=qlcl">Chất liệu sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","qls","") %>" href="Admin.aspx?modul=sp&modulphu=qls">Size sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","qlnsp","") %>" href="Admin.aspx?modul=sp&modulphu=qlnsp">Nhóm sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","pdg","") %>" href="Admin.aspx?modul=sp&modulphu=pdg">Phiên đấu giá</a></li>
            <li><a class="<%=DanhDau("SanPham","qldh","") %>" href="Admin.aspx?modul=sp&modulphu=qldh">Đơn hàng</a></li>
        </ul>

        <div class="head">Thêm mới</div>

        <ul>
            <li><a class="<%=DanhDau("SanPham","qldm","ThemMoi") %>" href="Admin.aspx?modul=sp&modulphu=qldm&thaotac=TheMoi">Danh mục sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","qlsp","ThemMoi") %>" href="Admin.aspx?modul=sp&modulphu=qlsp&thaotac=TheMoi">Danh sách sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","qlm","ThemMoi") %>" href="Admin.aspx?modul=sp&modulphu=qlm&thaotac=TheMoi">Màu sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","qlcl","ThemMoi") %>" href="Admin.aspx?modul=sp&modulphu=qlcl&thaotac=TheMoi">Chất liệu sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","qls","ThemMoi") %>" href="Admin.aspx?modul=sp&modulphu=qls&thaotac=TheMoi">Size sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","qlnsp","ThemMoi") %>" href="Admin.aspx?modul=sp&modulphu=qlnsp&thaotac=TheMoi">Nhóm sản phẩm</a></li>
            <li><a class="<%=DanhDau("SanPham","pdg","ThemMoi") %>" href="Admin.aspx?modul=sp&modulphu=pdgp&thaotac=TheMoi">Phiên đấu giá</a></li>
        </ul>
    </div>    
    <div class="cotPhai">        
        <asp:PlaceHolder ID="plLaod" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>
</div>
