using Hahn.ApplicatonProcess.July2021.Domain.Dto;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.Asset;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.July2021.Domain.Abstractions
{
    public interface IAssetRepository
    {

        /// <summary>
        /// Get all the live data from REST API.
        /// </summary>
        public Task<ResponseModel<AssetApi>> GetAll();
    }
}
