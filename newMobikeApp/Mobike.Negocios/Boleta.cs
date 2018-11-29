using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Boleta
    {
        private DateTime _fecha;
        private string _idPersonaF;
        private string _patenteF;
        private int _recorridoF;

        public int RecorridoF
        {
            get { return _recorridoF; }
            set { _recorridoF = value; }
        }


        public string PatenteF
        {
            get { return _patenteF; }
            set { _patenteF = value; }
        }


        public string PersonaF
        {
            get { return _idPersonaF; }
            set { _idPersonaF = value; }
        }


        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public Boleta()
        {
            PersonaF = string.Empty;
            PatenteF = string.Empty;
            RecorridoF = 0;
            
        }

        public Boleta(DateTime Fecha,
                      string RutF, 
                      string Patente,
                      int Recorrido)
        {
            this.Fecha = Fecha;
            this.PersonaF = RutF;
            this.PatenteF = Patente;

        }

        public bool Create()
        {
            try
            {
                Datos.boleta bo = new Datos.boleta()
                {
                    fecha = this.Fecha,
                    id_personaF = this.PersonaF,
                    id_biciF = this.PatenteF,
                    id_recorridoF = this.RecorridoF

                };
                Conexion.Mob.boleta.Add(bo);
                Conexion.Mob.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
