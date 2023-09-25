using SuperHeroes;
// See https://aka.ms/new-console-template for more information


/* En una galaxia lejana habitan muchos superhéroes con habilidades extraordinarias, estos
han decidido realizar una competencia entre ellos comparando sus distintos atributos. Para
ello, necesitamos crear la clase "SuperHeroe" que nos permita representar a estos
poderosos personajes con los atributos nombre (String), fuerza (int), resistencia (int) y
superpoderes (int). 
Todos los atributos numéricos deberán aceptar valores entre 0 y 100; en caso que el setter
correspondiente reciba un valor fuera de rango deberá setear el valor límite  correspondiente
(si recibe un valor negativo asignar cero, si recibe uno superior a cien, asignar cien).
El constructor de la clase recibirá todos los valores de sus atributos por parámetro y 
usará los setters (todos privados) para validar el rango correcto de los poderes del superhéroe.
Se deberá crear un método competir() el cual recibirá otro superhéroe como parámetro y ,
comparando los  poderes de él mismo contra el otro recibido por  parámetro, devolverá
TRIUNFO , EMPATE o  DERROTA, dependiendo del resultado. 
Para triunfar un superhéroe debe superar al otro en al menos 2 de los 3 ítems.
******************************************************************************
¿Qué te proponemos realizar?
Escribir la clase Test que contenga el método main() para probar el correcto funcionamiento de la clase previamente
realizada con el siguiente ejemplo:
superHeroe1: Nombre: “Batman”, Fuerza: 90, Resistencia: 70, Superpoderes: 0
superHeroe2: Nombre: “Superman”, Fuerza: 95, Resistencia: 60, Superpoderes: 70
1. Hacer jugar al superheroe1 pasándole el objeto superheroe2 y mostrar el resultado por pantalla. 
2. Chequear el resultado (debería ser DERROTA).
3. Hacer jugar al superheroe2 contra el superheroe1 y mostrar el resultado por pantalla. 
4. Chequear el resultado (debería ser TRIUNFO).
5. Crear más superhéroes con distintos valores. */

namespace S02PF1
{
    class Program
    {
        public static void Main(string[] args)
        {
            SuperHeroe superheroe1 = new SuperHeroe("Batman", 90, 70, 0);
            SuperHeroe superheroe2 = new SuperHeroe("Superman", 95, 60, 70);

            superheroe1.competir(superheroe2);
        }
    }
}
