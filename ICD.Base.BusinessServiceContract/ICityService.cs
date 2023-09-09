using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface ICityService
    {
        Task<BaseCityResult> InsertCityAsync(InsertCityRequest request);
        Task<BaseCityResult> UpdateCityAsync(UpdateCityRequest request);
        Task<DeleteTypeIntResult> DeleteCityAsync(DeleteTypeIntRequest request);
        Task<GetCityResult> GetCityAsync(GetCityQuery request);

    } 
}
