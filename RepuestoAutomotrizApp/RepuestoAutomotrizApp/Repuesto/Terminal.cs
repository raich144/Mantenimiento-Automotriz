using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp.Repuesto
{
    public abstract class Terminal : IRepuesto
    {
       public abstract string insertarItemProforma();

        public abstract double insertarTotalProforma();
       
    }
}
