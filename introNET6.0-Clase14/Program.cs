using introNET6._0_Clase14;

//Creo las 4 variaciones de palos.
Cartas espadas = new Cartas("Espada");
Cartas bastos = new Cartas(" Basto");
Cartas oros = new Cartas("  Oro ");
Cartas copas = new Cartas(" Copa ");

//Creo un vector por cada palo
var vectorCartasEspadas = espadas.GetCartas();
var vectorCartasBastos = bastos.GetCartas();
var vectorCartasOros = oros.GetCartas();
var vectorCartasCopas = copas.GetCartas();

//Asigno todos los palos a un mazo/baraja en una lista.
Mazo mazo = new Mazo(vectorCartasEspadas, vectorCartasBastos, vectorCartasOros, vectorCartasCopas);

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
            mazo.Barajar();
            Console.WriteLine("la baraja se ha barajado!");
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("Carta Actual: ");
            Console.WriteLine(mazo.Cartas.First());
            break;

        case 3:
            Console.Clear();
            List<string> tempListaDeCartasSiguiente = mazo.SiguienteCarta();
            foreach (var carta in tempListaDeCartasSiguiente)
            {
                Console.WriteLine(carta);
            }

            break;

        case 4:
            Console.Clear();
            Console.WriteLine("Quedan en la baraja: " + mazo.Cartas.Count + " cartas.");
            break;

        case 5:
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de cartas que desea: ");
            int cantidad = int.Parse(Console.ReadLine());
            List<string> tempListaDeCartas = mazo.DarCartas(cantidad);

            foreach (var carta in tempListaDeCartas)
            {
                Console.WriteLine(carta);
            }
            
            break;

        case 6:
            
            Console.Clear();
            List<string> tempListaDeCartasMonton = mazo.CartasMonton();

            foreach (var carta in tempListaDeCartasMonton)
            {
                Console.WriteLine(carta);
            }
            break;

        case 7:
            Console.Clear();

            foreach (var carta in mazo.Cartas)
            {
                Console.WriteLine(carta);
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
