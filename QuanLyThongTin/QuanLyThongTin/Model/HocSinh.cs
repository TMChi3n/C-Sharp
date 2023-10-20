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

        
    }
}
