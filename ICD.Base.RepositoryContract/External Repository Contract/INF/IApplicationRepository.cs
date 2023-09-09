using ICD.Base.Domain.External_Entity.INF;
using ICD.Base.Domain.External_View;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.RepositoryContract.External_Repository_Contract.INF
{
    public interface IApplicationRepository : IRepository<ApplicationEntity, long>
    {
        Task<ListQueryResult<ApplicationKeyView>> GetApplicationKeyAsync(QueryDataSource<ApplicationKeyView> searchQuery);
    }
}
