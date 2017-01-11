using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc ;
        protected double cenaBiletu ;
        public SrodekLokomocji();



	virtual public void ObliczCene() 
{

double a, b, wynik;
a = iloscMiejsc ;
b = cenaBiletu;

wynik = (b = a * 3);    Console.WriteLine(wynik);
Console.ReadKey(); 
 {

 }
    }

   

}
    }