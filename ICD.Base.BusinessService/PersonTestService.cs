using ICD.Base.BusinessServiceContract;
using ICD.Base.Domain.Entity;
using ICD.Base.RepositoryContract;
using ICD.Framework.AppMapper.Extensions;
using ICD.Framework.Data.UnitOfWork;
using ICD.Framework.DataAnnotation;
using ICD.Framework.Extensions;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using ICD.Framework.QueryDataSource.Fitlter;
using ICD.Infrastructure.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessService
{
    [Dependency(typeof(IPersonTestService))]
    public class PersonTestService : IPersonTestService
    {
        private readonly IUnitOfWork _db;
        private readonly IPersonTestRepository _personTestRepository;
        public PersonTestService(IUnitOfWork db)
        {
            _db = db;
            _personTestRepository = _db.GetRepository<IPersonTestRepository>();
        }

        public async Task<DeleteTypeIntResult> DeletePersonTestAsync(DeleteTypeIntRequest request)
        {
            await _personTestRepository.DeleteWithAsync(x => x.Key == request.Key);

            await _db.SaveChangesAsync();

            return new DeleteTypeIntResult { Success = true };
        }

        public async Task<GetAllPersonTestsResult> GetAllPersonTestsAsync(GetAllPersonTestsQuery query)
        {
            QueryDataSource<PersonTestEntity> queryDataSource = query.ToQueryDataSource<PersonTestEntity>();

            ListQueryResult<PersonTestEntity> result = await _personTestRepository.GetAllPersonTestsAsync(queryDataSource);

            GetAllPersonTestsResult finalResult = result.MapTo<GetAllPersonTestsResult>();

            return finalResult;
        }

        public async Task<GetPersonTestsByFirstNameResult> GetPersonTestsByFirstNameAsync(GetPersonTestsByFirstNameQuery query)
        {
            QueryDataSource<PersonTestEntity> queryDataSource = query.ToQueryDataSource<PersonTestEntity>();

            queryDataSource.AddFilter(new ExpressionFilterInfo<PersonTestEntity>(x => x.FName == query.FirstName));

            ListQueryResult<PersonTestEntity> result = await _personTestRepository.GetAllPersonTestsAsync(queryDataSource);

            GetPersonTestsByFirstNameResult finalResult = result.MapTo<GetPersonTestsByFirstNameResult>();

            return finalResult;
        }

        public async Task<BasePersonTestResult> InsertPersonTestAsync(InsertPersonTestRequest request)
        {
            PersonTestEntity personTestEntity = request.MapTo<PersonTestEntity>();

            await _personTestRepository.AddAsync(personTestEntity);

            await _db.SaveChangesAsync();

            return new BasePersonTestResult { Success = true };
        }

        public async Task<BasePersonTestResult> UpdatePersonTestAsync(UpdatePersonTestRequest request)
        {
            PersonTestEntity personTest = await _personTestRepository.FirstOrDefaultAsync(x => x.Key == request.Key);

            if (personTest.IsNull())
                throw new ICDException("NotFound");

            personTest = request.MapTo<PersonTestEntity>();

            _personTestRepository.Update(personTest);

            _db.SaveChanges();

            return new BasePersonTestResult { Success = true };
        }
    }
}
