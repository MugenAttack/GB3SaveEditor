namespace GB3SaveEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numHPHigh = new System.Windows.Forms.NumericUpDown();
            this.numHPMed = new System.Windows.Forms.NumericUpDown();
            this.numHPLow = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numPHigh = new System.Windows.Forms.NumericUpDown();
            this.numPMed = new System.Windows.Forms.NumericUpDown();
            this.numPLow = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHPHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHPMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHPLow)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPLow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numHPHigh);
            this.groupBox3.Controls.Add(this.numHPMed);
            this.groupBox3.Controls.Add(this.numHPLow);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(315, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 130);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hard Plastic";
            // 
            // numHPHigh
            // 
            this.numHPHigh.Location = new System.Drawing.Point(131, 87);
            this.numHPHigh.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numHPHigh.Name = "numHPHigh";
            this.numHPHigh.Size = new System.Drawing.Size(150, 22);
            this.numHPHigh.TabIndex = 8;
            this.numHPHigh.ValueChanged += new System.EventHandler(this.numHPHigh_ValueChanged);
            // 
            // numHPMed
            // 
            this.numHPMed.Location = new System.Drawing.Point(131, 59);
            this.numHPMed.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numHPMed.Name = "numHPMed";
            this.numHPMed.Size = new System.Drawing.Size(150, 22);
            this.numHPMed.TabIndex = 7;
            this.numHPMed.ValueChanged += new System.EventHandler(this.numHPMed_ValueChanged);
            // 
            // numHPLow
            // 
            this.numHPLow.Location = new System.Drawing.Point(131, 31);
            this.numHPLow.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numHPLow.Name = "numHPLow";
            this.numHPLow.Size = new System.Drawing.Size(150, 22);
            this.numHPLow.TabIndex = 6;
            this.numHPLow.ValueChanged += new System.EventHandler(this.numHPLow_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Low";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "High";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Medium";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numPHigh);
            this.groupBox2.Controls.Add(this.numPMed);
            this.groupBox2.Controls.Add(this.numPLow);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(315, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 130);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plastic";
            // 
            // numPHigh
            // 
            this.numPHigh.Location = new System.Drawing.Point(131, 87);
            this.numPHigh.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numPHigh.Name = "numPHigh";
            this.numPHigh.Size = new System.Drawing.Size(150, 22);
            this.numPHigh.TabIndex = 8;
            this.numPHigh.ValueChanged += new System.EventHandler(this.numPHigh_ValueChanged);
            // 
            // numPMed
            // 
            this.numPMed.Location = new System.Drawing.Point(131, 59);
            this.numPMed.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numPMed.Name = "numPMed";
            this.numPMed.Size = new System.Drawing.Size(150, 22);
            this.numPMed.TabIndex = 7;
            this.numPMed.ValueChanged += new System.EventHandler(this.numPMed_ValueChanged);
            // 
            // numPLow
            // 
            this.numPLow.Location = new System.Drawing.Point(131, 31);
            this.numPLow.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numPLow.Name = "numPLow";
            this.numPLow.Size = new System.Drawing.Size(150, 22);
            this.numPLow.TabIndex = 6;
            this.numPLow.ValueChanged += new System.EventHandler(this.numPLow_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Low";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "High";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Medium";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExp);
            this.groupBox1.Controls.Add(this.txtRank);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCredits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rank:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Experience:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-4, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 358);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Parts";
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(131, 86);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(150, 22);
            this.txtRank.TabIndex = 5;
            this.txtRank.TextChanged += new System.EventHandler(this.txtRank_TextChanged);
            // 
            // txtExp
            // 
            this.txtExp.Location = new System.Drawing.Point(131, 58);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(150, 22);
            this.txtExp.TabIndex = 3;
            this.txtExp.TextChanged += new System.EventHandler(this.txtExp_TextChanged);
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(131, 30);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(150, 22);
            this.txtCredits.TabIndex = 1;
            this.txtCredits.TextChanged += new System.EventHandler(this.txtCredits_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(218, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Coming Soon!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 414);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GB3 Save Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHPHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHPMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHPLow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPLow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numHPHigh;
        private System.Windows.Forms.NumericUpDown numHPMed;
        private System.Windows.Forms.NumericUpDown numHPLow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numPHigh;
        private System.Windows.Forms.NumericUpDown numPMed;
        private System.Windows.Forms.NumericUpDown numPLow;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Label label10;
    }
}

