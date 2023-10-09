﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieAPI_Project;

#nullable disable

namespace MovieAPI_Project.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.Property<int>("CharactersId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("CharactersId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CharacterMovie");
                });

            modelBuilder.Entity("MovieAPI_Project.Entity.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Leonardo DiCaprio",
                            Gender = "Male",
                            Picture = "https://img.washingtonpost.com/rf/image_1484w/2010-2019/WashingtonPost/2012/03/28/Style/Images/t3282.jpg?uuid=_HqPaHjaEeGW_E4_moVh7g"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Clark Joseph Kent",
                            Gender = "Male",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/d/d6/Superman_Man_of_Steel.jpg"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Henry Philip",
                            Gender = "Male",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/0/08/X-Men_Origins_Wolverine_theatrical_poster.jpg"
                        });
                });

            modelBuilder.Entity("MovieAPI_Project.Entity.Franchise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Franchises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This franchise makes superhit movies.",
                            Name = "Marvel Movies"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This franchise makes superhit movies.",
                            Name = "Mad max disaster"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This franchise makes superhit movies.",
                            Name = "Avengers Infinity War"
                        });
                });

            modelBuilder.Entity("MovieAPI_Project.Entity.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FranchiseId")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FranchiseId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Director = "James Cameron",
                            FranchiseId = 1,
                            Genre = "Romance",
                            Picture = "https://deadline.com/2022/06/titanic-rerelease-date-remastered-version-james-cameron-1235050212/",
                            ReleaseYear = 1997,
                            Title = "Titanic",
                            Trailer = "https://www.youtube.com/watch?v=kVrqfYjkTdQ"
                        },
                        new
                        {
                            Id = 2,
                            Director = "Richard Lester",
                            FranchiseId = 1,
                            Genre = "Action",
                            Picture = "https://www.rottentomatoes.com/m/superman_the_movie",
                            ReleaseYear = 1979,
                            Title = "Superman",
                            Trailer = "https://www.youtube.com/watch?v=pUwxH4SM9Rg"
                        },
                        new
                        {
                            Id = 3,
                            Director = "James Mangold",
                            FranchiseId = 2,
                            Genre = "Fiction",
                            Picture = "https://www.imdb.com/title/tt3385516/",
                            ReleaseYear = 2000,
                            Title = "X-Men",
                            Trailer = "https://www.youtube.com/watch?v=VNxwlx6etXI"
                        });
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.HasOne("MovieAPI_Project.Entity.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieAPI_Project.Entity.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieAPI_Project.Entity.Movie", b =>
                {
                    b.HasOne("MovieAPI_Project.Entity.Franchise", "Franchise")
                        .WithMany("Movies")
                        .HasForeignKey("FranchiseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Franchise");
                });

            modelBuilder.Entity("MovieAPI_Project.Entity.Franchise", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
