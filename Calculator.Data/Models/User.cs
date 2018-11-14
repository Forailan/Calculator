using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Calculator.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public long IpAddressInt { get; set; }

        public string IpAddress => new IPAddress(this.IpAddressInt).ToString();
    }
}
