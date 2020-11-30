using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDD.Domain
{
    public class Customer : BaseDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
