using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThongTin.Model
{
    [Table("Khoa")]
    internal class Khoa
    {
        [Key]
        public int idKhoa { get; set; }
        public String tenKhoa { get; set; }

        public static DataTable ListKhoa()
        {
            SqlConnection conn = Global.getConnection();
            String sql = "select * from Khoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }
    }
}
