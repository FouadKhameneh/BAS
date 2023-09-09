using ICD.Base.Domain.External_Entity.HRM;
using ICD.Framework.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.RepositoryContract.External_Repository_Contract.HRM
{
    public interface ICompanyLanguageRepository : IRepository<CompanyLanguageEntity , long>
    {
    }
}
