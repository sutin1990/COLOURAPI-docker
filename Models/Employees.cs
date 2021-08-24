using System;
using System.Collections.Generic;

namespace ColourAPI.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public int? DepId { get; set; }
    }
}
