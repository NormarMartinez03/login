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

namespace almacen2._0
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void login()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=NORMAR;Initial Catalog=almacen1;Integrated Security=True");
            cn.Open();
            SqlCommand cm = new SqlCommand("select Nom_User,contraseña from usuario where Nom_User='" + Txtusuario.Text + "' and contraseña='" + txtcontraseña.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Exitoso Bienvenido "+Txtusuario.Text, " Sistema");
                //si los credenciales es correcto abre el formulario menu
                this.Hide();
                Form2 frinicio = new Form2();
                frinicio.ShowDialog();
                
             
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Sistema");
                txtcontraseña.Clear();
                Txtusuario.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

       
    }
}
   