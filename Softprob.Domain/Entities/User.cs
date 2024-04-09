using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softprob.Domain.Entities
{
    public class User:TeamPlayer
    {
        public string Password { get; set; } = string.Empty;
        
    }
}
