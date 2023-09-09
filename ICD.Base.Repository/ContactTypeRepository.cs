using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Base.RepositoryContract;
using ICD.Framework.Data.Repository;
using ICD.Framework.DataAnnotation;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ICD.Framework.Extensions;
using System.Security.Cryptography.X509Certificates;

namespace ICD.Base.Repository
{
    [Dependency(typeof(IContactTypeRepository))]
    public class ContactTypeRepository : BaseRepository<ContactTypeEntity, int>, IContactTypeRepository
    {
        public async Task<ListQueryResult<ContactTypeView>> GetContactTypeAsync(QueryDataSource<ContactTypeView> searchQuery, int languageRef)
        {
            var finalResult = new ListQueryResult<ContactTypeView>
            {
                Entities = new List<ContactTypeView>()
            };

            var queryResult = from ct in GenericRepository.Query<ContactTypeEntity>()

                              join ctl in GenericRepository.Query<ContactTypeLanguageEntity>() on ct.Key equals ctl.ContactTypeRef

                              where ctl.LanguageRef == languageRef

                              select new ContactTypeView
                              {
                                  Key = ct.Key,
                                  Alias = ct.Alias,
                                  IsActive = ct.IsActive,
                                  ContactTypeRef = ctl.ContactTypeRef,
                                  LanguageRef = ctl.LanguageRef,
                                  _Title = ctl._Title
                              };

            var result = await queryResult.ToListQueryResultAsync(searchQuery);

            finalResult = result;

            return finalResult;
        }
    }
}
