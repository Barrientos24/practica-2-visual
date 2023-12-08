namespace Practica_8
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            delete = new Button();
            cal = new Button();
            label4 = new Label();
            area = new TextBox();
            volumen = new TextBox();
            radio = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            delete2 = new Button();
            cal1 = new Button();
            resultado = new TextBox();
            altura2 = new TextBox();
            base2 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tabPage3 = new TabPage();
            volumen3 = new TextBox();
            label12 = new Label();
            borrar3 = new Button();
            calcular3 = new Button();
            area3 = new TextBox();
            lado = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tabPage4 = new TabPage();
            Borrar4 = new Button();
            Calcular4 = new Button();
            volumen4 = new TextBox();
            label17 = new Label();
            area4 = new TextBox();
            altura4 = new TextBox();
            radio4 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            tabPage5 = new TabPage();
            borrar5 = new Button();
            calcular5 = new Button();
            resultado5 = new TextBox();
            diam5 = new TextBox();
            diametro5 = new TextBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            tabPage6 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            volumen6 = new TextBox();
            area6 = new TextBox();
            LadoA = new TextBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Controls.Add(tabPage5);
            tabControl.Controls.Add(tabPage6);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(621, 426);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.SlateBlue;
            tabPage1.Controls.Add(delete);
            tabPage1.Controls.Add(cal);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(area);
            tabPage1.Controls.Add(volumen);
            tabPage1.Controls.Add(radio);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(613, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Circunferencia";
            // 
            // delete
            // 
            delete.AutoSize = true;
            delete.BackColor = Color.Silver;
            delete.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            delete.Location = new Point(453, 293);
            delete.Name = "delete";
            delete.Size = new Size(86, 35);
            delete.TabIndex = 8;
            delete.Text = "Borrar";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // cal
            // 
            cal.AutoSize = true;
            cal.BackColor = Color.Silver;
            cal.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            cal.Location = new Point(124, 293);
            cal.Name = "cal";
            cal.Size = new Size(90, 35);
            cal.TabIndex = 7;
            cal.Text = "Calcular";
            cal.UseVisualStyleBackColor = false;
            cal.Click += cal_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 192);
            label4.Name = "label4";
            label4.Size = new Size(57, 30);
            label4.TabIndex = 6;
            label4.Text = "Area";
            // 
            // area
            // 
            area.Location = new Point(86, 192);
            area.Name = "area";
            area.ReadOnly = true;
            area.Size = new Size(100, 23);
            area.TabIndex = 5;
            // 
            // volumen
            // 
            volumen.Location = new Point(494, 192);
            volumen.Name = "volumen";
            volumen.ReadOnly = true;
            volumen.Size = new Size(100, 23);
            volumen.TabIndex = 4;
            // 
            // radio
            // 
            radio.Location = new Point(272, 91);
            radio.Name = "radio";
            radio.Size = new Size(100, 23);
            radio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(391, 192);
            label3.Name = "label3";
            label3.Size = new Size(97, 30);
            label3.TabIndex = 2;
            label3.Text = "Volumen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(198, 84);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 1;
            label2.Text = "Radio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(212, 19);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 0;
            label1.Text = "Circunferencia";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Yellow;
            tabPage2.Controls.Add(delete2);
            tabPage2.Controls.Add(cal1);
            tabPage2.Controls.Add(resultado);
            tabPage2.Controls.Add(altura2);
            tabPage2.Controls.Add(base2);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(613, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Triangulo";
            tabPage2.Click += tabPage2_Click;
            // 
            // delete2
            // 
            delete2.AutoSize = true;
            delete2.BackColor = Color.Black;
            delete2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            delete2.ForeColor = Color.White;
            delete2.Location = new Point(410, 252);
            delete2.Name = "delete2";
            delete2.Size = new Size(75, 35);
            delete2.TabIndex = 8;
            delete2.Text = "Borrar";
            delete2.UseVisualStyleBackColor = false;
            delete2.Click += delete2_Click;
            // 
            // cal1
            // 
            cal1.AutoSize = true;
            cal1.BackColor = Color.Black;
            cal1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            cal1.ForeColor = Color.White;
            cal1.Location = new Point(138, 257);
            cal1.Name = "cal1";
            cal1.Size = new Size(90, 35);
            cal1.TabIndex = 7;
            cal1.Text = "Calcular";
            cal1.TextAlign = ContentAlignment.TopCenter;
            cal1.UseVisualStyleBackColor = false;
            cal1.Click += cal1_Click;
            // 
            // resultado
            // 
            resultado.Location = new Point(285, 213);
            resultado.Name = "resultado";
            resultado.ReadOnly = true;
            resultado.Size = new Size(100, 23);
            resultado.TabIndex = 6;
            // 
            // altura2
            // 
            altura2.Location = new Point(415, 95);
            altura2.Name = "altura2";
            altura2.Size = new Size(100, 23);
            altura2.TabIndex = 5;
            // 
            // base2
            // 
            base2.Location = new Point(173, 97);
            base2.Name = "base2";
            base2.Size = new Size(100, 23);
            base2.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(223, 216);
            label8.Name = "label8";
            label8.Size = new Size(50, 25);
            label8.TabIndex = 3;
            label8.Text = "Area";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(346, 95);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 2;
            label7.Text = "Altura";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(117, 99);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 1;
            label6.Text = "Base";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(267, 31);
            label5.Name = "label5";
            label5.Size = new Size(98, 30);
            label5.TabIndex = 0;
            label5.Text = "Triangulo";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 128, 0);
            tabPage3.Controls.Add(volumen3);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(borrar3);
            tabPage3.Controls.Add(calcular3);
            tabPage3.Controls.Add(area3);
            tabPage3.Controls.Add(lado);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(613, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cubo";
            // 
            // volumen3
            // 
            volumen3.Location = new Point(260, 193);
            volumen3.Name = "volumen3";
            volumen3.ReadOnly = true;
            volumen3.Size = new Size(100, 23);
            volumen3.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(150, 193);
            label12.Name = "label12";
            label12.Size = new Size(94, 30);
            label12.TabIndex = 7;
            label12.Text = "Volumen";
            // 
            // borrar3
            // 
            borrar3.AutoSize = true;
            borrar3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            borrar3.Location = new Point(373, 252);
            borrar3.Name = "borrar3";
            borrar3.Size = new Size(91, 35);
            borrar3.TabIndex = 6;
            borrar3.Text = "Borrar";
            borrar3.UseVisualStyleBackColor = true;
            borrar3.Click += borrar3_Click;
            // 
            // calcular3
            // 
            calcular3.AutoSize = true;
            calcular3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            calcular3.Location = new Point(135, 252);
            calcular3.Name = "calcular3";
            calcular3.Size = new Size(98, 40);
            calcular3.TabIndex = 5;
            calcular3.Text = "Calcular";
            calcular3.UseVisualStyleBackColor = true;
            calcular3.Click += calcular3_Click;
            // 
            // area3
            // 
            area3.Location = new Point(260, 148);
            area3.Name = "area3";
            area3.ReadOnly = true;
            area3.Size = new Size(100, 23);
            area3.TabIndex = 4;
            // 
            // lado
            // 
            lado.Location = new Point(260, 100);
            lado.Name = "lado";
            lado.Size = new Size(100, 23);
            lado.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(200, 151);
            label11.Name = "label11";
            label11.Size = new Size(54, 30);
            label11.TabIndex = 2;
            label11.Text = "Area";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(108, 100);
            label10.Name = "label10";
            label10.Size = new Size(136, 30);
            label10.TabIndex = 1;
            label10.Text = "Lado Tamaño";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(244, 25);
            label9.Name = "label9";
            label9.Size = new Size(116, 32);
            label9.TabIndex = 0;
            label9.Text = "Cuadrado";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Lime;
            tabPage4.Controls.Add(Borrar4);
            tabPage4.Controls.Add(Calcular4);
            tabPage4.Controls.Add(volumen4);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(area4);
            tabPage4.Controls.Add(altura4);
            tabPage4.Controls.Add(radio4);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label13);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(613, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Cilindro";
            // 
            // Borrar4
            // 
            Borrar4.AutoSize = true;
            Borrar4.BackColor = Color.LimeGreen;
            Borrar4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            Borrar4.Location = new Point(381, 316);
            Borrar4.Name = "Borrar4";
            Borrar4.Size = new Size(78, 40);
            Borrar4.TabIndex = 10;
            Borrar4.Text = "Borrar";
            Borrar4.UseVisualStyleBackColor = false;
            Borrar4.Click += Borrar4_Click;
            // 
            // Calcular4
            // 
            Calcular4.AutoSize = true;
            Calcular4.BackColor = Color.LimeGreen;
            Calcular4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            Calcular4.Location = new Point(154, 316);
            Calcular4.Name = "Calcular4";
            Calcular4.Size = new Size(96, 40);
            Calcular4.TabIndex = 9;
            Calcular4.Text = "Calcular";
            Calcular4.UseVisualStyleBackColor = false;
            Calcular4.Click += Calcular4_Click;
            // 
            // volumen4
            // 
            volumen4.Location = new Point(265, 227);
            volumen4.Name = "volumen4";
            volumen4.ReadOnly = true;
            volumen4.Size = new Size(100, 23);
            volumen4.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label17.Location = new Point(176, 227);
            label17.Name = "label17";
            label17.Size = new Size(86, 25);
            label17.TabIndex = 7;
            label17.Text = "Volumen";
            // 
            // area4
            // 
            area4.Location = new Point(235, 171);
            area4.Name = "area4";
            area4.ReadOnly = true;
            area4.Size = new Size(100, 23);
            area4.TabIndex = 6;
            // 
            // altura4
            // 
            altura4.Location = new Point(209, 122);
            altura4.Name = "altura4";
            altura4.Size = new Size(100, 23);
            altura4.TabIndex = 5;
            // 
            // radio4
            // 
            radio4.Location = new Point(185, 67);
            radio4.Name = "radio4";
            radio4.Size = new Size(100, 23);
            radio4.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label16.Location = new Point(252, 20);
            label16.Name = "label16";
            label16.Size = new Size(82, 30);
            label16.TabIndex = 3;
            label16.Text = "Cilindro";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(162, 171);
            label15.Name = "label15";
            label15.Size = new Size(50, 25);
            label15.TabIndex = 2;
            label15.Text = "Area";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(124, 122);
            label14.Name = "label14";
            label14.Size = new Size(63, 25);
            label14.TabIndex = 1;
            label14.Text = "Altura";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(110, 65);
            label13.Name = "label13";
            label13.Size = new Size(60, 25);
            label13.TabIndex = 0;
            label13.Text = "Radio";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Red;
            tabPage5.Controls.Add(borrar5);
            tabPage5.Controls.Add(calcular5);
            tabPage5.Controls.Add(resultado5);
            tabPage5.Controls.Add(diam5);
            tabPage5.Controls.Add(diametro5);
            tabPage5.Controls.Add(label21);
            tabPage5.Controls.Add(label20);
            tabPage5.Controls.Add(label19);
            tabPage5.Controls.Add(label18);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(613, 398);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Rombo";
            // 
            // borrar5
            // 
            borrar5.AutoSize = true;
            borrar5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            borrar5.Location = new Point(425, 326);
            borrar5.Name = "borrar5";
            borrar5.Size = new Size(78, 40);
            borrar5.TabIndex = 8;
            borrar5.Text = "Borrar";
            borrar5.UseVisualStyleBackColor = true;
            borrar5.Click += borrar5_Click;
            // 
            // calcular5
            // 
            calcular5.AutoSize = true;
            calcular5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            calcular5.Location = new Point(134, 326);
            calcular5.Name = "calcular5";
            calcular5.Size = new Size(96, 40);
            calcular5.TabIndex = 7;
            calcular5.Text = "Calcular";
            calcular5.UseVisualStyleBackColor = true;
            calcular5.Click += calcular5_Click;
            // 
            // resultado5
            // 
            resultado5.Location = new Point(279, 213);
            resultado5.Name = "resultado5";
            resultado5.ReadOnly = true;
            resultado5.Size = new Size(100, 23);
            resultado5.TabIndex = 6;
            // 
            // diam5
            // 
            diam5.Location = new Point(234, 160);
            diam5.Name = "diam5";
            diam5.Size = new Size(100, 23);
            diam5.TabIndex = 5;
            // 
            // diametro5
            // 
            diametro5.Location = new Point(188, 106);
            diametro5.Name = "diametro5";
            diametro5.Size = new Size(100, 23);
            diametro5.TabIndex = 4;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(219, 213);
            label21.Name = "label21";
            label21.Size = new Size(54, 30);
            label21.TabIndex = 3;
            label21.Text = "Area";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(114, 160);
            label20.Name = "label20";
            label20.Size = new Size(114, 30);
            label20.TabIndex = 2;
            label20.Text = "Diametro 2";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(71, 99);
            label19.Name = "label19";
            label19.Size = new Size(114, 30);
            label19.TabIndex = 1;
            label19.Text = "Diametro 1";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(256, 24);
            label18.Name = "label18";
            label18.Size = new Size(99, 37);
            label18.TabIndex = 0;
            label18.Text = "Rombo";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.Indigo;
            tabPage6.Controls.Add(button2);
            tabPage6.Controls.Add(button1);
            tabPage6.Controls.Add(volumen6);
            tabPage6.Controls.Add(area6);
            tabPage6.Controls.Add(LadoA);
            tabPage6.Controls.Add(label25);
            tabPage6.Controls.Add(label24);
            tabPage6.Controls.Add(label23);
            tabPage6.Controls.Add(label22);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(613, 398);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Octaedro";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(374, 276);
            button2.Name = "button2";
            button2.Size = new Size(105, 42);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(147, 276);
            button1.Name = "button1";
            button1.Size = new Size(109, 42);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // volumen6
            // 
            volumen6.Location = new Point(344, 186);
            volumen6.Name = "volumen6";
            volumen6.ReadOnly = true;
            volumen6.Size = new Size(100, 23);
            volumen6.TabIndex = 6;
            // 
            // area6
            // 
            area6.Location = new Point(287, 134);
            area6.Name = "area6";
            area6.ReadOnly = true;
            area6.Size = new Size(100, 23);
            area6.TabIndex = 5;
            // 
            // LadoA
            // 
            LadoA.Location = new Point(245, 82);
            LadoA.Name = "LadoA";
            LadoA.Size = new Size(100, 23);
            LadoA.TabIndex = 4;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label25.ForeColor = Color.White;
            label25.Location = new Point(226, 186);
            label25.Name = "label25";
            label25.Size = new Size(94, 30);
            label25.TabIndex = 3;
            label25.Text = "Volumen";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(213, 134);
            label24.Name = "label24";
            label24.Size = new Size(54, 30);
            label24.TabIndex = 2;
            label24.Text = "Area";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(158, 81);
            label23.Name = "label23";
            label23.Size = new Size(75, 30);
            label23.TabIndex = 1;
            label23.Text = "Lado A";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(213, 12);
            label22.Name = "label22";
            label22.Size = new Size(133, 40);
            label22.TabIndex = 0;
            label22.Text = "Octaedro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 449);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Label label1;
        private Button cal;
        private Label label4;
        private TextBox area;
        private TextBox volumen;
        private TextBox radio;
        private Label label3;
        private Label label2;
        private Button delete;
        private TextBox resultado;
        private TextBox altura2;
        private TextBox base2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button delete2;
        private Button cal1;
        private Label label9;
        private Button borrar3;
        private Button calcular3;
        private TextBox area3;
        private TextBox lado;
        private Label label11;
        private Label label10;
        private TextBox volumen3;
        private Label label12;
        private TextBox volumen4;
        private Label label17;
        private TextBox area4;
        private TextBox altura4;
        private TextBox radio4;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button Borrar4;
        private Button Calcular4;
        private TextBox resultado5;
        private TextBox diam5;
        private TextBox diametro5;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Button borrar5;
        private Button calcular5;
        private Button button2;
        private Button button1;
        private TextBox volumen6;
        private TextBox area6;
        private TextBox LadoA;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
    }
}