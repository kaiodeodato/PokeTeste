namespace PokeTeste
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
            button1 = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(36, 30);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(206, 62);
            button1.TabIndex = 0;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 95);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 1;
            label1.Text = "Amount";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(36, 136);
            numericUpDown1.Margin = new Padding(6);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(206, 39);
            numericUpDown1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Trebuchet MS", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(36, 201);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(206, 188);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(270, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Location = new Point(514, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(270, 253);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(271, 305);
            label3.Name = "label3";
            label3.Size = new Size(105, 32);
            label3.TabIndex = 7;
            label3.Text = "Abilities";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(271, 360);
            label4.Name = "label4";
            label4.Size = new Size(199, 32);
            label4.TabIndex = 8;
            label4.Text = "Base experience";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Trebuchet MS", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(377, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 35);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Trebuchet MS", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(377, 300);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(354, 35);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Trebuchet MS", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(469, 355);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 35);
            textBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(709, 403);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 12;
            label5.Text = "status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(760, 425);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
    }
}