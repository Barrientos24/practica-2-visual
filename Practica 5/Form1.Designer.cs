namespace Practica_5
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            radio = new TextBox();
            altura = new TextBox();
            BaseArea = new TextBox();
            LateralArea = new TextBox();
            AreaTotl = new TextBox();
            volumen = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            calcular = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(365, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduce los valores del cilindro";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(346, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 77);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 2;
            label2.Text = "Radio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 113);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 3;
            label3.Text = "Altura";
            // 
            // radio
            // 
            radio.Location = new Point(144, 77);
            radio.Name = "radio";
            radio.Size = new Size(100, 23);
            radio.TabIndex = 4;
            // 
            // altura
            // 
            altura.Location = new Point(144, 110);
            altura.Name = "altura";
            altura.Size = new Size(100, 23);
            altura.TabIndex = 5;
            // 
            // BaseArea
            // 
            BaseArea.Location = new Point(144, 252);
            BaseArea.Name = "BaseArea";
            BaseArea.Size = new Size(100, 23);
            BaseArea.TabIndex = 6;
            // 
            // LateralArea
            // 
            LateralArea.Location = new Point(144, 290);
            LateralArea.Name = "LateralArea";
            LateralArea.Size = new Size(100, 23);
            LateralArea.TabIndex = 7;
            // 
            // AreaTotl
            // 
            AreaTotl.Location = new Point(144, 334);
            AreaTotl.Name = "AreaTotl";
            AreaTotl.Size = new Size(100, 23);
            AreaTotl.TabIndex = 8;
            // 
            // volumen
            // 
            volumen.Location = new Point(144, 369);
            volumen.Name = "volumen";
            volumen.Size = new Size(100, 23);
            volumen.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(39, 252);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 10;
            label4.Text = "Base Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(20, 290);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 11;
            label5.Text = "Lateral Area";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(30, 334);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 12;
            label6.Text = "Total Area";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(49, 369);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 13;
            label7.Text = "Volumen";
            // 
            // calcular
            // 
            calcular.AutoSize = true;
            calcular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            calcular.Location = new Point(52, 183);
            calcular.Name = "calcular";
            calcular.Size = new Size(80, 31);
            calcular.TabIndex = 14;
            calcular.Text = "Calcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(156, 183);
            button2.Name = "button2";
            button2.Size = new Size(76, 31);
            button2.TabIndex = 15;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(262, 183);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 16;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(487, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(calcular);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(volumen);
            Controls.Add(AreaTotl);
            Controls.Add(LateralArea);
            Controls.Add(BaseArea);
            Controls.Add(altura);
            Controls.Add(radio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox radio;
        private TextBox altura;
        private TextBox BaseArea;
        private TextBox LateralArea;
        private TextBox AreaTotl;
        private TextBox volumen;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button calcular;
        private Button button2;
        private Button button3;
    }
}