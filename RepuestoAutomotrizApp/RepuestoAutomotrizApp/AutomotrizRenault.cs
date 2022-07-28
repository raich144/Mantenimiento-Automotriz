using RepuestoAutomotrizApp.Renault;
using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp
{
    public class AutomotrizRenault : IAutomotriz
    {
        public Axial createAxial(int cantidad)
        {
            return new RenaultAxial(cantidad);
        }

        public Rotula createRotula(int cantidad)
        {
            throw new NotImplementedException();
        }

        public Terminal createTerminal(int cantidad)
        {
            throw new NotImplementedException();
        }
    }
}
