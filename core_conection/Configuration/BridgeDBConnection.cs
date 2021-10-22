
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica_2_nuguets;
using practica_2_nuguets.Interfaces;
using practica_2_nuguets.Models;
using core_conection.Tools;

namespace core_conection.Configuration
{
    public class BridgeDBConnection<T>
    {
        public static IConnectionDB<T> Create(string ConnectionString, DbEnum DB)
        {
            //return Factorizer<T>.Create(EncryptTool.Decrypt(ConnectionString), DB);
            return Factorizer<T>.Create(ConnectionString, DB);
        }
    }
}
