using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDstudent4.Models;

namespace CRUDstudent4.Data
{
    public class CRUDstudent4Context : DbContext
    {
        public CRUDstudent4Context (DbContextOptions<CRUDstudent4Context> options)
            : base(options)
        {
        }

        public DbSet<CRUDstudent4.Models.Student> Student { get; set; } = default!;
    }
}
