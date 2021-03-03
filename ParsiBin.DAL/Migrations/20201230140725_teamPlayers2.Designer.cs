﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParsiBin.DAL.Context;

namespace ParsiBin.DAL.Migrations
{
    [DbContext(typeof(ParsibinContext))]
    [Migration("20201230140725_teamPlayers2")]
    partial class teamPlayers2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ParsiBin.DAL.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NationalityId");

                    b.ToTable("Coach");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Flag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("League");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<int?>("LeagueId")
                        .HasColumnType("int");

                    b.Property<DateTime>("MatchDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MatchStatus")
                        .HasColumnType("int");

                    b.Property<int?>("SeasonId")
                        .HasColumnType("int");

                    b.Property<int?>("StadiumId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Week")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("LeagueId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("StadiumId");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.MatchResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AwayGoal")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HomeGoal")
                        .HasColumnType("int");

                    b.Property<int?>("MatchId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.ToTable("MatchResult");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NationalityId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Season");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.SeasonTeams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("SeasonId")
                        .HasColumnType("int");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.HasIndex("TeamId");

                    b.ToTable("SeasonTeams");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Stadium");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("CoachId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StadiumId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CoachId");

                    b.HasIndex("CountryId");

                    b.HasIndex("StadiumId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.TeamCoach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CoachId")
                        .HasColumnType("int");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LeftDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoachId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamCoach");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.TeamPlayers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LeftDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamPlayers");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.City", b =>
                {
                    b.HasOne("ParsiBin.DAL.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Coach", b =>
                {
                    b.HasOne("ParsiBin.DAL.Entities.Country", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");

                    b.Navigation("Nationality");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Match", b =>
                {
                    b.HasOne("ParsiBin.DAL.Entities.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId");

                    b.HasOne("ParsiBin.DAL.Entities.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId");

                    b.HasOne("ParsiBin.DAL.Entities.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId");

                    b.HasOne("ParsiBin.DAL.Entities.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId");

                    b.HasOne("ParsiBin.DAL.Entities.Stadium", "Stadium")
                        .WithMany()
                        .HasForeignKey("StadiumId");

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");

                    b.Navigation("League");

                    b.Navigation("Season");

                    b.Navigation("Stadium");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.MatchResult", b =>
                {
                    b.HasOne("ParsiBin.DAL.Entities.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId");

                    b.Navigation("Match");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Player", b =>
                {
                    b.HasOne("ParsiBin.DAL.Entities.Country", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");

                    b.Navigation("Nationality");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Season", b =>
                {
                    b.HasOne("ParsiBin.DAL.Entities.League", "League")
                        .WithMany("Seasons")
                        .HasForeignKey("LeagueId");

                    b.Navigation("League");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.SeasonTeams", b =>
                {
                    b.HasOne("ParsiBin.DAL.Entities.Season", "Season")
                        .WithMany("SeasonTeams")
                        .HasForeignKey("SeasonId");

                    b.HasOne("ParsiBin.DAL.Entities.Team", "Team")
                        .WithMany("SeasonTeams")
                        .HasForeignKey("TeamId");

                    b.Navigation("Season");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Stadium", b =>
                {
                    b.HasOne("ParsiBin.DAL.Entities.City", "City")
                        .WithMany("Stadiums")
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Team", b =>
                {
                    b.HasOne("ParsiBin.DAL.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("ParsiBin.DAL.Entities.Coach", "Coach")
                        .WithMany()
                        .HasForeignKey("CoachId");

                    b.HasOne("ParsiBin.DAL.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("ParsiBin.DAL.Entities.Stadium", "Stadium")
                        .WithMany("TeamsArena")
                        .HasForeignKey("StadiumId");

                    b.Navigation("City");

                    b.Navigation("Coach");

                    b.Navigation("Country");

                    b.Navigation("Stadium");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.TeamCoach", b =>
                {
                    b.HasOne("ParsiBin.DAL.Entities.Coach", "Coach")
                        .WithMany()
                        .HasForeignKey("CoachId");

                    b.HasOne("ParsiBin.DAL.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.Navigation("Coach");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.TeamPlayers", b =>
                {
                    b.HasOne("ParsiBin.DAL.Entities.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");

                    b.HasOne("ParsiBin.DAL.Entities.Team", "Team")
                        .WithMany("TeamPlayers")
                        .HasForeignKey("TeamId");

                    b.Navigation("Player");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.City", b =>
                {
                    b.Navigation("Stadiums");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.League", b =>
                {
                    b.Navigation("Seasons");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Season", b =>
                {
                    b.Navigation("SeasonTeams");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Stadium", b =>
                {
                    b.Navigation("TeamsArena");
                });

            modelBuilder.Entity("ParsiBin.DAL.Entities.Team", b =>
                {
                    b.Navigation("SeasonTeams");

                    b.Navigation("TeamPlayers");
                });
#pragma warning restore 612, 618
        }
    }
}
