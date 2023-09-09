using ICD.Base.BusinessServiceContract;
using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Base.RepositoryContract;
using ICD.Framework.AppMapper.Extensions;
using ICD.Framework.Data.UnitOfWork;
using ICD.Framework.DataAnnotation;
using ICD.Framework.Extensions;
using ICD.Framework.QueryDataSource.Fitlter;
using ICD.Framework.QueryDataSource;
using ICD.Infrastructure.BusinessServiceContract;
using ICD.Infrastructure.Exception;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessService
{
    [Dependency(typeof(IContactTypeService))]
    public class ContactTypeService : IContactTypeService
    {
        private readonly IUnitOfWork _db;
        private readonly IContactTypeRepository _contactTypeRepository;
        private readonly IContactTypeLanguageRepository _contactTypeLanguageRepository;
        private readonly IEntityService _entityService;

        public ContactTypeService(IUnitOfWork db, IEntityService entityService)
        {
            _db = db;
            _contactTypeRepository = _db.GetRepository<IContactTypeRepository>();
            _contactTypeLanguageRepository = _db.GetRepository<IContactTypeLanguageRepository>();
            _entityService = entityService;
        }

        public async Task<DeleteTypeIntResult> DeleteContactTypeByIdAsync(DeleteTypeIntRequest request)
        {
            var result = new DeleteTypeIntResult();

            await _contactTypeRepository.DeleteWithAsync(ct => ct.Key == request.Key);
            await _contactTypeLanguageRepository.DeleteWithAsync(ctl => ctl.ContactTypeRef == request.Key);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {

                SqlErrorHandling.Handler(e);
            }

            if (result != null)
            {
                result.Success = true;
                return result;
            }
            return result;
        }

        public async Task<GetContactTypeResult> GetContactTypeAsync(GetContactTypeQuery query)
        {
            var result = new GetContactTypeResult
            {
                Entities = new List<GetContactTypeModel>()
            };

            var searchQuery = query.ToQueryDataSource<ContactTypeView>();

            var contactTypeResult = await _contactTypeRepository.GetContactTypeAsync(searchQuery, query.LanguageRef);

            if (contactTypeResult.Entities.Any())
            {
                    result = contactTypeResult.MapTo<GetContactTypeResult>();
            }

            return result;
        }

        public async Task<GetContactTypeByKeyResult> GetContactTypeByKeyAsync(GetContactTypeByKeyQuery query)
        {
            var result = new GetContactTypeByKeyResult
            {
                Entity = new GetContactTypeByKeyModel()
            };

            var searchQuery = query.ToQueryDataSource<ContactTypeView>();

            searchQuery.AddFilter(new ExpressionFilterInfo<ContactTypeView>(x => x.Key == query.Key));

            var contactTypeResult = await _contactTypeRepository.GetContactTypeAsync(searchQuery, query.LanguageRef);

            if (contactTypeResult.Entities.Any())
            {
                result.Entity = contactTypeResult.Entities.FirstOrDefault().MapTo<GetContactTypeByKeyModel>();
            }

            return result;
        }

        public async Task<BaseContactTypeResult> InsertContactTypeAsync(InsertContactTypeRequest request)
        {
            var contactTypeEntity = request.MapTo<ContactTypeEntity>();

            contactTypeEntity.ContactTypeLanguages = new List<ContactTypeLanguageEntity>
            {
                new ContactTypeLanguageEntity
                {
                    LanguageRef = request.LanguageRef,
                    _Title = request._Title
                }
            };

            await _contactTypeRepository.AddAsync(contactTypeEntity);

            try
            {
                await _db.SaveChangesAsync();

                await _entityService.InsertMultilingualEntityAsync<ContactTypeEntity, InsertContactTypeRequest, int>(contactTypeEntity, request);
            }
            catch (DbUpdateException e)
            {
                SqlErrorHandling.Handler(e, "DuplicateValue");
            }

            return new BaseContactTypeResult();
        }

        public async Task<BaseContactTypeResult> UpdateContactTypeAsync(UpdateContactTypeRequest request)
        {
            var result = new BaseContactTypeResult();

            var contactTypeEntity = await _contactTypeRepository.FindAsync(request.Key);

            if (contactTypeEntity.IsNull())
                throw new ICDException("NotFound");

            if (contactTypeEntity != null)
            {
                contactTypeEntity = request.MapTo<ContactTypeEntity>();
                contactTypeEntity.Key = request.Key;
            }

            var contactTypeLanguageEntity = await _contactTypeLanguageRepository.FirstOrDefaultAsync(ctl => ctl.ContactTypeRef == request.Key && ctl.LanguageRef == request.LanguageRef);
            if (contactTypeLanguageEntity != null)
            {
                var key = contactTypeLanguageEntity.Key;
                contactTypeLanguageEntity = request.MapTo<ContactTypeLanguageEntity>();
                contactTypeLanguageEntity.ContactTypeRef = request.Key;
                contactTypeLanguageEntity.Key = key;
            }

            if (contactTypeEntity != null && contactTypeLanguageEntity != null)
            {
                _contactTypeRepository.Update(contactTypeEntity);
                _contactTypeLanguageRepository.Update(contactTypeLanguageEntity);
                await _db.SaveChangesAsync();

                result.Success = true;
            }
            else
                result.Success = false;

            return result;
        }
    }
}
