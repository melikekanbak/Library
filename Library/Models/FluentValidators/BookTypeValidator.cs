using FluentValidation;

namespace Library.Models.FluentValidators
{
    public class BookTypeValidator : AbstractValidator<BookType>
    {
        public BookTypeValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty()
           .NotNull()
           .WithMessage("Zorunlu Alan!");
        }
     
    }
}
