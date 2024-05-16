using Application.Dtos;
using Application.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Domain.Entities;


namespace Infastructure
{
    public class ProgramDbContext: DbContext
    {
        private object options;
        public ProgramDbContext() { }
        public ProgramDbContext(object options)
        {
            this.options = options;
        }

        public DbSet<ProgramEntity>? Program { get; set; }
        public DbSet<SubmissionEntity>? Answer { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();

                string connectionString1 = configuration.GetConnectionString("CosmosDBConnection1");
                string connectionString2 = configuration.GetConnectionString("CosmosDBConnection2");

                optionsBuilder.UseCosmos(connectionString1, connectionString2, "submission_form_db");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgramEntity>()
                .HasMany(p => p.Questions)
                .WithOne(q => q.Program)
                .HasForeignKey(q => q.ProgramId);

            modelBuilder.Entity<QuestionEntity>()
                .HasOne(p => p.QuestionType)
                .WithOne(q => q.QuestionEntity);

            modelBuilder.Entity<SubmissionEntity>()
                .HasMany(s => s.Questions)
                .WithOne(q => q.Submission)
                .HasForeignKey(q => q.SubmissionId);

            modelBuilder.Entity<SubmissionQuestionEntity>()
                .HasOne(s => s.QuestionType)
                .WithOne(qt => qt.QuestionEntity);
        }
    }
}
