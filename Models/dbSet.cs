using Microsoft.EntityFrameworkCore;

namespace WebAPI_Employe.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options) : base(options) { }
        DbSet<Employees> Employees
        {
            get;
            set;
        }
    }
}
