using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Anfiteatro_inventario
{
    public partial class Form2 : Form
    {

        Conexion seconecta = new Conexion();
        
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_cantidad_actual_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                
                MessageBox.Show(seconecta.consulta(Convert.ToInt32(txt_id_producto.Text), txt_nombre_producto.Text,txt_cantidad_actual.Text,txt_fecha_ingreso.Text,txt_cantidad_min.Text));
                seconecta.cargar_productos(data_anfi);
            }
            catch
            {
                MessageBox.Show("Antes de buscar, proporcione los valores buscados");
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_actualiza_Click(object sender, EventArgs e)
        {

            MessageBox.Show(seconecta.atualizar(Convert.ToInt32(txt_id_producto.Text), txt_nombre_producto.Text, txt_cantidad_actual.Text, txt_fecha_ingreso.Text));
            seconecta.cargar_productos(data_anfi);

            txt_id_producto.Text = "";
            txt_nombre_producto.Text = "";
            txt_cantidad_actual.Text = "";
        }

        private void btn_ingresa_Click(object sender, EventArgs e)
        {
            if (validarnumero(txt_cantidad_min.Text) == true || validarnumero(txt_cantidad_actual.Text)||validarnumero(txt_id_producto.Text))
            {
                
                if (seconecta.registro(Convert.ToInt32(txt_id_producto.Text)) == 0)
                {
                    
                    MessageBox.Show(seconecta.insertar(Convert.ToInt32(txt_id_producto.Text), txt_nombre_producto.Text, txt_fecha_ingreso.Text, txt_cantidad_actual.Text, txt_cantidad_min.Text));
                    seconecta.cargar_productos(data_anfi);
                    txt_cantidad_actual.Text = "";
                    txt_cantidad_min.Text = "";
                    txt_fecha_ingreso.Text = "";
                    txt_id_producto.Text = "";
                    txt_nombre_producto.Text = "";

                }
                else
                    MessageBox.Show("Este registro ya existe, favor de introducir un ID distinto");

            }
            else 
            {
                MessageBox.Show("Por favor, proporcione en cantidad actual, cantidad minima e id un numero entero.");
            }
        }

        bool validarnumero(string numero)
        {
            try {
                int.Parse(numero);
                return true;
            }
            catch {
                return false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string cantidad_actual="", cantidad_minima="", nombre_producto="", id_producto="";
            seconecta.cargar_productos(data_anfi);
            MessageBox.Show(seconecta.validacion(cantidad_actual, cantidad_minima, nombre_producto, id_producto));
            
        }
    }
}
