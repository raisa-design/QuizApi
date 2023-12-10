namespace quizapi.entity
{
    public class Question
    {

        public int Id { get; set; }
        public string Enunciation { get; set; }
        public int QuizId { get; set; }
        public string Image { get; set; }

        public string CorrectAnswer { get; set; }
        
        


        //public bool responderpergunta(int resposta)
        //{
        //    if (resposta == alternativacorreta)
        //    {
        //        return true;
        //    }
        //    else
        //    {

        //        return false;
        //    };

        //}

    }
}
