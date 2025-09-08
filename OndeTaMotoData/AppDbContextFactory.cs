using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OndeTaMotoData;

namespace LivroApi 
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseOracle("User Id=FIAP_ORACLE_USER;Password=FIAP_ORACLE_PASS;Data Source=oracle.fiap.com.br:1521/ORCL");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}