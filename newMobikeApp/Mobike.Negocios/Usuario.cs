using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Usuario
    {
        private string _idPersona;
        private long _tarjeta;
        private double _saldo;
        private string _pass;
        private string _nombre;
        private string _direccion;
        private string _correo;

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }


        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public string Password
        {
            get { return _pass; }
            set { _pass = value; }
        }


        public string IdPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public long Tarjeta
        {
            get { return _tarjeta; }
            set { _tarjeta = value; }
        }
        #region Constructores
        public Usuario()
        {
            _idPersona = string.Empty;
            _pass = string.Empty;
            _correo = string.Empty;
            _nombre = string.Empty;
            _direccion = string.Empty;
            _saldo = 0;
            _tarjeta = -1;
        }

        public Usuario(string IdPersona, string Contrasena, string Nombre, string Direccion, long Tarjeta, double Saldo, string Correo)
        {
            this.IdPersona = IdPersona;
            this.Password = Contrasena;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Tarjeta = Tarjeta;
            this.Saldo = Saldo;
            this.Correo = Correo;
        }
        #endregion
        #region CRUD
        public bool Create()
        {
            try
            {
                Datos.usuario usu = new Datos.usuario()
                {
                    id_persona = this.IdPersona,
                    password = this.Password,
                    nombre = this.Nombre,
                    direccion = this.Direccion,
                    tarjeta = this.Tarjeta,
                    saldo = this.Saldo,
                    correo = this.Correo

                };
                Conexion.Mob.usuario.Add(usu);
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
                Datos.usuario usu = (from auxper in Conexion.Mob.usuario
                                     where auxper.id_persona == this.IdPersona
                                     select auxper).First();
                this.IdPersona = usu.id_persona;
                this.Password = usu.password;
                this.Nombre = usu.nombre;
                this.Direccion = usu.direccion;
                this.Saldo = usu.saldo;
                this.Tarjeta = usu.tarjeta;
                this.Correo = usu.correo;

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
                Datos.usuario usu = Conexion.Mob.usuario.First(p => p.id_persona == IdPersona);

                usu.id_persona = IdPersona;
                usu.nombre = Nombre;
                usu.password = Password;
                usu.direccion = Direccion;
                usu.saldo = Saldo;
                usu.tarjeta = Tarjeta;
                usu.correo = Correo;


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
                Datos.usuario usu = (from auxper in Conexion.Mob.usuario
                                     where auxper.id_persona == this.IdPersona
                                     select auxper).First();
                Conexion.Mob.usuario.Remove(usu);
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
