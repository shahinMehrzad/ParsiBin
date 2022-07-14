using ParsiBin.Application.Common.Validation;

namespace ParsiBin.Application.Identity.Users.Password
{
    public class ForgotPasswordRequest
    {
        public string Email { get; set; } = default!;
    }

    public class ForgotPasswordRequestValidator : CustomValidator<ForgotPasswordRequest>
    {
        public ForgotPasswordRequestValidator() =>
            RuleFor(p => p.Email).Cascade(CascadeMode.Stop)
                .NotEmpty()
                .EmailAddress()
                    .WithMessage("Invalid Email Address.");
    }
}
