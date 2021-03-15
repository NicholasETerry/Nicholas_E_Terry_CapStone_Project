﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nicholas_E_Terry_CapStone.Data;

namespace Nicholas_E_Terry_CapStone.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "56c2e392-8634-476d-bc10-a23af3435ff3",
                            ConcurrencyStamp = "b6d69058-9bb5-443f-a6c0-df23a0a33df7",
                            Name = "Consumer",
                            NormalizedName = "CONSUMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.ArticleAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("First_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ArticleAuthors");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.CleanArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArticleAuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Article_filepath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lead_paragraph")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("News_desk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pub_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Web_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Word_count")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleAuthorId");

                    b.ToTable("CleanArticles");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.ContributorComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Contributor_Comment_Clean_ArticleId")
                        .HasColumnType("int");

                    b.Property<int?>("Contributor_Comment_Clean_Article_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Contributor_Comment_UserModelId")
                        .HasColumnType("int");

                    b.Property<int?>("Contributor_Comment_UserModel_Id")
                        .HasColumnType("int");

                    b.Property<string>("contributorComment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Contributor_Comment_Clean_ArticleId");

                    b.HasIndex("Contributor_Comment_UserModelId");

                    b.ToTable("ContributorComments");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Highest_level")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.HighLight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("End_highlight")
                        .HasColumnType("int");

                    b.Property<int>("HighLights_CleanArticle_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Highlights_Clean_ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("Start_highlight")
                        .HasColumnType("int");

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("highlight_color")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Highlights_Clean_ArticleId");

                    b.ToTable("Highlights");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.Hobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hobby_user")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.Occupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Occupation_user")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Occupations");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.PreviousOccupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Previous_occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("PreviousOccupations");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.Rank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Rank_user")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rankings");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SKill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.TagContributorSuggested", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attribute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TagCleanArticleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TagCleanArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("TagsContributorsSuggest");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EducationId")
                        .HasColumnType("int");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OccupationId")
                        .HasColumnType("int");

                    b.Property<int?>("RankId")
                        .HasColumnType("int");

                    b.Property<int?>("UserAddressId")
                        .HasColumnType("int");

                    b.Property<int?>("UserNameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.HasIndex("IdentityUserId");

                    b.HasIndex("OccupationId");

                    b.HasIndex("RankId");

                    b.HasIndex("UserAddressId");

                    b.HasIndex("UserNameId");

                    b.ToTable("UserModels");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.UserModelAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip_code")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserModelAddresses");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.UserNameModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("User_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserNamesModel");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CleanArticleVoteId")
                        .HasColumnType("int");

                    b.Property<int?>("UserNameModelVoteId")
                        .HasColumnType("int");

                    b.Property<int>("UsernameVoteId")
                        .HasColumnType("int");

                    b.Property<string>("vote")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CleanArticleVoteId");

                    b.HasIndex("UserNameModelVoteId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.CleanArticle", b =>
                {
                    b.HasOne("Nicholas_E_Terry_CapStone.Models.ArticleAuthor", "ArticleAuthor")
                        .WithMany()
                        .HasForeignKey("ArticleAuthorId");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.ContributorComment", b =>
                {
                    b.HasOne("Nicholas_E_Terry_CapStone.Models.CleanArticle", "Contributor_Comment_Clean_Article")
                        .WithMany()
                        .HasForeignKey("Contributor_Comment_Clean_ArticleId");

                    b.HasOne("Nicholas_E_Terry_CapStone.Models.UserModel", "Contributor_Comment_UserModel")
                        .WithMany()
                        .HasForeignKey("Contributor_Comment_UserModelId");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.HighLight", b =>
                {
                    b.HasOne("Nicholas_E_Terry_CapStone.Models.CleanArticle", "Highlights_Clean_Article")
                        .WithMany()
                        .HasForeignKey("Highlights_Clean_ArticleId");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.Hobby", b =>
                {
                    b.HasOne("Nicholas_E_Terry_CapStone.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.PreviousOccupation", b =>
                {
                    b.HasOne("Nicholas_E_Terry_CapStone.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.Skill", b =>
                {
                    b.HasOne("Nicholas_E_Terry_CapStone.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.TagContributorSuggested", b =>
                {
                    b.HasOne("Nicholas_E_Terry_CapStone.Models.CleanArticle", "TagCleanArticle")
                        .WithMany()
                        .HasForeignKey("TagCleanArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nicholas_E_Terry_CapStone.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.UserModel", b =>
                {
                    b.HasOne("Nicholas_E_Terry_CapStone.Models.Education", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.HasOne("Nicholas_E_Terry_CapStone.Models.Occupation", "Occupation")
                        .WithMany()
                        .HasForeignKey("OccupationId");

                    b.HasOne("Nicholas_E_Terry_CapStone.Models.Rank", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId");

                    b.HasOne("Nicholas_E_Terry_CapStone.Models.UserModelAddress", "UserModelAddress")
                        .WithMany()
                        .HasForeignKey("UserAddressId");

                    b.HasOne("Nicholas_E_Terry_CapStone.Models.UserNameModel", "UserNameModel")
                        .WithMany()
                        .HasForeignKey("UserNameId");
                });

            modelBuilder.Entity("Nicholas_E_Terry_CapStone.Models.Vote", b =>
                {
                    b.HasOne("Nicholas_E_Terry_CapStone.Models.CleanArticle", "CleanArticleVote")
                        .WithMany()
                        .HasForeignKey("CleanArticleVoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nicholas_E_Terry_CapStone.Models.UserNameModel", "UserNameModelVote")
                        .WithMany()
                        .HasForeignKey("UserNameModelVoteId");
                });
#pragma warning restore 612, 618
        }
    }
}
