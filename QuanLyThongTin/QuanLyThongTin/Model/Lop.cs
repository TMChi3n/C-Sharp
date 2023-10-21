using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using QuanLyThongTin.Linq;

namespace QuanLyThongTin.Model
{
    [Table("Lop")]
    public class Lop
    {
        [Key]
        public int idLop { get; set; }
        public String tenLop { get; set; }
        public int idKhoa { get; set; }

        public static List<Lop> ListLop()
        {
            DataContext dtx = new DataContext();
            var lst = (from x in dtx.Lop select x).ToList();
            return lst;
        }

    }
}
