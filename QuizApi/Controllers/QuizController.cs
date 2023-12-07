using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class QuizController : ControllerBase
{
    [HttpGet]
    public IActionResult GetQuiz()
    {
        var quizData = new { live = true };
        return Ok(quizData);
    }
}







//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using QuizApi.Application;
//using QuizApi.Data;
//using QuizApi.Entidade;


//namespace QuizApi.Controllers
//{
//    [Route("[controller]")]
//    [ApiController]

//    public class QuizController : ControllerBase
//    {
//        private readonly DataContext _context;
//        private readonly QuizAplication _quizAplication;

//        public QuizController(DataContext context, QuizAplication quizAplication)
//        {
//            _context = context;
//            _quizAplication = quizAplication;
//        }
//        // GET: api/<QuizController>
//        [HttpGet("obter-todos")]
//        public async Task<List<Quiz>> ObterTodos()
//        {
//            var quizes = _quizAplication.ObterTodosQuizes();
//            return await quizes;  
//        }

//        // GET api/<QuizController>/5
//        [HttpGet("obter-por-id/{id}")]
//        public async Task<Quiz> ObterPorId(Guid id)
//        {
//            var quiz =await _quizAplication.ObterPorId(id);
//            return quiz;
//        }

//        //POST api/<ContaBancariaController>
//        [HttpPost("cadastrar-quiz")]
//         public async Task<ActionResult<Quiz>> CadastrarQuiz(string titulo, string descricao)
//        {
//            var quiz = _quizAplication.CadastrarQuiz (titulo, descricao);
//            return await quiz;
//        }

//        [HttpPut("alterar-por-id/{id}")]
//        public async Task<ActionResult<Quiz>> AtualizarQuiz(Guid id, string titulo, string descricao)
//        {
//            var quiz =  _quizAplication.AtualizarQuiz(id, titulo, descricao);
//            return await quiz;
//        }


//        [HttpDelete("remover-por-id/{id}")]
//        public async Task<Quiz> RemoverQuiz(Guid id)
//        {
//            var quiz = _quizAplication.RemoverQuiz(id);
//            return await quiz;
//        }


//        [HttpPut("adicionar-pergunta/{id}")]
//        public async Task <ActionResult<Quiz>> AdicionarPergunta(Guid id, string descricao, string a, string b, string c, string d, int correta)
//        {
//            var quiz =  _quizAplication.AdicionarPergunta(id,descricao,a,b,c,d,correta);
//            return await quiz;
//        }

//        [HttpPut("obter-perguntas-por-quizid/{id}")]
//        public  async Task <ActionResult<Quiz>> ObterPerguntasPorQuizId(Guid id)
//        {
//           // var quiz = _context.quizzes.Include(x => x.Perguntas).FirstOrDefault(x => x.Id == id);
//            //return Ok(quiz);

//            var quiz =  _quizAplication.ObterPerguntasPorQuizId(id);
//            return await quiz;
//        }

//        [HttpGet("responder-pergunta/{id}")]
//        public async Task<ActionResult<String>> ResponderPergunta(Guid id, int resposta)
//        {
//            var resultado = _quizAplication.ResponderPergunta(id, resposta);
//            return await resultado;
//        }


//    }
//}