namespace CompareFiles
{
    partial class CompareFiles
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChoose1 = new System.Windows.Forms.Button();
            this.btnChoose2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 22);
            this.textBox2.TabIndex = 1;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(185, 485);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(136, 65);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "File 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "File 2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ASCII Comparison (Display only first and last line of each differences)",
            "ASCII Comparison (Default)",
            "ASCII Comparison (With Line Number)",
            "Binary Comparison",
            "Case Insensitive Comparison",
            "Unicode Comparison",
            "Ignore White Spaces"});
            this.comboBox1.Location = new System.Drawing.Point(93, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(107, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Multi-Type";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ASCII Comparison (Display only first and last line of each differences)",
            "ASCII Comparison (Default)",
            "ASCII Comparison (With Line Number)",
            "Binary Comparison",
            "Case Insensitive Comparison",
            "Unicode Comparison",
            "Ignore White Spaces"});
            this.comboBox2.Location = new System.Drawing.Point(93, 234);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(348, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type 2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 278);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(348, 201);
            this.textBox3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Output";
            // 
            // btnChoose1
            // 
            this.btnChoose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChoose1.Location = new System.Drawing.Point(412, 12);
            this.btnChoose1.Name = "btnChoose1";
            this.btnChoose1.Size = new System.Drawing.Size(62, 35);
            this.btnChoose1.TabIndex = 12;
            this.btnChoose1.Text = "...";
            this.btnChoose1.UseVisualStyleBackColor = true;
            this.btnChoose1.Click += new System.EventHandler(this.btnChoose1_Click);
            // 
            // btnChoose2
            // 
            this.btnChoose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChoose2.Location = new System.Drawing.Point(412, 86);
            this.btnChoose2.Name = "btnChoose2";
            this.btnChoose2.Size = new System.Drawing.Size(62, 35);
            this.btnChoose2.TabIndex = 13;
            this.btnChoose2.Text = "...";
            this.btnChoose2.UseVisualStyleBackColor = true;
            this.btnChoose2.Click += new System.EventHandler(this.btnChoose2_Click);
            // 
            // CompareFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 576);
            this.Controls.Add(this.btnChoose2);
            this.Controls.Add(this.btnChoose1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "CompareFiles";
            this.Text = "File Comparison";
            this.Load += new System.EventHandler(this.CompareFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChoose1;
        private System.Windows.Forms.Button btnChoose2;
    }
}

