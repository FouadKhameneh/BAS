using ICD.Base.Domain.External_Entity.HRM;
using ICD.Base.RepositoryContract.External_Repository_Contract.HRM;
using ICD.Framework.Data.Repository;
using ICD.Framework.DataAnnotation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Repository.External_Repository.HRM
{
    [Dependency(typeof(ICompanyLanguageRepository))]
    public class CompanyLanguageRepository : BaseRepository<CompanyLanguageEntity , long> , ICompanyLanguageRepository
    {
    }
}
