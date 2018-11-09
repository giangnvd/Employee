using Annotation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Annotation.Context
{
    public class EmployContext : DbContext
    {
        public  DbSet<Employee> Employee { get; set; }
    }
}