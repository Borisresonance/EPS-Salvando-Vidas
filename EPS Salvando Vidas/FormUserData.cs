using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EPS_Salvando_Vidas
{
    public partial class FormUserData : Form
    {
        private Stack<Paciente> pila = new Stack<Paciente>();
        private Queue<Paciente> cola = new Queue<Paciente>();
        private List<Paciente> lista = new List<Paciente>();

        public FormUserData()
        {
            InitializeComponent();
        }

        // Update Copago
        private void UpdateCopago()
        {
            if (cmbEstrato.SelectedIndex != -1 && (rbMedicinaGeneral.Checked || rbExamenLaboratorio.Checked))
            {
                string selectedEstrato = cmbEstrato.SelectedItem.ToString();
                if (int.TryParse(selectedEstrato, out int estrato))
                {
                    string tipoAtencion = rbMedicinaGeneral.Checked ? "Medicina General" : "Examen Laboratorio";
                    decimal copago = CopagoCalculator.CalculateCopago(estrato, tipoAtencion);
                    txtCopago.Text = copago.ToString("C");
                }
                else
                {
                    MessageBox.Show("Please select a valid Estrato.");
                }
            }
            else
            {
                MessageBox.Show("Please select an Estrato and type of attention.");
            }
        }

        // Exit Button Click Handler
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Handle keypress to allow only numbers
        private void txtNumeroIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Disallow non-numeric input
            }
        }

        // Handle keypress to allow only letters and spaces
        private void txtNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Disallow non-alphabetic input
            }
        }

        // Update copago when Estrato changes
        private void cmbEstrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCopago();
        }

        // Handle keypress to allow only numbers
        private void numEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Disallow non-numeric input
            }
        }

        // Update copago when MedicinaGeneral is checked
        private void rbMedicinaGeneral_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCopago();
        }

        // Update copago when ExamenLaboratorio is checked
        private void rbExamenLaboratorio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCopago();
        }

        // Register patient
        private void btnRegistrar_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNumeroIdentificacion.Text) ||
        string.IsNullOrEmpty(numEdad.Text) || cmbEstrato.SelectedIndex == -1 ||
        (!rbMedicinaGeneral.Checked && !rbExamenLaboratorio.Checked))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtNumeroIdentificacion.Text, out int numeroIdentificacionInt))
            {
                MessageBox.Show("El número de identificación no es válido. Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtNombre.Text;
            int edad = Convert.ToInt32(numEdad.Text);

            if (!int.TryParse(cmbEstrato.SelectedItem.ToString(), out int estrato))
            {
                MessageBox.Show("El estrato seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipoAtencion = rbMedicinaGeneral.Checked ? "Medicina General" : "Examen Laboratorio";
            decimal copago = CopagoCalculator.CalculateCopago(estrato, tipoAtencion);

            Paciente newPaciente = new Paciente
            {
                Id = numeroIdentificacionInt,
                Nombre = nombre,
                Edad = edad,
                Estrato = estrato,
                TipoAtencion = tipoAtencion,
                Copago = copago
            };

            // Use selected structure to add the patient
            switch (selectedStructure)
            {
                case "Pila":
                    pila.Push(newPaciente);
                    UpdateDataGridView(dgvPila, pila);
                    break;
                case "Cola":
                    cola.Enqueue(newPaciente);
                    UpdateDataGridView(dgvCola, cola);
                    break;
                case "Lista":
                    lista.Add(newPaciente);
                    UpdateDataGridView(dgvLista, lista);
                    break;
            }

            ClearFormFields();

        }

        // Update DataGridView based on collection
        private void UpdateDataGridView(DataGridView dataGridView, IEnumerable<Paciente> collection)
        {
            dataGridView.Rows.Clear();
            foreach (var paciente in collection)
            {
                dataGridView.Rows.Add(
                    paciente.Id,              // ID Number
                    paciente.Nombre,          // Name
                    paciente.Edad,            // Age
                    paciente.Estrato,         // Estrato
                    paciente.TipoAtencion,    // Tipo de Atención
                    paciente.Copago.ToString("C")  // Copago Value
                );
            }
        }

        // Clear the form fields
        private void ClearFormFields()
        {
            txtNombre.Clear();
            txtNumeroIdentificacion.Clear();
            numEdad.Clear();
            cmbEstrato.SelectedIndex = -1;
            rbMedicinaGeneral.Checked = false;
            rbExamenLaboratorio.Checked = false;
            txtCopago.Clear();
        }

        // Missing event handler for button2 click
        private void button2_Click(object sender, EventArgs e)
        {

            txtNombre.Clear();
            txtNumeroIdentificacion.Clear();
            numEdad.Clear();
            cmbEstrato.SelectedIndex = -1;
            rbMedicinaGeneral.Checked = false;
            rbExamenLaboratorio.Checked = false;
            txtCopago.Clear();


        }



        // Missing event handler for label8 click
        private void label8_Click(object sender, EventArgs e)
        {
            // Handle label8 click event
        }

        // Missing event handler for label4 click
        private void label4_Click(object sender, EventArgs e)
        {
            // Handle label4 click event
        }

        // Missing event handler for comboBox1 SelectedIndexChanged
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call UpdateCopago() or other related logic when combobox value changes
        }

        // Missing event handler for pilaTab click
        private void pilaTab_Click(object sender, EventArgs e)
        {
            // Handle click on 'pilaTab' to update the display or perform any required action
        }

        // Form load event handler
        private void FormUserData_Load(object sender, EventArgs e)
        {
            // Handle form load event
            // Initialize or load any necessary data when the form is loaded
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string selectedStructure = "Pila"; // Default structure

        private void cmbEstructura_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStructure = cmbEstructura.SelectedItem?.ToString() ?? "Pila";

        }
    }
}
