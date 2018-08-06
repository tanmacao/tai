using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Connet_ADO_DATA;

namespace WebsiteMau.DataCs
{
    public class Size
    {
        #region Phương thức xóa Size
        /// Phương thức xóa Size theo mã Size truyền vào
        /// </summary>
        /// <param name="masp">mã Size cần xóa</param>
        public static void Size_Delete(string sizeid)
        {
            SqlCommand cmd = new SqlCommand("size_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sizeid", sizeid);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Size vào bảng Size
        /// <summary>
        /// Phương thức thêm mới Size vào bảng Size
        /// </summary>
        /// <param name="tensize"></param>

        public static void Size_Inser(string tensize, string ret)
        {
            SqlCommand cmd = new SqlCommand("size_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tensize", tensize);
            cmd.Parameters.AddWithValue("@ret", ret);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Size
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một Size
        /// </summary>
        /// <param name="sizeid"></param>
        /// <param name="tensize"></param>

        public static void Size_Update(string sizeid, string tensize)
        {
            SqlCommand cmd = new SqlCommand("size_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sizeid", sizeid);
            cmd.Parameters.AddWithValue("@tensize", tensize);
            Database.ExcuteNonQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả Size
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Size
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Size()
        {
            SqlCommand cmd = new SqlCommand("thongtin_size");
            cmd.CommandType = CommandType.StoredProcedure;
            return Database.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin size theo id size
        /// <summary>
        /// Phương thức lấy ra thông tin size theo id size
        /// <para name="SizeID">Mã của size cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Size_by_id(string SizeID)
        {
            SqlCommand cmd = new SqlCommand("thongtin_size_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SizeID", SizeID);
            return Database.GetData(cmd);
        }
        #endregion
    }
}