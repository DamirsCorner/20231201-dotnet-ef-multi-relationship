﻿// <auto-generated />
using System;
using EfCoreMultiRelationship;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreMultiRelationship.Migrations
{
    [DbContext(typeof(BloggingDbContext))]
    partial class BloggingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCoreMultiRelationship.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<int?>("AuthorUserId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.HasIndex("AuthorUserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EfCoreMultiRelationship.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EfCoreMultiRelationship.Post", b =>
                {
                    b.HasOne("EfCoreMultiRelationship.User", "Author")
                        .WithMany("AuthoredPosts")
                        .HasForeignKey("AuthorUserId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("EfCoreMultiRelationship.User", b =>
                {
                    b.Navigation("AuthoredPosts");
                });
#pragma warning restore 612, 618
        }
    }
}