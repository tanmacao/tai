﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Connet_ADO_DATA;



namespace WebsiteData
{
    /// <summary>
    /// Summary description for DangKy
    /// </summary>
    public class DangKy
    {
        #region Phương thức xóa tài khoản theo tên đăng nhập truyền vào
        /// <summary>
        ///  Phương thức xóa tài khoản theo tên đăng nhập truyền vào
        /// </summary>
        /// <param name="tendangnhap"></param>
        public static void Dangky_Delete(string tendangnhap)
        {
            SqlCommand cmd = new SqlCommand("dangky_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới tài khoản vào bảng đăng ký
        /// <summary>
        /// Phương thức thêm mới tài khoản vào bảng đăng ký
        /// </summary>
        /// <param name="tendangnhap"></param>
        /// <param name="matkhau"></param>
        /// <param name="emaildk"></param>
        /// <param name="diachidk"></param>
        /// <param name="tendaydu"></param>
        /// <param name="cauhoibaomat"></param>
        /// <param name="ngaysinh"></param>
        /// <param name="gioitinhdk"></param>
        /// <param name="maquyen"></param>
        /// <param name="ret"></param>
        public static void Dangky_Inser(string tendangnhap,string matkhau,string emaildk,string diachidk,string tendaydu,string cauhoibaomat,string ngaysinh,string gioitinhdk,string maquyen, string ret)
        {
            SqlCommand cmd = new SqlCommand("dangky_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Parameters.AddWithValue("@emaildk", emaildk);
            cmd.Parameters.AddWithValue("@diachidk", diachidk);
            cmd.Parameters.AddWithValue("@tendaydu", tendaydu);

            cmd.Parameters.AddWithValue("@cauhoibaomat", cauhoibaomat);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinhdk", gioitinhdk);
            cmd.Parameters.AddWithValue("@maquyen", maquyen);
            cmd.Parameters.AddWithValue("@ret", ret);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một tài khoản đăng ký
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một tài khoản đăng ký
        /// </summary>
        /// <param name="tendangnhap"></param>
        /// <param name="matkhau"></param>
        /// <param name="emaildk"></param>
        /// <param name="diachidk"></param>
        /// <param name="tendaydu"></param>
        /// <param name="cauhoibaomat"></param>
        /// <param name="ngaysinh"></param>
        /// <param name="gioitinhdk"></param>
        /// <param name="maquyen"></param>
        public static void Dangky_Update(string tendangnhap, string matkhau, string emaildk, string diachidk, string tendaydu, string cauhoibaomat, string ngaysinh, string gioitinhdk, string maquyen)
        {
            SqlCommand cmd = new SqlCommand("dangky_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Parameters.AddWithValue("@emaildk", emaildk);
            cmd.Parameters.AddWithValue("@diachidk", diachidk);
            cmd.Parameters.AddWithValue("@tendaydu", tendaydu);

            cmd.Parameters.AddWithValue("@cauhoibaomat", cauhoibaomat);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinhdk", gioitinhdk);
            cmd.Parameters.AddWithValue("@maquyen", maquyen);
            Database.ExcuteNonQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả tài khoản đăng ký
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả tài khoản đăng ký
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Dangky()
        {
            SqlCommand cmd = new SqlCommand("thongtin_dangky");
            cmd.CommandType = CommandType.StoredProcedure;
            return Database.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin tìa khoản theo tên đăng nhập
        /// <summary>
        /// Phương thức lấy ra thông tin tìa khoản theo tên đăng nhập
        /// <para name="TenDangNhap">Tên đăng nhập của tài khoản cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_DangKy_by_id(string TenDangNhap)
        {
            SqlCommand cmd = new SqlCommand("thongtin_dangky_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            return Database.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin tài khoản theo tên đăng nhập và mật khẩu
        /// <summary>
        /// Phương thức lấy ra thông tin tài khoản theo tên đăng nhập và mật khẩu
        /// </summary>
        /// <param name="TenDangNhap"></param>
        /// <param name="MatKhau"></param>
        /// <returns></returns>
        public static DataTable Thongtin_DangKy_by_id_matkhau(string TenDangNhap, string MatKhau)
        {
            SqlCommand cmd = new SqlCommand("thongtin_dangky_by_id_matkhau");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            return Database.GetData(cmd);
        }
        #endregion
    }
}

