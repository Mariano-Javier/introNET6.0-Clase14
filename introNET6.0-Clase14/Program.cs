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



var cartasEspadaMezclada = espadas.CartasMezcladas();

foreach (string name in cartasEspadaMezclada)
{
    Console.WriteLine(name);
}