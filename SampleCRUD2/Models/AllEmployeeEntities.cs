using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace SampleCRUD2.Models
{
    public class AllEmployeeEntities
    {
    }

    public class Employee
    {
        [Key]
        public Int64 EmployeeId { set; get; }

        [Required(ErrorMessage = "Required")]
        public int CountryId { set; get; }

        [Required(ErrorMessage = "Required")]
        public int StateId { set; get; }

        [Required(ErrorMessage = "Required")]
        public string Full_name { set; get; }

        [Required(ErrorMessage = "Required")]
        public string Email { set; get; }

        [Required(ErrorMessage = "Required")]
        public string Mobile { set; get; }

        [NotMapped]
        [DisplayName("Country")]
        public string Country_name { set; get; }

        [NotMapped]
        [DisplayName("State")]
        public string State { set; get; }
    }
    public class Country
    {
        [Key]
        public Int32 CountryId { set; get; }

        [Required(ErrorMessage = "Required")]
        public string Country_name { set; get; }
    }

    public class States
    {
        [Key]
        public Int32 StateId { set; get; }

        [Required(ErrorMessage = "Required")]
        public Int32 CountryId { set; get; }

        [Required(ErrorMessage = "Required")]
        public string StateName { set; get; }
    }
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options) { }
        public DbSet<Employee> Employee { set; get; }
        public DbSet<Country> Country { set; get; }
        public DbSet<States> States { set; get; }
    }
}
