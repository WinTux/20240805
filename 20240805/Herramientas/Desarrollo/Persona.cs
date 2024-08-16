


namespace Principal.Herramientas.Desarrollo
{
    public class Person
    {
        // Abstracción
        private string nombre;
        public string Nombre { 
            get { return "Nombre: " + nombre; } 
            set { if (value.Length >= 3 && value.Length < 40)
                    nombre = value;
            } }
        public string Apellido { get; set; }
        private int edad;
        public int Edad { 
            get { return edad; } 
            set {
                if (value > 0)
                    edad = value;
            } }
        public Person() {
            Nombre = "NA";
            Apellido = "NA";
            edad = 0;
        }
        public Person(string nom, string ap) {
            Nombre = nom;
            Apellido = ap;
            edad = 0;
        }
        public Person(string apellido, string nombre, int edad ) {
            Nombre = nombre;
            Apellido = apellido;
            this.edad = edad;
        }

        public void saludar() {
            Console.WriteLine("Hola, me llamo "+ Nombre+" "+Apellido+" y mi edad es de "+edad+" años ("+obtenerComentario()+").");
        }

        private string obtenerComentario()
        {
            return edad >= 18 ? "Soy mayor de edad" : "Soy menor";
        }
    }
}

public class UnaClaseSobreTiposDeDatos {
    public string descripcion;
    public int cantidad;

    public void MetodoCualquiera() {
        int contador = 0;
        int edad;

        var peso = 50.1;
        double peso2 = 50.1;

        //var variableMisteriosa; //esta mal

        float numero_Pi_Redondeado = 3.1416f;

        var resultado = peso + contador;

        resultado = sumar(5, 10) - sumar(20,4);

        string apellido = "Peralta";

        Console.WriteLine("El apellido es: " + apellido);
    }

    public int sumar (int a, int b){
        return a + b;
    }
}

namespace Pregrado {
    using Principal.Herramientas.Desarrollo;
    public class Estudiante : Person, Ciudadano {
        public int matricula { get; set; }
        public int gestion { get; set; }
        public Estudiante() : base() {
            matricula = 10000;
            gestion = 2024;
        }
        public Estudiante(string nombre, string apellido, int edad, int matricula, int gestion) : base(apellido, nombre, edad)
        {
            this.matricula = matricula;
            this.gestion = gestion;
        }
        public void detalles() {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, edad: {Edad} (Matricula: {matricula}-{gestion})");
        }

        public void saludoCivico()
        {
            Console.WriteLine($"El estudiante {Nombre} {Apellido} saluda a Bolivia.");
        }

        public string nivelResponsabilidad(int valor)
        {
            string nivel = "";
            switch (valor) {
                case 1: case 2: case 3:
                    nivel = "Bajo";
                    break;
                case 4: case 5: case 6:
                    nivel = "Medio";
                    break;
                case 7: case 8: case 9: case 10:
                    nivel = "Alto";
                    break;
                default:
                    nivel = "NN";
                    break;
            }
            return nivel;
        }
        public void saludar()
        {
            Console.WriteLine("Hola, soy el estudiante "+ Apellido + " y mi edad es de " + Edad + " años.");
        }
    }

    public interface Ciudadano {
        public void saludoCivico();
        public string nivelResponsabilidad(int valor);
    }

    public class Docente : Person, Ciudadano
    {
        public float sueldo;
        public string asignatura;

        public Docente() : base()
        {
            sueldo = 2100;
            asignatura = "NN";
        }
        public Docente(string nombre, string apellido, int edad, float sueldo, string asignatura) : base(apellido, nombre, edad)
        {
            this.sueldo = sueldo;
            this.asignatura = asignatura;
        }
        public string nivelResponsabilidad(int valor)
        {
            string nivel = "";
            switch (valor)
            {
                case 1:
                case 2:
                case 3:
                    nivel = "Bajo";
                    break;
                case 4:
                case 5:
                case 6:
                    nivel = "Medio";
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                    nivel = "Alto";
                    break;
                default:
                    nivel = "NN";
                    break;
            }
            return nivel;
        }

        public void saludoCivico()
        {
            Console.WriteLine($"El docente {Nombre} {Apellido} saluda a Bolivia.");
        }
    }

    namespace Ejecutivo {
        public class Administrador { 
        
        }

        public class Externo {
        
        }
    }
}

namespace Postgrado {
    public class Estudiante { 
    
    }
    public class Docente { 
    
    }
}