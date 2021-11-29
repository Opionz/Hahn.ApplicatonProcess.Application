namespace Hahn.ApplicatonProcess.July2021.Domain.Model
{
    public class Asset
    {
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public virtual User User { get; set; }
    }
}
