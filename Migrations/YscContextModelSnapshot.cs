﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YSC_Server.DbContext;

namespace YSCServer.Migrations
{
    [DbContext(typeof(YscContext))]
    partial class YscContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("YSC_Server.DaoModels.YelpReview", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusinessId");

                    b.Property<DateTime>("CrationTIme");

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

                    b.HasKey("id");

                    b.ToTable("YelpReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
