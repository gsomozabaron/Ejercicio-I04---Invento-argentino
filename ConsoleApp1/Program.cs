namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo azul = new Boligrafo(ConsoleColor.Blue,100);
            Boligrafo rojo = new Boligrafo(ConsoleColor.Red, 50);

            Console.WriteLine($"Bolígrafo Azul - Tinta: {azul.GetTinta()}");
            Console.WriteLine($"Bolígrafo Rojo - Tinta: {rojo.GetTinta()}");

            azul.Pintar(80, '*');
            azul.Pintar(10, '*');
            azul.Pintar(150, '*');

            rojo.Pintar(5, '#');
            rojo.Pintar(10, '#');
            rojo.Pintar(30, '#');

            azul.Recargar();
            rojo.Recargar();
        }
    }
}

/*

Generar un método setter privado SetTinta que valide el nivel de tinta y, 
si es válido, modifique el valor del atributo tinta.

El argumento tinta contedrá la cantidad de tinta a agregar o quitar. 
Podrá ser positivo (cargar tinta) o negativo (gastar tinta).

Se deberá validar que el nivel de tinta resultante sea mayor o igual a cero y menor o igual a cantidadTintaMaxima.
Si no es válido, no se deberá modificar el atributo ni realizar ninguna acción.

El método Recargar colocará la tinta en su nivel máximo. Reutilizar código.

El método Pintar restará la tinta gastada (reutilizar código). 
El parámetro gasto representará la cantidad de unidades de tinta a utilizar y utilizará tanta tinta como tenga disponible
sin quedar en negativo. 

Utilizando el parámetro dibujo informará el resultado retornando tantos * como unidades de tinta haya gastado, 
por ejemplo:
Si no había nada de tinta retornará una cadena de texto vacía.

Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.

Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.


Utilizar todos los métodos y mostrar los resultados por consola.
Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.
 */