<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhMuc_HienThi.ascx.cs" Inherits="WebsiteMau.cms.admin.SanPham.QuanLyDanhMuc.DanhMuc_HienThi" %>
<div class="head">
    Danh mục sản phâm đã tạo
</div>
<div class="KhungChuaBan">
    <table class="tbDanhMuc">
        <tr>
            <th class="cotMa">Mã</th>
            <th class="cotTen">Tên danh mục</th>
            <th class="cotAnh">Ảnh đại diện</th>
            <th class="cotThuTu">thứ tự</th>
            <th class="cotCongCu">Công cụ</th>
        </tr>
        <asp:Literal ID="ltrDanhMuc" runat="server"></asp:Literal>
        
      
    </table>
</div>