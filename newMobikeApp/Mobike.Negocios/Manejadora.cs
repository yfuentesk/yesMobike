using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Manejadora
    {
        public Manejadora()
        {

        }

        public SqlConnection ConexionDBQuery()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=DESKTOP-LQI7STV\\SQLEXPRESS;" +
            "Initial Catalog=MoBike;" +
            "integrated security = True;" +
            "MultipleActiveResultSets = True;";

            return conn;
        }

        public List<Usuario> ListarUsuario()
        {
            List<Usuario> ListaUsuario = new List<Usuario>();
            foreach (Datos.usuario usu in Conexion.Mob.usuario)
            {
                Usuario nuevoUsuario = new Usuario(usu.id_persona,
                                                   usu.password,
                                                   usu.nombre,
                                                   usu.direccion,
                                                   usu.tarjeta,
                                                   usu.saldo,
                                                   usu.correo);
                ListaUsuario.Add(nuevoUsuario);
            }
            return ListaUsuario;
        }

        public List<Administrador> ListarAdmin()
        {
            List<Administrador> ListaAdmin = new List<Administrador>();
            foreach (Datos.administrador adm in Conexion.Mob.administrador)
            {
                Administrador nuevoAdmin = new Administrador(adm.id_adm,
                                                   adm.password,
                                                   adm.nombre,
                                                   adm.rol);
                ListaAdmin.Add(nuevoAdmin);

            }
            return ListaAdmin;
        }

        public List<Recorrido> ListarRecorridos()
        {
            List<Recorrido> ListarRecorrido = new List<Recorrido>();
            foreach (Datos.recorrido re in Conexion.Mob.recorrido)
            {
                Recorrido nuevoRecorrido = new Recorrido(re.id_recorrido,
                                                         re.kilometros,
                                                         re.inicio_recorrido,
                                                         re.fin_recorrido,
                                                         re.tiempo_estimado,
                                                         re.cobro);
                ListarRecorrido.Add(nuevoRecorrido);
            }
            return ListarRecorrido;
        }

        public List<Estacionamiento> ListarEstacionamiento()
        {
            List<Estacionamiento> ListarEstacionamiento = new List<Estacionamiento>();
            foreach (Datos.estacionamiento est in Conexion.Mob.estacionamiento)
            {
                Estacionamiento nuevoEstacionamiento = new Estacionamiento(est.id_est, 
                                                                           est.nombre, 
                                                                           est.direccion, 
                                                                           est.capacidad);
                ListarEstacionamiento.Add(nuevoEstacionamiento);
            }
            return ListarEstacionamiento;
        }

        public List<Bicicleta> ListarBicicletas()
        {
            List<Bicicleta> ListarBicicleta = new List<Bicicleta>();
            foreach (Datos.bicicleta b in Conexion.Mob.bicicleta)
            {
                Bicicleta nuevaBici = new Bicicleta(b.id_bici,
                                                    b.location,
                                                    b.estado,
                                                    b.id_estF);
                ListarBicicleta.Add(nuevaBici);
            }
            return ListarBicicleta;
        }
    }
}
