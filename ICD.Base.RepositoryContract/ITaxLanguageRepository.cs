using ICD.Base.Domain.Entity;
using ICD.Framework.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.RepositoryContract
{
    public interface ITaxLanguageRepository : IRepository<TaxLanguageEntity, int>
    {
    }
}
