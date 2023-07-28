using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risxpert
{
  
    public partial class Form_Risxpert : Form
    {

        /*
        private string nombre; // Variable para almacenar el nombre
        private string fecha; //Variable para almacenar el nombre
        private string activo;
        private string tipo;
        private string analista;
        private string daño;


        */

        List<Riesgo> Riesgos = new List<Riesgo>();
        int n = 0;
        int r = 0;

        //Riesgo = new Riesgo(int n);
       
        





        public Form_Risxpert()
        {
            InitializeComponent();
        }
         

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblMensaje.Text = "";
           /* if (FileDialog.Exists("database.txt"))
            {
                return;
            }
            StreamWriter archivo = new StreamWriter("database.txt");
            archivo.Close();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int n = 0; n += Riesgos; n++)
            {
                dataGridView2 = dataGridView1.Rows.CollectionChanged += dataGridView1_CellContentClick;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         /*  Analista = txtAnalista.Text;*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* for (n = 0; n < Riesgo.Count; n++)
                // No hay necesidad de type cast
                r = Riesgos[n];
            Console.Writeline(r);
           */
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Riesgo R1 = new Riesgo();
            {

            /*    ID = n + 1,
                Nombre = txtAnalista.Text;
                lblFecha.Text = txtFecha.Text;
                Activo = 
            */

            }
            //for (n = 0; n = Riesgo)


            /* for (n = 0; n < Riesgo.Count; n++)
                // No hay necesidad de type cast
                r = Riesgos[n];
           // Console.Writeline(r);

            R1 = new Riesgo;*/

            
            dataGridView1.Rows.Add();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            for (n = 0;  n < Riesgos.Count; n++)
            {
                Riesgo r = Riesgos[n];
                dataGridView1.Rows.Add(r.Id, r.Nombre, r.Fecha, r.Activo, r.Tipo, r.Analista, r.Daño);

            }
            
            //dataGridView1.Rows.Clear();

            //btnGuardar = dataGridView1.Rows[0];

           /* for (int i = 0; i < Riesgos.Count; i++)
            {
                Riesgo riesgo = Riesgos[i];
                dataGridView1.Rows.Add(riesgo.Id, riesgo.Nombre, riesgo.Fecha, riesgo.Activo, riesgo.Tipo, riesgo.Analista, riesgo.Daño);
            }
            
            */
            StreamWriter archive  = new StreamWriter("database.txt", true);
            archive.WriteLine(txtAnalista.Text);
            archive.WriteLine(txtFecha.Text);
            archive.WriteLine(dataGridView1.Text);
            archive.Close();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            /*Fecha = txtFecha.Text; */
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           /* nombre = txtAnalista.Text;
            fecha = txtFecha.Text;*/
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
    public class Riesgo
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Activo { get; set; }
        public string Tipo { get; set; }
        public string Analista { get; set; }
        public string Daño { get; set; }
    }
}
