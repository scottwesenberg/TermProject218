﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject1.Models;

#nullable disable

namespace TermProject1.Migrations
{
    [DbContext(typeof(GameContext))]
    partial class GameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TermProject1.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GameId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = "A",
                            Name = "Action"
                        },
                        new
                        {
                            Id = "C",
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = "D",
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = "O",
                            Name = "Open-World"
                        },
                        new
                        {
                            Id = "F",
                            Name = "Sci-Fi"
                        },
                        new
                        {
                            Id = "RPG",
                            Name = "Role-Playing"
                        },
                        new
                        {
                            Id = "S",
                            Name = "Shooter"
                        },
                        new
                        {
                            Id = "FAN",
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = "CAS",
                            Name = "Casual"
                        },
                        new
                        {
                            Id = "COMP",
                            Name = "Competitive"
                        },
                        new
                        {
                            Id = "STR",
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = "SPORT",
                            Name = "Sports"
                        });
                });

            modelBuilder.Entity("TermProject1.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<float>("IGNRating")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Creator = "Rockstar Studios",
                            Description = "Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game's vast and atmospheric world also provides the foundation for a brand new online multiplayer experience.",
                            IGNRating = 10f,
                            Name = "Red Dead Redemption 2",
                            Year = 2018
                        },
                        new
                        {
                            Id = 2,
                            Creator = "Bethesda Game Studios",
                            Description = "Elden Ring is an expansive fantasy Action-RPG game developed by FromSoftware, Inc. under the direction of Hidetaka Miyazaki and created in collaboration with famed author George R.R. Martin.",
                            IGNRating = 7f,
                            Name = "Starfield",
                            Year = 2023
                        },
                        new
                        {
                            Id = 3,
                            Creator = "FromSoftware",
                            Description = "Starfield is a next-generation roleplaying game set in space, created by the acclaimed team behind The Elder Scrolls and Fallout.",
                            IGNRating = 10f,
                            Name = "Elden Ring",
                            Year = 2022
                        });
                });

            modelBuilder.Entity("TermProject1.Models.GameCategory", b =>
                {
                    b.Property<int>("GameCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameCategoryId"), 1L, 1);

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("GameCategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GameId");

                    b.ToTable("GameCategories");

                    b.HasData(
                        new
                        {
                            GameCategoryId = 1,
                            CategoryId = "O",
                            GameId = 1
                        },
                        new
                        {
                            GameCategoryId = 2,
                            CategoryId = "S",
                            GameId = 1
                        },
                        new
                        {
                            GameCategoryId = 3,
                            CategoryId = "A",
                            GameId = 1
                        },
                        new
                        {
                            GameCategoryId = 4,
                            CategoryId = "F",
                            GameId = 2
                        },
                        new
                        {
                            GameCategoryId = 5,
                            CategoryId = "O",
                            GameId = 2
                        },
                        new
                        {
                            GameCategoryId = 6,
                            CategoryId = "RPG",
                            GameId = 3
                        },
                        new
                        {
                            GameCategoryId = 7,
                            CategoryId = "F",
                            GameId = 3
                        },
                        new
                        {
                            GameCategoryId = 8,
                            CategoryId = "FAN",
                            GameId = 3
                        });
                });

            modelBuilder.Entity("TermProject1.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<float>("GameRating")
                        .HasColumnType("real");

                    b.Property<string>("GameReview")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.HasKey("ReviewId");

                    b.HasIndex("GameId");

                    b.ToTable("Review");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            GameId = 1,
                            GameRating = 9.3f,
                            GameReview = "This game is absolutely breathtaking. The visual graphics and interactions will have you stomping around in the snow for hours. I highly reccomend this game to anyone who likes a semi-casual shooter with amazing graphics and a gret story."
                        },
                        new
                        {
                            ReviewId = 2,
                            GameId = 2,
                            GameRating = 7.5f,
                            GameReview = "Starfield is a cool space experiece with quite a bit to offer. It has game physics that will keep you insterested, but I have a hard time wanting to follow to story. I'd rather just explore the vastness of space."
                        },
                        new
                        {
                            ReviewId = 3,
                            GameId = 2,
                            GameRating = 9.3f,
                            GameReview = "BEST GAME EVER I LOVE SPACE"
                        },
                        new
                        {
                            ReviewId = 4,
                            GameId = 3,
                            GameRating = 9f,
                            GameReview = "Elden Ring is a gorgeous open world game, with seamless graphics and fighting mechanics. It is a beautifully made game, though it is very difficult!"
                        });
                });

            modelBuilder.Entity("TermProject1.Models.Category", b =>
                {
                    b.HasOne("TermProject1.Models.Category", null)
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId");

                    b.HasOne("TermProject1.Models.Game", null)
                        .WithMany("GameCategories")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("TermProject1.Models.GameCategory", b =>
                {
                    b.HasOne("TermProject1.Models.Category", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("TermProject1.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("TermProject1.Models.Review", b =>
                {
                    b.HasOne("TermProject1.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("TermProject1.Models.Category", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("TermProject1.Models.Game", b =>
                {
                    b.Navigation("GameCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
