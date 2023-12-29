namespace BotonesSQL
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Ticket Fiscal";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(187, 59);
            button1.Name = "button1";
            button1.Size = new Size(170, 43);
            button1.TabIndex = 1;
            button1.Text = "Borrar setup";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(187, 108);
            button2.Name = "button2";
            button2.Size = new Size(170, 43);
            button2.TabIndex = 2;
            button2.Text = "Ocultar usuario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 59);
            button3.Name = "button3";
            button3.Size = new Size(169, 43);
            button3.TabIndex = 3;
            button3.Text = "Actualizar nombre cliente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 206);
            button4.Name = "button4";
            button4.Size = new Size(169, 43);
            button4.TabIndex = 4;
            button4.Text = "Ocultar ticket";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(12, 108);
            button5.Name = "button5";
            button5.Size = new Size(169, 43);
            button5.TabIndex = 5;
            button5.Text = "Actualizar DNI";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(12, 157);
            button6.Name = "button6";
            button6.Size = new Size(169, 43);
            button6.TabIndex = 6;
            button6.Text = "Ticket sin vendedor";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(187, 23);
            label2.Name = "label2";
            label2.Size = new Size(128, 29);
            label2.TabIndex = 7;
            label2.Text = "FrontRest";
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(12, 255);
            button8.Name = "button8";
            button8.Size = new Size(169, 43);
            button8.TabIndex = 9;
            button8.Text = "Cambiar régimen de facturación";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(187, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(373, 311);
            Controls.Add(pictureBox1);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            Text = "QueryAutomatic";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
        private Button button8;
        private PictureBox pictureBox1;
    }
}