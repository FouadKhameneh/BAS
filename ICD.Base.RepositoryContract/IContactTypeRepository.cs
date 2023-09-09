using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.RepositoryContract
{
    public interface IContactTypeRepository : IRepository<ContactTypeEntity, int>
    {
        Task<ListQueryResult<ContactTypeView>> GetContactTypeAsync(QueryDataSource<ContactTypeView> searchQuery, int languageRef);
    }
}
