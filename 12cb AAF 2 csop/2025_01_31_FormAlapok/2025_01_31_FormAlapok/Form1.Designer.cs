namespace _2025_01_31_FormAlapok
{
    partial class Form1
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
            this.szinezesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MuveletCombo = new System.Windows.Forms.ComboBox();
            this.szam1NUD = new System.Windows.Forms.NumericUpDown();
            this.szam2NUD = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.EredmenyLabel = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.szam1NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szam2NUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // szinezesBtn
            // 
            this.szinezesBtn.Location = new System.Drawing.Point(15, 15);
            this.szinezesBtn.Margin = new System.Windows.Forms.Padding(6);
            this.szinezesBtn.Name = "szinezesBtn";
            this.szinezesBtn.Size = new System.Drawing.Size(150, 44);
            this.szinezesBtn.TabIndex = 0;
            this.szinezesBtn.Text = "Szinezés";
            this.szinezesBtn.UseVisualStyleBackColor = true;
            this.szinezesBtn.Click += new System.EventHandler(this.szinezesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Művelet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 32);
            this.textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(182, 23);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 30);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 38);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 30);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Red";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(473, 12);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 329);
            this.listBox1.TabIndex = 5;
            // 
            // MuveletCombo
            // 
            this.MuveletCombo.FormattingEnabled = true;
            this.MuveletCombo.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "maradék",
            "hatvány"});
            this.MuveletCombo.Location = new System.Drawing.Point(131, 362);
            this.MuveletCombo.Margin = new System.Windows.Forms.Padding(6);
            this.MuveletCombo.Name = "MuveletCombo";
            this.MuveletCombo.Size = new System.Drawing.Size(76, 33);
            this.MuveletCombo.TabIndex = 6;
            this.MuveletCombo.SelectedIndexChanged += new System.EventHandler(this.MuveletCombo_SelectedIndexChanged);
            // 
            // szam1NUD
            // 
            this.szam1NUD.Location = new System.Drawing.Point(24, 317);
            this.szam1NUD.Name = "szam1NUD";
            this.szam1NUD.Size = new System.Drawing.Size(120, 32);
            this.szam1NUD.TabIndex = 7;
            this.szam1NUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.szam1NUD.ValueChanged += new System.EventHandler(this.szam1NUD_ValueChanged);
            // 
            // szam2NUD
            // 
            this.szam2NUD.Location = new System.Drawing.Point(150, 317);
            this.szam2NUD.Name = "szam2NUD";
            this.szam2NUD.Size = new System.Drawing.Size(120, 32);
            this.szam2NUD.TabIndex = 8;
            this.szam2NUD.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.szam2NUD.ValueChanged += new System.EventHandler(this.szam2NUD_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Szamol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EredmenyLabel
            // 
            this.EredmenyLabel.AutoSize = true;
            this.EredmenyLabel.Location = new System.Drawing.Point(150, 417);
            this.EredmenyLabel.Name = "EredmenyLabel";
            this.EredmenyLabel.Size = new System.Drawing.Size(70, 26);
            this.EredmenyLabel.TabIndex = 10;
            this.EredmenyLabel.Text = "label2";
            this.EredmenyLabel.Click += new System.EventHandler(this.EredmenyLabel_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 30);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Green";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 115);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 30);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Blue";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 46);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 30);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Red";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 82);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(90, 30);
            this.radioButton5.TabIndex = 14;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Green";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 123);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(74, 30);
            this.radioButton6.TabIndex = 15;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Blue";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Betű";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(15, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 195);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Háttér";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Location = new System.Drawing.Point(174, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 166);
            this.panel1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Új elem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EredmenyLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.szam2NUD);
            this.Controls.Add(this.szam1NUD);
            this.Controls.Add(this.MuveletCombo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szinezesBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form alapok";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.szam1NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szam2NUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button szinezesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox MuveletCombo;
        private System.Windows.Forms.NumericUpDown szam1NUD;
        private System.Windows.Forms.NumericUpDown szam2NUD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label EredmenyLabel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

