﻿using practica_2_nuguets.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using practica_entrega.Interfaces;
using practica_entrega.Models;

namespace practica_entrega.Services
{
    public class LoginService: ILogin,IDisposable
    {
        private bool disposedValue;
        private IConnectionDB<LoginModel> _conn;

        public LoginService(IConnectionDB<LoginModel> conn)
        {
            _conn = conn;
        }

        public Models.LoginModel Login(Models.LoginMinModel user)
        {
            throw new Exception();
        }

        #region Dispose

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _conn.Dispose();// TODO: eliminar el estado administrado (objetos administrados)
                }

                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~MinervaService()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        void IDisposable.Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
