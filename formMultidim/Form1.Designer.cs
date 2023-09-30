namespace formMultidim
{
    partial class Form1
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbmatriz1 = new System.Windows.Forms.Label();
            this.txtbresultado = new System.Windows.Forms.Label();
            this.lbmatriz2 = new System.Windows.Forms.Label();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnIntro = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(94, 300);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(122, 66);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(94, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(592, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "   Introduce los valores de tu matriz";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "matriz 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "matriz 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "resultado";
            // 
            // lbmatriz1
            // 
            this.lbmatriz1.Location = new System.Drawing.Point(107, 194);
            this.lbmatriz1.Name = "lbmatriz1";
            this.lbmatriz1.Size = new System.Drawing.Size(109, 75);
            this.lbmatriz1.TabIndex = 2;
            this.lbmatriz1.Text = "0";
            // 
            // txtbresultado
            // 
            this.txtbresultado.Location = new System.Drawing.Point(462, 194);
            this.txtbresultado.Name = "txtbresultado";
            this.txtbresultado.Size = new System.Drawing.Size(342, 104);
            this.txtbresultado.TabIndex = 2;
            this.txtbresultado.Text = "0";
            // 
            // lbmatriz2
            // 
            this.lbmatriz2.Location = new System.Drawing.Point(276, 194);
            this.lbmatriz2.Name = "lbmatriz2";
            this.lbmatriz2.Size = new System.Drawing.Size(101, 75);
            this.lbmatriz2.TabIndex = 2;
            this.lbmatriz2.Text = "0";
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(94, 382);
            this.btnSeno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(122, 72);
            this.btnSeno.TabIndex = 0;
            this.btnSeno.Text = "sen";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(259, 300);
            this.btnResta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(118, 66);
            this.btnResta.TabIndex = 0;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(259, 382);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 72);
            this.button4.TabIndex = 0;
            this.button4.Text = "T";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(422, 300);
            this.btnMultiplicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(108, 66);
            this.btnMultiplicacion.TabIndex = 0;
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(422, 382);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 72);
            this.button6.TabIndex = 0;
            this.button6.Text = "c";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnIntro
            // 
            this.btnIntro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnIntro.Location = new System.Drawing.Point(570, 300);
            this.btnIntro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(116, 154);
            this.btnIntro.TabIndex = 0;
            this.btnIntro.Text = "In";
            this.btnIntro.UseVisualStyleBackColor = false;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(288, 47);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "rad";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(478, 47);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 20);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "deg";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 548);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtbresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbmatriz1);
            this.Controls.Add(this.lbmatriz2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnIntro);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Calculadora de Matrices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbmatriz1;
        private System.Windows.Forms.Label txtbresultado;
        private System.Windows.Forms.Label lbmatriz2;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnIntro;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

