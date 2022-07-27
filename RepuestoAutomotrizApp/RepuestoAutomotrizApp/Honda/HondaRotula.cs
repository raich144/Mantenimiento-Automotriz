using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp.Honda
{
    public class HondaRotula : Rotula
    {
        //Atributos
        const string DESCRIPCION = "Rotula marca Honda";
        const double PRECIO = 10.00;
        int cantidad;

        public HondaRotula(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public override string CalularPresupuesto()
        {
            double importe = this.cantidad * PRECIO;
            string presupuesto = "|  " + cantidad + "\t| " + "\t" + DESCRIPCION + "\t\t| " + "   " + PRECIO +
                                "    |   " + importe + "\t" + "   |" +
                                "---------------------------------------------------------------------------";


            return presupuesto;
        }
    }
}
