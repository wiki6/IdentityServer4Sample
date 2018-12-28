﻿// <auto-generated />
using System;
using Fate.Recommend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fate.Recommend.Migrations
{
    [DbContext(typeof(RecommendContext))]
    [Migration("20181129092007_AddUserName")]
    partial class AddUserName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Fate.Recommend.Model.RecommendProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar")
                        .HasMaxLength(100);

                    b.Property<string>("Company")
                        .HasMaxLength(100);

                    b.Property<int?>("FromUserId");

                    b.Property<string>("FromUserName")
                        .HasMaxLength(100);

                    b.Property<int?>("ProjectId");

                    b.Property<int?>("UserId");

                    b.Property<string>("UserName")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("RecommendProjects");
                });
#pragma warning restore 612, 618
        }
    }
}
