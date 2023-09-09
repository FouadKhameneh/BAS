using ICD.Framework.Data.Repository;
using ICD.Base.Domain.External_Entity.HRM;

namespace ICD.Base.RepositoryContract.External_Repository_Contract.HRM
{
    public interface ICompanyRepository : IRepository<CompanyEntity, short> { }
}
