﻿using LiteDB;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Risxpert
{


    public partial class Form_Risxpert : Form
    {
        List<Riesgo> Riesgos = new List<Riesgo>();


        int CELL_DANO = 0;
        int CELL_ID = 1;
        int CELL_NAME = 2;
        int CELL_TIPO = 3;
        int CELL_ACTIVO = 4;
        int CELL_ANALISTA = 5;
        int CELL_FECHA = 6;
        int Row = 0;


       




        /*
         private void SaveData(int i)
         {
             MessageBox.Show("¡El botón fue clicado!");
             using (var db = new LiteDatabase(@"C:\Programación\Programación para Mecatrónicos\PPM\Tarea 9\Risxpert program\Risxpert\Data Base Lite DB Risxpert\Risxpert.txt")) { }
            
        /*var col = db.GetCollection
         }
        */

        /*
        private string nombre; // Variable para almacenar el nombre
        private string fecha; //Variable para almacenar el nombre
        private string activo;
        private string tipo;
        private string analista;
        private string daño;*/





        //Riesgo = new Riesgo(int n);







        public Form_Risxpert()
        {
            InitializeComponent();
        }










        private void Form1_Load(object sender, EventArgs e)
        {


           



            /*
            List<Riesgo> Riesgos = new List<Riesgo>();
            {
                Riesgos.Add(item: new Riesgo {Ref = 1, Id = 1, Activo = "", Nombre = "", Tipo = "", Daño = "" });
                ActualizarDataGridView();
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("", "", "", "", "");


            }*/
            //lblMensaje.Text = "";
            /* if (FileDialog.Exists("database.txt"))
             {
                 return;
             }
             StreamWriter archivo = new StreamWriter("database.txt");
             archivo.Close();*/
        }





        //Añadir datos a la tabla


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                object value = cell.Value;

                // Actualiza el valor en el DataGridView2 en la misma fila y columna
                dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;
            }
        }


        private void EliminarPrimeraFila(object sender, EventArgs e)
        {

            List<Riesgo> Riesgos = new List<Riesgo>();

            try
            {
                // Verificar si hay al menos una fila en la lista Riesgos
                if (Riesgos.Count > 0)
                {
                    // Eliminar la primera fila de la lista Riesgos
                    Riesgos.RemoveAt(0);

                    // Actualizar el DataGridView con los datos actualizados
                    //ActualizarDataGridView();

                    MessageBox.Show("Primera fila eliminada correctamente.");
                }
                else
                {
                    MessageBox.Show("La lista de Riesgos está vacía.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la primera fila: " + ex.Message);
            }
        }

        //private void ActualizarDataGridView()
        //{

        //    List<Riesgo> Riesgos = new List<Riesgo>();

        //    // Limpiar el DataGridView
        //    // dataGridView1.Rows.Clear();

        //    // Agregar los datos actualizados a partir de la lista Riesgos al DataGridView
        //    foreach (Riesgo riesgo in Riesgos)
        //    {
        //        dataGridView1.Rows.Add(riesgo.Id, riesgo.Activo, riesgo.Nombre, riesgo.Tipo, riesgo.Daño);
        //    }
        //    //dataGridView1.Rows.Clear();

        //}

        /*private void tabControl_Selected(object sender, TabControlEventArgs e)
        { 
            for (int i = 0; i < dataGridView1.Rows.Count;)
            {
                UpdateTab2(i);
                UpdateTab3(i);
                UpdateTab4(i);
            }
        }*/

        //private void UpdateTab2(int i)
        //{
        //    Riesgos = Riesgos[i];

        //}
            



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Riesgo> Riesgos = new List<Riesgo>();


            /* // Paso 2: Limpiar DataGridView2
             dataGridView2.Rows.Clear();

              Paso 3: Agregar los datos a DataGridView2
             foreach (Riesgo riesgo in datosDataGridView1)
             {
                 dataGridView2.Rows.Add(riesgo.Ref, riesgo.Id, riesgo.Nombre, riesgo.Fecha, riesgo.Activo, riesgo.Tipo, riesgo.Analista, riesgo.Daño, riesgo.Estado);
             }*/


            /*  dataGridView2.Rows.Add(dataGridView1);
            dataGridView2.Rows.Add(dataGridView2);

            /*  for (int n = 0; n = Riesgos; n++)
            {
                dataGridView2 = dataGridView1.Rows.cell[0];
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*  Analista = txtAnalista.Text;*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            // Verifica que el índice de fila y columna sea válido
            if (rowIndex >= 0 && columnIndex >= 0)
            {
                object cellValue = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value;
            }



            /*  DataTable table = new DataTable();

             /* table.Columns.Add("Ref", typeof(int));
              table.Columns.Add("ID", typeof(string));
              table.Columns.Add("Activo/Bien", typeof(string));
              table.Columns.Add("Riesgo", typeof(string));
              table.Columns.Add("Tipo de Riesgo", typeof(string));
              table.Columns.Add("Daño", typeof(string));



              table.Rows.Add(1, "aaaa", typeof(string));

              dataGridView1.DataSource = table;
              */





            //List<Riesgo> Riesgos = new List<Riesgo>();

            //  Riesgos.Add(new Riesgo(dataGridView1));

            //dataGridView1.ToString.Text.Rows.Add();

            /* for (n = 0; n < Riesgo.Count; n++)
                // No hay necesidad de type cast
                r = Riesgos[n];
            Console.Writeline(r);
           */
        }

        /*
          private void BtnMas_Click_1(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].ToString();

            DataGridViewRow lastRow = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
            bool isLastRowEmpty = true;
            foreach (DataGridViewCell cell in lastRow.Cells)
            {
                if (cell.Value != null && cell.Value.ToString().Trim() != "")
                {
                    isLastRowEmpty = false;
                    break;
                }
            }

            // Si la última fila está vacía, agregar una nueva fila
            if (isLastRowEmpty)
            {
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Selected = true; // Opcional: seleccionar la nueva fila
            }
            else
            { }

            //Riesgo R1 = new Riesgo();
            {

                /*    ID = n + 1,
                    Nombre = txtAnalista.Text;
                    lblFecha.Text = txtFecha.Text;
                    Activo = v
                */

            /*}/*
            //for (n = 0; n = Riesgo)


            /* for (n = 0; n < Riesgo.Count; n++)
                // No hay necesidad de type cast
                r = Riesgos[n];
           // Console.Writeline(r);

            R1 = new Riesgo;


            dataGridView1.Rows.Add();
        }
            */

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //ActualizarDataGridView();
            /*

            // Recorre las filas del DataGridView y crea objetos Riesgo para cada fila
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    Riesgo Riesgos = new Riesgo
                    {
                        //  Ref = Convert.ToInt32(row.Cells["Ref"].Value),
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        Nombre = row.Cells["Nombre"].Value.ToString(),
                        Fecha = Convert.ToDateTime(row.Cells["Fecha"].Value),
                        Activo = row.Cells["Activo"].Value.ToString(),
                        Tipo = row.Cells["Tipo"].Value.ToString(),
                        Analista = row.Cells["Analista"].Value.ToString(),
                        Daño = row.Cells["Daño"].Value.ToString(),
                        //Estado = Convert.ToBoolean(row.Cells["Estado"].Value)
                    };

                    object value = Riesgos.Add(Riesgos); // Agrega el objeto Riesgo a la lista
                }
            }
            */
            /*
                        // Guarda los datos en LiteDB
                        using (var db = new LiteDatabase(@"C:\Programación\Programación para Mecatrónicos\PPM\Tarea 9\Risxpert program\Risxpert\Data Base Lite DB Risxpert\mibasederisxpert.db"))
                        {
                            var col = db.GetCollection<Riesgo>("Riesgos");

                            // Borra todos los datos actuales en la colección antes de guardar los nuevos datos
                           // bool v = col.Delete(Query.All());

                            // Inserta los nuevos datos en la colección
                            col.Insert((Riesgo)col);
                        }

                        // Actualiza el DataGridView para mostrar los datos guardados
                        ActualizarDataGridView();*/

        }



        /* private void TransferirDatosDataGridView()
         {
             // Paso 1: Obtener los datos de DataGridView1
             List<Riesgo> datosDataGridView1 = new List<Riesgo>();
             foreach (DataGridViewRow row in dataGridView1.Rows)
             {
                 if (!row.IsNewRow)
                 {
                     Riesgo riesgo = new Riesgo
                     {
                         Ref = Convert.ToInt32(row.Cells["Ref"].Value),
                         Id = Convert.ToInt32(row.Cells["Id"].Value),
                         Nombre = row.Cells["Nombre"].Value.ToString(),
                         Fecha = Convert.ToDateTime(row.Cells["Fecha"].Value),
                         Activo = row.Cells["Activo"].Value.ToString(),
                         Tipo = row.Cells["Tipo"].Value.ToString(),
                         Analista = row.Cells["Analista"].Value.ToString(),
                         Daño = row.Cells["Daño"].Value.ToString(),
                         Estado = Convert.ToBoolean(row.Cells["Estado"].Value)
                     };

                     datosDataGridView1.Add(riesgo);
                 } 
             }
             */





        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {

        }



        // btnGuardar.Click += SaveData(int i) ;




        // btnGuardar = dataGridView1.Rows[1];

        // for (n = 0;  n < Riesgos.Count; n++)
        //{
        //   Riesgo r = Riesgos[n];
        //  dataGridView1.Rows.Add(r.Id, r.Nombre, r.Fecha, r.Activo, r.Tipo, r.Analista, r.Daño);



        //dataGridView1.Rows.Clear();

        //btnGuardar = dataGridView1.Rows[0];

        /* for (int i = 0; i < Riesgos.Count; i++)
         {
             Riesgo riesgo = Riesgos[i];
             dataGridView1.Rows.Add(riesgo.Id, riesgo.Nombre, riesgo.Fecha, riesgo.Activo, riesgo.Tipo, riesgo.Analista, riesgo.Daño);
         }

         */
        /*StreamWriter archive  = new StreamWriter("database.txt", true);
        archive.WriteLine(txtAnalista.Text);
        archive.WriteLine(txtFecha.Text);
        archive.WriteLine(dataGridView1.Text);
        archive.Close();*/


        /* private EventHandler SaveData(int v, object i)
         {
             throw new NotImplementedException();
         }/*

         private void lblMensaje_Click(object sender, EventArgs e)
         {

         }

         private void txtFecha_TextChanged(object sender, EventArgs e)
         {
             /*Fecha = txtFecha.Text; */


        

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                MessageBox.Show("Fila eliminada correctamente");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }


        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /*private void btnAgregar2_Click_1(object sender, EventArgs e)
        {
            List<int> listaDatos = new List<int> { 10, 20, 30, 40, 50 };

            // Asegúrate de que haya suficientes filas en la DataGridView para contener los datos.
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(listaDatos.Count);

            // Agregar los datos enteros a la primera columna de la DataGridView.
            for (int i = 0; i < listaDatos.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = listaDatos[i];
            }
        }
        */
       /* private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Riesgo r1 = new Riesgo();
            Row = dataGridView1.Rows.Add();
            r1.Nombre = txtNombre.Text;
            r1.Daño = txtDano.Text;
            r1.Analista = txtAnalista.Text;
            r1.Activo = txtActivo.Text;
            r1.Tipo = txtTipo.Text;
            r1.Fecha = txtFecha.Text;
            //r1.Estado = r1.Estado.ToString(txtEstado.Text);
            r1.Id = Int32.Parse(txtId.Text);

            Riesgos.Add(r1);

            dataGridView1.Rows[Row].Cells[CELL_ID].Value = txtId;
            dataGridView1.Rows[Row].Cells[CELL_NAME].Value = txtNombre;
            dataGridView1.Rows[Row].Cells[CELL_DANO].Value = txtDano;
            dataGridView1.Rows[Row].Cells[CELL_ACTIVO].Value = txtActivo;
            dataGridView1.Rows[Row].Cells[CELL_TIPO].Value = txtTipo;
            dataGridView1.Rows[Row].Cells[CELL_FECHA].Value = txtFecha;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Riesgos;

            txtNombre.Text = string.Empty;
            txtDano.Text = string.Empty;
            txtId.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtTipo.Text = string.Empty;
            

        }*/



        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                MessageBox.Show("Fila eliminada correctamente");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            Riesgo newRiesgo = new Riesgo();
            Riesgos.Add(newRiesgo);
            
            int n = dataGridView1.Rows.Add();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Riesgos;

            
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];

            
           


            //DataGridViewRow newRow = dataGridView1.Rows[n];


            //dataGridView1.Rows[n].ToString();

            /*DataGridViewRow lastRow = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
            bool isLastRowEmpty = true;
            foreach (DataGridViewCell cell in lastRow.Cells)
            {
                if (cell.Value != null && cell.Value.ToString().Trim() != "")
                {
                    isLastRowEmpty = false;
                    break;
                }
            }

            // Si la última fila está vacía, agregar una nueva fila
            if (isLastRowEmpty)
            {
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Selected = true; // Opcional: seleccionar la nueva fila
            }
            else
            { }
            dataGridView1.Rows.Add();*/
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Riesgo r1 = new Riesgo();
            Row = dataGridView1.Rows.Add();
            r1.Id = Int32.Parse(txtId.Text);
            r1.Activo = txtActivo.Text;
            r1.Nombre = txtNombre.Text;
            r1.Tipo = txtTipo.Text;
            r1.Daño = txtDano.Text;
            r1.Analista = txtAnalista.Text;
            r1.Fecha = txtFecha.Text;
            //r1.Estado = r1.Estado.ToString(txtEstado.Text);
            

            Riesgos.Add(r1);

            dataGridView1.Rows.Add(r1.Activo, r1.Nombre, r1.Tipo, r1.Daño, r1.Analista, r1.Fecha);

            // Intentarlo con la lista nueva

            //for (int i = 0; i <  ;i++) 
            //{
            //    Riesgos[i] = r1;
            //}

            /*
            dataGridView1.Rows[Row].Cells[CELL_ID].Value = r1.Id;
            dataGridView1.Rows[Row].Cells[CELL_NAME].Value = r1.Nombre;
            dataGridView1.Rows[Row].Cells[CELL_DANO].Value = r1.Daño;
            dataGridView1.Rows[Row].Cells[CELL_ACTIVO].Value = r1.Activo;
            dataGridView1.Rows[Row].Cells[CELL_TIPO].Value = r1.Tipo;
            dataGridView1.Rows[Row].Cells[CELL_ANALISTA].Value = r1.Analista;
            dataGridView1.Rows[Row].Cells[CELL_FECHA].Value = r1.Fecha;
            */
            

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Riesgos;

            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDano.Text = string.Empty;
            txtActivo.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtAnalista.Text = string.Empty;
            txtFecha.Text = string.Empty;
            

            dataGridView1.Refresh();

            try
            {
                r1.Id = Int32.Parse(txtId.Text);
                r1.Activo = txtActivo.Text;
                r1.Nombre = txtNombre.Text;
                r1.Tipo = txtTipo.Text;
                r1.Daño = txtDano.Text;
                r1.Analista = txtAnalista.Text;
                r1.Fecha = txtFecha.Text;
            }
            catch (FormatException ex)
            {
               // MessageBox.Show("El valor de ID debe ser un número válido.");
            }

        }

        private void UpdateData(object sender, EventArgs e)
        {
            for (int i = 0 ; i < dataGridView1.Rows.Count ; i++)
            {
                var r1 = dataGridView1.Rows[i];

                r1.Cells[CELL_ID].Value = txtId.Text;
                r1.Cells[CELL_ACTIVO].Value = txtActivo.Text;
                r1.Cells[CELL_NAME].Value = txtNombre.Text;
                r1.Cells[CELL_TIPO].Value = txtTipo.Text;
                r1.Cells[CELL_DANO].Value = txtDano.Text;
                r1.Cells[CELL_ANALISTA].Value = txtAnalista.Text;
                r1.Cells[CELL_FECHA].Value = txtFecha.Text;



            }
        }
    }





    public class Riesgo
    {
        //  public int Ref { get; set; }
        public int Id { get; set; }
        public string Activo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Daño { get; set; }
        public string Analista { get; set; }
        public string Fecha { get; set; }
        //public bool Estado { get; set;}

        public int F { get; set; }
        public int S { get; set; }
        public int P { get; set; }
        public int E { get; set; }
        public int A { get; set; }
        public int V { get; set; }

        internal object Add(Riesgo riesgos)
        {
            throw new NotImplementedException();
        }
    }


}
