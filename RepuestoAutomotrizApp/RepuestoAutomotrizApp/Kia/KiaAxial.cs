using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp.Kia
{
    public class KiaAxial : Axial
    {
        //Atributos
        const string DESCRIPCION = "Axial original Kia";
        const double PRECIO = 15.55;
        int cantidad;

        //Varibale global
        double total = 0.00;

        public KiaAxial(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public override string insertarItemProforma()
        {
            double importe = this.cantidad * PRECIO;
            importe = Math.Round(importe, 2);
            string presupuesto = "|  " + cantidad + "\t| " + "\t" + DESCRIPCION + "\t\t| " + "   " + PRECIO +
                                "    |   " + importe + "\t" + "   |\n" +
                                "---------------------------------------------------------------------------\n";

            return presupuesto;
        }

        public override double insertarTotalProforma()
        {
            total = cantidad * PRECIO;
            return total;
        }
    }
}
