using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QuizApi.Entity;

namespace QuizApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //public DbSet<Quiz> quizzes { get; set; }
        //public DbSet<Question> questoes { get; set; }


    }
}
