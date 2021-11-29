using Hahn.ApplicatonProcess.July2021.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hahn.ApplicatonProcess.July2021.Data.Models.Configurations
{

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.OwnsOne(x => x.Address)
                .WithOwner(x => x.User);

            builder.OwnsMany(x => x.Assets)
                .WithOwner(x => x.User);
        }
    }
}
