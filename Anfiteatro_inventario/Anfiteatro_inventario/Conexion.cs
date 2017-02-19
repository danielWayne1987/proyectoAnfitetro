using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Anfiteatro_inventario
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=anfiteatro;Integrated Security=True");
                cn.Open();
                //MessageBox.Show("Conectado");


            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logro la conexion  " + ex.ToString());

            }
        }

        public string insertar(int id_producto, string nombre_producto, string fecha_producto, string cantidad_actual, string cantidad_minima)
        {
            string salida = "se logro guardar la informacion";

            try
            {
                //cmd = new SqlCommand("INSERT INTO Productos (id_producto,nombre_producto,fecha_ingreso,cantidad_actual, cantidad_minima) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')");
                cmd = new SqlCommand("INSERT INTO Productos (id_producto,nombre_producto,fecha_producto,cantidad_actual, cantidad_minima) VALUES (" + id_producto + ",'" + nombre_producto + "','" + fecha_producto + "','" + cantidad_actual + "','" + cantidad_minima + "')", cn);
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                salida = "no se logro guardar la informacion   " + ex.ToString();
            }
            return salida;
        }

        public int registro(int id_producto)
        {
            int contador = 0;

            try
            {
                
                cmd = new SqlCommand("Select * from Productos where id_producto="+id_producto+"", cn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro hcer l consulta" + ex.ToString());
            }
            return contador;
        }

        public void cargar_productos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Productos ", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show("no se pudo  " + ex.ToString());
            }
        
        }

        public void auto_completa(int id_producto, TextBox nombre_producto, TextBox cantidad_actual, TextBox cantidad_minima, DateTimePicker fecha_producto)
        {
            try
            {
                cmd = new SqlCommand("Select * from Productos where id_producto" + id_producto+"",cn);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    nombre_producto.Text = dr["nombre_producto"].ToString();
                    cantidad_actual.Text = dr["cantidad_actual"].ToString();
                    cantidad_minima.Text = dr["cantidad_minima"].ToString();
                    fecha_producto.Text = dr["fecha_ingreso"].ToString();

                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se pude autocompletar " + ex.ToString());
            }
        }

        public string atualizar(int id_producto, string nombre_producto, string cantidad_actual, string fecha_producto)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                //cmd = new SqlCommand("Update Productos set nombre_producto ='" + nombre_producto + "' ,cantidad_actual='" + cantidad_actual + "', fecha_ingreso='" + fecha_ingreso + "' where id_producto=" + id_producto + "", cn);
                //cmd= new SqlCommand("Update Productos set cantidad_actual= '"+ cantidad_actual +"', fecha_ingreso='"+fecha_ingreso+"' where id_producto="+ id_producto+" && nombre_producto='"+nombre_producto+"', cn);
                cmd = new SqlCommand("Update Productos set cantidad_actual='" + cantidad_actual + "', fecha_producto = '" + fecha_producto + "' where id_producto=" + id_producto + " ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No pudo actualizar la informacion: " + ex.ToString();
            }
            return salida;
        }

        public string consulta(int id_producto, string nombre_producto, string cantidad_actual, string fecha_producto, string cantidad_minima)
        {
            string consulta_datos = "consulta exitosa";

            try
            {
                cmd = new SqlCommand("Select * from Productos where id_producto" + id_producto + "", cn);
                dr = cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se logro hacer la consulta esperada " + ex.ToString());
            }
            return consulta_datos;
        }

        public string inicio_sesion (string Password)
        {
            string sesion="Bienvenido ";
            try
            { }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return sesion;
        }
        public string validacion(string cantidad_actual, string cantidad_minima, string nombre_producto, string id_producto)
        {
            string val = "";
            cmd = new SqlCommand("Select * from Productos where cantidad_minima < cantidad_actual", cn);

            return val;
        }




    }
}
