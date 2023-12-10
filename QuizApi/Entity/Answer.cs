namespace QuizApi.Entity
{
    public class Answer
    {


        public int Id { get; set; }
        public string Text { get; set;}

        public int QuestionId { get; set; }

        public string Image { get; set; }
    }
}
