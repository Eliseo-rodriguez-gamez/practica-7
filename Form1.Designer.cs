namespace practica_7
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
            label5 = new Label();
            valor = new TextBox();
            Resultado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 46);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 88);
            label2.Name = "label2";
            label2.Size = new Size(99, 18);
            label2.TabIndex = 1;
            label2.Text = "Ingresa Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 125);
            label3.Name = "label3";
            label3.Size = new Size(206, 19);
            label3.TabIndex = 2;
            label3.Text = "Opcioes de Conversiones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(58, 237);
            label4.Name = "label4";
            label4.Size = new Size(164, 19);
            label4.TabIndex = 3;
            label4.Text = "Resultado en Gados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(117, 275);
            label5.Name = "label5";
            label5.Size = new Size(166, 18);
            label5.TabIndex = 4;
            label5.Text = "Equivalente en Grados";
            // 
            // valor
            // 
            valor.Location = new Point(259, 83);
            valor.Name = "valor";
            valor.Size = new Size(100, 23);
            valor.TabIndex = 5;
            valor.TextChanged += textBox1_TextChanged;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(117, 311);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(192, 23);
            Resultado.TabIndex = 6;
            Resultado.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(58, 162);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 7;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(248, 162);
            button2.Name = "button2";
            button2.Size = new Size(118, 23);
            button2.TabIndex = 8;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(171, 200);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Resultado);
            Controls.Add(valor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox valor;
        private TextBox Resultado;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}