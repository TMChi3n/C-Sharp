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
            String sql = "insert GiaoVien(tenGV, gioiTinh, queQuan) values (@tenGV, @gioiTinh, @queQuan)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@tenGV", SqlDbType.NVarChar).Value = gv.tenGV;
            cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = gv.gioiTinh;
            cmd.Parameters.Add("@queQuan", SqlDbType.NVarChar).Value = gv.queQuan;

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
            SqlConnection conn = Global.getConnection();
            String sql = "update GiaoVien set tenGV=@tenGV, gioiTinh=@gioiTinh, queQuan=@queQuan where idGV=@idGV";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@tenGV", SqlDbType.NVarChar).Value = gv.tenGV;
            cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = gv.gioiTinh;
            cmd.Parameters.Add("@queQuan", SqlDbType.NVarChar).Value = gv.queQuan;

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

        public static DataTable searchGV(String str_search)
        {

            SqlConnection conn = Global.getConnection();
            String sql = @"select G.idGV, G.tenGV, G.gioiTinh, G.queQuan, K.tenKhoa, L.tenLop 
                            from GiaoVien G
                            join Khoa K on G.idKhoa = k.idKhoa
                            join Lop L on G.idLop = L.idLop";

            String str_where = @" WHERE G.tenGV like '%'+@chuoitimkiem+'%'
               OR K.tenKhoa like '%'+@chuoitimkiem+'%'
               OR L.tenLop like '%'+@chuoitimkiem+'%' ";

            SqlCommand cmd = new SqlCommand(sql + str_where, conn);
            cmd.Parameters.Add("@chuoitimkiem", SqlDbType.NVarChar).Value = str_search;
            DataTable dt = new DataTable();
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            return dt;
        }
    }
}
