using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using FluentValidation;
namespace QuizApi.Entity
{
    public class Quiz : AbstractValidator<Quiz>
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image{ get; set; }


    }
}
