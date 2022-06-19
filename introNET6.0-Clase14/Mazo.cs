using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introNET6._0_Clase14
{
    internal class Mazo
    {
        public List<String> Cartas { get; set; }
        public List<String> CartasFueraDeBaraja { get; set; }


        public Mazo(String[] palo1, String[] palo2, String[] palo3, String[] palo4)
        {
            CartasFueraDeBaraja = new List<String>();
            Cartas = new List<String>();
            Cartas.AddRange(palo1);
            Cartas.AddRange(palo2);
            Cartas.AddRange(palo3);
            Cartas.AddRange(palo4);
        }

        public List<String> GetMazo()
        {
            return Cartas;
        }

        public void Barajar()
        {
            Random aleatorio = new Random();

            List<string> nuevaListDeCartas = new List<string>();
            List<int> nuevoOrdenDeCartas = new List<int>();
                                   
            for (int i = 0; i < Cartas.Count; i++)
            {
                int numeroAleatorio;

                do
                {
                    numeroAleatorio = aleatorio.Next(0, Cartas.Count);
                }
                while (nuevoOrdenDeCartas.Contains(numeroAleatorio));

                nuevoOrdenDeCartas.Add(numeroAleatorio);
            }

            foreach (int index in nuevoOrdenDeCartas)
            {
                nuevaListDeCartas.Add(Cartas[index]);
            }

            Cartas.Clear();
            Cartas = nuevaListDeCartas.ToList();
        }

        public List<String> SiguienteCarta()
        {
            List<string> tempCartas = DarCartas(1);

            return tempCartas;
        }

        public List<string> DarCartas(int cantidad)
        {

            if (cantidad > Cartas.Count)
            {
                List<string> tempCartas = new List<string>();
                tempCartas.Add("No hay cartas suficientes");

                return tempCartas;
            }
            else
            {
                List<string> tempCartas = new List<string>();

                for (int i = 0; i < cantidad; i++)
                {
                    tempCartas.Add(Cartas[i]);
                    CartasFueraDeBaraja.Add(Cartas[i]);
                }

                for (int i = 0; i < cantidad; i++)
                {
                    Cartas.RemoveAt(0);
                }

                return tempCartas;
            }

        }

        public List<string> CartasMonton()
        {
            if (CartasFueraDeBaraja.Count == 0)
            {
                List<string> tempCartas = new List<string>();
                tempCartas.Add("No hay cartas fuera de la baraja");

                return tempCartas;
            }
            else
            {
                return CartasFueraDeBaraja;
            }
        }

    }






}
