using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface ILogoService
    {
        Task<GetLogoResult> GetLogoAsync(GetLogoQuery query);
    }
}
