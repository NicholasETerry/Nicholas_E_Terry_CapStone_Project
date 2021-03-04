using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nicholas_E_Terry_CapStone.Models;

namespace Nicholas_E_Terry_CapStone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // User related information

        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<UserModelAddress> UserModelAddresses { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<PreviousOccupation> PreviousOccupations { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<UserNameModel> UserNamesModel { get; set; }
        public DbSet<Rank> Rankings { get; set; }

        // Article relasted information

        public DbSet<CleanArticle> CleanArticles { get; set; }
        public DbSet<ArticleAuthor> ArticleAuthors { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<UserSuggestedArticleAttribute> UserSuggestedArticleAttributes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "consumer (this is temp)",
                    NormalizedName = "CONSUMER"
                }
                );
            builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = "contributor (this is temp)",
                NormalizedName = "CONTRIBUTOR"
            }
            );
        }
    }
}
