namespace Practica_6
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Base = new TextBox();
            Altura = new TextBox();
            Resultado = new TextBox();
            calculo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "Area Triangulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 1;
            label2.Text = "Base";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(47, 128);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(47, 188);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // Base
            // 
            Base.Location = new Point(158, 72);
            Base.Name = "Base";
            Base.Size = new Size(100, 23);
            Base.TabIndex = 4;
            // 
            // Altura
            // 
            Altura.Location = new Point(158, 128);
            Altura.Name = "Altura";
            Altura.Size = new Size(100, 23);
            Altura.TabIndex = 5;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(158, 188);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 23);
            Resultado.TabIndex = 6;
            // 
            // calculo
            // 
            calculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calculo.Location = new Point(100, 275);
            calculo.Name = "calculo";
            calculo.Size = new Size(90, 35);
            calculo.TabIndex = 7;
            calculo.Text = "Calcular";
            calculo.UseVisualStyleBackColor = true;
            calculo.Click += calculo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 364);
            Controls.Add(calculo);
            Controls.Add(Resultado);
            Controls.Add(Altura);
            Controls.Add(Base);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculo De Area";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Base;
        private TextBox Altura;
        private TextBox Resultado;
        private Button calculo;
    }
}