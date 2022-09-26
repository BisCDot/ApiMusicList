using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiMusicList.Model.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemSong>().ToTable("ItemSong");
            modelBuilder.Entity<ItemSong>().HasKey(s => s.Id);
        }

        public DbSet<ItemSong> itemSongs { get; set; }
    }
}