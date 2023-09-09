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
    [Dependency(typeof(ITeacherTestService))]
    
    public class TeacherTestService : ITeacherTestService
    {
        private readonly IUnitOfWork _db;
        private readonly ITeacherTestRepository _teacherTestRepository;
        
        public TeacherTestService(IUnitOfWork db)
        {
            _db = db;
            _teacherTestRepository = _db.GetRepository<ITeacherTestRepository>();
        }
        
        public async Task<DeleteTypeIntResult> DeleteTeacherTestAsync(DeleteTypeIntRequest request)
        {
            await _teacherTestRepository.DeleteWithAsync(x => x.Key == request.Key);

            await _db.SaveChangesAsync();

            return new DeleteTypeIntResult { Success = true };
        }

        public async Task<GetAllTeacherTestsResult> GetAllTeacherTestsAsync(GetAllTeacherTestsQuery query)
        {
            QueryDataSource<TeacherTestEntity> queryDataSource = query.ToQueryDataSource<TeacherTestEntity>();

            ListQueryResult<TeacherTestEntity> result = await _teacherTestRepository.GetAllTeacherTestsAsync(queryDataSource);

            GetAllTeacherTestsResult finalResult = result.MapTo<GetAllTeacherTestsResult>();

            return finalResult;
        }

        public async Task<BaseTeacherTestResult> UpdateTeacherTestAsync(UpdateTeacherTestRequest request)
        {
            TeacherTestEntity teacherTest = await _teacherTestRepository.FirstOrDefaultAsync(x => x.Key == request.Key);

            if (teacherTest.IsNull())
                throw new ICDException("NotFound");

            teacherTest = request.MapTo<TeacherTestEntity>();

            _teacherTestRepository.Update(teacherTest);

            _db.SaveChanges();

            return new BaseTeacherTestResult { Success = true };
        }
        
        public async Task<BaseTeacherTestResult> InsertTeacherTestAsync(InsertTeacherTestRequest request)
        {
            TeacherTestEntity teacherTestEntity = request.MapTo<TeacherTestEntity>();

            await _teacherTestRepository.AddAsync(teacherTestEntity);

            await _db.SaveChangesAsync();

            return new BaseTeacherTestResult { Success = true };
        }
    }
}