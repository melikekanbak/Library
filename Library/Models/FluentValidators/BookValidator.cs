using FluentValidation;

namespace Library.Models.FluentValidators
{
    public class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Zorunlu Alan!");
            RuleFor(x => x.PageCount)
                .NotEmpty()
                .NotNull()
                .WithMessage("Zorunlu Alan!")
                .Must(y => int.TryParse(y, out int value))
                .WithMessage("Lütfen Sayfayı sayı ile ifade edin.");
        }
    }
}
