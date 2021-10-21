using System;
using System.Collections.Generic;
using System.Text;

namespace practica_entrega.Interfaces
{
    public interface ILogin : IDisposable
    {
        Models.LoginModel Login(Models.LoginMinModel user);
    }
}
