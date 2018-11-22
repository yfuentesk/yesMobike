using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobike.Datos;

namespace Mobike.Negocios
{
    internal class Conexion
    {
        private static MoBikeEntities _mobike;
        public static MoBikeEntities Mob
        {
            get
            {
                if (_mobike == null)
                {
                    _mobike = new MoBikeEntities();
                }
                return _mobike;
            }
            set
            {
                _mobike = value;
            }
        }
    }
}
