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
                 � [es somnbrerito de potencia
                * / %
                 + -
              --------->
         */
        private void operar(object sender, EventArgs e) {
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

            string exp_postfix = convertirApostfix(expresion);
            lblMensaje.Text = exp_postfix;
        }

        private string convertirApostfix(string exp_infix)
        {
            string exp_postfix = "";
            // Resolvemos el problema
            Stack<char> pila_auxiliar = new Stack<char>();
            for (int i = 0; i < exp_infix.Length; i++) {
                char simbolo = exp_infix[i];
                switch (simbolo) {
                    case '(':
                        pila_auxiliar.Push(simbolo);
                        break;
                    case ')':
                        char elemento_de_pila;
                        do {
                            elemento_de_pila = pila_auxiliar.Pop();
                            if (!elemento_de_pila.Equals('('))
                                exp_postfix += elemento_de_pila;
                        } while (!elemento_de_pila.Equals('(') && pila_auxiliar.Count > 0);
                        break;
                    case '+': case '-':
                        if (pila_auxiliar.Count == 0)
                        {
                            pila_auxiliar.Push(simbolo);
                        }
                        else
                        {
                            elemento_de_pila = pila_auxiliar.Pop();
                            bool hay_operador = "+-*/".Contains(elemento_de_pila);
                            while (hay_operador)
                            {
                                exp_postfix += elemento_de_pila;
                                elemento_de_pila = pila_auxiliar.Pop();
                                hay_operador = "+-*/".Contains(elemento_de_pila);
                            }
                            if (elemento_de_pila.Equals('('))
                            {
                                //pila_auxiliar.Push('(');
                                pila_auxiliar.Push(simbolo);
                            }
                                
                        }
                        break;
                    case '*': case '/':
                        if (pila_auxiliar.Count == 0) {
                            pila_auxiliar.Push(simbolo);
                        }
                        else
                        {
                            elemento_de_pila = pila_auxiliar.Pop();
                            bool hay_operador = "*/".Contains(elemento_de_pila);
                            while (hay_operador) {
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
    }
}
