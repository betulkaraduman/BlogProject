using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NSE9T2O\\SQLEXPRESS01;database=CoreBlogDb;integrated security=true; ");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>().HasOne(i => i.HomeTeam).WithMany(i => i.HomeMatches).HasForeignKey(i => i.HomeTeamId).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Match>().HasOne(i => i.GuestTeam).WithMany(i => i.AwayMatches).HasForeignKey(i => i.GuestTeamId).OnDelete(DeleteBehavior.ClientSetNull);


            modelBuilder.Entity<Message>().HasOne(i => i.SenderUser).WithMany(i => i.WriterSender).HasForeignKey(i => i.SenderId).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Message>().HasOne(i => i.ReceiverUser).WithMany(i => i.WriterReceiver).HasForeignKey(i => i.ReveiverId).OnDelete(DeleteBehavior.ClientSetNull);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<BlogRaiting> BlogRaitings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
