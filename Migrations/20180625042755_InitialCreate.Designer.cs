﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YSC_Server.DbContext;

namespace YSCServer.Migrations
{
    [DbContext(typeof(YscContext))]
    [Migration("20180625042755_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("YSC_Server.DaoModels.Algorithm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CrationTime");

                    b.Property<int>("Creator");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedTime");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Algorithms");
                });

            modelBuilder.Entity("YSC_Server.DaoModels.Leetcode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlgorithmId");

                    b.Property<string>("Chapter");

                    b.Property<DateTime>("CrationTime");

                    b.Property<int>("Creator");

                    b.Property<string>("Description");

                    b.Property<string>("Difficultity");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedTime");

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("Leetcodes");
                });

            modelBuilder.Entity("YSC_Server.DaoModels.YelpReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusinessId");

                    b.Property<DateTime>("CrationTime");

                    b.Property<int>("Creator");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedTime");

                    b.Property<string>("ReviewId");

                    b.Property<string>("UserId");

                    b.Property<int>("cool");

                    b.Property<string>("date");

                    b.Property<int>("funny");

                    b.Property<int>("stars");

                    b.Property<string>("text");

                    b.Property<int>("type");

                    b.Property<int>("useful");

                    b.HasKey("Id");

                    b.ToTable("YelpReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
