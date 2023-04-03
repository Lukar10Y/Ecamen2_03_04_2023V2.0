using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDockUp
{
    public class Funcion
    {
        public static string DarColor(Random random)
        {
            int num = random.Next(1, 5);
            if (num == 1) return "Negro";
            else if (num == 2) return "Blanco";
            else if (num == 3) return "Gris";
            else return "Azul";
        }
        public static void LlenarValores(Random random, List<Electronicos> Lista, int Cantidad)
        {
            int num;
            string Descripcion;
            for (int i = 0; i < Cantidad; i++)
            {
                num = random.Next(1, 4);
                if (num == 1)
                {
                    Descripcion = "El nuevo BLU G60 es un teléfono inteligente Android de clase básica";
                    Lista.Add(new Electronicos("Blu", "Telefono", "G60", 2018, DarColor(random), random.Next(100, 141), random.Next(10, 51), Descripcion));
                }
                else if (num == 2)
                {
                    Descripcion = "La Laptop Lenovo Smart ofrece componentes de calidad combinado con un diseño moderno y elegante\n para que uses a gusto tu ordenador para tareas cotidianas.";
                    Lista.Add(new Electronicos("Lenovo", "Laptop", "Smart", 2022, DarColor(random), random.Next(500, 751), random.Next(20, 31), Descripcion));
                }
                else
                {
                    Descripcion = "EL Samsung Series 2019 continua con la gran calidad de sus predecesores, increible sonorizacion\n e imagen para horas de entretenimiento.";
                    Lista.Add(new Electronicos("Samsung", "Televisor", "Series", 2019, "Negro", random.Next(47, 53), random.Next(300, 401), random.Next(30, 41), Descripcion));
                }
            }
        }
        public static void LlenarValores(Random random, List<Software> Lista, int Cantidad)
        {
            int num;
            string Descripcion;
            for (int i = 0; i < Cantidad; i++)
            {
                num = random.Next(1, 4);
                if (num == 1)
                {
                    Descripcion = "Antivirus de interfaz muy intuitiva, protección avanzada de aplicaciones en paralelo.";
                    Lista.Add(new Software("MacAfee", "Antivirus", random.Next(8, 11), random.Next(3, 9), 1, random.Next(20, 40), 0, random.Next(100, 251), Descripcion));
                }
                else if (num == 2)
                {
                    Descripcion = "Windows es el nombre de una familia de distribuciones de software para PC,\n teléfonos inteligentes, servidores y sistemas empotrados, desarrollados y vendidos por Microsoft\n y disponibles para múltiples arquitecturas";
                    Lista.Add(new Software("Windows", "Sistema Operativo", random.Next(10, 12), random.Next(20, 29), 12, random.Next(39, 50), random.Next(19, 30), random.Next(300, 400), Descripcion, true));
                }
                else
                {
                    Descripcion = "Spotify es una aplicación imprescindible para los usuarios de servicio de música online.\n Con ella podremos escuchar nuestra música y podcasts favoritos estemos donde estemos.";
                    Lista.Add(new Software("Spotify", "App", 8.8, 5, random.Next(0, 2), random.Next(29, 39), random.Next(49, 350), Descripcion));
                }
            }
        }
        public static void LlenarValores(Random random, List<Hardware> Lista, int Cantidad)
        {
            int num;
            string Descripcion;
            for (int i = 0; i < Cantidad; i++)
            {
                num = random.Next(1, 4);
                if (num == 1)
                {
                    Descripcion = "Dispositivo de reproduccion de audio Xiaomi de Impresionante Calidad.";
                    Lista.Add(new Hardware("Xiaomi", "Corneta", DarColor(random), random.Next(10, 16), random.Next(20, 26), random.Next(100, 125), Descripcion));
                }
                else if (num == 2)
                {
                    Descripcion = "El esencial Razer conserva la forma ergonómica clásica que ha sido un sello\n distintivo de las generaciones anteriores. Su cuerpo elegante y distinto está diseñado para la comodidad";
                    Lista.Add(new Hardware("Razer", "Mouse", DarColor(random), random.Next(3, 6), 20.99, random.Next(80, 100), Descripcion, Bool(random), Bool(random)));
                }
                else
                {
                    Descripcion = "Disfruta de tus partidas en otro nivel con Redragon, marca reconocida que se \n especializa en brindar la mejor experiencia de juego al público gamer desde hace más de 20 años.\n Sus teclados se adaptan a todo tipo de jugadores.";
                    Lista.Add(new Hardware("RedDragon", "Teclado", DarColor(random), 15.5, random.Next(60, 80), random.Next(29, 39), Descripcion, Bool(random), Bool(random)));
                }
            }
        }
        public static bool Bool(Random random)
        {
            int num = random.Next(1, 3);
            if (num == 1) return true;
            else return false;
        }
    }
}
