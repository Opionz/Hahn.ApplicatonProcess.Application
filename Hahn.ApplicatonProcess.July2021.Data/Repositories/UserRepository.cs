using AutoMapper;
using Hahn.ApplicatonProcess.July2021.Data.Models;
using Hahn.ApplicatonProcess.July2021.Domain.Abstractions;
using Hahn.ApplicatonProcess.July2021.Domain.Dto;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.User;
using Hahn.ApplicatonProcess.July2021.Domain.Model;
using System;
using System.Linq;

namespace Hahn.ApplicatonProcess.July2021.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly HahnContext _hahnContext;
        private readonly IMapper _mapper;

        public UserRepository(HahnContext hahnContext, IMapper mapper)
        {
            _hahnContext = hahnContext;
            _mapper = mapper;
        }

        public ResponseModel<UserGetPutDto> Add(UserPostDto item)
        {
            try
            {
                var model = _mapper.Map<User>(item);
                _hahnContext.Users.Add(model);
                _hahnContext.SaveChanges();
                return ResponseModel<UserGetPutDto>.SuccessWithData(_mapper.Map<UserGetPutDto>(model));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public ResponseModel Delete(int item)
        {
            if (!_hahnContext.Users.Any(x => x.Id == item))
            {
                return ResponseModel.MakeError("User does not exisit.");
            }
            _hahnContext.Users.Remove(_hahnContext.Users.FirstOrDefault(x => x.Id == item));
            return _hahnContext.SaveChanges() > 1 ? ResponseModel.Success : ResponseModel.MakeError();
        }

        public ResponseModel<UserGetPutDto> Get(int id)
        {
            var model = _hahnContext.Users.FirstOrDefault(x => x.Id == id);
            return ResponseModel<UserGetPutDto>.SuccessWithData(_mapper.Map<UserGetPutDto>(model));
        }

        public ResponseModel Update(UserGetPutDto item)
        {
            var isAvailable = _hahnContext.Users.Any(x => x.Id == item.Id);
            if (isAvailable)
            {
                var model = _mapper.Map<User>(item);
                _hahnContext.Update(model);
                _hahnContext.SaveChanges();
                return ResponseModel.Success;
            }
            return ResponseModel.MakeError("the item was not found");
        }


    }
}
