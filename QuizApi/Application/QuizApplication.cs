
using Microsoft.EntityFrameworkCore;
using QuizApi.Entity;
using QuizApi.Repository;

namespace QuizApi.Application
{
    public class QuizApplication
    {
        private readonly QuizRepository _quizRepository;

        public QuizApplication(QuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }

        public async Task<List<Quiz>> ObterTodosQuizzes()
        {
            try
            {
                var quizes = await _quizRepository.GetAllQuizzes();
                if (quizes == null) return null;

                return quizes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<Quiz> GetQuizById (int id)
        {
            try
            {
                var quiz = await _quizRepository.GetQuizById(id);
                return quiz;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Quiz> CreateQuiz(string title, string image)
        {
            try
            {
                var quiz = await _quizRepository.CreateQuiz(title, image);
                return quiz;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}



//        public async Task<Quiz> CadastrarQuiz(string titulo, string descricao)
//        {
//            try
//            {

//                var quiz = new Quiz();
//                quiz.Title = titulo;
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
//                quiz.Title = titulo;
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
//                    return "Resposta errada";
//                }

//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }



//    }
//}
