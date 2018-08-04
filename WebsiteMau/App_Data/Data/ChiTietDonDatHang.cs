using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Connet_ADO_DATA;

namespace WebsiteData
{
    public class ChiTietDonDatHang
    {
        #region Thêm mới thông tin cho đơn đặt hàng
        /// <summary>
        /// Thêm mới dữ liệu cho thông tin đơn đăt hàng 
        /// </summary>
        /// <param name="msp"></param>
        /// <param name="madondathang"></param>
        /// <param name="soluongdat"></param>
        /// <param name="dongiadat"></param>
        /// <param name="ret"></param>

        public static void ChiTietDonDatHang_Insert(string msp, string madondathang, string soluongdat, string dongiadat, string ret)
        {
            SqlCommand cmd = new SqlCommand("chitietdondathang_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", msp);
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            cmd.Parameters.AddWithValue("@soluongdat", soluongdat);
            cmd.Parameters.AddWithValue("@dongiadat", dongiadat);
            cmd.Parameters.AddWithValue("@ret", ret);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region Xóa thông tin chi tiết đơn đặt hang theo mã
        /// <summary>
        /// Xóa thông tin chi tiết đơn đặt hàng 
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="madondathang"></param>
        public static void ChiTietDonDatHang_Delete(string masp, string madondathang)
        {
            SqlCommand cmd = new SqlCommand("chitietdondathang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region Cập nhật lại thông tin chi tiết đơn đặt hàng 
        /// <summary>
        /// Cập nhật thông tin chi tiết đơn đặt hàng 
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="madondathang"></param>
        public static void ChiTietDonDatHang_Update(string masp, string madondathang, string solongdat, string dongiadat)
        {
            SqlCommand cmd = new SqlCommand("chitietdondathang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            cmd.Parameters.AddWithValue("@soluongdat", solongdat);
            cmd.Parameters.AddWithValue("@dongiadat", dongiadat);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region Lấy thông tin chi tiết đơn đặt hàng 
        /// <summary>
        /// lấy thông tin chi tiết đơn đặt hàng 
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_ChiTietDonDatHang()
        {
            SqlCommand cmd = new SqlCommand("thongtin_chitietdondathang");
            cmd.CommandType = CommandType.StoredProcedure;
            return Database.GetData(cmd);
        }
        #endregion

        #region lấy thoohng tin chi tiết đơn đặt hang theo mã
        /// <summary>
        /// Lấy thông tin đơn dặt hang theo mã đơn đặt hàng 
        /// </summary>
        /// <param name="madondathang"></param>
        /// <returns></returns>
        public static DataTable Thongtin_ChiTietDonDathang_by_madondathang(string madondathang)
        {
            SqlCommand cmd = new SqlCommand("thongtin_chitietdondathang_by_madondathang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            return Database.GetData(cmd);
        }
        #endregion
    }
}






