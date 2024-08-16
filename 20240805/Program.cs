using Postgrado;
using Principal.Herramientas.Desarrollo;
using System.Data;

namespace _20240805
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            Pregrado.Estudiante e_pre = new Pregrado.Estudiante();
            e_pre.Nombre = "Pepe";
            e_pre.matricula = 123456;
            Estudiante e_post;
            Estudiante e_post_2;
            Estudiante e_post_3;
            Console.WriteLine("Hola mundo!");

            UnaClaseSobreTiposDeDatos variable = new UnaClaseSobreTiposDeDatos();
            variable.MetodoCualquiera();
            /*
            Console.WriteLine("Argumento 1: " + args[0]);
            Console.WriteLine("Argumento 2: " + args[1]);
            Console.WriteLine("Argumento 3: " + args[2]);
            */

            //ejemplo1();

            //ejemplo2();

            ejemplo3();

        }

        private static void ejemplo3()
        {
            string[] arr01 = new string[3];

            //List
            // [v p] -> [v p] -> null
            List<string> lista01 = new List<string>();
            List<object> lista02 = new List<object>();
            List<Pregrado.Ciudadano> lista03 = new List<Pregrado.Ciudadano>();

            lista01.Add("Pepe");
            lista01.Add("Ana");
            lista01.Add("Sofía");
            foreach (string valor in lista01)
                Console.WriteLine("Elemento de lista: "+valor);
            lista01.Remove("Ana");
            foreach (string valor in lista01)
                Console.WriteLine("Elemento de lista: " + valor);
            Person per01 = new Person("Sosa", "Samantha", 20);
            Person per02 = new Person("Perales", "Pepe", 20);
            Person per03 = new Person("Rocha", "Sofía", 25);
            List<Person> lista04 = new List<Person>();
            lista04.Add(per01);
            lista04.Add(per02);
            lista04.Add(per03);
            foreach (Person valor in lista04)
                Console.WriteLine("Elemento de lista: " + valor.Apellido);
            lista04.Remove(per02);
            foreach (Person valor in lista04)
                Console.WriteLine("Elemento de lista: " + valor.Apellido);

            //List<Person> lista05 = lista04; // referencia
            List<Person> lista05 = new List<Person>();
            foreach (Person p in lista04) {
                Person np = new Person(p.Apellido, p.Nombre, p.Edad);
                lista05.Add(np);
            }
                


            lista05.Add(new Person("NEW","ITEM",18));
            per03.Apellido = "Cambiado";
            foreach (Person valor in lista05)
                Console.WriteLine("Elemento de lista: " + valor.Apellido);
            foreach (Person valor in lista04)
                Console.WriteLine("Elemento de lista: " + valor.Apellido);

            // Stack (Pila) - LIFO

            Console.WriteLine("La suma es: " + (6 + obtenerNumero()));
            // generar un numero pseudo-aleatorio
            // ejecutar obtenerNumero()
            // Resolver la expresion (suma de enteros)
            // Concatenar
            // Tarea: Mostrar en consola

            Stack<int> pila01 = new Stack<int>();
            pila01.Push(5);
            pila01.Push(15);
            pila01.Push(25);
            foreach (int val in pila01)
                Console.WriteLine(val);

            int aux = pila01.Pop();
            foreach (int val in pila01)
                Console.WriteLine(val);

            aux = pila01.Peek();
            Console.WriteLine("Te cuento que en la cima hay un "+aux);
            foreach (int val in pila01)
                Console.WriteLine(val);

            // Queue (Cola) FIFO
            Console.WriteLine("******* Queue ********");
            Queue<string> cola01 = new Queue<string>();
            cola01.Enqueue("Pepe");
            cola01.Enqueue("Samantha");
            cola01.Enqueue("Carlos");
            foreach (string val in cola01)
                Console.WriteLine(val);
            string aux2 = cola01.Dequeue();
            foreach (string val in cola01)
                Console.WriteLine(val);

            Queue<Pregrado.Docente> cola02 = new Queue<Pregrado.Docente>();

            Pregrado.Docente doc01 = new Pregrado.Docente("Ana", "Rocha", 46, 3000, "FIS100");
            Pregrado.Docente doc02 = new Pregrado.Docente("Sofía", "Peralta", 30, 3000, "LIN100");
            cola02.Enqueue(new Pregrado.Docente("Pepe","Perales",55,3000,"QMC120"));
            cola02.Enqueue(doc01);
            cola02.Enqueue(doc02);
            foreach (Pregrado.Docente val in cola02)
                Console.WriteLine($"Docente {val.Nombre} {val.Apellido} ({val.asignatura})");

            Pregrado.Docente docAux = cola02.Peek();
            docAux.asignatura = "CAMBIADO";

            foreach (Pregrado.Docente val in cola02)
                Console.WriteLine($"Docente {val.Nombre} {val.Apellido} ({val.asignatura})");

            // Map (mapa) (tipo diccionario)

            IDictionary<string,Pregrado.Estudiante> mapa = new Dictionary<string,Pregrado.Estudiante>();
            mapa.Add("e2", new Pregrado.Estudiante("Ana", "Mendoza", 25, 123456, 2020));
            mapa.Add("e1", new Pregrado.Estudiante("Sofía", "Ramos", 20, 123459, 2021));
            bool yaExiste = false;
            foreach (string llave in mapa.Keys)
            {
                if (llave.Equals("e2"))
                    yaExiste = true;
            }
            if(!yaExiste)
                mapa.Add("e2", new Pregrado.Estudiante("Ana", "Lopez", 25, 123456, 2020));
            foreach (KeyValuePair<string, Pregrado.Estudiante> tupla in mapa) {
                Console.WriteLine($"Llave: {tupla.Key}, valor: {tupla.Value.Apellido}");
            }
            
            Console.WriteLine(mapa["e2"].Apellido);
            //Ciudadano ciu01 = new Pregrado.Estudiante();

            // Linq
            var listita = cola02.OrderBy(x => x.Apellido).ToList();
            foreach (var elem in listita)
                Console.WriteLine($"Docente {elem.Apellido}");

            // SELECT * FROM Persona;
        }

        private static int obtenerNumero()
        {
            return 5;// RNG
        }

        private static void ejemplo2()
        {
            Person p = new Person();
            p.saludar();
            p.Nombre = "Pepe";
            p.Apellido = "Perales";
            p.Edad = 20;
            p.saludar();

            Person pp = new Person("Sofia", "Sosa");
            pp.saludar();
            Person ppp = new Person("Roca", "Samantha", 25);
            ppp.Edad = -25;
            ppp.Nombre = "Samanta";
            
            ppp.saludar();

            Pregrado.Estudiante est01 = new Pregrado.Estudiante();
            est01.saludar();

            Pregrado.Estudiante est02 = new Pregrado.Estudiante("Sofía", "Lima", 21, 120045, 2023);
            est02.saludar();
            est02.detalles();
            est02.saludoCivico();
            Console.WriteLine("Responsabilidad: "+ est02.nivelResponsabilidad(7));
            Pregrado.Docente doc01 = new Pregrado.Docente();
            doc01.saludar();
            doc01.saludoCivico();
            doc01.nivelResponsabilidad(6);

            Pregrado.Ciudadano[] ciudadanos = new Pregrado.Ciudadano[2];
            ciudadanos[0] = est02;
            ciudadanos[1] = doc01;
        }

        public static void ejemplo1() {
            // Condicionales
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse( Console.ReadLine());
            int bandera = -1;
            //simple
            if (edad >= 18) {
                Console.WriteLine("Bienvenido usuario.");
                // otras cosas que hacer
            }

            //compuesta
            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido usuario (compuesto).");
                bandera = 1;
            }
            else {
                Console.WriteLine("No puede ingresar a la aplicación.");
                bandera = 0;
            }

            // 1: CUMPLE, 0: NO COMPLE

            string mensaje = "";
            if (bandera == 1)
                mensaje = "CUMPLE";
            else 
                mensaje = "NO CUMPLE";

            Console.WriteLine(mensaje);

            // terneraio
            mensaje = bandera == 1 ? "CUMPLE" : "NO CUMPLE";
            Console.WriteLine(mensaje);

            Console.WriteLine("Ingrese el numero dde dia de la semana (1=Lunes, 2=Martes, etc.)");
            int numdia = int.Parse( Console.ReadLine());
            if (numdia == 1)
                Console.WriteLine("Lunes");
            else
                if (numdia == 2)
                Console.WriteLine("Martes");
            else if (numdia == 3)
                Console.WriteLine("Miercoles");
            else
                if (numdia == 4)
                Console.WriteLine("Jueves");
            else if (numdia == 5)
                Console.WriteLine("Viernes");
            else
                if (numdia == 6)
                Console.WriteLine("Sábado");
            else if (numdia == 7)
                Console.WriteLine("Domingo");
            else
                Console.WriteLine("No existe ese día.");

            switch (numdia) {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Fin de semana");
                    break;
                
                default:
                    Console.WriteLine("No existe ese día.");
                    break;
            }

            // Bucles / iteraciones / 
            //while (mientras)
            int contador = 0;
            while (contador < 10) {
                Console.WriteLine("El contador está en: " + contador);
                contador++;
            }
            Console.WriteLine("FIN del WHILE");

            while (contador >= 0) {
                Console.WriteLine("El contador está en: " + contador);
                contador--;
            }
            Console.WriteLine("FIN del WHILE");

            while (contador < 5)
            {
                Console.WriteLine("El contador está en: " + contador++);
            }
            Console.WriteLine("FIN del WHILE");

            // for (para)
            for (int i = 0; i < 5; i++) {
                // i++ i-- i+=2 i-=3 i*=2 i/=4

                // 4.0 - 3.0 ---> 1.000000000001

                Console.WriteLine("El contador está en: " + i);
            }
            Console.WriteLine("FIN del FOR");

            // do-while
            do {
                contador--;
                Console.WriteLine("El contador está en: " + contador);
            } while (contador > 0);
            Console.WriteLine("FIN del DO WHILE");



        }
    }
}


namespace Otro {
    public class Secundario {
        public void HacerAlgo() {
            Estudiante est;
        }
    }
}