using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Bicicleta
    {
        private string _idBicicleta;
        private string _location;
        private string _estado;

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string IdBicicleta
        {
            get { return _idBicicleta; }
            set { _idBicicleta = value; }
        }

        public Bicicleta()
        {
            _idBicicleta = string.Empty;
            _location = string.Empty;
            _estado = string.Empty;
        }

        public Bicicleta(string idBici, string Locacion, string Estado)
        {
            this.IdBicicleta = idBici;
            this.Location = Locacion;
            this.Estado = Estado;
        }

        #region CRUD
        public bool Create()
        {
            try
            {
                Datos.bicicleta bic = new Datos.bicicleta()
                {
                    id_bici = this.IdBicicleta,
                    location = this.Location,
                    estado = this.Estado,

                };
                Conexion.Mob.bicicleta.Add(bic);
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
                Datos.bicicleta bic = (from auxbic in Conexion.Mob.bicicleta
                                       where auxbic.id_bici == this.IdBicicleta
                                       select auxbic).First();
                this.IdBicicleta = bic.id_bici;
                this.Location = bic.location;
                this.Estado = bic.estado;


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
                ;

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
        }
        #endregion
    }
}
