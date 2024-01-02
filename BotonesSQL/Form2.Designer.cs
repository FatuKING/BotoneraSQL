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
            btn6 = new Button();
            btn7 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            label2 = new Label();
            btn5 = new Button();
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
            // btn6
            // 
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(187, 59);
            btn6.Name = "btn6";
            btn6.Size = new Size(170, 43);
            btn6.TabIndex = 6;
            btn6.Text = "Borrar setup";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(187, 108);
            btn7.Name = "btn7";
            btn7.Size = new Size(170, 43);
            btn7.TabIndex = 7;
            btn7.Text = "Ocultar usuario";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn1
            // 
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(12, 59);
            btn1.Name = "btn1";
            btn1.Size = new Size(169, 43);
            btn1.TabIndex = 1;
            btn1.Text = "Actualizar nombre cliente";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(12, 206);
            btn4.Name = "btn4";
            btn4.Size = new Size(169, 43);
            btn4.TabIndex = 4;
            btn4.Text = "Ocultar ticket";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn2
            // 
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(12, 108);
            btn2.Name = "btn2";
            btn2.Size = new Size(169, 43);
            btn2.TabIndex = 2;
            btn2.Text = "Actualizar DNI";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(12, 157);
            btn3.Name = "btn3";
            btn3.Size = new Size(169, 43);
            btn3.TabIndex = 3;
            btn3.Text = "Ticket sin vendedor";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(187, 23);
            label2.Name = "label2";
            label2.Size = new Size(128, 29);
            label2.TabIndex = 2;
            label2.Text = "FrontRest";
            // 
            // btn5
            // 
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(12, 255);
            btn5.Name = "btn5";
            btn5.Size = new Size(169, 43);
            btn5.TabIndex = 5;
            btn5.Text = "Cambiar régimen de facturación";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
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
            Controls.Add(btn5);
            Controls.Add(label2);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btn7);
            Controls.Add(btn6);
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
        private Label label2;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private PictureBox pictureBox1;
    }
}