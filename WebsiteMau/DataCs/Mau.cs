﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Connet_ADO_DATA;

namespace WebsiteMau.DataCs
{
    public class Mau
    {
        #region Phương thức xóa Mau
        /// <summary>
        /// Phương thức xóa Mau
        /// </summary>
        /// <param name="mauid"></param>
        public static void Mau_Delete(string mauid)
        {
            SqlCommand cmd = new SqlCommand("mau_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mauid", mauid);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Màu vào bảng Màu
        /// <summary>
        /// Phương thức thêm mới Màu vào bảng Màu
        /// </summary>
        /// <param name="tenmau"></param>
        /// <param name="ret"></param>

        public static void Mau_Inser(string tenmau, string ret)
        {
            SqlCommand cmd = new SqlCommand("mau_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenmau", tenmau);
            cmd.Parameters.AddWithValue("@ret", ret);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Màu
        /// <summary>
        ///  Phương thức chỉnh sửa thông tin một Màu
        /// </summary>
        /// <param name="mauid"></param>
        /// <param name="tenmau"></param>

        public static void Mau_Update(string mauid, string tenmau)
        {
            SqlCommand cmd = new SqlCommand("mau_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mauid", mauid);
            cmd.Parameters.AddWithValue("@tenmau", tenmau);
            Database.ExcuteNonQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả Màu
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Màu
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Mau()
        {
            SqlCommand cmd = new SqlCommand("thongtin_mau");
            cmd.CommandType = CommandType.StoredProcedure;
            return Database.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin màu theo id màu
        /// <summary>
        /// Phương thức lấy ra thông tin màu theo id màu
        /// <para name="MauID">Mã của màu cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Mau_by_id(string MauID)
        {
            SqlCommand cmd = new SqlCommand("thongtin_mau_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MauID", MauID);
            return Database.GetData(cmd);
        }
        #endregion
    }
}