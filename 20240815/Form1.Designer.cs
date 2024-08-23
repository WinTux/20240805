namespace _20240815
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSaludar = new Button();
            lblMensaje = new Label();
            tabControl1 = new TabControl();
            tbCalculadora = new TabPage();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtResultado = new TextBox();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button10 = new Button();
            button9 = new Button();
            txtContenido = new TextBox();
            lblOrigen = new Label();
            button8 = new Button();
            button7 = new Button();
            lblContenidoArchivo = new Label();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            button14 = new Button();
            groupBox2 = new GroupBox();
            button13 = new Button();
            txtNumero = new TextBox();
            txtCadena = new TextBox();
            txtValor1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button12 = new Button();
            lblConexion = new Label();
            button11 = new Button();
            tbAcerca = new TabPage();
            dialogoAbreArchivo = new OpenFileDialog();
            groupBox4 = new GroupBox();
            button15 = new Button();
            lblRegistros = new Label();
            tabControl1.SuspendLayout();
            tbCalculadora.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(126, 12);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(75, 23);
            btnSaludar.TabIndex = 0;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(12, 47);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbCalculadora);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tbAcerca);
            tabControl1.Location = new Point(2, 93);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(353, 428);
            tabControl1.TabIndex = 2;
            // 
            // tbCalculadora
            // 
            tbCalculadora.Controls.Add(button6);
            tbCalculadora.Controls.Add(button5);
            tbCalculadora.Controls.Add(button4);
            tbCalculadora.Controls.Add(button3);
            tbCalculadora.Controls.Add(button2);
            tbCalculadora.Controls.Add(button1);
            tbCalculadora.Controls.Add(txtResultado);
            tbCalculadora.Location = new Point(4, 24);
            tbCalculadora.Name = "tbCalculadora";
            tbCalculadora.Padding = new Padding(3);
            tbCalculadora.Size = new Size(345, 400);
            tbCalculadora.TabIndex = 0;
            tbCalculadora.Text = "Calculadora";
            tbCalculadora.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(211, 230);
            button6.Name = "button6";
            button6.Size = new Size(61, 60);
            button6.TabIndex = 6;
            button6.Text = "=";
            button6.UseVisualStyleBackColor = true;
            button6.Click += operar;
            // 
            // button5
            // 
            button5.Location = new Point(218, 149);
            button5.Name = "button5";
            button5.Size = new Size(54, 54);
            button5.TabIndex = 5;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(225, 78);
            button4.Name = "button4";
            button4.Size = new Size(54, 54);
            button4.TabIndex = 4;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(60, 142);
            button3.Name = "button3";
            button3.Size = new Size(61, 51);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(124, 75);
            button2.Name = "button2";
            button2.Size = new Size(61, 57);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(60, 78);
            button1.Name = "button1";
            button1.Size = new Size(57, 51);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(59, 37);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(224, 23);
            txtResultado.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(345, 400);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Pila";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(txtContenido);
            tabPage2.Controls.Add(lblOrigen);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(lblContenidoArchivo);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(345, 400);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Archivos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(39, 312);
            button10.Name = "button10";
            button10.Size = new Size(240, 23);
            button10.TabIndex = 6;
            button10.Text = "Ejemplos de Path";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(204, 280);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 5;
            button9.Text = "Guardar";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(32, 208);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(247, 66);
            txtContenido.TabIndex = 4;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(27, 71);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(0, 15);
            lblOrigen.TabIndex = 3;
            // 
            // button8
            // 
            button8.Location = new Point(204, 90);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 2;
            button8.Text = "Abrir...";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(120, 19);
            button7.Name = "button7";
            button7.Size = new Size(159, 23);
            button7.TabIndex = 1;
            button7.Text = "Abrir prueba.txt";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // lblContenidoArchivo
            // 
            lblContenidoArchivo.AutoSize = true;
            lblContenidoArchivo.Location = new Point(32, 149);
            lblContenidoArchivo.Name = "lblContenidoArchivo";
            lblContenidoArchivo.Size = new Size(38, 15);
            lblContenidoArchivo.TabIndex = 0;
            lblContenidoArchivo.Text = "Texto:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(lblConexion);
            tabPage3.Controls.Add(button11);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(345, 400);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "Bases de datos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button14);
            groupBox3.Location = new Point(19, 256);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(316, 38);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminación";
            // 
            // button14
            // 
            button14.Location = new Point(83, 9);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 0;
            button14.Text = "Eliminar";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button13);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(txtCadena);
            groupBox2.Controls.Add(txtValor1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(16, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 126);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inserción";
            // 
            // button13
            // 
            button13.Location = new Point(191, 74);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 2;
            button13.Text = "Insertar";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(70, 75);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // txtCadena
            // 
            txtCadena.Location = new Point(70, 48);
            txtCadena.Name = "txtCadena";
            txtCadena.Size = new Size(100, 23);
            txtCadena.TabIndex = 1;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(70, 21);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 78);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 51);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "Cadena:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 24);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button12);
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 67);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear tabla";
            // 
            // button12
            // 
            button12.Location = new Point(10, 27);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 0;
            button12.Text = "Crear";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Location = new Point(99, 14);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(78, 15);
            lblConexion.TabIndex = 1;
            lblConexion.Text = "Sin conexión.";
            // 
            // button11
            // 
            button11.Location = new Point(5, 10);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 0;
            button11.Text = "Conectarse";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // tbAcerca
            // 
            tbAcerca.Location = new Point(4, 24);
            tbAcerca.Name = "tbAcerca";
            tbAcerca.Padding = new Padding(3);
            tbAcerca.Size = new Size(345, 400);
            tbAcerca.TabIndex = 1;
            tbAcerca.Text = "Acerca de";
            tbAcerca.UseVisualStyleBackColor = true;
            // 
            // dialogoAbreArchivo
            // 
            dialogoAbreArchivo.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblRegistros);
            groupBox4.Controls.Add(button15);
            groupBox4.Location = new Point(9, 299);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(326, 98);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Read";
            // 
            // button15
            // 
            button15.Location = new Point(90, 10);
            button15.Name = "button15";
            button15.Size = new Size(127, 23);
            button15.TabIndex = 0;
            button15.Text = "Obtener registros";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Location = new Point(12, 45);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(74, 15);
            lblRegistros.TabIndex = 1;
            lblRegistros.Text = "Sin registros.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 523);
            Controls.Add(tabControl1);
            Controls.Add(lblMensaje);
            Controls.Add(btnSaludar);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tbCalculadora.ResumeLayout(false);
            tbCalculadora.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaludar;
        private Label lblMensaje;
        private TabControl tabControl1;
        private TabPage tbCalculadora;
        private TabPage tbAcerca;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtResultado;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblContenidoArchivo;
        private Button button7;
        private Button button8;
        private OpenFileDialog dialogoAbreArchivo;
        private Label lblOrigen;
        private TextBox txtContenido;
        private Button button9;
        private Button button10;
        private TabPage tabPage3;
        private Label lblConexion;
        private Button button11;
        private GroupBox groupBox1;
        private Button button12;
        private GroupBox groupBox2;
        private Button button13;
        private TextBox txtNumero;
        private TextBox txtCadena;
        private TextBox txtValor1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button button14;
        private GroupBox groupBox4;
        private Label lblRegistros;
        private Button button15;
    }
}
