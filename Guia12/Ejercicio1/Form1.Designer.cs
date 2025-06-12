namespace Ejercicio1
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
            btnSolicitar = new Button();
            label1 = new Label();
            lbMostrarValor = new Label();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(115, 34);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(115, 23);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "Solocitar Valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 97);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Resultado";
            // 
            // lbMostrarValor
            // 
            lbMostrarValor.BackColor = SystemColors.ActiveCaption;
            lbMostrarValor.Location = new Point(196, 88);
            lbMostrarValor.Name = "lbMostrarValor";
            lbMostrarValor.Size = new Size(100, 24);
            lbMostrarValor.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 140);
            Controls.Add(lbMostrarValor);
            Controls.Add(label1);
            Controls.Add(btnSolicitar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitar;
        private Label label1;
        private Label lbMostrarValor;
    }
}
