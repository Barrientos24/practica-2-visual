namespace Practica_3
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
            label1 = new Label();
            label2 = new Label();
            resultado = new Label();
            Numero2 = new TextBox();
            Suma = new Button();
            Numero1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero 2:";
            // 
            // resultado
            // 
            resultado.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            resultado.Location = new Point(3, 143);
            resultado.Name = "resultado";
            resultado.Size = new Size(229, 23);
            resultado.TabIndex = 2;
            // 
            // Numero2
            // 
            Numero2.Location = new Point(94, 53);
            Numero2.Name = "Numero2";
            Numero2.Size = new Size(100, 23);
            Numero2.TabIndex = 4;
            // 
            // Suma
            // 
            Suma.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Suma.ImageAlign = ContentAlignment.TopRight;
            Suma.Location = new Point(80, 206);
            Suma.Name = "Suma";
            Suma.Size = new Size(75, 23);
            Suma.TabIndex = 5;
            Suma.Text = "Sumar";
            Suma.UseVisualStyleBackColor = true;
            Suma.Click += Suma_Click;
            // 
            // Numero1
            // 
            Numero1.Location = new Point(94, 9);
            Numero1.Name = "Numero1";
            Numero1.Size = new Size(100, 23);
            Numero1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 261);
            Controls.Add(Numero1);
            Controls.Add(Suma);
            Controls.Add(Numero2);
            Controls.Add(resultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Sumar Numeros";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label resultado;
        private TextBox Num1;
        private TextBox Numero2;
        private Button Suma;
        private TextBox Numero1;
    }
}