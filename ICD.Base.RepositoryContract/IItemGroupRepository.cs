using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System.Threading.Tasks;

namespace ICD.Base.RepositoryContract
{
    public interface IItemGroupRepository : IRepository<ItemGroupEntity, int>
    {
        Task<ListQueryResult<ItemGroupView>> GetItemGroupsByApplicationRef(QueryDataSource<ItemGroupView> searchQuery, int languageRef);

    }
}
