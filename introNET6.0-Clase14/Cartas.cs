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
            Carta01 = "   _ _ _ _\n" +
                      "|1        |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "| " + palo + "  |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "|_ _ _ _ 1|";

            Carta02 = "   _ _ _ _\n" +
                      "|2        |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "| " + palo + "  |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "|_ _ _ _ 2|";

            Carta03 = "   _ _ _ _\n" +
                      "|3        |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "| " + palo + "  |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "|_ _ _ _ 3|";

            Carta04 = "   _ _ _ _\n" +
                      "|4        |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "| " + palo + "  |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "|_ _ _ _ 4|";

            Carta05 = "   _ _ _ _\n" +
                      "|5        |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "| " + palo + "  |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "|_ _ _ _ 5|";

            Carta06 = "   _ _ _ _\n" +
                      "|6        |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "| " + palo + "  |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "|_ _ _ _ 6|";

            Carta07 = "   _ _ _ _\n" +
                      "|7        |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "| " + palo + "  |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "|_ _ _ _ 7|";

            Carta08 = "   _ _ _ _\n" +
                      "|10       |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "| " + palo + "  |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "|_ _ _ _10|";
            
            Carta09 = "   _ _ _ _\n" +
                      "|11       |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "| " + palo + "  |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "|_ _ _ _11|";

            Carta10 = "   _ _ _ _\n" +
                      "|12       |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "| " + palo + "  |\n" +
                      "|         |\n" +
                      "|         |\n" +
                      "|_ _ _ _12|";
                                  
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


