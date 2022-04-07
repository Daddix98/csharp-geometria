using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo  // creo classe rettangolo con i parametriti 
    {
        public int baseRettangolo;
        public int altezzaRettangolo;

        public Rettangolo( int baseRettangolo, int altezzaRettangolo) // creo un costrutto dove assegno i parametri della classe 
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

         public int CalcolaArea() // creo un metodo che mi calcola l'area del rettangolo
         { 
            int calcolaCArea = baseRettangolo * altezzaRettangolo;
            return calcolaCArea;
         }

        public int CalcoloPerimetro() // creo un metodo che mi calcola il perimetro del rettangolo
        {
            int calcoloCPerimetro = baseRettangolo * 2 + altezzaRettangolo * 2;
            return calcoloCPerimetro;
        }

        public void Stampa() // creo un metodo che mi stampa a video tutti i risultati dei metodi calcolo 
        {
            
            int b = baseRettangolo;
            Console.WriteLine("Base: " + baseRettangolo  + "cm");
            int h = altezzaRettangolo;
            Console.WriteLine("Altezza: " + altezzaRettangolo + "cm");
            int area = CalcolaArea();
            Console.WriteLine("Area: " + area + "cm2");
            int perimetro = CalcoloPerimetro();
            Console.WriteLine("Perimetro: " + perimetro + "cm");

        }




    }
}
