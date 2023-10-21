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
    [Table("GiaoVien")]
    public class GiaoVien
    {
        [Key]
        public int idGV { get; set; }
        public String tenGV { get; set; }
        public String gioiTinh { get; set; }
        public String queQuan { get; set; }
        public int idLop { get; set; }
        public int idKhoa { get; set; }


        

        public static bool insertGV(GiaoVien gv)
        {
            SqlConnection conn = Global.getConnection();
            String sql = "insert GiaoVien(tenGV, gioiTinh, queQuan, idKhoa, idLop)" +
                " values (@tenGV, @gioiTinh, @queQuan, @idLop, @idKhoa)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@tenGV", SqlDbType.NVarChar).Value = gv.tenGV;
            cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = gv.gioiTinh;
            cmd.Parameters.Add("@queQuan", SqlDbType.NVarChar).Value = gv.queQuan;
            cmd.Parameters.Add("@idKhoa", SqlDbType.Int).Value = gv.idKhoa;
            cmd.Parameters.Add("@idLop", SqlDbType.Int).Value = gv.idLop;

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public static GiaoVien getGVById(int idKhoa)
        {
            GiaoVien gv = new GiaoVien();
            SqlConnection conn = Global.getConnection();
            String sql = "select * from GiaoVien where idGV=@idGV";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@idGV", SqlDbType.Int).Value = idKhoa;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if(dt.Rows.Count > 0 )
            {
                DataRow dr = dt.Rows[0];
                gv.idGV = idKhoa;
                gv.tenGV = dr["tenGV"].ToString();
                gv.gioiTinh = dr["gioiTinh"].ToString();
                gv.queQuan = dr["queQuan"].ToString();
                return gv;
            }
            return gv;
        }

        public static bool updateGV(GiaoVien gv)
        {
            DataContext dtx = new DataContext();
            GiaoVien udgv = (from x in dtx.GV where x.idGV == gv.idGV select x).SingleOrDefault();
            if (udgv != null)
            {
                udgv.tenGV = gv.tenGV;
                udgv.idKhoa = gv.idKhoa;
                udgv.idLop = gv.idLop;
                udgv.gioiTinh = gv.gioiTinh;
                udgv.queQuan = gv.queQuan;
                dtx.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool deleteGV(int idGV)
        {
            SqlConnection conn = Global.getConnection();
            String sql = "delete GiaoVien where idGV=@idGV";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@idGV", SqlDbType.Int).Value = idGV;
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
