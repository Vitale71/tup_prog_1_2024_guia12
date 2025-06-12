namespace Ejercicio5
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
            btnRegistrar = new Button();
            button2 = new Button();
            button3 = new Button();
            tbValor = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            lbCantidadIngresados = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(202, 34);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(170, 28);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(217, 257);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Mostrar Listado";
            button3.UseVisualStyleBackColor = true;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(23, 25);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 391);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Cantidad:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(32, 252);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 105);
            textBox2.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(23, 82);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "secuencial";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(23, 107);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(84, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Biseccional";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(66, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Burbuja";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 47);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(76, 19);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "Quicksort";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // lbCantidadIngresados
            // 
            lbCantidadIngresados.AutoSize = true;
            lbCantidadIngresados.Location = new Point(198, 391);
            lbCantidadIngresados.Name = "lbCantidadIngresados";
            lbCantidadIngresados.Size = new Size(122, 15);
            lbCantidadIngresados.TabIndex = 10;
            lbCantidadIngresados.Text = "lbCantidadIngresados";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(tbValor);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(32, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 146);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo Ordenamiento";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(192, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(138, 72);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo Ordenamiento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 419);
            Controls.Add(textBox2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lbCantidadIngresados);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button button2;
        private Button button3;
        private TextBox tbValor;
        private Label label1;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label lbCantidadIngresados;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
