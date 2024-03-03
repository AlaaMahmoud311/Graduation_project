using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EduChatbot_DB_Context  : DbContext
    {


        public EduChatbot_DB_Context(DbContextOptions<EduChatbot_DB_Context> options) : base(options)
        {

        }





        public DbSet<Courses> Courses { get; set; }
        public DbSet<DashBoard> DashBoards { get; set; }
        public DbSet<Quizes> Quizes{ get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<Choices> Choices{ get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<DashBoard_Course>().HasKey(a => new { a.Course_Id, a.Dash_Id });
            modelBuilder.Entity<DashBoard_Track>().HasKey(a => new { a.Track_Id, a.Dash_Id });

            modelBuilder.Entity<Tracks>()
           .HasOne<Quizes>(t => t.quize)
           .WithOne(q => q.Track)
           .HasForeignKey<Quizes>(ad => ad.Track_id);




        }

    }
}
