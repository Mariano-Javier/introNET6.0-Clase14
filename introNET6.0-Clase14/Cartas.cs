using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introNET6._0_Clase14
{
    public class Cartas
    {
        public string Carta01 { get; set; }
        public string Carta02 { get; set; }
        public string Carta03 { get; set; }
        public string Carta04 { get; set; }
        public string Carta05 { get; set; }
        public string Carta06 { get; set; }
        public string Carta07 { get; set; }
        public string Carta08 { get; set; }
        public string Carta09 { get; set; }
        public string Carta10 { get; set; }
        
        public Cartas(string palo)
        {
            Carta01 = "1 de " + palo;
            Carta02 = "2 de " + palo;
            Carta03 = "3 de " + palo;
            Carta04 = "4 de " + palo;
            Carta05 = "5 de " + palo;
            Carta06 = "6 de " + palo;
            Carta07 = "7 de " + palo;
            Carta08 = "10 de " + palo;
            Carta09 = "11 de " + palo;
            Carta10 = "12 de " + palo;
        }

        public string[] GetCartas() //Envia en forma de vector las cartas ordenadas.
        {
            string[] cartas = new string[10];
            cartas[0] = Carta01;
            cartas[1] = Carta02;
            cartas[2] = Carta03;
            cartas[3] = Carta04;
            cartas[4] = Carta05;
            cartas[5] = Carta06;
            cartas[6] = Carta07;
            cartas[7] = Carta08;
            cartas[8] = Carta09;
            cartas[9] = Carta10;
            return cartas;
        }
    }
}


