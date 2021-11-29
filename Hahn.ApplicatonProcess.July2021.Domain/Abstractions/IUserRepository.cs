using Hahn.ApplicatonProcess.July2021.Domain.Dto.User;

namespace Hahn.ApplicatonProcess.July2021.Domain.Abstractions
{
    public interface IUserRepository : ICrudRepository<UserPostDto, UserGetPutDto>
    {

    }
}
