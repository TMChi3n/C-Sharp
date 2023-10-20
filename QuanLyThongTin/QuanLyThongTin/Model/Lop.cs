using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyThongTin.Model
{
    [Table("Lop")]
    public class Lop
    {
        [Key]
        public int idLop { get; set; }
        public String tenLop { get; set; }
        public int idKhoa { get; set; }

        public static DataTable ListLop()
        {
            SqlConnection conn = Global.getConnection();
            String sql = "select * from Lop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
