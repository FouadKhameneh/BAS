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

namespace ICD.Base.Repository
{
    [Dependency(typeof(ICostTypeRepository))]
    public class CostTypeRepository : BaseRepository<CostTypeEntity, short>, ICostTypeRepository
    {
        public async Task<ListQueryResult<CostTypeView>> GetCostTypeAsync(QueryDataSource<CostTypeView> searchQuery, int languageRef)
        {
            var result = new ListQueryResult<CostTypeView>
            {
                Entities = new List<CostTypeView>()
            };

            var queryResult = from c in GenericRepository.Query<CostTypeEntity>()
                              join cl in GenericRepository.Query<CostTypeLanguageEntity>() on c.Key equals cl.CostTypeRef
                              join sht in GenericRepository.Query<ItemRowLanguageEntity>() on c.ItemRowRef_SharingType equals sht.ItemRowRef
                              join cot in GenericRepository.Query<ItemRowLanguageEntity>() on c.ItemRowRef_CostOrigin equals cot.ItemRowRef

                              join ctt in GenericRepository.Query<CostTypeTaxEntity>() on c.Key equals ctt.CostTypeRef
                              into leftCtt
                              from ctt in leftCtt.DefaultIfEmpty()

                              join tax in GenericRepository.Query<TaxEntity>() on ctt.TaxRef equals tax.Key
                              into leftTax
                              from tax in leftTax.DefaultIfEmpty()

                              where cl.LanguageRef == languageRef &&
                              sht.LanguageRef == languageRef

                              select new CostTypeView
                              {
                                  Key = c.Key,
                                  IsActive = c.IsActive,
                                  CostSign = c.CostSign,
                                  CompanyRef = c.CompanyRef,
                                  ItemRowRef_CostOrigin = c.ItemRowRef_CostOrigin,
                                  ItemRowRef_CostOriginTitle = cot._Title,
                                  ItemRowRef_SharingType = c.ItemRowRef_SharingType,
                                  _Title = cl._Title,
                                  _Description = cl._Description,
                                  ItemRow_SharingTypeTitle = sht._Title,
                                  TaxRef = ctt.TaxRef,
                                  TaxAlias = tax.Alias,
                                  TaxIsActive = tax.IsActive,
                                  TaxPercent = tax.TaxPercent
                              };

            result = await queryResult.ToListQueryResultAsync(searchQuery);

            return result;
        }
    }
}
