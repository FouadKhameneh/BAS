using ICD.Base.Domain.Entity;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System.Threading.Tasks;

namespace ICD.Base.RepositoryContract
{
    public interface IPersonIdentityRepository : IRepository<PersonIdentityEntity, int> 
    {
    }
}
