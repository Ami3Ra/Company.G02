using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.G02.BLL.Interfaces;
using Company.G02.DAL.Data.Contexts;
using Company.G02.DAL.Models;

namespace Company.G02.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CompanyDbContext context) : base(context) // ASK CLR Create Object From CompanyDbContext
        {
            
        }

    }
}
