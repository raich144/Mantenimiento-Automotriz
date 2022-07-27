using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp
{
    public interface IAutomotriz
    {
        public Axial createAxial(int cantidad);
        public Rotula createRotula(int cantidad);
        public Terminal createTerminal(int cantidad);

    
    }
}
