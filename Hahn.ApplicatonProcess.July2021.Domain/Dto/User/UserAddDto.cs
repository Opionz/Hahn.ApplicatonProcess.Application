 using Hahn.ApplicatonProcess.July2021.Domain.Dto.Address;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.Asset;
using System.Collections.Generic;

namespace Hahn.ApplicatonProcess.July2021.Domain.Dto.User
{
    public class UserPostDto
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<AssetDto> Assets { get; set; }
        public AddressDto Address { get; set; }
    }
}
