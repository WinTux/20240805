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
        private void operar() {
            var res = "(45 + 12) * 7 - 3";

            // INFIX: A + B
            // PREFIX: + A B
            // POSTFIX: A B +
            
        }
    }
}
