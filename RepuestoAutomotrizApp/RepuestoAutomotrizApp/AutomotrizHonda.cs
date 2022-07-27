using RepuestoAutomotrizApp.Honda;
using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp
{
    public class AutomotrizHonda : IAutomotriz  
    {
        public Axial createAxial(int cantidad)
        {
            return new HondaAxial(cantidad);
        }

        public Rotula createRotula(int cantidad)
        {
            return new HondaRotula(cantidad);
        }

        public Terminal createTerminal(int cantidad)
        {
            return new HondaTerminal(cantidad);  
        }
    }
}
