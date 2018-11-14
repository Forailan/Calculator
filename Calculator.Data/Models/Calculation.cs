using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Data.Models
{
    public class Calculation
    {
        public Guid Id { get; set; }

        public IEnumerable<User> Users { get; set; }

        public IEnumerable<Expression> Expressions { get; set; } 

        public DateTime Date { get; set; }
    }
}
