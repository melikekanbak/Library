using FluentValidation;

namespace Library.Models.FluentValidators
{
    public class AuthorValidator:AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.FirstName)
              .NotEmpty()
              .NotNull()
              .WithMessage("Zorunlu Alan!")
              .MinimumLength(3)
              .WithMessage("İsim en az 3 haneli olmalıdır.");
            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Zorunlu Alan!")
                .MinimumLength(2)
                .WithMessage("İsim en az 3 haneli olmalıdır.");


        }
    }
}
