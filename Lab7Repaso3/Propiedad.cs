using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Repaso3
{
    class Propiedad
    {
        {
    public int NumeroCasa { get; set; }
        public string DPIDueño { get; set; }
        public decimal CuotaMantenimiento { get; set; }
        public Propiedad(int numeroCasa, string dpiPropietario, decimal cuotaMantenimiento)
        {
            NumeroCasa = numeroCasa;
            DPIPropietario = dpiPropietario;
            CuotaMantenimiento = cuotaMantenimiento;
        }
    }
}
