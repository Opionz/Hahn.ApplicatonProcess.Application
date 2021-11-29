using AutoMapper;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.Address;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.Asset;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.User;
using Hahn.ApplicatonProcess.July2021.Domain.Model;

namespace Hahn.ApplicatonProcess.July2021.Data.AutoMapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User, UserGetPutDto>().ReverseMap();
            CreateMap<User, UserPostDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Asset, AssetDto>().ReverseMap();
        }
    }
}
