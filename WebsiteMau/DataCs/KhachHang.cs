﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Connet_ADO_DATA;

namespace WebsiteMau.DataCs
{
    public class KhachHang
    {
        #region Phương thức xóa Khachang theo mã Khachang truyền vào
        /// <summary>
        /// / Phương thức xóa Khachang theo mã Khachang truyền vào
        /// </summary>
        /// <param name="makh"></param>
        public static void Khachang_Delete(string makh)
        {
            SqlCommand cmd = new SqlCommand("khachang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Khachang vào Khachang
        /// <summary>
        /// Phương thức thêm mới Khachang vào Khachang
        /// </summary>
        /// <param name="tenkh"></param>
        /// <param name="diachikh"></param>
        /// <param name="sdtkh"></param>
        /// <param name="emailkh"></param>
        /// <param name="matkhau"></param>
        /// <param name="ret"></param>
        public static void Khachang_Inser(string tenkh, string diachikh, string sdtkh, string emailkh, string matkhau, string ret)
        {
            SqlCommand cmd = new SqlCommand("khachang_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@diachikh", diachikh);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Parameters.AddWithValue("@ret", ret);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một KhachHang
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một KhachHang
        /// </summary>
        /// <param name="makh"></param>
        /// <param name="tenkh"></param>
        /// <param name="diachikh"></param>
        /// <param name="sdtkh"></param>
        /// <param name="emailkh"></param>
        /// <param name="matkhau"></param>
        public static void Khachang_Update(string makh, string tenkh, string diachikh, string sdtkh, string emailkh, string matkhau)
        {
            SqlCommand cmd = new SqlCommand("khachang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@diachikh", diachikh);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            Database.ExcuteNonQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả KhachHang
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả KhachHang
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Khachhang()
        {
            SqlCommand cmd = new SqlCommand("thongtin_khachhang");
            cmd.CommandType = CommandType.StoredProcedure;
            return Database.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả KhachHang theo email
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả KhachHang
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Khachhang_by_emailkh(string emailkh)
        {
            SqlCommand cmd = new SqlCommand("thongtin_khachhang_by_emailkh");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            return Database.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả KhachHang theo mã KH
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả KhachHang
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Khachhang_by_makh(string makh)
        {
            SqlCommand cmd = new SqlCommand("thongtin_khachhang_by_makh");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);
            return Database.GetData(cmd);
        }
        #endregion


        #region Phương thức lấy ra danh sách tất cả KhachHang theo email và mật khẩu
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả KhachHang
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Khachhang_by_emailkh_matkhau(string emailkh, string matkhau)
        {
            SqlCommand cmd = new SqlCommand("thongtin_khachhang_by_emailkh_matkhau");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            return Database.GetData(cmd);
        }
        #endregion
    }
}