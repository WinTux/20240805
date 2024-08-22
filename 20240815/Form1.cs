using Microsoft.Data.SqlClient;

namespace _20240815
{
    public partial class Form1 : Form
    {
        int numero1;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Hola mundo!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Guardar el 1er numero
            bool correcto = int.TryParse(txtResultado.Text, out numero1);
            if (!correcto)
            {
                numero1 = 0;
                txtResultado.Text = "FORMATO INCORRECTO";
            }
            else
            {
                //Limpiar la pantalla
                txtResultado.Text = "";
                // Asignar operacion
                operacion = "suma";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Guardar el 1er numero
            numero1 = int.Parse(txtResultado.Text);
            //Limpiar la pantalla
            txtResultado.Text = "";
            // Asignar operacion
            operacion = "resta";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "suma":
                    txtResultado.Text = (numero1 + int.Parse(txtResultado.Text)) + "";
                    break;
                case "resta":
                    txtResultado.Text = (numero1 - int.Parse(txtResultado.Text)) + "";
                    break;
                default:
                    txtResultado.Text = "ERROR DE SINTAXIS";
                    break;
            }
        }

        // (45+12)*7-3 --> 57 * 7 - 3 -> 399 -3 -> 396
        // 5-2*3 -> -1
        // 2-5-(2*3)+1 -> 2-5-6+1 -> -8
        /*
                 ()
                 ¨ [es somnbrerito de potencia
                * / %
                 + -
              --------->
         */
        private void operar(object sender, EventArgs e)
        {
            var expresion = txtResultado.Text;// a * (b + c) --> 5 * (3+2)
            /*
            
            pila aux: 
            salida: a b c + *
             

            pila: 
            RES: 25

            
             */

            // INFIX: A + B
            // PREFIX: + A B
            // POSTFIX: A B +

            string exp_postfix = convertirApostfix(expresion);// 5*(6-3) -> 563-*
            lblMensaje.Text = resolverPostfix(exp_postfix); // 5 6 3 

            int r = resolverRecursivo(5);//factorial
            lblMensaje.Text += "--> 5! = " + r;
        }

        private string resolverPostfix(string exp_postfix)
        {
            Stack<int> pila = new Stack<int>();
            // Solución al problema
            for (int i = 0; i < exp_postfix.Length; i++)
            {
                char caracter = exp_postfix[i];
                bool esNum = int.TryParse(caracter + "", out int numero);
                if (esNum)
                    pila.Push(numero);
                else
                {
                    int b = pila.Pop();
                    int a = pila.Pop();
                    switch (caracter)
                    {
                        case '+':
                            pila.Push(a + b);
                            break;
                        case '-':
                            pila.Push(a - b);
                            break;
                        case '*':
                            pila.Push(a * b);
                            break;
                        case '/':
                            pila.Push(a / b);
                            break;
                        default:
                            lblMensaje.Text = "ERROR AL RESOLVER LA EXPRESIÓN POSTFIX";
                            break;
                    }
                }
            }
            return pila.Pop() + "";
        }

        public void recibeArchivo(string rutaArchivo)
        {
            StreamReader archivo = new StreamReader(rutaArchivo);
            //string? comando = archivo.ReadLine();
            string? linea = "";
            while (!archivo.EndOfStream)
            {
                linea += archivo.ReadLine() + "\n";// \t
            }
            archivo.Close();
            lblContenidoArchivo.Text = linea;
            txtContenido.Text = linea;
        }

