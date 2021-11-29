using FluentValidation;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.User;

namespace Hahn.ApplicatonProcess.July2021.Domain.Validation
{
    public class UserPostDtoValidation : AbstractValidator<UserPostDto>
    {
        public UserPostDtoValidation()
        {
            RuleFor(x => x.FirstName).MinimumLength(3);
            RuleFor(x => x.LastName).MinimumLength(3);
            RuleFor(x => x.Age).GreaterThanOrEqualTo(18);
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
