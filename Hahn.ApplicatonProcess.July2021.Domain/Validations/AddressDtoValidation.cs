using FluentValidation;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.Address;

namespace Hahn.ApplicatonProcess.July2021.Domain.Validation
{
    public class AddressDtoValidation : AbstractValidator<AddressDto>
    {
        public AddressDtoValidation()
        {
            RuleFor(x => x.City).NotNull().NotEmpty();
            RuleFor(x => x.Street).NotNull().NotEmpty();
            RuleFor(x => x.PostalCode).NotNull().NotEmpty();
            RuleFor(x => x.HouseNumber).NotNull().NotEmpty();
        }
    }
}
