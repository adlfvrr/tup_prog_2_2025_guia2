using ej1.Models;
namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona nuevaPersona;
        ModalDatos modalPersona;
        Servicio servicio = new Servicio();
        private void btnListar_Click(object sender, EventArgs e)
        {
            lsbListar.Items.Clear();
            for(int i = 0; i < servicio.VerCantidadPersonas(); i++)
            {
                lsbListar.Items.Add(servicio.VerPersona(i).Describir());
            }
            lsbListar.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modalPersona = new ModalDatos();
            if (modalPersona.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(modalPersona.tbDNI.Text);
                string nombre = (modalPersona.tbNombre.Text);
                if (servicio.AgregarPersona(dni, nombre) == false)
                {
                    MessageBox.Show("DNI ya existente");
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            modalPersona = new ModalDatos();
            if (modalPersona.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(modalPersona.tbDNI.Text);
                if (servicio.VerPersonaPorDNI(dni) != null)
                {
                    MessageBox.Show($"DNI: {dni} - Nombre: {servicio.VerPersonaPorDNI(dni).Nombre}");
                }
                else
                {
                    MessageBox.Show("Persona no encontrada");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            modalPersona = new ModalDatos();
            if (modalPersona.ShowDialog() == DialogResult.OK)
            {
                Persona persona = servicio.VerPersonaPorDNI(Convert.ToInt32(modalPersona.tbDNI.Text));
                servicio.EliminarPersona(persona);
                lsbListar.Items.Remove(persona);
            }
        }
    }
}
