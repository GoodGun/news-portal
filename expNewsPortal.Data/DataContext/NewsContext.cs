using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using expNewsPortal.Data.Data;

namespace expNewsPortal.Data.DataContext
{
    public class NewsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<NewsItem> NewsItems { get; set; }
        public DbSet<ImageItem> ImageItems { get; set; }
    }
}
