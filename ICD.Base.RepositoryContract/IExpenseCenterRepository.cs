using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System.Threading.Tasks;

namespace ICD.Base.RepositoryContract
{
    public interface IExpenseCenterRepository : IRepository<ExpenseCenterEntity, long>
    {
        Task<ListQueryResult<ExpenseCenterView>> GetExpenseCentersAsync(QueryDataSource<ExpenseCenterView> queryDataSource , int languageRef);
    }
}
