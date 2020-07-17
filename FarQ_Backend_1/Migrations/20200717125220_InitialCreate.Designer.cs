﻿// <auto-generated />
using FarQ_Backend_1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FarQ_Backend_1.Migrations
{
    [DbContext(typeof(FarQContext))]
    [Migration("20200717125220_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("Q_Backend.Models.Booth", b =>
                {
                    b.Property<int>("BoothID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrentUser")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InterviewerName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Occupied")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Payload")
                        .HasColumnType("TEXT");

                    b.HasKey("BoothID");

                    b.HasIndex("InterviewerName");

                    b.ToTable("Booth");
                });

            modelBuilder.Entity("Q_Backend.Models.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployerLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("HelpLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserLink")
                        .HasColumnType("TEXT");

                    b.HasKey("EventID");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("Q_Backend.Models.EventOrganiser", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("EventID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EventIDs")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("EventOrganiser");
                });

            modelBuilder.Entity("Q_Backend.Models.Interviewer", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Desc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("EventID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Interviewer");
                });

            modelBuilder.Entity("Q_Backend.Models.Pool", b =>
                {
                    b.Property<string>("Booths")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("QueueID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Booths");

                    b.ToTable("Pool");
                });

            modelBuilder.Entity("Q_Backend.Models.Queue", b =>
                {
                    b.Property<int>("QueueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserIDs")
                        .HasColumnType("TEXT");

                    b.HasKey("QueueID");

                    b.ToTable("Queue");
                });

            modelBuilder.Entity("Q_Backend.Models.User", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("EventID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Q_Backend.Models.Booth", b =>
                {
                    b.HasOne("Q_Backend.Models.Interviewer", "Interviewer")
                        .WithMany()
                        .HasForeignKey("InterviewerName");
                });
#pragma warning restore 612, 618
        }
    }
}