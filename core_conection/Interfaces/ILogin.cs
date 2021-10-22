using System;
using System.Collections.Generic;
using System.Text;

namespace core_conection.Interfaces
{
    public interface ILogin : IDisposable
    {
        Models.LoginModel Login(Models.LoginMinModel user);
    }
}
