namespace Yugioh_match_tracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Tele-Marines", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton1.Location = new Point(21, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 15);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "WIN";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Tele-Marines", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton2.Location = new Point(21, 42);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 15);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "LOSS";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Tele-Marines", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(86, 169);
            button1.Name = "button1";
            button1.Size = new Size(92, 29);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Location = new Point(306, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 205);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Tele-Marines", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(218, 169);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 11;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tele-Marines", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(245, 39);
            label4.Name = "label4";
            label4.Size = new Size(271, 11);
            label4.TabIndex = 10;
            label4.Text = "- Your opponents score";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tele-Marines", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(245, 17);
            label3.Name = "label3";
            label3.Size = new Size(146, 11);
            label3.TabIndex = 9;
            label3.Text = "- Your score";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(190, 37);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(49, 23);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(190, 12);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tele-Marines", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(127, 116);
            label2.Name = "label2";
            label2.Size = new Size(352, 11);
            label2.TabIndex = 6;
            label2.Text = "- Name of your opponents deck";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tele-Marines", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(127, 87);
            label1.Name = "label1";
            label1.Size = new Size(227, 11);
            label1.TabIndex = 5;
            label1.Text = "- Name of your deck";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.HotTrack;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(306, 223);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(526, 349);
            listBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Font = new Font("Tele-Marines", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(350, 169);
            button3.Name = "button3";
            button3.Size = new Size(80, 29);
            button3.TabIndex = 12;
            button3.Text = "Load";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 578);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Yugioh match hisotry tracker";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private Button button3;
    }
}