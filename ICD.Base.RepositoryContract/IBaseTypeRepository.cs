using ICD.Base.Domain.Entity;
using ICD.Framework.Data.Repository;

namespace ICD.Base.RepositoryContract
{
    public interface IBaseTypeRepository : IRepository<BaseTypeEntity, int> { }
}
