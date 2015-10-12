using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tarea_ejercicios_cap_11
{
    public partial class TareaCap11 : Form
    {
        
        public string informacion="";
        public MemoryStream cadena = new MemoryStream(50);
        byte[] buffer = new byte[50];
        public string nombre = "";
        public string direccion = "";
        public TareaCap11()
        {
            InitializeComponent();
        }

        private void TareaCap11_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            informacion = txtCadena.Text;
            cadena.Write(ASCIIEncoding.ASCII.GetBytes(informacion), 0, informacion.Length);
            cadena.Seek(0, SeekOrigin.Begin);
            cadena.Read(buffer, 0, 5).ToString();
            informacion = ASCIIEncoding.ASCII.GetString(buffer);
            for (int i = informacion.Length - 1; i >= 0; i--)
            {
                lbResultado.Text += informacion[i];
            }
            
        }
         
        private void btnProcesar2_Click(object sender, EventArgs e)
        {
            nombre = txtNombreArchivo.Text;
            direccion = txtDireccionArchivo.Text;
            FileStream archivo = new FileStream(@nombre,FileMode.Open);
            
            archivo.Read(buffer, 0, (int)archivo.Length);
            lbResultado2.Text += ASCIIEncoding.ASCII.GetString(buffer);
            
        }

        private void btnProcesar3_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = txtArchivoNombre.Text;
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente decea borrar el archivo?", "Eliminar archivo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {

                    FileStream fs = new FileStream(@nombre, FileMode.Truncate);
                }
            }
            catch (Exception ex) { MessageBox.Show("La direccion es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
       }
    }
}
