using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
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
    public interface ICityRepository : IRepository<CityEntity, int>
    {
        Task<ListQueryResult<CityView>> GetCityAsync(QueryDataSource<CityView> searchQuery, int languageRef);
    }
}

