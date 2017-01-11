using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    class Program
    {
        static void Main(string[] args);
        

            interface  IZarzadzaj
{
                void DodajAutobus(int iloscMiejsc);
                void DodajSamolot(int iloscMiejsc, int odleglosc);
                void UsunOstatni();
                void Wyczysc();


}

       interface IData
       {

             void UstawDate(DateTime data);
             bool SprawdzDate();
}



        }
    
}
