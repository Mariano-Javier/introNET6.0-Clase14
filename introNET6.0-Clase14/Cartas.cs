using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introNET6._0_Clase14
{
    internal class Cartas
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

        public List<string> CartasMezcladas() //mezcla las 10 cartas del mismo palo.
        {
            Random aleatorio = new Random();

            List<string> NuevaListDeCartas = new List<string>();
            List<int> NuevaListOfIndex = new List<int>();
            List<string> listDeCartas = new List<string>()
            {
                Carta01, Carta02, Carta03, Carta04, Carta05, Carta06, Carta07, Carta08, Carta09, Carta10
            };

            List<int> listOfNumbers = new List<int>()
            {
                    0,1,2,3,4,5,6,7,8,9
            };

            int totalCartas = listDeCartas.Count;

            for (int i = 0; i < totalCartas; i++)
            {
                int numeroAleatorio;

                do
                {
                    numeroAleatorio = aleatorio.Next(0, 10);
                }
                while (NuevaListOfIndex.Contains(numeroAleatorio));

                NuevaListOfIndex.Add(numeroAleatorio);
                listOfNumbers.Remove(numeroAleatorio);
            }

            foreach (int index in NuevaListOfIndex)
            {
                NuevaListDeCartas.Add(listDeCartas[index]);
            }

            return NuevaListDeCartas;
        }

    }
}


