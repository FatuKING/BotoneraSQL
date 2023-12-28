namespace BotonesSQL
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 46);
            label1.Name = "label1";
            label1.Size = new Size(120, 16);
            label1.TabIndex = 1;
            label1.Text = "Numero de ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 76);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Numero de DNI";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(78, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 23);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(23, 150);
            button2.Name = "button2";
            button2.Size = new Size(238, 32);
            button2.TabIndex = 5;
            button2.Text = "Cambiar DNI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 9);
            label3.Name = "label3";
            label3.Size = new Size(126, 18);
            label3.TabIndex = 6;
            label3.Text = "Actualizar DNI";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(23, 111);
            button1.Name = "button1";
            button1.Size = new Size(239, 33);
            button1.TabIndex = 7;
            button1.Text = "Consulta DNI actual";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(285, 194);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private Button button1;
    }
}