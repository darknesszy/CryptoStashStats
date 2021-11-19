﻿// <auto-generated />
using System;
using CryptoStashStats.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CryptoStashStats.Migrations
{
    [DbContext(typeof(FinanceContext))]
    partial class FinanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("financeSchema")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CryptoStashStats.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Ticker", "Name")
                        .IsUnique();

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("CryptoStashStats.Models.CurrencyExchange", b =>
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
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("CurrencyExchanges");
                });

            modelBuilder.Entity("CryptoStashStats.Models.ExchangeAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CurrencyExchangeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyExchangeId");

                    b.ToTable("ExchangeAccounts");
                });

            modelBuilder.Entity("CryptoStashStats.Models.ExchangeAccountApiKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ExchangeAccountId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PrivateKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PublicKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ExchangeAccountId")
                        .IsUnique();

                    b.HasIndex("PublicKey", "PrivateKey")
                        .IsUnique();

                    b.ToTable("ExchangeAccountApiKeys");
                });

            modelBuilder.Entity("CryptoStashStats.Models.ExchangeAccountBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("integer");

                    b.Property<int?>("ExchangeAccountId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("Savings")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("ExchangeAccountId");

                    b.ToTable("ExchangeAccountBalances");
                });

            modelBuilder.Entity("CryptoStashStats.Models.ExchangeRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("BuyerCurrencyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("CurrencyExchangeId")
                        .HasColumnType("integer");

                    b.Property<double>("Current")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("SellerCurrencyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BuyerCurrencyId");

                    b.HasIndex("CurrencyExchangeId");

                    b.HasIndex("SellerCurrencyId");

                    b.ToTable("ExchangeRates");
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

                    b.Property<double?>("Balance")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Address")
                        .IsUnique();

                    b.HasIndex("CurrencyId");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("CurrencyExchangeAccount", b =>
                {
                    b.Property<int>("CurrenciesId")
                        .HasColumnType("integer");

                    b.Property<int>("ExchangeAccountsId")
                        .HasColumnType("integer");

                    b.HasKey("CurrenciesId", "ExchangeAccountsId");

                    b.HasIndex("ExchangeAccountsId");

                    b.ToTable("CurrencyExchangeAccount");
                });

            modelBuilder.Entity("CryptoStashStats.Models.ExchangeAccount", b =>
                {
                    b.HasOne("CryptoStashStats.Models.CurrencyExchange", "CurrencyExchange")
                        .WithMany()
                        .HasForeignKey("CurrencyExchangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrencyExchange");
                });

            modelBuilder.Entity("CryptoStashStats.Models.ExchangeAccountApiKey", b =>
                {
                    b.HasOne("CryptoStashStats.Models.ExchangeAccount", "ExchangeAccount")
                        .WithOne("ExchangeAccountApiKey")
                        .HasForeignKey("CryptoStashStats.Models.ExchangeAccountApiKey", "ExchangeAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExchangeAccount");
                });

            modelBuilder.Entity("CryptoStashStats.Models.ExchangeAccountBalance", b =>
                {
                    b.HasOne("CryptoStashStats.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CryptoStashStats.Models.ExchangeAccount", "ExchangeAccount")
                        .WithMany()
                        .HasForeignKey("ExchangeAccountId");

                    b.Navigation("Currency");

                    b.Navigation("ExchangeAccount");
                });

            modelBuilder.Entity("CryptoStashStats.Models.ExchangeRate", b =>
                {
                    b.HasOne("CryptoStashStats.Models.Currency", "BuyerCurrency")
                        .WithMany()
                        .HasForeignKey("BuyerCurrencyId");

                    b.HasOne("CryptoStashStats.Models.CurrencyExchange", "CurrencyExchange")
                        .WithMany()
                        .HasForeignKey("CurrencyExchangeId");

                    b.HasOne("CryptoStashStats.Models.Currency", "SellerCurrency")
                        .WithMany()
                        .HasForeignKey("SellerCurrencyId");

                    b.Navigation("BuyerCurrency");

                    b.Navigation("CurrencyExchange");

                    b.Navigation("SellerCurrency");
                });

            modelBuilder.Entity("CryptoStashStats.Models.Wallet", b =>
                {
                    b.HasOne("CryptoStashStats.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("CurrencyExchangeAccount", b =>
                {
                    b.HasOne("CryptoStashStats.Models.Currency", null)
                        .WithMany()
                        .HasForeignKey("CurrenciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CryptoStashStats.Models.ExchangeAccount", null)
                        .WithMany()
                        .HasForeignKey("ExchangeAccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CryptoStashStats.Models.ExchangeAccount", b =>
                {
                    b.Navigation("ExchangeAccountApiKey")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
