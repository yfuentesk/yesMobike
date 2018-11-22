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
        private int _idRecorrido;
        private double _km;
        private DateTime _inicioRecorrido;
        private DateTime _finRecorrido;
        private double _tiempoEstimado;
        private double _cobro;
        #endregion
        #region Propiedades
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

        public int Id_Recorrido
        {
            get { return _idRecorrido; }
            set { _idRecorrido = value; }
        }
        #endregion
        #region Constructores
        public Recorrido()
        {
            Id_Recorrido = -1;
            Kilometros = 0;
            InicioRecorrido = DateTime.MinValue;
            FinRecorrido = DateTime.MinValue;
            TiempoEstimado = 0;
            Cobro = 0;

        }
        public Recorrido(
            int IdRecorrido,
            double Km,
            DateTime IniRecorrido,
            DateTime FinRecorrido,
            double TiempoEstimado,
            double Cobro)
        {
            this.Id_Recorrido = IdRecorrido;
            this.Kilometros = Km;
            this.InicioRecorrido = InicioRecorrido;
            this.FinRecorrido = FinRecorrido;
            this.TiempoEstimado = TiempoEstimado;
            this.Cobro = Cobro;
        }
        #endregion
    }
}

