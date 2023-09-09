using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IGLNService
    {
        Task<InsertGLNResult> InsertGLNAsync(InsertGLNRequest request);
        Task<InsertListGlnResult> InsertListGLNAsync(InsertListGlnRequest request);
        Task<InsertListLegalGLNResult> InsertListLegalGLNAsync(InsertListLegalGLNRequest request);
        Task<GetGLNResult> GetGLNAsync(GetGLNQuery query);
        Task<BaseGLNResult> UpdateGLNAsync(UpdateGLNRequest request);
        Task<DeleteTypeLongResult> DeleteGLNByIdAsync(DeleteTypeLongRequest request);
        Task<GetGLNByCompanyResult> GetGLNByCompanyAsync(GetGLNByCompanyQuery query);
        Task<GetGLNByKeyResult> GetGLNByKeyAsync(GetGLNByKeyQuery query);
    }
}
