using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System.Threading.Tasks;

namespace ICD.Base.RepositoryContract
{
    public interface IPersonRepository : IRepository<PersonEntity, long>
    {
        Task<ListQueryResult<PersonView>> GetPeoplesByTitleRefAndLanguageRef(QueryDataSource<PersonView> searchQuery, int languageRef);
    }
}
