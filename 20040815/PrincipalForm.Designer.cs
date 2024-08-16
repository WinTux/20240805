namespace _20040815
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbAcerca = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(132, 415);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(75, 63);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Saludar";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(41, 245);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbAcerca);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(305, 229);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(297, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbAcerca
            // 
            this.tbAcerca.Location = new System.Drawing.Point(4, 22);
            this.tbAcerca.Name = "tbAcerca";
            this.tbAcerca.Padding = new System.Windows.Forms.Padding(3);
            this.tbAcerca.Size = new System.Drawing.Size(297, 203);
            this.tbAcerca.TabIndex = 1;
            this.tbAcerca.Text = "Acerda de";
            this.tbAcerca.UseVisualStyleBackColor = true;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 507);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnSaludo);
            this.MinimizeBox = false;
            this.Name = "PrincipalForm";
            this.Text = "PrincipalForm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbAcerca;
    }
}