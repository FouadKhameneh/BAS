using ICD.Base.Domain.Entity;
using ICD.Framework.Data.Repository;

namespace ICD.Base.RepositoryContract
{
    public interface ILocationTypeRepository : IRepository<LocationTypeEntity, int> { }
}
