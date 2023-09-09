using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IPersonContactService
    {
        Task<BasePersonContactResult> InsertPersonContactAsync(InsertPersonContactRequest request);
        Task<GetPersonContactResult> GetPersonContactAsync(GetPersonContactQuery query);
    }
}
