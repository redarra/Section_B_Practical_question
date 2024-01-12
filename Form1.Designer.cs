namespace Section_B_Practical_question
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 20);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter a new word:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 192);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 1;
            label2.Text = "OR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 2;
            label3.Text = "Select a word:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(530, 150);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 3;
            label4.Text = "Select another word:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 31);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 33);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "--Words--";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(530, 192);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(258, 33);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "--Words--";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 241);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(101, 29);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Remove";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(530, 238);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(101, 29);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Remove";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(343, 103);
            button1.Name = "button1";
            button1.Size = new Size(125, 34);
            button1.TabIndex = 9;
            button1.Text = "Add Word";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 358);
            label5.Name = "label5";
            label5.Size = new Size(800, 92);
            label5.TabIndex = 10;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(343, 238);
            button2.Name = "button2";
            button2.Size = new Size(125, 34);
            button2.TabIndex = 11;
            button2.Text = "Concatenate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Label label5;
        private Button button2;
    }
}