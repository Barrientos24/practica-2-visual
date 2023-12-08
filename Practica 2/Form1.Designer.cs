namespace Trabajo_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Etiqueta_1 = new Label();
            Nombre = new Label();
            Etiqueta_3 = new Label();
            texto = new TextBox();
            Enviar = new Button();
            Saludo = new Label();
            SuspendLayout();
            // 
            // Etiqueta_1
            // 
            Etiqueta_1.BackColor = Color.Transparent;
            Etiqueta_1.Font = new Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Etiqueta_1.ForeColor = SystemColors.ActiveCaptionText;
            Etiqueta_1.Location = new Point(39, 59);
            Etiqueta_1.Name = "Etiqueta_1";
            Etiqueta_1.Size = new Size(237, 50);
            Etiqueta_1.TabIndex = 0;
            Etiqueta_1.Text = "Hello World!";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = Color.Transparent;
            Nombre.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Nombre.Location = new Point(81, 223);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(314, 32);
            Nombre.TabIndex = 1;
            Nombre.Text = "Cual es su Nombre?";
            // 
            // Etiqueta_3
            // 
            Etiqueta_3.AutoSize = true;
            Etiqueta_3.BackColor = Color.Transparent;
            Etiqueta_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Etiqueta_3.Location = new Point(108, 284);
            Etiqueta_3.Name = "Etiqueta_3";
            Etiqueta_3.Size = new Size(213, 21);
            Etiqueta_3.TabIndex = 2;
            Etiqueta_3.Text = "Salude a alguien especial!!";
            // 
            // texto
            // 
            texto.Location = new Point(108, 258);
            texto.Name = "texto";
            texto.Size = new Size(254, 23);
            texto.TabIndex = 3;
            // 
            // Enviar
            // 
            Enviar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Enviar.Location = new Point(434, 245);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(147, 42);
            Enviar.TabIndex = 4;
            Enviar.Text = "Diga \"Hello\"";
            Enviar.TextAlign = ContentAlignment.TopLeft;
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += Enviar_Click;
            // 
            // Saludo
            // 
            Saludo.BackColor = Color.Transparent;
            Saludo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Saludo.Location = new Point(103, 136);
            Saludo.Name = "Saludo";
            Saludo.Size = new Size(500, 25);
            Saludo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(761, 450);
            Controls.Add(Saludo);
            Controls.Add(Enviar);
            Controls.Add(texto);
            Controls.Add(Etiqueta_3);
            Controls.Add(Nombre);
            Controls.Add(Etiqueta_1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Hello World!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Etiqueta_1;
        private Label Nombre;
        private Label Etiqueta_3;
        private TextBox texto;
        private Button Enviar;
        private Label Saludo;
    }
}