using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodaxyProject
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(String username, String password);
    }
}
