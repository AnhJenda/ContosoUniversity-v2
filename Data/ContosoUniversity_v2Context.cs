using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity_v2.Models;

namespace ContosoUniversity_v2.Data
{
    public class ContosoUniversity_v2Context : DbContext
    {
        public ContosoUniversity_v2Context (DbContextOptions<ContosoUniversity_v2Context> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity_v2.Models.Student> Student { get; set; } = default!;
        public DbSet<ContosoUniversity_v2.Models.Course>  Course { get; set; } = default!;
        public DbSet<ContosoUniversity_v2.Models.Enrollment>  Enrollment { get; set; } = default!;
    }
}
