namespace Practica_4
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
            text1 = new TextBox();
            text2 = new TextBox();
            text3 = new TextBox();
            text4 = new TextBox();
            NumeroA = new Label();
            NumeroB = new Label();
            NumeroC = new Label();
            NumeroD = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textA = new TextBox();
            textB = new TextBox();
            textC = new TextBox();
            textD = new TextBox();
            invertir = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // text1
            // 
            text1.Location = new Point(110, 71);
            text1.Name = "text1";
            text1.Size = new Size(100, 23);
            text1.TabIndex = 0;
            // 
            // text2
            // 
            text2.Location = new Point(110, 116);
            text2.Name = "text2";
            text2.Size = new Size(100, 23);
            text2.TabIndex = 1;
            // 
            // text3
            // 
            text3.Location = new Point(110, 162);
            text3.Name = "text3";
            text3.Size = new Size(100, 23);
            text3.TabIndex = 2;
            // 
            // text4
            // 
            text4.Location = new Point(110, 213);
            text4.Name = "text4";
            text4.Size = new Size(100, 23);
            text4.TabIndex = 3;
            // 
            // NumeroA
            // 
            NumeroA.AutoSize = true;
            NumeroA.Location = new Point(33, 74);
            NumeroA.Name = "NumeroA";
            NumeroA.Size = new Size(65, 15);
            NumeroA.TabIndex = 4;
            NumeroA.Text = "Numero A:";
            // 
            // NumeroB
            // 
            NumeroB.AutoSize = true;
            NumeroB.Location = new Point(33, 124);
            NumeroB.Name = "NumeroB";
            NumeroB.Size = new Size(64, 15);
            NumeroB.TabIndex = 5;
            NumeroB.Text = "Numero B:";
            // 
            // NumeroC
            // 
            NumeroC.AutoSize = true;
            NumeroC.Location = new Point(33, 170);
            NumeroC.Name = "NumeroC";
            NumeroC.Size = new Size(65, 15);
            NumeroC.TabIndex = 6;
            NumeroC.Text = "Numero C:";
            // 
            // NumeroD
            // 
            NumeroD.AutoSize = true;
            NumeroD.Location = new Point(33, 221);
            NumeroD.Name = "NumeroD";
            NumeroD.Size = new Size(65, 15);
            NumeroD.TabIndex = 7;
            NumeroD.Text = "Numero D:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 74);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 8;
            label1.Text = "Numero A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 124);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 9;
            label2.Text = "Numero B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 170);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 10;
            label3.Text = "Numero C:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 221);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 11;
            label4.Text = "Numero D:";
            // 
            // textA
            // 
            textA.Location = new Point(389, 71);
            textA.Name = "textA";
            textA.Size = new Size(100, 23);
            textA.TabIndex = 12;
            // 
            // textB
            // 
            textB.Location = new Point(389, 121);
            textB.Name = "textB";
            textB.Size = new Size(100, 23);
            textB.TabIndex = 13;
            // 
            // textC
            // 
            textC.Location = new Point(389, 167);
            textC.Name = "textC";
            textC.Size = new Size(100, 23);
            textC.TabIndex = 14;
            // 
            // textD
            // 
            textD.Location = new Point(389, 218);
            textD.Name = "textD";
            textD.Size = new Size(100, 23);
            textD.TabIndex = 15;
            // 
            // invertir
            // 
            invertir.BackColor = Color.White;
            invertir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            invertir.Location = new Point(205, 269);
            invertir.Name = "invertir";
            invertir.Size = new Size(100, 50);
            invertir.TabIndex = 16;
            invertir.Text = "Invertir Numeros";
            invertir.UseVisualStyleBackColor = false;
            invertir.Click += invertir_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(179, 9);
            label9.Name = "label9";
            label9.Size = new Size(183, 25);
            label9.TabIndex = 17;
            label9.Text = "Numeros Invertidos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(521, 386);
            Controls.Add(label9);
            Controls.Add(invertir);
            Controls.Add(textD);
            Controls.Add(textC);
            Controls.Add(textB);
            Controls.Add(textA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NumeroD);
            Controls.Add(NumeroC);
            Controls.Add(NumeroB);
            Controls.Add(NumeroA);
            Controls.Add(text4);
            Controls.Add(text3);
            Controls.Add(text2);
            Controls.Add(text1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text1;
        private TextBox text2;
        private TextBox text3;
        private TextBox text4;
        private Label NumeroA;
        private Label NumeroB;
        private Label NumeroC;
        private Label NumeroD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textA;
        private TextBox textB;
        private TextBox textC;
        private TextBox textD;
        private Button invertir;
        private Label label9;
    }
}