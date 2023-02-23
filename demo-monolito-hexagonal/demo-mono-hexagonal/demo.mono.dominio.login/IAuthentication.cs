using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace demo.mono.dominio.login
{
    public interface IAuthentication
    {
        public bool ValidacionLogin(string user, string pass, string token);
    }
}
