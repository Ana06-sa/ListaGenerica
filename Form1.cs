using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaGenerica
{
    public partial class ListaGe : Form
    {
        public ListaGe()
        {
            InitializeComponent();
        }
        ListaGenerica<string> lista = new ListaGenerica<string>();

        private void ListaGenerica_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtDato.Text != "")  
            {
                lista.Agregar(txtDato.Text);
                txtDato.Text = "";   // limpiar
                MessageBox.Show("Elemento agregado.");
            }
            else
            {
                MessageBox.Show("Escribe un dato primero.");
            }

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtDato.Text != "")
            {
                int indice = Convert.ToInt32(txtDato.Text); 
                lista.Eliminar(indice);
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Escribe un índice válido para eliminar.");
            }

        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            MostrarLista();
        }

        // Método sencillo para mostrar en el TextBox
        private void MostrarLista()
        {
            txtMosDatos.Text = ""; // limpiar

            // Obtener los datos como una lista
            List<string> datos = lista.Mostrar();
            for (int i = 0; i < datos.Count; i++) // Cambiar Length por Count
            {
                if (datos[i] != null) // que no esté vacío
                {
                    txtMosDatos.Text = txtMosDatos.Text + "[" + i + "] " + datos[i] + "\n"; // en lugar de Environment.NewLine
                }
            }
        }
    }
}
