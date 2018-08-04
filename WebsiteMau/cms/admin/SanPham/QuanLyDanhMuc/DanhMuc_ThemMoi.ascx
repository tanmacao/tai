<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhMuc_ThemMoi.ascx.cs" Inherits="WebsiteMau.cms.admin.SanPham.QuanLyDanhMuc.DanhMuc_ThemMoi" %>
<div class="head">
    Thêm mới danh mục sản phẩm 
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongtin">
        <div class="tentruong">Danh mục cha</div>
        <div class="toolbox">
            <asp:DropDownList ID="ddlDanhMucCha" runat="server"></asp:DropDownList>
        </div>
    </div>
     <div class="thongtin">
        <div class="tentruong">Tên danh mục</div>
        <div class="toolbox">
            <asp:TextBox ID="txtTenDanhMuc" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"  ControlToValidate="txtTenDanhMuc" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>        
    </div>
     <div class="thongtin">
        <div class="tentruong">Ảnh đại diện</div>
        <div class="toolbox">
            <asp:FileUpload ID="flAnhDaiDien" runat="server"></asp:FileUpload>
        </div>
    </div>
     <div class="thongtin">
        <div class="tentruong">Thứ tự</div>
        <div class="toolbox">
            <asp:TextBox ID="txtThuTu" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Thứ tự phải nhập kiểu số" ControlToValidate="txtThuTu" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" ForeColor="Red"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="thongtin">
        <div class="tentruong">&nbsp;</div>
        <div class="toolbox">
            <asp:CheckBox ID="cbThemNhieuDanhMuc" runat="server" Text="Tiếp tục tạo danh mục khác sau khi tạo danh mục này"></asp:CheckBox>
        </div>
    </div>
    <div class="thongtin">
        <div class="tentruong">&nbsp;</div>
        <div class="toolbox">
            <asp:Button ID="btnThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btnThemMoi_Click" />
            <asp:Button ID="btnHuy" runat="server" Text="Hủy" CssClass="btHuy" OnClick="btnHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>
