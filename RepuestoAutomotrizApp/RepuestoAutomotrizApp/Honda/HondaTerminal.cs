using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp.Honda
{
    public class HondaTerminal : Terminal
    {
        //Atributos
        const string DESCRIPCION = "Terminal marca Honda";
        const double PRECIO = 15.55;
        int cantidad;

        public HondaTerminal(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public override string CalularPresupuesto()
        {
            double importe = this.cantidad * PRECIO;
            string presupuesto = "|  " + cantidad + "\t| " + "\t" + DESCRIPCION + "\t\t| " + "   " + PRECIO +
                                "    |   " + importe + "   |\n" +
                                "---------------------------------------------------------------------------";


            return presupuesto;
        }
    }
}                              
