using ICD.Base.Domain.Entity;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.RepositoryContract
{
    public interface IPersonTestRepository : IRepository<PersonTestEntity,int>
    {
        Task<ListQueryResult<PersonTestEntity>> GetAllPersonTestsAsync(QueryDataSource<PersonTestEntity> queryDataSource);
    }
}
