using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace DomainEntities
{
    public class GolfDbContext : DbContext
    {

        public GolfDbContext(DbContextOptions<GolfDbContext> options) : base(options) { 
        
        }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseMySql("Server=localhost;Database=MetaGolf;User=root;Password=zsl@Calgary23;",new MySqlServerVersion(new Version(8, 0, 23)));
                optionsBuilder.UseMySql("Server=myfirstmysqlazureshulin.mysql.database.azure.com;Database=metagolf;User=shulinz;Password=root2023.yyc;",new MySqlServerVersion(new Version(8, 0, 23)));
            }
        }


        public DbSet<Common.Entities.User> Users { get; set; }
        public DbSet<Common.Entities.GolfCourses> GolfCourses { get; set;}
        public DbSet<Common.Entities.CourseHoles> CourseHoles { get; set;}
        public DbSet<Common.Entities.ThePerfectGame> ThePerfectGame { get; set;}
        public DbSet<Common.Entities.ThePerfectGameStroke> ThePerfectGameStroke { get; set;}
        public DbSet<Common.Entities.ThePerfectGameUser> ThePerfectGameUser { get; set;}
        public DbSet<Common.Entities.Area> Area { get; set;}
        public DbSet<Common.Entities.ScoreCardSubmission> ScoreCardSubmissions {get;set;}

        public DbSet<Common.Entities.CourseHoleCoordinates> CourseHoleCoordinates { get; set;}
        public DbSet<Common.Entities.CourseTeeNames> CourseTeeNames { get; set;}
        public DbSet<Common.Entities.CourseTees> CourseTees { get; set;}
        public DbSet<Common.Entities.GameGolfers> GameGolfers { get; set;}
        public DbSet<Common.Entities.Games> Games { get; set;}
        public DbSet<Common.Entities.GameTypes> GameTypes { get; set;}
        public DbSet<Common.Entities.Level> Level { get; set;}

        public DbSet<Common.Entities.TournamenTypes> TournamenTypes { get; set;}

        public DbSet<Common.Entities.GameMilestoneT> GameMilestoneT {get;set;}
        public DbSet<Common.Entities.GameMilestoneMatchT> GameMilestoneMatchT {get;set;}
        public DbSet<Common.Entities.GameMilestone> GameMilestone {get;set;}
        public DbSet<Common.Entities.GameMilestoneMatch> GameMilestoneMatch {get;set;}
        public DbSet<Common.Entities.GameHoleRoadmap> GameHoleRoadmap {get;set;}

        public DbSet<Common.Entities.GameMatchScoreCard> GameMatchScoreCard {get;set;}
        public DbSet<Common.Entities.GameMatchStroke> GameMatchStroke {get;set;}
        public DbSet<Common.Entities.JoinOpenTournament> JoinOpenTournaments {get;set;}



      
    }
}
