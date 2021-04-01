﻿// <auto-generated />
using System;
using GreentableApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GreentableApi.Migrations
{
    [DbContext(typeof(GreentableContext))]
    [Migration("20210331062455_Initial-0.1")]
    partial class Initial01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GreentableApi.Models.Users", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdBy")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("googleuid")
                        .HasColumnType("text");

                    b.Property<string>("meta")
                        .HasColumnType("jsonb");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedBy")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GreentableApi.Models.homeContent", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdBy")
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("meta")
                        .HasColumnType("jsonb");

                    b.Property<string>("posttype")
                        .HasColumnType("text");

                    b.Property<string>("profilemedia")
                        .HasColumnType("text");

                    b.Property<string>("profilename")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedBy")
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("homeContent");
                });
#pragma warning restore 612, 618
        }
    }
}
