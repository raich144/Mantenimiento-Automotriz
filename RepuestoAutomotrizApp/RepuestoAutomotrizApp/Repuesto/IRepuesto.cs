using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp.Repuesto
{
    public interface IRepuesto
    {
        public string insertarItemProforma();
        public double insertarTotalProforma();
    }
}
