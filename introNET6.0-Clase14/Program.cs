using introNET6._0_Clase14;

//Creo las 4 variaciones de palos.
Cartas espadas = new Cartas("Espada");
Cartas bastos = new Cartas("Basto");
Cartas oros = new Cartas("Oro");
Cartas copas = new Cartas("Copa");

//Creo un vector por cada palo
var vectorCartasEspadas = espadas.GetCartas();
var vectorCartasBastos = bastos.GetCartas();
var vectorCartasOros = oros.GetCartas();
var vectorCartasCopas = copas.GetCartas();

//Asigno todos los palos a un mazo/baraja en una lista.
List<String> baraja = new List<String>();

baraja.AddRange(vectorCartasEspadas);
baraja.AddRange(vectorCartasBastos);
baraja.AddRange(vectorCartasOros);
baraja.AddRange(vectorCartasCopas);


//static List<string> Barajar(List<string> baraja)
//{
//    //Barajo la baraja
//    var nuevaBaraja = baraja.OrderBy(emp => Guid.NewGuid()).ToList();
//    return nuevaBaraja;
//}


static List<string> Barajar(List<string> baraja)
{
    Random aleatorio = new Random();

    List<string> NuevaListDeCartas = new List<string>();
    List<int> NuevaListOfIndex = new List<int>();
    List<string> listDeCartas = baraja;

    List<int> listOfNumbers = new List<int>()
            {
                    0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39
            };

    int totalCartas = listDeCartas.Count;

    for (int i = 0; i < totalCartas; i++)
    {
        int numeroAleatorio;

        do
        {
            numeroAleatorio = aleatorio.Next(0, 40);
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









var barajaBarajada = Barajar(baraja);

foreach (string name in barajaBarajada)
{
    Console.WriteLine(name);
}