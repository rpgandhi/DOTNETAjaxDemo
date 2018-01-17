
using Microsoft.EntityFrameworkCore;

namespace AjaxDemo.Models
{
    public class AjaxDemoContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=ajaxdemo;uid=root;pwd=root;");
    }
}