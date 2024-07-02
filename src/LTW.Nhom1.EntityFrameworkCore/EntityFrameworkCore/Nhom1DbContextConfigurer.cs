using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LTW.Nhom1.EntityFrameworkCore
{
    public static class Nhom1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Nhom1DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Nhom1DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
