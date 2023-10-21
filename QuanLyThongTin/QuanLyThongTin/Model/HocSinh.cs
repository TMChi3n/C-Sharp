using QuanLyThongTin.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTin.Model
{
    [Table("HocSinh")]
    public class HocSinh
    {
        [Key]
        public int idHS { get; set; }
        public String tenHS { get; set; }
        public String gioiTinh { get; set; }
        public String queQuan { get; set; }
        public int idLop { get; set; }

        public static bool insertHS(HocSinh hs)
        {
            SqlConnection conn = Global.getConnection();
            String sql = "insert HocSinh(tenHS, gioiTinh, queQuan, idLop)" +
                " values (@tenHS, @gioiTinh, @queQuan, @idLop)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@tenHS", SqlDbType.NVarChar).Value = hs.tenHS;
            cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = hs.gioiTinh;
            cmd.Parameters.Add("@queQuan", SqlDbType.NVarChar).Value = hs.queQuan;
            cmd.Parameters.Add("@idLop", SqlDbType.Int).Value = hs.idLop;

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static HocSinh getHSById(int idLop)
        {
            HocSinh hs = new HocSinh();
            SqlConnection conn = Global.getConnection();
            String sql = "select * from HocSinh where idHS=@idHS";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@idHS", SqlDbType.Int).Value = idLop;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                hs.idHS = idLop;
                hs.tenHS = dr["tenHS"].ToString();
                hs.gioiTinh = dr["gioiTinh"].ToString();
                hs.queQuan = dr["queQuan"].ToString();
                return hs;
            }
            return hs;
        }

        public static bool updateHS(HocSinh hs)
        {
            DataContext dtx = new DataContext();
            HocSinh udhs = (from x in dtx.HS where x.idHS == hs.idHS select x).SingleOrDefault();
            if (udhs != null)
            {
                udhs.tenHS = hs.tenHS;
                udhs.idLop = hs.idLop;
                udhs.gioiTinh = hs.gioiTinh;
                udhs.queQuan = hs.queQuan;
                dtx.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool deleteHS(int idHS)
        {
            SqlConnection conn = Global.getConnection();
            String sql = "delete HocSinh where idHS=@idHS";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@idHS", SqlDbType.Int).Value = idHS;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