        private int resolverRecursivo(int n)
        {// factorial - 5! = 5*4*3*2*1 = 120 -> n! = n*(n-1)*(n-2)*...*1 
            if (n == 1 || n == 0)
                return 1;
            return n * resolverRecursivo(n - 1); // 5 * 4 * 3 * 2 * 1
        }
        private string convertirApostfix(string exp_infix)
        {
            string exp_postfix = "";
            // Resolvemos el problema
            Stack<char> pila_auxiliar = new Stack<char>();
            for (int i = 0; i < exp_infix.Length; i++)
            {
                char simbolo = exp_infix[i];
                switch (simbolo)
                {
                    case '(':
                        pila_auxiliar.Push(simbolo);
                        break;
                    case ')':
                        char elemento_de_pila;
                        do
                        {
                            elemento_de_pila = pila_auxiliar.Pop();
                            if (!elemento_de_pila.Equals('('))
                                exp_postfix += elemento_de_pila;
                        } while (!elemento_de_pila.Equals('(') && pila_auxiliar.Count > 0);
                        break;
                    case '+':
                    case '-':
                        if (pila_auxiliar.Count == 0)
                        {
                            pila_auxiliar.Push(simbolo);
                        }
                        else
                        {
                            elemento_de_pila = pila_auxiliar.Pop();
                            bool hay_operador = "+-*/".Contains(elemento_de_pila);
                            while (hay_operador)
                            { // RPN (Reverse Polish Notation) ALG (algebraico)
                                exp_postfix += elemento_de_pila; // 6/(4-1)*5-5 -> 641-/5*5-  (*)
                                if (pila_auxiliar.Count > 0)
                                {
                                    elemento_de_pila = pila_auxiliar.Pop();
                                    hay_operador = "+-*/".Contains(elemento_de_pila);
                                }
                                else
                                    hay_operador = false;
                            }
                            if (elemento_de_pila.Equals('('))
                            {
                                //pila_auxiliar.Push('(');
                                pila_auxiliar.Push(simbolo);
                            }

                        }
                        break;
                    case '*':
                    case '/':
                        if (pila_auxiliar.Count == 0)
                        {
                            pila_auxiliar.Push(simbolo);
                        }
                        else
                        {
                            elemento_de_pila = pila_auxiliar.Pop();
                            bool hay_operador = "*/".Contains(elemento_de_pila);
                            while (hay_operador)
                            {
                                exp_postfix += elemento_de_pila;
                                elemento_de_pila = pila_auxiliar.Pop();
                                hay_operador = "*/".Contains(elemento_de_pila);
                            }
                            if ("(+-".Contains(elemento_de_pila))
                                pila_auxiliar.Push(simbolo);
                        }
                        break;
                    default: // si es numero (operando)
                        exp_postfix += simbolo;
                        break;
                }
            }
            while (pila_auxiliar.Count > 0)
                exp_postfix += pila_auxiliar.Pop();
            return exp_postfix;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            recibeArchivo("C:\\Users\\Docker\\Downloads\\prueba.txt");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult re = dialogoAbreArchivo.ShowDialog();
            string origen = "";
            if (re == DialogResult.OK)
            {
                origen = dialogoAbreArchivo.FileName;
                lblOrigen.Text = origen;
                recibeArchivo(origen);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string contenido = txtContenido.Text;
            string destino = "C:\\Users\\Docker\\Desktop\\guardado.txt";
            if (File.Exists(destino))
                File.Delete(destino);
            FileInfo dest = new FileInfo(destino);
            using (FileStream fs = dest.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(contenido);// *
                }
            }
            lblMensaje.Text = "Escrito exitosamente.";
        }

        private void sobrePath()
        {
            string path = @"C:\Users\Docker\Downloads\prueba.txt";
            string nombre_archivo = Path.GetFileName(path);
            lblMensaje.Text = $"PATH: {path}\nNOMBRE ARCH: {nombre_archivo}";

            nombre_archivo = Path.GetFileNameWithoutExtension(path);
            lblMensaje.Text = $"PATH: {path}\nNOMBRE ARCH: {nombre_archivo}";

            nombre_archivo = Path.GetExtension(path);
            lblMensaje.Text = $"PATH: {path}\nEXTENSIÓN: {nombre_archivo}";

            nombre_archivo = Path.GetPathRoot(path);
            lblMensaje.Text = $"PATH: {path}\nRAÍZ: {nombre_archivo}";
            nombre_archivo = Path.GetDirectoryName(path);
            lblMensaje.Text = $"PATH: {path}\nDIRECTORIO: {nombre_archivo}";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sobrePath();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Cadena de conexión
            string cadenaConexion = @"Server=192.168.1.254;DataBase=Empresa;User=sa;password=123456ABCxyz;TrustServerCertificate=True;Encrypt=False";
            using (var con = new SqlConnection(cadenaConexion)) {
                con.Open();
                lblConexion.Text = "Conexión exitosa!!";
            }
        }
    }
}
