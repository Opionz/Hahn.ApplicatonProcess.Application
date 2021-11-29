using Hahn.ApplicatonProcess.July2021.Domain.Abstractions;
using Hahn.ApplicatonProcess.July2021.Domain.Dto;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.Asset;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.July2021.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetRepository _assetRepository;

        public AssetsController(IAssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
        }

        /// <summary>
        /// Get all assets from an online API.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseModel<AssetApi>> Get()
        {
            return await _assetRepository.GetAll();
        }
    }
}
