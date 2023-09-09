using ICD.Base.Domain.External_Entity.HRM;
using ICD.Base.RepositoryContract.External_Repository_Contract.HRM;
using ICD.Framework.Data.Repository;
using ICD.Framework.DataAnnotation;

namespace ICD.Base.Repository.External_Repository.HRM
{
    [Dependency(typeof(ICompanyRepository))]
    public class CompanyRepository : BaseRepository<CompanyEntity, short>, ICompanyRepository { }
}
