using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Recorrido
    {
        #region Campos
        private double _km;
        private DateTime _inicioRecorrido;
        private DateTime _finRecorrido;
        private double _tiempoEstimado;
        private double _cobro;
        private string _idPersona;
        private string _correo;
        private string _pantente;


        #endregion
        #region Propiedades

        public string Patente
        {
            get { return _pantente; }
            set { _pantente = value; }
        }


        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }


        public string Rut
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }

        public double Cobro
        {
            get { return _cobro; }
            set { _cobro = value; }
        }


        public double TiempoEstimado
        {
            get { return _tiempoEstimado; }
            set { _tiempoEstimado = value; }
        }


        public DateTime FinRecorrido
        {
            get { return _finRecorrido; }
            set { _finRecorrido = value; }
        }


        public DateTime InicioRecorrido
        {
            get { return _inicioRecorrido; }
            set { _inicioRecorrido = value; }
        }

        public double Kilometros
        {
            get { return _km; }
            set { _km = value; }
        }

        #endregion
        #region Constructores
        public Recorrido()
        {
            Kilometros = 0;
            InicioRecorrido = DateTime.MinValue;
            FinRecorrido = DateTime.MinValue;
            TiempoEstimado = 0;
            Cobro = 0;
            Rut = string.Empty;
            Correo = string.Empty;
            Patente = string.Empty;

        }
        public Recorrido(
            double Km,
            DateTime IniRecorrido,
            DateTime FinRecorrido,
            double TiempoEstimado,
            double Cobro,
            string Rut,
            string Correo,
            string Patente)
        {
            this.Kilometros = Km;
            this.InicioRecorrido = InicioRecorrido;
            this.FinRecorrido = FinRecorrido;
            this.TiempoEstimado = TiempoEstimado;
            this.Cobro = Cobro;
            this.Rut = Rut;
            this.Correo = Correo;
            this.Patente = Patente;
        }
        #endregion
        #region CRUD

        public bool Create()
        {
            try
            {
                Datos.recorrido re = new Datos.recorrido()
                {
                    kilometros = this.Kilometros,
                    inicio_recorrido = this.InicioRecorrido,
                    fin_recorrido = this.FinRecorrido,
                    tiempo_estimado = this.TiempoEstimado,
                    cobro = this.Cobro,
                    id_personaF = this.Rut,
                    correoF = this.Correo,
                    id_biciF = this.Patente

                };
                Conexion.Mob.recorrido.Add(re);
                Conexion.Mob.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        /*public bool Read()
        {
            try
            {
                Datos.recorrido bic = (from auxbic in Conexion.Mob.recorrido
                                       where auxbic.id_recorrido == this.id
                                       select auxbic).First();
                this.IdBicicleta = bic.id_bici;
                this.Location = bic.location;
                this.Estado = bic.estado;
                this.Estacionamiento = bic.id_estF;


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
                Datos.bicicleta bic = Conexion.Mob.bicicleta.First(b => b.id_bici == IdBicicleta);

                bic.estado = Estado;
                bic.location = Location;
                bic.id_estF = Estacionamiento;

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
                Datos.bicicleta bic = (from auxbic in Conexion.Mob.bicicleta
                                       where auxbic.id_bici == this.IdBicicleta
                                       select auxbic).First();
                Conexion.Mob.bicicleta.Remove(bic);
                Conexion.Mob.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        } */
        #endregion
    }
}

