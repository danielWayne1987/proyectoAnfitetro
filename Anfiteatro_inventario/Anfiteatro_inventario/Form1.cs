using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anfiteatro_inventario
{
    public partial class Form1 : Form
    {

        Conexion seconecta = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnacceder_Click(object sender, EventArgs e)
        {
            string pass1 = "anfi123456";
            string pass2 = "anfiteatro";
            

            if(txtPassword.Text == pass1 || txtPassword.Text==pass2)
            {
                Form2 objaccede = new Form2();
                this.Hide();
                objaccede.Show();
                txtPassword.Text = "";
            
            }
            else
            {
                MessageBox.Show("Introdusca la contraña correcta !!");
            }
            
           
        }

        

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
