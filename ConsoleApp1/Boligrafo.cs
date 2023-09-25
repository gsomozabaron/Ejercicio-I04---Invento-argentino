using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor() => color;
        public short GetTinta() => tinta;

        private void SetTinta(short tinta)
        {
            if (this.tinta + tinta >= 0 && this.tinta + tinta <= cantidadTintaMaxima)
                this.tinta += tinta;
        }

        public void Recargar()
        {
            Console.WriteLine($"\n Recarga {this.color}...");
            this.tinta = cantidadTintaMaxima;
            Console.WriteLine($"Bolígrafo {color} - Tinta: {this.GetTinta()}");
        }

        public void Pintar(int gasto, char dibujo)
        {
            Console.WriteLine($"\n usando {this.color}, {gasto}:");
            int unidadesGastadas = Math.Min(gasto, this.tinta);
            this.SetTinta((short)(-unidadesGastadas)); 
            
            string resultado = "";
            if (unidadesGastadas > 0)
            {
                Console.ForegroundColor = this.color;
                resultado = new string(dibujo, unidadesGastadas);
            }
            Console.WriteLine(resultado);
            Console.WriteLine($"Bolígrafo {color} - Tinta restante: {this.GetTinta()}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}



/*

Generar un método setter privado SetTinta que valide el nivel de tinta y, si es válido, 
modifique el valor del atributo tinta.

El argumento tinta contedrá la cantidad de tinta a agregar o quitar. 
Podrá ser positivo (cargar tinta) o negativo (gastar tinta).

Se deberá validar que el nivel de tinta resultante sea mayor o igual a cero y menor o igual a cantidadTintaMaxima. Si no es válido, no se deberá modificar el atributo ni realizar ninguna acción.
El método Recargar colocará la tinta en su nivel máximo. Reutilizar código.

El método Pintar restará la tinta gastada (reutilizar código). 
El parámetro gasto representará la cantidad de unidades de tinta a utilizar y utilizará tanta tinta 
como tenga disponible sin quedar en negativo. 

Utilizando el parámetro dibujo informará el resultado retornando tantos * como unidades de tinta haya gastado, 
por ejemplo:
Si no había nada de tinta retornará una cadena de texto vacía.
Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.
Agregar un proyecto de consola.

En el método Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue)
y una cantidad inicial de tinta de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.

Utilizar todos los métodos y mostrar los resultados por consola.
Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.
 */
