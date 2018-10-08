using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Printing_and_Engraving_Site
{
    public class EmployeeDataModel : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }

    public class EmployeeDB : Employee
    {
        

    }
}