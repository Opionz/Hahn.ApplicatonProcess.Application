using Hahn.ApplicatonProcess.July2021.Domain.Dto.Address;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.Asset;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.User;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace Hahn.ApplicatonProcess.July2021.Web.Swagger.DefaultValues
{
    public class UserDtoDefault : IExamplesProvider<UserPostDto>
    {
        public UserPostDto GetExamples()
        {
            return new UserPostDto
            {
                Age = 20,
                FirstName = "Opeyemi",
                LastName = "Ajayi",
                Email = "ope.ajayi@hotmail.com",
                Address = new AddressDto
                {
                    City = "Lagos",
                    Street = "Lagos",
                    HouseNumber = "182",
                    PostalCode = "1827765"
                },
                Assets = new List<AssetDto>
                {
                    new AssetDto { Id = "abc", Name = "opeyemi", Symbol = "cr7" },
                    new AssetDto { Id = "def", Name = "oluwatobiloba", Symbol = "ogs" }
                }
            };
        }
    }
}
