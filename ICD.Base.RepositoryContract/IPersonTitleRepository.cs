using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace ICD.Base.RepositoryContract
{
    public interface IPersonTitleRepository : IRepository<PersonTitleEntity, int>
    {
        Task<ListQueryResult<PersonTitleView>> GetPersonTitlesByLanguageRef(QueryDataSource<PersonTitleView> searchQuery, int languageRef);
    }
}
