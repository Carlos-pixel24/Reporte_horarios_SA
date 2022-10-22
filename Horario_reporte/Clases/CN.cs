using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Horario_reporte.Clases
{
    internal class CN
    {
        MySqlConnection conex = new MySqlConnection();
        static string server = "sql762.main-hosting.eu";
        static string bd = "u643983355_HorarioReporte";
        static string user = "u643983355_CARLOS";
        static string password = "HORARIOREPORTe1";
       

        string cadenaconexion = "server="+server+";"+"user="+user+";"+"pwd="+password+";"+"database="+bd+";";


        public MySqlConnection iniciarCN()
        {
            try {

                conex.ConnectionString = cadenaconexion;
                conex.Open();
                MessageBox.Show("Conexion Realizada con exito.");


            }
            catch(MySqlException e)
            {
                MessageBox.Show("No se pudo establecer conexion, Error " + e);
            }

            return conex;
        }
    }
}
