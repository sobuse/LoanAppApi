﻿// <auto-generated />
using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoanAppApi.Migrations
{
    [DbContext(typeof(LoanApplicationDbContext))]
    [Migration("20211105195108_InitialData")]
    partial class InitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Entity.Models.Borrower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("BorrowersId");

                    b.Property<string>("BVN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BorrowedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LoanAmount")
                        .HasColumnType("int");

                    b.Property<Guid>("LoanOfficerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MonthlyIncome")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Borrowers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("47632e5a-6d34-4ad2-869b-cf95c636c3ed"),
                            BVN = "7689432176",
                            BorrowedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1991, 11, 13, 20, 51, 7, 47, DateTimeKind.Local).AddTicks(7882),
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "OluwaDare John",
                            Gender = 2,
                            IsDeleted = false,
                            LoanAmount = 1000000,
                            LoanOfficerId = new Guid("9a07b75e-e943-48bc-821c-76685161668d"),
                            MonthlyIncome = 200000
                        });
                });

            modelBuilder.Entity("Entity.Models.Loan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RequesterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Loans");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a466a903-2b53-40c1-8dbf-8d6e323baa43"),
                            Amount = 10000000,
                            Comment = "Please I need a loan for my house rent",
                            CreatedAt = new DateTime(2021, 11, 5, 20, 51, 7, 50, DateTimeKind.Local).AddTicks(5870),
                            RequesterId = new Guid("47632e5a-6d34-4ad2-869b-cf95c636c3ed")
                        });
                });

            modelBuilder.Entity("Entity.Models.LoanOfficer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LoanOfficerId");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("RequestLoan")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LoanOfficers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9a07b75e-e943-48bc-821c-76685161668d"),
                            Fullname = "Obuse Samuel",
                            RequestLoan = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
