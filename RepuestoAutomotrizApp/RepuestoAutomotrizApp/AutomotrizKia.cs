using RepuestoAutomotrizApp.Kia;
using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp
{
    public class AutomotrizKia : IAutomotriz
    {
        public Axial createAxial(int cantidad)
        {
            return new KiaAxial(cantidad);
        }

        public Rotula createRotula(int cantidad)
        {
            return new KiaRotula(cantidad);
        }

        public Terminal createTerminal(int cantidad)
        {
            return new KiaTerminal(cantidad);
        }
    }
}
