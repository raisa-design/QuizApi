using System.ComponentModel.DataAnnotations;

namespace QuizApi.Entity
{
    public class Quiz
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image{ get; set; }

        
    }
}
