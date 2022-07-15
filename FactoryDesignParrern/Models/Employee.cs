using System;
using System.Collections.Generic;

#nullable disable

namespace FactoryDesignParrern.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobDescription { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public decimal? Hourlypay { get; set; }
        public decimal? Bonus { get; set; }
        public int? EmployeeTypeId { get; set; }

        public virtual EmployeeType EmployeeType { get; set; }
    }
}
