using System.Data.Entity;
using VertexWebForm.Models;

namespace VertexWebForm.Data
{
    public class VertexWebFormDbContext : DbContext
    {
        public VertexWebFormDbContext() : base("VertexWebForm")
        {

        }

        public DbSet<CollegeSport> CollegeSports { get; set; }
        public DbSet<HighSchool> HighSchools { get; set; }
        public DbSet<PostHighSchool> PostHighSchools { get; set; }
        public DbSet<UserForm> UserForms { get; set; }
    }
}