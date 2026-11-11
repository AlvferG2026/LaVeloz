using System;
using System.Windows.Forms;
using LaVeloz.Logica;

namespace LaVeloz.Ui
{
    public partial class Form1 : Form
    {
        private GestorPasajeros gestor = new GestorPasajeros();

        public Form1()
        {
            InitializeComponent();
            MostrarPasajeros();
        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            string nombre = txtNOMBRE.Text.Trim();
            string destino = cmbDESTINO.Text.Trim();

            if (dni == "" || nombre == "" || destino == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            foreach (char caracter in dni)
            {
                if (!char.IsDigit(caracter))
                {
                    MessageBox.Show("El DNI debe contener solamente números.");
                    return;
                }
            }

            foreach (Pasajero p in gestor.ObtenerPasajeros())
            {
                if (p.DNI == dni)
                {
                    MessageBox.Show("Ya existe un pasajero con ese DNI.");
                    return;
                }
            }

            Pasajero nuevo = new Pasajero(dni, nombre, destino);
            gestor.AgregarPasajero(nuevo);

            MessageBox.Show("Pasajero registrado correctamente.");

            LimpiarCampos();
            MostrarPasajeros();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            if (dni == "")
            {
                MessageBox.Show("Ingrese el DNI del pasajero que desea eliminar.");
                return;
            }

            bool eliminado = gestor.EliminarPasajero(dni);

            if (eliminado)
            {
                MessageBox.Show("Pasajero eliminado correctamente.");
                LimpiarCampos();
                MostrarPasajeros();
            }
            else
            {
                MessageBox.Show("No se encontró un pasajero con ese DNI.");
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            string nombre = txtNOMBRE.Text.Trim();
            string destino = cmbDESTINO.Text.Trim();

            if (dni == "" || nombre == "" || destino == "")
            {
                MessageBox.Show("Complete todos los campos para modificar.");
                return;
            }

            foreach (char caracter in dni)
            {
                if (!char.IsDigit(caracter))
                {
                    MessageBox.Show("El DNI debe contener solamente números.");
                    return;
                }
            }

            bool modificado = gestor.ModificarPasajero(
                dni, nombre, destino
            );

            if (modificado)
            {
                MessageBox.Show("Pasajero modificado correctamente.");
                LimpiarCampos();
                MostrarPasajeros();
            }
            else
            {
                MessageBox.Show("No se encontró un pasajero con ese DNI.");
            }
        }

        private void MostrarPasajeros()
        {
            txtINFORMACION.Clear();

            foreach (Pasajero p in gestor.ObtenerPasajeros())
            {
                txtINFORMACION.AppendText(
                    "DNI: " + p.DNI +
                    " | Nombre: " + p.Nombre +
                    " | Destino: " + p.Destino +
                    Environment.NewLine
                );
            }
        }

        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNOMBRE.Clear();
            cmbDESTINO.SelectedIndex = -1;
        }

        private void btnREGISTRARDESTINO_Click(object sender, EventArgs e)
        {
            if (cmbDESTINO.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione un destino.");
                return;
            }

            MessageBox.Show("Destino seleccionado: " + cmbDESTINO.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}