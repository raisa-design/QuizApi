

















//using Microsoft.EntityFrameworkCore;
//using QuizApi.Data;
//using QuizApi.Entidade;

//namespace QuizApi.Application
//{
//    public class QuizAplication
//    {

//        private readonly DataContext _context;

//        public QuizAplication(DataContext context)
//        {
//            _context = context;
//        }

//        public async Task<List<Quiz>> ObterTodosQuizes()
//        {
//            try
//            {
//                var quizes = await _context.quizzes.ToListAsync();
//                if (quizes == null) return null;

//                return quizes;
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }

//        public async Task<Quiz> ObterPorId(Guid id)
//        {
//            try
//            {
//                var quiz = await _context.quizzes.FirstOrDefaultAsync(x => x.Id == id);
//                return quiz;

//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }


//        public async Task<Quiz> CadastrarQuiz( string titulo, string descricao)
//        {
//            try
//            {

//                var quiz = new Quiz();
//                quiz.Titulo = titulo;
//                quiz.Descricao = descricao;
//                _context.quizzes.Add(quiz);
//                _context.SaveChanges();
//                return quiz;

//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }

//        public async Task<Quiz> AtualizarQuiz(Guid id, string titulo, string descricao)
//        {
//            try
//            {

//                var quiz = await _context.quizzes.FirstOrDefaultAsync(quiz => quiz.Id == id);
//                quiz.Titulo = titulo;
//                quiz.Descricao = descricao;
//                _context.quizzes.Update(quiz);
//                _context.SaveChangesAsync();
//                return quiz;

//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }
//        public async Task<Quiz> RemoverQuiz(Guid id)
//        {
//            try
//            {

//                var quiz = _context.quizzes.Find(id);
//                _context.Remove(quiz);
//                _context.SaveChangesAsync();
//                return quiz;

//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }

//        public async Task<Quiz> AdicionarPergunta(Guid id, string descricao, string a, string b, string c, string d, int correta)
//        {
//            try
//            {

//                var quiz = _context.quizzes.FirstOrDefault(quiz => quiz.Id == id);

//                var pergunta = new Pergunta();
//                pergunta.Descricao = descricao;
//                pergunta.AlternativaA = a;
//                pergunta.AlternativaB = b;
//                pergunta.AlternativaC = c;
//                pergunta.AlternativaD = d;
//                pergunta.AlternativaCorreta = correta;

//                quiz.Perguntas.Add(pergunta);

//                _context.quizzes.Update(quiz);
//                _context.SaveChangesAsync();
//                return quiz;

//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }


//        public async Task<Quiz> ObterPerguntasPorQuizId(Guid id)
//        {
//            try
//            {

//                var quiz = _context.quizzes.Include(x => x.Perguntas).FirstOrDefault(x => x.Id == id);
//                return quiz;

//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }

//        public async Task<String> ResponderPergunta(Guid id, int resposta)
//        {
//            try
//            {

//                var pergunta = _context.perguntas.FirstOrDefault(x => x.Id == id);
//                if (pergunta.ResponderPergunta(resposta) == true)
//                {
//                    return "Resposta correta";
//                }
//                else
//                {
//                     return "Resposta errada";
//                }

//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }



//    }
//}
