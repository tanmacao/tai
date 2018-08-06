﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Connet_ADO_DATA;

namespace WebsiteMau.DataCs
{
    public class DanhMuc
    {

        #region Phương thức xóa danh mục theo mã danh mục truyền vào
        /// <summary>
        /// Phương thức xóa danh mục theo mã danh mục truyền vào
        /// </summary>
        /// <param name="madm"></param>
        public static void Danhmuc_Delete(string madm)
        {
            SqlCommand cmd = new SqlCommand("danhmuc_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", madm);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới danh mục vào bảng danh mục
        /// <summary>
        /// Phương thức thêm mới danh mục vào bảng danh mục
        /// </summary>
        /// <param name="tendm"></param>
        /// <param name="anhdaidien"></param>
        /// <param name="thutu"></param>
        /// <param name="maDMcha"></param>
        /// <param name="ret"></param>
        public static void Danhmuc_Inser(string tendm, string anhdaidien, string thutu, string maDMcha, string ret)
        {
            SqlCommand cmd = new SqlCommand("danhmuc_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendm", tendm);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@maDMcha", maDMcha);
            cmd.Parameters.AddWithValue("@ret", ret);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một danh mục
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một danh mục
        /// </summary>
        /// <param name="madm"></param>
        /// <param name="tendm"></param>
        /// <param name="anhdaidien"></param>
        /// <param name="thutu"></param>
        /// <param name="maDMcha"></param>
        public static void Danhmuc_Update(string madm, string tendm, string anhdaidien, string thutu, string maDMcha)
        {
            SqlCommand cmd = new SqlCommand("danhmuc_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", madm);
            cmd.Parameters.AddWithValue("@tendm", tendm);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@maDMcha", maDMcha);
            Database.ExcuteNonQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả danh mục
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả danh mục
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Danhmuc()
        {
            SqlCommand cmd = new SqlCommand("thongtin_danhmuc");
            cmd.CommandType = CommandType.StoredProcedure;
            return Database.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin danh mục theo id danh mục
        /// <summary>
        /// Phương thức lấy ra thông tin danh mục theo id danh mục
        /// <para name="MaDM">Mã của danh mục cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Danhmuc_by_id(string MaDM)
        {
            SqlCommand cmd = new SqlCommand("thongtin_danhmuc_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMD", MaDM);
            return Database.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin danh mục theo id danh mục cha
        /// <summary>
        /// Phương thức lấy ra thông tin danh mục theo id danh mục cha
        /// <para name="MaDMCha">Mã danh mục cha cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Danhmuc_by_MaDMCha(string MaDMCha)
        {
            SqlCommand cmd = new SqlCommand("thongtin_danhmuc_by_MaDMCha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDMCha", MaDMCha);
            return Database.GetData(cmd);
        }
        #endregion
    }
}