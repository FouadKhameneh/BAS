using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System.Threading.Tasks;

namespace ICD.Base.RepositoryContract
{
    public interface IItemRowRepository : IRepository<ItemRowEntity, int>
    {
        Task<ListQueryResult<ItemRowView>> GetItemRowsByItemGroupRef(QueryDataSource<ItemRowView> searchQuery, int languageRef);
        Task<ListQueryResult<ItemRowByKeyView>> GetItemRowByKeyAsync(QueryDataSource<ItemRowByKeyView> queryDataSource, int languageRef);
    }
}
