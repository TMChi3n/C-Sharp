using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QuanLyThongTin.Linq;

namespace QuanLyThongTin.Model
{
    [Table("Khoa")]
    internal class Khoa
    {
        [Key]
        public int idKhoa { get; set; }
        public String tenKhoa { get; set; }

        public static List<Khoa> ListKhoa()
        {
            DataContext dtx = new DataContext();
            var lst = (from x in dtx.Khoa select x).ToList();
            return lst;
        }

    }
}
