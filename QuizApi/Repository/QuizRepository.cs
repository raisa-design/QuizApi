using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using QuizApi.Entity;
using System.Data;

namespace QuizApi.Repository
{
    public class QuizRepository
    {
        private readonly IDbConnection _connection;

        public QuizRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<Quiz>> GetAllQuizzes()
        {
            using (_connection)
            {
                string query = "SELECT * FROM QUIZ";
                _connection.Open();
                var result = await _connection.QueryAsync<Quiz>(query);
                return(result.ToList());
            }
        }

        public async Task<Quiz> GetQuizById( int id)
        {
            using (_connection)
            {
                string query = "SELECT * FROM QUIZ WHERE ID = @Id";
                _connection.Open();
                var result = await _connection.QueryAsync<Quiz>(query, new { Id = id });
                 return  result.FirstOrDefault();
               
            }

        }

        public async Task<Quiz> CreateQuiz( string title, string image)
        {
            using (_connection)
            {
                var quiz=new Quiz(){
                    Title=title,
                    Image = image
                };
                string query = "INSERT INTO QUIZ ( TITLE, IMAGE) VALUES (@Title, @Image)";
                _connection.Open();
                var result = await _connection.ExecuteAsync(query, quiz);
                return quiz;

               // public async Task<IActionResult> Post([FromBody] Quiz quiz)
        //{
        //    using (IDbConnection conn = Connection)
        //    {
        //        var title = quiz.Title;
        //        var image = quiz.Image;
        //        string sQuery = "INSERT INTO Quiz (Title, Image) VALUES(@title, @image)";
        //        conn.Open();
        //        var result = await conn.ExecuteAsync(sQuery, quiz);
        //        return Ok(result);
        //    }
        //}

            }

        }

    }
}
