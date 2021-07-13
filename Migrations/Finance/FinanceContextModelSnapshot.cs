﻿// <auto-generated />
using System;
using CryptoStashStats.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CryptoStashStats.Migrations.Finance
{
    [DbContext(typeof(FinanceContext))]
    partial class FinanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CryptoStashStats.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ProviderId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("CryptoStashStats.Models.AccountBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<int>("CoinId")
                        .HasColumnType("integer");

                    b.Property<double>("Current")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CoinId");

                    b.HasIndex("AccountId", "CoinId")
                        .IsUnique();

                    b.ToTable("AccountBalance");
                });

            modelBuilder.Entity("CryptoStashStats.Models.Coin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Ticker")
                        .IsUnique();

                    b.ToTable("Coin");
                });

            modelBuilder.Entity("CryptoStashStats.Models.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Provider");
                });

            modelBuilder.Entity("CryptoStashStats.Models.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Balance")
                        .HasColumnType("double precision");

                    b.Property<int?>("CoinId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Address")
                        .IsUnique();

                    b.HasIndex("CoinId");

                    b.ToTable("Wallet");
                });

            modelBuilder.Entity("CryptoStashStats.Models.Account", b =>
                {
                    b.HasOne("CryptoStashStats.Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("CryptoStashStats.Models.AccountBalance", b =>
                {
                    b.HasOne("CryptoStashStats.Models.Account", "Account")
                        .WithMany("AccountBalances")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CryptoStashStats.Models.Coin", "Coin")
                        .WithMany()
                        .HasForeignKey("CoinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Coin");
                });

            modelBuilder.Entity("CryptoStashStats.Models.Wallet", b =>
                {
                    b.HasOne("CryptoStashStats.Models.Coin", "Coin")
                        .WithMany()
                        .HasForeignKey("CoinId");

                    b.Navigation("Coin");
                });

            modelBuilder.Entity("CryptoStashStats.Models.Account", b =>
                {
                    b.Navigation("AccountBalances");
                });
#pragma warning restore 612, 618
        }
    }
}
