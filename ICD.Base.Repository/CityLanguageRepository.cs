using ICD.Base.Domain.Entity;
using ICD.Base.RepositoryContract;
using ICD.Framework.Data.Repository;
using ICD.Framework.DataAnnotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Repository
{
    [Dependency(typeof(ICityLanguageRepository))]
    public class CityLanguageRepository : BaseRepository<CityLanguageEntity, int>, ICityLanguageRepository
    {

    }
}
