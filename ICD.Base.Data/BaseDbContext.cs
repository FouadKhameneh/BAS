using ICD.Framework.Data.EF;
using Microsoft.EntityFrameworkCore;

namespace ICD.Base.Data
{
    public class BaseDbContext : DataContext
    {
        public BaseDbContext(DbContextOptions options)
            :base(options)
        {

        }
    }
}
