﻿//// <auto-generated />
//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
////using QuizApi.Data;

//#nullable disable

//namespace QuizApi.Migrations
//{
//   // [DbContext(typeof(DataContext))]
//    partial class DataContextModelSnapshot : ModelSnapshot
//    {
//        protected override void BuildModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

//            modelBuilder.Entity("QuizApi.Entidade.Pergunta", b =>
//                {
//                    b.Property<Guid>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("TEXT");

//                    b.Property<string>("AlternativaA")
//                        .IsRequired()
//                        .HasColumnType("TEXT");

//                    b.Property<string>("AlternativaB")
//                        .IsRequired()
//                        .HasColumnType("TEXT");

//                    b.Property<string>("AlternativaC")
//                        .IsRequired()
//                        .HasColumnType("TEXT");

//                    b.Property<int>("AlternativaCorreta")
//                        .HasColumnType("INTEGER");

//                    b.Property<string>("AlternativaD")
//                        .IsRequired()
//                        .HasColumnType("TEXT");

//                    b.Property<string>("Descricao")
//                        .IsRequired()
//                        .HasColumnType("TEXT");

//                    b.Property<Guid>("QuizId")
//                        .HasColumnType("TEXT");

//                    b.HasKey("Id");

//                    b.HasIndex("QuizId");

//                    b.ToTable("perguntas");
//                });

//            modelBuilder.Entity("QuizApi.Entidade.Quiz", b =>
//                {
//                    b.Property<Guid>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("TEXT");

//                    b.Property<string>("Descricao")
//                        .IsRequired()
//                        .HasColumnType("TEXT");

//                    b.Property<string>("Titulo")
//                        .IsRequired()
//                        .HasColumnType("TEXT");

//                    b.HasKey("Id");

//                    b.ToTable("quizzes");
//                });

//            modelBuilder.Entity("QuizApi.Entidade.Pergunta", b =>
//                {
//                    b.HasOne("QuizApi.Entidade.Quiz", "Quiz")
//                        .WithMany("Perguntas")
//                        .HasForeignKey("QuizId")
//                        .OnDelete(DeleteBehavior.Cascade)
//                        .IsRequired();

//                    b.Navigation("Quiz");
//                });

//            modelBuilder.Entity("QuizApi.Entidade.Quiz", b =>
//                {
//                    b.Navigation("Perguntas");
//                });
//#pragma warning restore 612, 618
//        }
//    }
//}