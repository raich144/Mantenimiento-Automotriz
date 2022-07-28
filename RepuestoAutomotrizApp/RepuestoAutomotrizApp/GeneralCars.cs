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
            
            Axial axial = marca.createAxial(5);
            Rotula rotula = marca.createRotula(5);
            Terminal terminal = marca.createTerminal(5);

            listaRepuesto.Add(axial);
            listaRepuesto.Add(rotula);
            listaRepuesto.Add(terminal);
        }

        public void realizarProforma() 
        {
            string item = "";
            double total = 0.00;
            foreach (var repuesto in listaRepuesto)
            {
                total += repuesto.insertarTotalProforma();
                item += repuesto.insertarItemProforma();       
            }
            imprimirCabecera();
            Console.WriteLine(item);
            imprimirTotal(total);
            
        }

        public void imprimirCabecera()
        {
            string cabecera = "---------------------------------------------------------------------------\n"
                            + "|  \t\tPROFROMA 0001 : REPUESTOS PARA AUTO \t\t\t   |\n"
                            + "---------------------------------------------------------------------------\n"
                            + "| CANT.\t| " + "\t\tDESCRIPCION\t\t| " + "P. UNITARIO | " + " IMPORTE   |\n"
                            + "---------------------------------------------------------------------------";
            Console.WriteLine(cabecera);    
        }

        public void imprimirTotal(double total)
        {
            string totalItem = "|      \t| " + "\t\t           \t\t| " + "TOTAL:       | " + " " + total + "    |\n"
                            + "---------------------------------------------------------------------------";

            Console.WriteLine(totalItem);
        }
    }
}
