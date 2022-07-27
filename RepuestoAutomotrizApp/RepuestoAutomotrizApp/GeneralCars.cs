using RepuestoAutomotrizApp.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuestoAutomotrizApp
{
    public class GeneralCars
    {
        //Atributos
        IAutomotriz marca;
        List<IRepuesto> listaRepuesto;

        public GeneralCars(IAutomotriz marca)
        {
            this.marca = marca;
            this.listaRepuesto = new List<IRepuesto>();   
        }

        public void CreateRepuestos() 
        {
            //Label titulo = sistema.createLabel("Are yu Sure?.");
            Axial axial = marca.createAxial(5);
            Rotula rotula = marca.createRotula(5);
            Terminal terminal = marca.createTerminal(5);

            listaRepuesto.Add(axial);
            listaRepuesto.Add(rotula);
            listaRepuesto.Add(terminal);
        }

        public void realizarProforma() 
        {
            string screen = "";
            foreach (var repuesto in listaRepuesto)
            {
                screen = repuesto.CalularPresupuesto();
            }
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("|  \t\tPROFROMA 0001 : REPUESTOS PARA AUTO HONDA\t\t  |");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("| CANT.\t| " + "\t\tDESCRIPCION\t\t| " + "P. UNITARIO | " + " IMPORTE  |");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine(screen);
        }
    }
}
