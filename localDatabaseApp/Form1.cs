using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace localDatabaseApp
{
    public partial class Form1 : Form
    {
        List<students> users = new List<students>();
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            accesoData db = new accesoData();
            users = db.GetUsers(textBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melisa\Desktop\localDatabaseApp\localDatabaseApp\students.mdf;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO estudiantes (matricula,nombre,apellido,contraseña,total_ejercicios,date_reporte_generado) VALUES (@matricula,@nombre,@apellido,@contraseña,NULL,NULL)", con);
            cmd.Parameters.Add("@matricula", matriculaInt.Text);
            cmd.Parameters.Add("@nombre", textNombre.Text);
            cmd.Parameters.Add("@apellido", textApellido.Text);
            cmd.Parameters.Add("@contraseña", textPass.Text);
            cmd.ExecuteNonQuery(); 
        }
    }
}
