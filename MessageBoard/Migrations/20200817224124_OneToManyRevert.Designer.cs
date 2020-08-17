﻿// <auto-generated />
using System;
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.Solution.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    [Migration("20200817224124_OneToManyRevert")]
    partial class OneToManyRevert
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoard.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Name = "The Mod Squad"
                        },
                        new
                        {
                            GroupId = 2,
                            Name = "Mighty Morphin Power Rangers"
                        },
                        new
                        {
                            GroupId = 3,
                            Name = "Blink 182"
                        });
                });

            modelBuilder.Entity("MessageBoard.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("Date");

                    b.Property<int>("GroupId");

                    b.Property<string>("Title");

                    b.Property<string>("UserName");

                    b.HasKey("MessageId");

                    b.HasIndex("GroupId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            Body = "Hello? Hello???",
                            Date = new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 1,
                            Title = "Hello",
                            UserName = "Test1"
                        },
                        new
                        {
                            MessageId = 2,
                            Body = "I don't know why you say goodbye I say hello.",
                            Date = new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            GroupId = 1,
                            Title = "Goodbye",
                            UserName = "Test2"
                        },
                        new
                        {
                            MessageId = 3,
                            Body = "This is a test of the emergency alert system.",
                            Date = new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            GroupId = 2,
                            Title = "This is only a test",
                            UserName = "Test3"
                        },
                        new
                        {
                            MessageId = 4,
                            Body = "You would be dead. Probably, who knows. If you saw a flash, most likely.",
                            Date = new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            GroupId = 3,
                            Title = "If this was a real alert",
                            UserName = "Test4"
                        },
                        new
                        {
                            MessageId = 5,
                            Body = "I couldn't stay away",
                            Date = new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 3,
                            Title = "My Second Message",
                            UserName = "Test2"
                        });
                });

            modelBuilder.Entity("MessageBoard.Models.Message", b =>
                {
                    b.HasOne("MessageBoard.Models.Group")
                        .WithMany("Messages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
