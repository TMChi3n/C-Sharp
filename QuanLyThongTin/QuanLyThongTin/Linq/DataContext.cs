using QuanLyThongTin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace QuanLyThongTin.Linq
{
    internal class DataContext : DbContext
    {
        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<Lop> Lop { get; set; }
        public DbSet<GiaoVien> GV { get; set; }
        public DbSet<HocSinh> HS { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String conn = Global.getConnectionString();
            optionsBuilder.UseSqlServer(conn, options =>
            {
                options.EnableRetryOnFailure();
            });
        }

    }
}
