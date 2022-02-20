using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollAdo.net
{
    internal class payrollmodel
    {
            public int  Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public long Zip { get; set; }
            public Int64 PhoneNumber { get; set; }
            public string Email { get; set; }
        }
    }

