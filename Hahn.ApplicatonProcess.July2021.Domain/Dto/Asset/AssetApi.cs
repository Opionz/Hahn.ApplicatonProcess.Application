using System.Collections.Generic;

namespace Hahn.ApplicatonProcess.July2021.Domain.Dto.Asset
{
    public class AssetApi
    {
        public IEnumerable<AssetDto> Data { get; set; }
        public long TimeStamp { get; set; }
    }
}



