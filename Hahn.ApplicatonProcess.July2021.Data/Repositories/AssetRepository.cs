using Hahn.ApplicatonProcess.July2021.Domain.Abstractions;
using Hahn.ApplicatonProcess.July2021.Domain.Dto;
using Hahn.ApplicatonProcess.July2021.Domain.Dto.Asset;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.July2021.Data.Repositories
{

    public class AssetRepository : IAssetRepository
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ResponseModel<AssetApi>> GetAll()
        {
            try
            {
                var assets = await client.GetFromJsonAsync<AssetApi>(@"https://api.coincap.io/v2/assets");
                return ResponseModel<AssetApi>.SuccessWithData(assets);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return ResponseModel<AssetApi>.MakeError("An error occured while trying to get assets, Kindly check the logsto resolve this issue");
            }
        }
    }
}
