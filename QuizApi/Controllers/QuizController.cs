using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using QuizApi.Application;
using QuizApi.Entity;
using Microsoft.Data.SqlClient;
using System.Data;
using MySqlConnector;
using Dapper;
using QuizApi.Application;


//[Route("api/[controller]")]
//[ApiController]
//public class QuizController : ControllerBase
//{

//}

namespace QuizApi.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class QuizController : ControllerBase
    {
        private readonly QuizApplication _quizAplication;

        public QuizController(QuizApplication quizAplication)
        {
            _quizAplication = quizAplication;
        }

        [HttpGet]
        public IActionResult GetQuiz()
        {
            var quizData = new { live = true };
            return Ok(quizData);
        }

        // GET: api/<QuizController>
        [HttpGet("get-quizzes")]
        public async Task<ActionResult<List<Quiz>>> Get()
        {
            var quizes = await _quizAplication.ObterTodosQuizzes();
            return Ok(quizes);
        }

        // GET: api/<QuizController>
        [HttpGet("{id}")]
        public async Task<ActionResult<Quiz>> GetQuizById (int id)
        {
            var quiz = await _quizAplication.GetQuizById(id);
            return Ok(quiz);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Quiz quiz)
        {
            var create = await _quizAplication.CreateQuiz(quiz.Title, quiz.Image);
            return Ok(create);

        }
























            // GET: api/Items/5
            //[HttpGet("{id}")]
            //public async Task<ActionResult<Quiz>> Get(int id)
            //{
            //    using (IDbConnection conn = Connection)
            //    {
            //        string query = "SELECT Id, Title FROM QUIZ WHERE Id = @Id";
            //        conn.Open();
            //        var result = await conn.QueryAsync<Quiz>(query, new { Id = id });
            //        return result.FirstOrDefault();
            //    }
            //}


            //[HttpPost]
            //public async Task<IActionResult> Post([FromBody] Quiz quiz)
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


            //    // GET api/<QuizController>/5
            //    [HttpGet("obter-por-id/{id}")]
            //    public async Task<Quiz> ObterPorId(Guid id)
            //    {
            //        var quiz = await _quizAplication.ObterPorId(id);
            //        return quiz;
            //    }

            //    //POST api/<ContaBancariaController>
            //    [HttpPost("cadastrar-quiz")]
            //    public async Task<ActionResult<Quiz>> CadastrarQuiz(string titulo, string descricao)
            //    {
            //        var quiz = _quizAplication.CadastrarQuiz(titulo, descricao);
            //        return await quiz;
            //    }

            //    [HttpPut("alterar-por-id/{id}")]
            //    public async Task<ActionResult<Quiz>> AtualizarQuiz(Guid id, string titulo, string descricao)
            //    {
            //        var quiz = _quizAplication.AtualizarQuiz(id, titulo, descricao);
            //        return await quiz;
            //    }


            //    [HttpDelete("remover-por-id/{id}")]
            //    public async Task<Quiz> RemoverQuiz(Guid id)
            //    {
            //        var quiz = _quizAplication.RemoverQuiz(id);
            //        return await quiz;
            //    }


            //    [HttpPut("adicionar-pergunta/{id}")]
            //    public async Task<ActionResult<Quiz>> AdicionarPergunta(Guid id, string descricao, string a, string b, string c, string d, int correta)
            //    {
            //        var quiz = _quizAplication.AdicionarPergunta(id, descricao, a, b, c, d, correta);
            //        return await quiz;
            //    }

            //    [HttpPut("obter-perguntas-por-quizid/{id}")]
            //    public async Task<ActionResult<Quiz>> ObterPerguntasPorQuizId(Guid id)
            //    {
            //        // var quiz = _context.quizzes.Include(x => x.Perguntas).FirstOrDefault(x => x.Id == id);
            //        //return Ok(quiz);

            //        var quiz = _quizAplication.ObterPerguntasPorQuizId(id);
            //        return await quiz;
            //    }

            //    [HttpGet("responder-pergunta/{id}")]
            //    public async Task<ActionResult<String>> ResponderPergunta(Guid id, int resposta)
            //    {
            //        var resultado = _quizAplication.ResponderPergunta(id, resposta);
            //        return await resultado;
            //    }


        }
}
