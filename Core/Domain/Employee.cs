using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Salary { get; set; }
       
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
