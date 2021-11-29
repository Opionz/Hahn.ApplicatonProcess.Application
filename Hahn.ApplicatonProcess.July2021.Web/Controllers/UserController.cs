using Hahn.ApplicatonProcess.July2021.Domain.Abstractions;
using Hahn.ApplicatonProcess.July2021.Domain.Dto;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.User;
using Hahn.ApplicatonProcess.July2021.Web.Swagger.DefaultValues;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using System.Runtime.CompilerServices;

namespace Hahn.ApplicatonProcess.July2021.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Get a user, its address, and its assets by passing id
        /// </summary>
        /// <param name="id">the id of user (it is numeric)</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ResponseModel<UserGetPutDto> Get(int id)
        {
            return _userRepository.Get(id);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [SwaggerRequestExample(typeof(UserPostDto), typeof(UserDtoDefault))]

        //<summary>
        //Post a user, its address, and its assets to server, you can update them later.
        //</summary>
        [HttpPost]
        public ActionResult Post([FromBody] UserPostDto user)
        {
            var model = _userRepository.Add(user);
            return CreatedAtAction(nameof(Get), new { id = model.Data.Id }, model);

        }

        /// <summary>
        /// Update a User, and its Assets
        /// </summary>
        /// <param name="userGetPut">User data, note that you have to pass the ID</param>
        /// <returns></returns>
        [HttpPut]
        public ResponseModel Put([FromBody] UserGetPutDto userGetPut)
        {
            return _userRepository.Update(userGetPut);
        }

        /// <summary>
        /// Delete a user by passing Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ResponseModel Delete(int id)
        {
            return _userRepository.Delete(id);
        }
    }
}
