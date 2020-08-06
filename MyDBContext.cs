using System;
using System.Data.Entity;

namespace CodeBlog_1
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("DBConnectionString")
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
