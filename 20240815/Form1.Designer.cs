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
            tbAcerca = new TabPage();
            tabPage1 = new TabPage();
            tabControl1.SuspendLayout();
            tbCalculadora.SuspendLayout();
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
            button6.Click += button6_Click;
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
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(345, 400);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Pila";
            tabPage1.UseVisualStyleBackColor = true;
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
    }
}
