using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System.Threading.Tasks;

namespace ICD.Base.RepositoryContract
{
    public interface IExpenseCenterLanguageRepository : IRepository<ExpenseCenterLanguageEntity, long>
    {
        Task<ListQueryResult<ExpenseCenterLanguageEntity>> GetExpenseCenterLanguagesAsync(QueryDataSource<ExpenseCenterLanguageEntity> queryDataSource, int languageRef);
    }
}
