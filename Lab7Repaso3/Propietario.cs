using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Repaso3
{
    public class Propietario
    {
        {
        public string DPI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Propietario(string dpi, string nombre, string apellido)
        {
            DPI = dpi;
            Nombre = nombre;
            Apellido = apellido;
        }

        public decimal CalcularCuotaTotal(IEnumerable<Propiedad> propiedades)
        {
            return propiedades.Where(p => p.DPIPropietario == DPI).Sum(p => p.CuotaMantenimiento);
        }
    }
}
