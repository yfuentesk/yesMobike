using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Estacionamiento
    {
        private int _idEstacionamiento;
        private string _nombreEst;
        private string _direccionEst;
        private int _capacidad;
        #region aa
        public int Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }


        public string DireccionEstacionamiento
        {
            get { return _direccionEst; }
            set { _direccionEst = value; }
        }


        public string NombreEstacionamiento
        {
            get { return _nombreEst; }
            set { _nombreEst = value; }
        }


        public int IdEstacionamiento
        {
            get { return _idEstacionamiento; }
            set { _idEstacionamiento = value; }
        }
        #endregion
        #region Constructores
        public Estacionamiento()
        {
            _idEstacionamiento = -1;
            _nombreEst = string.Empty;
            _direccionEst = string.Empty;
            _capacidad = -1;
        }

        public Estacionamiento(int IdEst, string NombreEst, string DireccionEst, int Cap)
        {
            this.IdEstacionamiento = IdEst;
            this.NombreEstacionamiento = NombreEst;
            this.DireccionEstacionamiento = DireccionEst;
            this.Capacidad = Cap;
        }
        #endregion
        #region CRUD
        public bool Create()
        {
            try
            {
                Datos.estacionamiento est = new Datos.estacionamiento()
                {
                    id_est = this.IdEstacionamiento,
                    nombre = this.NombreEstacionamiento,
                    direccion = this.DireccionEstacionamiento,
                    capacidad = this.Capacidad,

                };
                Conexion.Mob.estacionamiento.Add(est);
                Conexion.Mob.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Read()
        {
            try
            {
                Datos.estacionamiento est = (from auxest in Conexion.Mob.estacionamiento
                                             where auxest.id_est == this.IdEstacionamiento
                                             select auxest).First();
                this.IdEstacionamiento = est.id_est;
                this.NombreEstacionamiento = est.nombre;
                this.DireccionEstacionamiento = est.direccion;
                this.Capacidad = est.capacidad;


                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                Datos.estacionamiento est = Conexion.Mob.estacionamiento.First(e => e.id_est == IdEstacionamiento);

                est.nombre = NombreEstacionamiento;
                est.direccion = DireccionEstacionamiento;
                est.capacidad = Capacidad;

                Conexion.Mob.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Delete()
        {
            try
            {
                Datos.estacionamiento est = (from auxest in Conexion.Mob.estacionamiento
                                             where auxest.id_est == this.IdEstacionamiento
                                             select auxest).First();
                Conexion.Mob.estacionamiento.Remove(est);
                Conexion.Mob.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
