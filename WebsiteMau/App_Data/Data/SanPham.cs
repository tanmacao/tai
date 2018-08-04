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
    /// Class thực hiện truy vấn liên quan đế bảng SanPham
    /// </summary>
    public class SanPham
    {
#region Phương thức xóa sản phẩm theo mã sản phẩm truyền vào
		 /// <summary>
        /// Phương thức xóa sản phẩm theo mã sản phẩm truyền vào
        /// </summary>
        /// <param name="masp">mã sản phẩm cần xóa</param>
        public static void Sanpham_Delete(string masp)
        {
            SqlCommand cmd = new SqlCommand("sanpham_delete");
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            Database.ExcuteNonQuery(cmd);
        }
#endregion
        
#region Phương thức thêm mới sản phẩm vào bảng sản phẩm
		 /// <summary>
        /// Phương thức thêm mới sản phẩm vào bảng sản phẩm
        /// </summary>
        /// <param name="tensp"></param>
        /// <param name="mauID"></param>
        /// <param name="sizeID"></param>
        /// <param name="chatieuID"></param>
        /// <param name="anhsanpham"></param>
        /// <param name="soluongsp"></param>
        /// <param name="giasp"></param>
        /// <param name="motasp"></param>
        /// <param name="ngaytao"></param>
        /// <param name="ngayhuy"></param>
        /// <param name="maDM"></param>
        /// <param name="nhomID"></param>
        /// <param name="ret"></param>
        public static void Sanpham_Inser(string tensp,string mauID, string sizeID,string chatieuID,string anhsanpham,string soluongsp,string giasp,string motasp,string ngaytao,string ngayhuy,string maDM,string nhomID,string ret)
        {
            SqlCommand cmd = new SqlCommand("sanpham_inser");
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@mauID", mauID);
            cmd.Parameters.AddWithValue("@sizeID", sizeID);
            cmd.Parameters.AddWithValue("@chatieuID", chatieuID);
            cmd.Parameters.AddWithValue("@anhsanpham", anhsanpham);

            cmd.Parameters.AddWithValue("@soluongsp", soluongsp);
            cmd.Parameters.AddWithValue("@giasp", giasp);
            cmd.Parameters.AddWithValue("@motasp", motasp);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@ngayhuy", ngayhuy);

            cmd.Parameters.AddWithValue("@maDM", maDM);
            cmd.Parameters.AddWithValue("@nhomID", nhomID);
            cmd.Parameters.AddWithValue("@ret", ret);
            Database.ExcuteNonQuery(cmd);
        }
#endregion
        
#region  Phương thức chỉnh sửa thông tin một sản phẩm
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một sản phẩm
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="tensp"></param>
        /// <param name="mauid"></param>
        /// <param name="sizeid"></param>
        /// <param name="chatieuid"></param>
        /// <param name="anhsp"></param>
        /// <param name="soluongsp"></param>
        /// <param name="giasp"></param>
        /// <param name="motasp"></param>
        /// <param name="ngaytao"></param>
        /// <param name="ngayhuy"></param>
        /// <param name="madm"></param>
        /// <param name="nhomid"></param>
        public static void Sanpham_Update(string masp,string tensp,string mauid,string sizeid,string chatieuid,string anhsp,string soluongsp,string giasp,string motasp,string ngaytao,string ngayhuy,string madm,string nhomid)
        {
            SqlCommand cmd = new SqlCommand("sanpham_update");
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@mauid", mauid);
            cmd.Parameters.AddWithValue("@sizeid", sizeid);
            cmd.Parameters.AddWithValue("@chatieuid", chatieuid);
            cmd.Parameters.AddWithValue("@anhsp", anhsp);

            cmd.Parameters.AddWithValue("@soluongsp", soluongsp);
            cmd.Parameters.AddWithValue("@giasp", giasp);
            cmd.Parameters.AddWithValue("@motasp", motasp);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@ngayhuy", ngayhuy);

            cmd.Parameters.AddWithValue("@madm", madm);
            cmd.Parameters.AddWithValue("@nhomid", nhomid);
            Database.ExcuteNonQuery(cmd);
        }


	#endregion        
       
#region Phương thức lấy ra danh sách tất cả sản phẩm
		/// <summary>
        /// Phương thức lấy ra danh sách tất cả sản phẩm
        /// </summary>
        /// <returns></returns>
         public static DataTable Thongtin_Sanpham()
        {
            SqlCommand cmd = new SqlCommand("thongtin_sanpham");
            cmd.CommandType=CommandType.StoredProcedure;
            return Database.GetData(cmd);
        } 
#endregion

         #region Phương thức lấy ra thông tin sản phẩm theo id sản phẩm
         /// <summary>
         /// Phương thức lấy ra thông tin size theo id size
         /// <para name="MaSP">Mã của sản phẩm cần lấy thông tin</para>
         /// </summary>
         /// <returns></returns>
         public static DataTable Thongtin_Sanpham_by_id(string MaSP)
         {
             SqlCommand cmd = new SqlCommand("thongtin_sanpham_by_id");
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@MaSP", MaSP);
             return Database.GetData(cmd);
         }
        #endregion


        #region Lấy danh sách sản phẩm theo nhóm id
        public static DataTable Thongtin_Sanpham_by_nhomid(string NhomID, string SoSPHienThi)
        {
            SqlCommand cmd = new SqlCommand("thongtin_sanpham_by_nhomid");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NhomID", NhomID);
            cmd.Parameters.AddWithValue("@SoSPHienThi", SoSPHienThi);
            return Database.GetData(cmd);
        }
        #endregion

        #region Lấy danh sách sản phẩm theo mã danh mục - chỉ 3 sản phẩm đầu
        public static DataTable Thongtin_Sanpham_by_madm(string MaDM)
        {
            SqlCommand cmd = new SqlCommand("thongtin_sanpham_by_madm");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDM", MaDM);
            return Database.GetData(cmd);
        }

        public static DataTable Thongtin_Sanpham_by_madm_tatca(string MaDM)
        {
            SqlCommand cmd = new SqlCommand("thongtin_sanpham_by_madm_tatca");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDM", MaDM);
            return Database.GetData(cmd);
        }
        #endregion


        #region Lấy danh sách sản phẩm theo từ khóa tìm kiếm: sẽ tìm theo tên hoặc mã sản phẩm
        public static DataTable Thongtin_Sanpham_by_tukhoa(string tukhoa)
        {
            SqlCommand cmd = new SqlCommand("thongtin_sanpham_by_tukhoa");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuKhoa", tukhoa);
            return Database.GetData(cmd);
        }
        #endregion

    }
}
