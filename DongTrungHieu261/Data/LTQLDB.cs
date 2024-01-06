using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DongTrungHieu261.Models;

    public class LTQLDB : DbContext
    {
        public LTQLDB (DbContextOptions<LTQLDB> options)
            : base(options)
        {
        }

        public DbSet<DongTrungHieu261.Models.LopHoc> LopHoc { get; set; } = default!;
    }
