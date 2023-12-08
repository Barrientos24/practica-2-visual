namespace Practica_7
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
            grados = new TextBox();
            GradosF = new Button();
            GradosC = new Button();
            delete = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            resultado = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dato = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 30);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingrese Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(46, 107);
            label3.Name = "label3";
            label3.Size = new Size(177, 21);
            label3.TabIndex = 2;
            label3.Text = "Opciones de Conversion";
            // 
            // grados
            // 
            grados.Location = new Point(114, 3);
            grados.Name = "grados";
            grados.Size = new Size(146, 23);
            grados.TabIndex = 5;
            // 
            // GradosF
            // 
            GradosF.Location = new Point(3, 3);
            GradosF.Name = "GradosF";
            GradosF.Size = new Size(75, 23);
            GradosF.TabIndex = 6;
            GradosF.Text = "Fahrenheit";
            GradosF.UseVisualStyleBackColor = true;
            GradosF.Click += GradosF_Click;
            // 
            // GradosC
            // 
            GradosC.Location = new Point(84, 3);
            GradosC.Name = "GradosC";
            GradosC.Size = new Size(75, 23);
            GradosC.TabIndex = 7;
            GradosC.Text = "Centigrados";
            GradosC.UseVisualStyleBackColor = true;
            GradosC.Click += GradosC_Click;
            // 
            // delete
            // 
            delete.Location = new Point(165, 3);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 8;
            delete.Text = "Borrar";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(grados);
            flowLayoutPanel1.Location = new Point(46, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(269, 32);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(GradosF);
            flowLayoutPanel2.Controls.Add(GradosC);
            flowLayoutPanel2.Controls.Add(delete);
            flowLayoutPanel2.Location = new Point(49, 131);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(245, 31);
            flowLayoutPanel2.TabIndex = 11;
            // 
            // resultado
            // 
            resultado.Location = new Point(120, 252);
            resultado.Name = "resultado";
            resultado.Size = new Size(100, 23);
            resultado.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(52, 217);
            label4.Name = "label4";
            label4.Size = new Size(156, 21);
            label4.TabIndex = 3;
            label4.Text = "Resultado en Grados:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(46, 187);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 4;
            label5.Text = "Equivalencia en Grados:";
            // 
            // dato
            // 
            dato.AutoSize = true;
            dato.Location = new Point(214, 223);
            dato.Name = "dato";
            dato.Size = new Size(0, 15);
            dato.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 312);
            Controls.Add(dato);
            Controls.Add(resultado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox grados;
        private Button GradosF;
        private Button GradosC;
        private Button delete;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox resultado;
        private Label label4;
        private Label label5;
        private Label dato;
    }
}