using ICD.Base.BusinessServiceContract;
using ICD.Base.Domain.Entity;
using ICD.Base.RepositoryContract;
using ICD.Framework.AppMapper.Extensions;
using ICD.Framework.Data.UnitOfWork;
using ICD.Framework.DataAnnotation;
using ICD.Infrastructure.Exception;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ICD.Base.BusinessService
{
    [Dependency(typeof(IBaseTypeService))]
    public class BaseTypeService : IBaseTypeService
    {
        private readonly IUnitOfWork _db;
        private readonly IBaseTypeRepository _baseTypeRepository;
        private readonly IPersonRepository _personRepository;
        private readonly IPersonBaseTypeRepository _personBaseTypeRepository;

        public BaseTypeService(IUnitOfWork db)
        {
            _db = db;
            _baseTypeRepository = _db.GetRepository<IBaseTypeRepository>();
            _personRepository = _db.GetRepository<IPersonRepository>();
            _personBaseTypeRepository = _db.GetRepository<IPersonBaseTypeRepository>();
        }
        public async Task<BaseTypeResult> InsertBaseTypeAsync(InsertBaseTypeRequest request)
        {
            var baseTypeEntity = request.MapTo<BaseTypeEntity>();
            baseTypeEntity.personBaseTypes.Add(new PersonBaseTypeEntity { PersonRef = request.PersonRef });
            await _baseTypeRepository.AddAsync(baseTypeEntity);

            await _db.SaveChangesAsync();

            return new BaseTypeResult();
        }

        public async Task<BasePersonBaseTypeResult> InsertPersonBaseTypeAsync(InsertPersonBaseTypeRequest request)
        {
            var personBaseTypeEntity = request.MapTo<PersonBaseTypeEntity>();
            await _personBaseTypeRepository.AddAsync(personBaseTypeEntity);

            await _db.SaveChangesAsync();
            return new BasePersonBaseTypeResult();
        }

        public async Task<BaseTypeResult> DeletePersonBaseTypeAsync(DeleteBaseTypeRequest request)
        {
            var result = new BaseTypeResult();

            var baseTypeEntity = await _baseTypeRepository.FirstOrDefaultAsync(bt => bt.Alias == request.Alias);
            var baseTypeKey = baseTypeEntity.Key;

            await _personBaseTypeRepository.DeleteWithAsync(pbt => pbt.PersonRef == request.PersonRef && pbt.BaseTypeRef == baseTypeKey);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {

                SqlErrorHandling.Handler(e);
            }

            result.Success = true;
            return result;
        }

        public async Task<GetBaseTypeKeyByAliasResult> GetBaseTypeKeyByAliasAsync(GetBaseTypeKeyByAliasQuery query)
        {
            var result = new GetBaseTypeKeyByAliasResult
            {
                Entity = new GetBaseTypeKeyByAliasModel(),
                Success = false
            };

            var baseTypeKey = (await _baseTypeRepository.FirstOrDefaultAsync(bt => bt.Alias == query.Alias)).Key;

            result.Entity.BaseTypeKey = baseTypeKey;
            result.Success = true;

            return result;
        }
    }
}
