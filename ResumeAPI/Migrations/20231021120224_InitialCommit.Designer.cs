﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ResumeAPI.Data;

#nullable disable

namespace ResumeAPI.Migrations
{
    [DbContext(typeof(ResumeAPIContext))]
    [Migration("20231021120224_InitialCommit")]
    partial class InitialCommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ResumeAPI.Models.Api", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.HasKey("Id");

                    b.ToTable("Api");
                });

            modelBuilder.Entity("ResumeAPI.Models.Certifications", b =>
                {
                    b.Property<Guid>("CertificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("CredentialURL")
                        .IsRequired()
                        .HasColumnType("VARCHAR(225)");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("Date");

                    b.Property<string>("Issuer")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(525)");

                    b.Property<Guid?>("ResumeId")
                        .HasColumnType("uuid");

                    b.HasKey("CertificationId");

                    b.HasIndex("ResumeId");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("ResumeAPI.Models.Comments", b =>
                {
                    b.Property<Guid>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTime>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Massage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<Guid?>("ResumeId")
                        .HasColumnType("uuid");

                    b.HasKey("CommentId");

                    b.HasIndex("ResumeId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ResumeAPI.Models.Contacts", b =>
                {
                    b.Property<Guid>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTime>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("GitHub")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<Guid?>("ResumeId")
                        .HasColumnType("uuid");

                    b.HasKey("ContactId");

                    b.HasIndex("ResumeId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ResumeAPI.Models.Educations", b =>
                {
                    b.Property<Guid>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTime>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ResumeId")
                        .HasColumnType("uuid");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("EducationId");

                    b.HasIndex("ResumeId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("ResumeAPI.Models.Experiences", b =>
                {
                    b.Property<Guid>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string[]>("Responsibilities")
                        .HasColumnType("TEXT[]");

                    b.Property<Guid?>("ResumeId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("ExperienceId");

                    b.HasIndex("ResumeId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("ResumeAPI.Models.Projects", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTime>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Live")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Repo")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid?>("ResumeId")
                        .HasColumnType("uuid");

                    b.Property<string[]>("Stacks")
                        .HasColumnType("TEXT[]");

                    b.HasKey("ProjectId");

                    b.HasIndex("ResumeId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ResumeAPI.Models.Resume", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("AboutMe")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("Resume");
                });

            modelBuilder.Entity("ResumeAPI.RoutesList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ApiId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ApiId");

                    b.ToTable("RoutesList");
                });

            modelBuilder.Entity("ResumeAPI.Models.Certifications", b =>
                {
                    b.HasOne("ResumeAPI.Models.Resume", null)
                        .WithMany("Certifications")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeAPI.Models.Comments", b =>
                {
                    b.HasOne("ResumeAPI.Models.Resume", null)
                        .WithMany("Comments")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeAPI.Models.Contacts", b =>
                {
                    b.HasOne("ResumeAPI.Models.Resume", null)
                        .WithMany("Contacts")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeAPI.Models.Educations", b =>
                {
                    b.HasOne("ResumeAPI.Models.Resume", null)
                        .WithMany("Educations")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeAPI.Models.Experiences", b =>
                {
                    b.HasOne("ResumeAPI.Models.Resume", null)
                        .WithMany("Experiences")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeAPI.Models.Projects", b =>
                {
                    b.HasOne("ResumeAPI.Models.Resume", null)
                        .WithMany("Projects")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("ResumeAPI.RoutesList", b =>
                {
                    b.HasOne("ResumeAPI.Models.Api", "Api")
                        .WithMany("RoutesList")
                        .HasForeignKey("ApiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Api");
                });

            modelBuilder.Entity("ResumeAPI.Models.Api", b =>
                {
                    b.Navigation("RoutesList");
                });

            modelBuilder.Entity("ResumeAPI.Models.Resume", b =>
                {
                    b.Navigation("Certifications");

                    b.Navigation("Comments");

                    b.Navigation("Contacts");

                    b.Navigation("Educations");

                    b.Navigation("Experiences");

                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
