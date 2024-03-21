using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ControlPagosCondominio
{
    public partial class MainForm : Form
    {
        private List<Propietario> propietarios = new List<Propietario>();
        private List<Propiedad> propiedades = new List<Propiedad>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Aquí cargarías los datos de propietarios y propiedades desde archivos o cualquier otra fuente de datos
            CargarDatosPropietarios();
            CargarDatosPropiedades();

            // Combinar los datos y mostrarlos en el DataGridView
            MostrarDatos();
        }

        private void CargarDatosPropietarios()
        {
            // Aquí cargarías los datos de los propietarios desde el archivo o la base de datos
            // Este es solo un ejemplo de datos estáticos
            propietarios.Add(new Propietario("123456789", "Juan", "Pérez"));
            propietarios.Add(new Propietario("987654321", "María", "Gómez"));
            // Agregar más propietarios según sea necesario
        }

        private void CargarDatosPropiedades()
        {
            // Aquí cargarías los datos de las propiedades desde el archivo o la base de datos
            // Este es solo un ejemplo de datos estáticos
            propiedades.Add(new Propiedad(1, "123456789", 100));
            propiedades.Add(new Propiedad(2, "987654321", 150));
            // Agregar más propiedades según sea necesario
        }

        private void MostrarDatos()
        {
            var query = from propiedad in propiedades
                        join propietario in propietarios on propiedad.DPIPropietario equals propietario.DPI
                        select new
                        {
                            Nombre = propietario.Nombre,
                            Apellido = propietario.Apellido,
                            NumeroCasa = propiedad.NumeroCasa,
                            CuotaMantenimiento = propiedad.CuotaMantenimiento
                        };

            dgvPropiedades.DataSource = query.ToList();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Ordenar el DataGridView por cuota de mantenimiento
            dgvPropiedades.Sort(dgvPropiedades.Columns["CuotaMantenimiento"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnCuotasAltas_Click(object sender, EventArgs e)
        {
            // Mostrar las 3 cuotas de mantenimiento más altas
            var cuotasAltas = propiedades.OrderByDescending(p => p.CuotaMantenimiento).Take(3);
            MostrarCuotas(cuotasAltas);
        }

        private void btnPropietarioMasAlta_Click(object sender, EventArgs e)
        {
            // Mostrar al propietario con la cuota total más alta
            var propietarioMasAlta = propietarios.OrderByDescending(p => p.CalcularCuotaTotal(propiedades)).FirstOrDefault();
            if (propietarioMasAlta != null)
            {
                MessageBox.Show($"El propietario con la cuota total más alta es: {propietarioMasAlta.Nombre} {propietarioMasAlta.Apellido}. Debe pagar: {propietarioMasAlta.CalcularCuotaTotal(propiedades)}");
            }
        }

        private void MostrarCuotas(IEnumerable<Propiedad> propiedades)
        {
            string cuotas = "Las cuotas de mantenimiento más altas son:\n";
            foreach (var propiedad in propiedades)
            {
                cuotas += $"Número de casa: {propiedad.NumeroCasa}, Cuota de mantenimiento: {propiedad.CuotaMantenimiento}\n";
            }
            MessageBox.Show(cuotas);
        }
    }
}