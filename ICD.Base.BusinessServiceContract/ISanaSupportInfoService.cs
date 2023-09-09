using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface ISanaSupportInfoService 
    {
        Task<BaseSanaSupportInfoResult> InsertSanaSupportInfoAsync(InsertSanaSupportInfoRequest request);
        Task<BaseSanaSupportInfoResult> UpdateSanaSupportInfoAsync(UpdateSanaSupportInfoRequest request);
        Task<DeleteTypeIntResult> DeleteSanaSupportInfoAsync(DeleteTypeIntRequest request);
        Task<GetSanaSupportInfoResult> GetSanaSupportInfoAsync(GetSanaSupportInfoQuery query);
    }
}
