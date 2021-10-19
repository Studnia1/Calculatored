using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatored.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public B2BData UserData { get; set; }

    }
}
