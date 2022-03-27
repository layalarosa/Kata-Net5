using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kata_Net5.DTOs
{
    public class SuperHeroDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
    }
}
