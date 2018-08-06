using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Connet_ADO_DATA;

namespace WebsiteMau.DataCs
{
    public class ChiTietDonHang
    {
        #region Thêm thông tin chi tiết đơn hàng
        /// <summary>
        /// Thêm mới thông tin cho chi tiết hóa đơn 
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="maHoaDon"></param>
        /// <param name="soLuong"></param>
        /// <param name="donGia"></param>
        /// <param name="ret"></param>

        public static void ChiTietDonHang_Inert(string masp, string maHoaDon, string soLuong, string donGia, string ret)
        {
            SqlCommand cmd = new SqlCommand("chitietdonhang_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", maHoaDon);
            cmd.Parameters.AddWithValue("@soluong", soLuong);
            cmd.Parameters.AddWithValue("@dongia", donGia);
            cmd.Parameters.AddWithValue("@ret", ret);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region Xóa thông tin ci tiết hóa đơn theo mã hóa đơn
        /// <summary>
        /// Phương thức xóa thông tin hóa đơn theo mã hóa đơn
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="maHoaDon"></param>
        public static void ChiTietDonHang_Delete(string masp, string maHoaDon)
        {
            SqlCommand cmd = new SqlCommand("chitietdonhang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", maHoaDon);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region cập nhập lại dự liệu cho thông tin chi tiết hóa đơn
        /// <summary>
        /// Cập nhập lại thông tin choa cho tiết hóa đơn
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="maHoaDon"></param>
        /// <param name="soLuong"></param>
        /// <param name="donGia"></param>
        public static void ChiTietDonHang_Update(string masp, string maHoaDon, string soLuong, string donGia)
        {
            SqlCommand cmd = new SqlCommand("chitietdonhang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", maHoaDon);
            cmd.Parameters.AddWithValue("@soluong", soLuong);
            cmd.Parameters.AddWithValue("@dongia", donGia);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region Lấy toàn bộ thông tin hóa đơn 
        public static DataTable Thongtin_ChiTietDonHang()
        {
            SqlCommand cmd = new SqlCommand("thongtin_chitietdonhang");
            cmd.CommandType = CommandType.StoredProcedure;
            return Database.GetData(cmd);
        }
        #endregion
    }
}