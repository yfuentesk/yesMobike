using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Administrador
    {
        private string _idAdm;
        private string _password;
        private string _nombre;
        private string _rol;

        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        public string IdAdmin
        {
            get { return _idAdm; }
            set { _idAdm = value; }
        }

        public Administrador()
        {

        }

        public Administrador(string IdAdm, string Pass, string Nombre, string Rol)
        {
            this.IdAdmin = IdAdm;
            this.Password = Pass;
            this.Nombre = Nombre;
            this.Rol = Rol;
        }
        #region CRUD
        public bool Create()
        {
            try
            {
                Datos.administrador adm = new Datos.administrador()
                {
                    id_adm = this.IdAdmin,
                    password = this.Password,
                    nombre = this.Nombre,
                    rol = this.Rol,

                };
                Conexion.Mob.administrador.Add(adm);
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
                Datos.administrador adm = (from auxadm in Conexion.Mob.administrador
                                           where auxadm.id_adm == this.IdAdmin
                                           select auxadm).First();
                this.IdAdmin = adm.id_adm;
                this.Password = adm.password;
                this.Nombre = adm.nombre;
                this.Rol = adm.rol;

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
                Datos.administrador adm = Conexion.Mob.administrador.First(p => p.id_adm == IdAdmin);

                adm.nombre = Nombre;
                adm.password = Password;
                adm.rol = Rol;

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
                Datos.administrador adm = (from auxper in Conexion.Mob.administrador
                                           where auxper.id_adm == this.IdAdmin
                                           select auxper).First();
                Conexion.Mob.administrador.Remove(adm);
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
