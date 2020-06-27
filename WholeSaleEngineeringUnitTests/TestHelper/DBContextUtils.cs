using Microsoft.EntityFrameworkCore;

namespace WholeSaleEngineeringUnitTests.TestHelper
{
    public static class DBContextUtils
    {
        //******************************************************************************
        public static DbContextOptions<T> GetDbContextOptions<T>() where T : DbContext
        {
            return new DbContextOptionsBuilder<T>().UseSqlite("DataSource=:memory:").Options;
        }
        //******************************************************************************
        /// <summary>
        /// Clears all data from the specified table, you must call SaveChanges() to save the change
        /// </summary>
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }
    }
}
