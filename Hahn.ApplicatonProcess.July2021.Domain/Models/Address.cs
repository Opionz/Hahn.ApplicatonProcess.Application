namespace Hahn.ApplicatonProcess.July2021.Domain.Model
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string HouseNumber { get; set; }
        public virtual User User { get; set; }
    }
}
