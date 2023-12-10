using Dapper;
using MySqlConnector;
using QuizApi.Data;
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

    }
}
