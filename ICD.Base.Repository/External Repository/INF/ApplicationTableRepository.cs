using ICD.Base.Domain.External_Entity.INF;
using ICD.Base.RepositoryContract.External_Repository_Contract.INF;
using ICD.Framework.Data.Repository;
using ICD.Framework.DataAnnotation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Repository.External_Repository.INF
{
    [Dependency(typeof(IApplicationTableRepository))]
    public class ApplicationTableRepository : BaseRepository<ApplicationTableEntity, long>, IApplicationTableRepository
    {
    }
}
