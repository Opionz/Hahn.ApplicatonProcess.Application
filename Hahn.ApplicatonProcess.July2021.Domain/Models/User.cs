using System.Collections.Generic;

namespace Hahn.ApplicatonProcess.July2021.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Asset> Assets { get; set; }
        public Address Address { get; set; }
    }
}