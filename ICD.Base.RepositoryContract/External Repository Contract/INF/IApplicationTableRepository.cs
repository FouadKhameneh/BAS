using ICD.Base.Domain.External_Entity.INF;
using ICD.Framework.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.RepositoryContract.External_Repository_Contract.INF
{
    public interface IApplicationTableRepository : IRepository<ApplicationTableEntity, long>
    {
    }
}
