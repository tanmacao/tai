using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Connet_ADO_DATA;

namespace WebsiteMau.Data
{





    /// <summary>
    /// Summary description for ChatLieu
    /// </summary>
    public class ChatLieuCustomize
    {
        #region Method Delete_Chất liệu sản phẩm
        /// <summary>
        /// Method xóa chất liệu theo mã truyền vào
        /// </summary>
        /// <param name="chatLieu">Mã chất liệu cần xóa</param>
        public static void ChatLieu_Delete(string chatLieu)
        {
            SqlCommand cmd = new SqlCommand(chatLieu);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chatlieuid", chatLieu);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region Method  Insert_Chất Liệu
        /// <summary>
        /// Menthod insert data in Chat lieu
        /// </summary>
        /// <param name="tenChatLieu"></param>
        /// <param name="ret"></param>
        public static void ChatLieu_Insert(string tenChatLieu, string ret)
        {
            SqlCommand cmd = new SqlCommand("chatlieu_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenchatlieu", tenChatLieu);
            cmd.Parameters.AddWithValue("@ret", ret);
            Database.ExcuteNonQuery(cmd);
        }
        #endregion

        #region phuong thuc cap nhap lai du lieu cho ban chat lieu
        /// <summary>
        /// Menthod Update date in Chat lieu
        /// </summary>
        /// <param name="chatLieuID"></param>
        /// <param name="tenChatLieu"></param>
        public static void ChatLieu_Update(string chatLieuID, string tenChatLieu)
        {
            SqlCommand cmd = new SqlCommand("chatlieu_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chatlieuid", chatLieuID);
            cmd.Parameters.AddWithValue("@tenchatlieu", tenChatLieu);
            Database.ExcuteNonQuery(cmd);
        }

        #endregion

        #region Lấy thông tin dữ liệu bản chất liệu
        /// <summary>
        /// Select thong tin hcat lieu
        /// </summary>
        /// <returns></returns>                 
        public static DataTable ThongTin_ChatLieu()
        {
            SqlCommand cmd = new SqlCommand("thongtin_chatlieu");
            cmd.CommandType = CommandType.StoredProcedure;
            return Database.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin chất liệu theo id
        public static DataTable Thongtin_Chatlieu_By_ID(string chatLieuID)
        {
            SqlCommand cmd = new SqlCommand("thongtin_chatlieu_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ChatLieuID", chatLieuID);
            return Database.GetData(cmd);
        }
        #endregion
    }
}