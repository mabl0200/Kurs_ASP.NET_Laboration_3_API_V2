﻿// <auto-generated />
using Labb3.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labb3.API.Migrations
{
    [DbContext(typeof(Labb3DbContext))]
    partial class Labb3DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb3.Model.Hobby", b =>
                {
                    b.Property<int>("HobbyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HobbyId");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            HobbyId = 1,
                            Description = "Chess is a board game played between two players",
                            Title = "Chess"
                        },
                        new
                        {
                            HobbyId = 2,
                            Description = "Playing and listening to music",
                            Title = "Music"
                        },
                        new
                        {
                            HobbyId = 3,
                            Description = "Team sport where you score a goal by kicking a ball",
                            Title = "Football"
                        },
                        new
                        {
                            HobbyId = 4,
                            Description = "Cross-country skiing is a form of skiing where skiers rely on their own locomotion to move across snow-covered terrain, rather than using ski lifts or other forms of assistance",
                            Title = "Cross-country skiing"
                        });
                });

            modelBuilder.Entity("Labb3.Model.Link", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HobbyId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("varchar(200)");

                    b.HasKey("LinkId");

                    b.HasIndex("HobbyId");

                    b.HasIndex("PersonId");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            LinkId = 1,
                            HobbyId = 1,
                            PersonId = 4,
                            URL = "en.wikipedia.org/wiki/Chess"
                        },
                        new
                        {
                            LinkId = 2,
                            HobbyId = 2,
                            PersonId = 3,
                            URL = "open.spotify.com/"
                        },
                        new
                        {
                            LinkId = 3,
                            HobbyId = 3,
                            PersonId = 1,
                            URL = "laliga.com/en-GB"
                        },
                        new
                        {
                            LinkId = 4,
                            HobbyId = 4,
                            PersonId = 5,
                            URL = "fis-ski.com/en/cross-country"
                        },
                        new
                        {
                            LinkId = 5,
                            HobbyId = 4,
                            PersonId = 2,
                            URL = "lofsdalen.com/en/cross-country-skiing"
                        });
                });

            modelBuilder.Entity("Labb3.Model.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            FirstName = "Tobias",
                            LastName = "Karlsson",
                            PhoneNumber = "0701234569"
                        },
                        new
                        {
                            PersonId = 2,
                            FirstName = "Lisa",
                            LastName = "Nilsson",
                            PhoneNumber = "0707412589"
                        },
                        new
                        {
                            PersonId = 3,
                            FirstName = "Therese",
                            LastName = "Skog",
                            PhoneNumber = "0708523698"
                        },
                        new
                        {
                            PersonId = 4,
                            FirstName = "Jesper",
                            LastName = "Svensk",
                            PhoneNumber = "0701472536"
                        },
                        new
                        {
                            PersonId = 5,
                            FirstName = "Ture",
                            LastName = "Sventon",
                            PhoneNumber = "0703698521"
                        });
                });

            modelBuilder.Entity("Labb3.Model.PersonHobby", b =>
                {
                    b.Property<int>("PersonHobbyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HobbyId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("PersonHobbyId");

                    b.HasIndex("HobbyId");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonHobbies");

                    b.HasData(
                        new
                        {
                            PersonHobbyId = 1,
                            HobbyId = 1,
                            PersonId = 4
                        },
                        new
                        {
                            PersonHobbyId = 2,
                            HobbyId = 2,
                            PersonId = 3
                        },
                        new
                        {
                            PersonHobbyId = 3,
                            HobbyId = 3,
                            PersonId = 1
                        },
                        new
                        {
                            PersonHobbyId = 4,
                            HobbyId = 4,
                            PersonId = 5
                        },
                        new
                        {
                            PersonHobbyId = 5,
                            HobbyId = 4,
                            PersonId = 2
                        },
                        new
                        {
                            PersonHobbyId = 6,
                            HobbyId = 3,
                            PersonId = 2
                        },
                        new
                        {
                            PersonHobbyId = 7,
                            HobbyId = 2,
                            PersonId = 1
                        });
                });

            modelBuilder.Entity("Labb3.Model.Link", b =>
                {
                    b.HasOne("Labb3.Model.Hobby", "Hobby")
                        .WithMany("Links")
                        .HasForeignKey("HobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb3.Model.Person", "Person")
                        .WithMany("Links")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb3.Model.PersonHobby", b =>
                {
                    b.HasOne("Labb3.Model.Hobby", "Hobby")
                        .WithMany("PersonHobbies")
                        .HasForeignKey("HobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb3.Model.Person", "Person")
                        .WithMany("PersonHobbies")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
