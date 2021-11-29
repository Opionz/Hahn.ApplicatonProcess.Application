using Hahn.ApplicatonProcess.July2021.Domain.Dto;

namespace Hahn.ApplicatonProcess.July2021.Domain.Abstractions
{
    /// <summary>
    /// CRUD operation are handled in this interface.
    /// </summary>
    /// <typeparam name="PostDto">A Dto without Id (because Id is going to being generated automatically</typeparam>
    /// <typeparam name="GetPutDto">A Dto with Id</typeparam>
    public interface ICrudRepository<PostDto, GetPutDto>
    {
        public ResponseModel<GetPutDto> Get(int id);
        public ResponseModel<GetPutDto> Add(PostDto item);
        public ResponseModel Update(GetPutDto item);
        public ResponseModel Delete(int item);
    }
}
