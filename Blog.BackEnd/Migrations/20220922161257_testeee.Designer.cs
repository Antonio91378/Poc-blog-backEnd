﻿// <auto-generated />
using System;
using API.Blog.BackEnd.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Blog.BackEnd.Migrations
{
    [DbContext(typeof(Context2))]
    [Migration("20220922161257_testeee")]
    partial class testeee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.Blog.BackEnd.Domain.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdComment");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriationData")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("API.Blog.BackEnd.Domain.Entities.RepliedComment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdRepliedComment");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CriationData")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdComment")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdComment");

                    b.ToTable("RepliedComments");
                });

            modelBuilder.Entity("API.Blog.BackEnd.Domain.Entities.RepliedComment", b =>
                {
                    b.HasOne("API.Blog.BackEnd.Domain.Entities.Comment", "CurrentComment")
                        .WithMany("RepliedComments")
                        .HasForeignKey("IdComment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentComment");
                });

            modelBuilder.Entity("API.Blog.BackEnd.Domain.Entities.Comment", b =>
                {
                    b.Navigation("RepliedComments");
                });
#pragma warning restore 612, 618
        }
    }
}
