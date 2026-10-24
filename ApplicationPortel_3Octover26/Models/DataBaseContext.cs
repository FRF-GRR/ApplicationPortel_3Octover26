using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApplicationPortel_3Octover26.Models
{
    public class DataBaseContext : DbContext//docontext in entity framework 
    {

        public DataBaseContext() : base("dbconection")//base keyword in dbcontext connection with constroctor
        {

        }
        public DbSet<tblRegis1> tblRegis1s { get; set; }
        public DbSet<tblCountry> tblCountries { get; set; }
        public DbSet<tblState> tblStates { get; set; }
        public DbSet<tblCity> tblCities { get; set; }
        public DbSet<tblHobbies> tblHobbies { get; set; }
        public DbSet<tblGender> tblGenders { get; set; }
        public DbSet<tblDepartment> tblDepartments { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }

    }
}