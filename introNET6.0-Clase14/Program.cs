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

//Creo la función que baraja aleatoriamente las 40 cartas.

//static List<string> Barajar(List<string> baraja)
//{
//    //Función que ordena aleatoriamente una lista.
//    var nuevaBaraja = baraja.OrderBy(emp => Guid.NewGuid()).ToList();
//    return nuevaBaraja;
//}
List<string> barajaBarajada = new List<string>(baraja);
List<string> cartasFueraDeBaraja = new List<string>();

static List<string> Barajar(List<string> baraja)
{
    Random aleatorio = new Random();

    List<string> NuevaListDeCartas = new List<string>();
    List<int> NuevaListOfIndex = new List<int>();
    List<string> listDeCartas = baraja;

    List<int> listOfNumbers = new List<int>();


    for (int i = 0; i < baraja.Count; i++)
    {
        listOfNumbers.Add(i);
    };
    
    int totalCartas = listDeCartas.Count;

    for (int i = 0; i < totalCartas; i++)
    {
        int numeroAleatorio;

        do
        {
            numeroAleatorio = aleatorio.Next(0, baraja.Count);
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

// Devuelve la baraja mezclada aleatoriamente.
//var barajaBarajada = Barajar(baraja);

// imprime toda la baraja mezclada.
//foreach (string name in barajaBarajada)
//{
//    Console.WriteLine(name);
//}


// Imprime las cartas 1 por 1 hasta que se acaben las cartas.

static List<string> SiguienteCarta(List<string> baraja, List<string> cartasFueraDeBaraja)
{
    cartasFueraDeBaraja.Add(baraja[0]);
    baraja.RemoveAt(0);
    return baraja;
}




static List<string> DarCartas(int cantidad, List<string> barajaBarajada, List<string> cartasFueraDeBaraja)
{
    List<string> cartas = new List<string>();

    for (int i = 0; i < cantidad; i++)
    {
        cartas.Add(barajaBarajada[i]);
        cartasFueraDeBaraja.Add(barajaBarajada[i]);
    }

    for (int i = 0; i < cantidad; i++)
    {
        barajaBarajada.RemoveAt(0);
    }

    return cartas;
}

//barajaBarajada = SiguienteCarta(barajaBarajada);


//var barajaBarajada = baraja;

int opcion;
do
{
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("-----------Seleccione una opción--------------------");
    Console.WriteLine("1- Barajar cartas");
    Console.WriteLine("2- Mostrar carta Actual");
    Console.WriteLine("3- Mostrar siguiente carta");
    Console.WriteLine("4- Mostrar cartas disponibles");
    Console.WriteLine("5- Dar cartas");
    Console.WriteLine("6- Cartas Fuera de la Baraja");
    Console.WriteLine("7- Mostrar baraja");
    Console.WriteLine("8- Salir");
    Console.WriteLine("----------------------------------------------------");
    opcion = int.Parse(Console.ReadLine());


    
    switch (opcion)
    {
        case 1:
            Console.Clear();
            barajaBarajada = Barajar(barajaBarajada);
            Console.WriteLine("la baraja se ha barajado!");
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("Carta Actual: " + barajaBarajada[0]);
            break;
            
        case 3:
            Console.Clear();
            barajaBarajada = SiguienteCarta(barajaBarajada, cartasFueraDeBaraja);
            Console.WriteLine("Carta siguiente: " + barajaBarajada[0]);

            if (barajaBarajada.Count == 0)
            {
                Console.WriteLine("No hay cartas en la baraja!");
            }
            break;

        case 4:
            Console.Clear();
            Console.WriteLine("Quedan en la baraja: " + barajaBarajada.Count+" cartas.");
            break;

        case 5:
            Console.Clear();
            List<string> cartasCantidad = new List<string>();
            
            Console.WriteLine("Ingrese la cantidad de cartas que desea: ");
            int cantidad = int.Parse(Console.ReadLine());

            if ( cantidad > barajaBarajada.Count)
            {
                Console.WriteLine("No hay suficientes cartas en la baraja!");
                break;
            }
            else
            {
                Console.Clear();
                cartasCantidad = DarCartas(cantidad, barajaBarajada, cartasFueraDeBaraja);

                foreach (string name in cartasCantidad)
                {
                    Console.WriteLine(name);
                }
                break;

            }


        case 6:
            Console.Clear();

            if (cartasFueraDeBaraja.Count == 0)
            {
                Console.WriteLine("No hay cartas fuera de la baraja!");
                break;
            }

            else
            {
                foreach (string name in cartasFueraDeBaraja)
                {
                    Console.WriteLine(name);
                }
                break;
            }

        case 7:
            Console.Clear();


            foreach (string name in barajaBarajada)
            {
                Console.WriteLine(name);
            }
            break;


        case 8:
            break;
            
        default:
            Console.WriteLine("Opción inválida");
            break;
    }

}
while (opcion != 8);







