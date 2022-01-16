namespace GPA
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
            this.textBoxGPA_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxGPAx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.textBoxName_input = new System.Windows.Forms.TextBox();
            this.textBoxMaxName = new System.Windows.Forms.TextBox();
            this.textBoxMinName = new System.Windows.Forms.TextBox();
            this.textBoxAllData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxGPA_input
            // 
            this.textBoxGPA_input.Location = new System.Drawing.Point(286, 75);
            this.textBoxGPA_input.Name = "textBoxGPA_input";
            this.textBoxGPA_input.Size = new System.Drawing.Size(125, 27);
            this.textBoxGPA_input.TabIndex = 0;
            this.textBoxGPA_input.TextChanged += new System.EventHandler(this.textBoxGPA_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPA INPUT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxGPAx
            // 
            this.textBoxGPAx.Location = new System.Drawing.Point(260, 42);
            this.textBoxGPAx.Name = "textBoxGPAx";
            this.textBoxGPAx.Size = new System.Drawing.Size(125, 27);
            this.textBoxGPAx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "GPAx";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMinName);
            this.groupBox1.Controls.Add(this.textBoxMaxName);
            this.groupBox1.Controls.Add(this.textBoxMinGPA);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBoxMaxGPA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxGPAx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUTPUT";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "MAX GPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "MIN GPA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Location = new System.Drawing.Point(260, 94);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.Size = new System.Drawing.Size(125, 27);
            this.textBoxMaxGPA.TabIndex = 8;
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Location = new System.Drawing.Point(260, 149);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.Size = new System.Drawing.Size(125, 27);
            this.textBoxMinGPA.TabIndex = 9;
            // 
            // textBoxName_input
            // 
            this.textBoxName_input.Location = new System.Drawing.Point(131, 75);
            this.textBoxName_input.Name = "textBoxName_input";
            this.textBoxName_input.Size = new System.Drawing.Size(125, 27);
            this.textBoxName_input.TabIndex = 7;
            // 
            // textBoxMaxName
            // 
            this.textBoxMaxName.Location = new System.Drawing.Point(105, 94);
            this.textBoxMaxName.Name = "textBoxMaxName";
            this.textBoxMaxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxMaxName.TabIndex = 11;
            // 
            // textBoxMinName
            // 
            this.textBoxMinName.Location = new System.Drawing.Point(105, 146);
            this.textBoxMinName.Name = "textBoxMinName";
            this.textBoxMinName.Size = new System.Drawing.Size(125, 27);
            this.textBoxMinName.TabIndex = 12;
            // 
            // textBoxAllData
            // 
            this.textBoxAllData.Location = new System.Drawing.Point(80, 350);
            this.textBoxAllData.Multiline = true;
            this.textBoxAllData.Name = "textBoxAllData";
            this.textBoxAllData.Size = new System.Drawing.Size(375, 93);
            this.textBoxAllData.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 502);
            this.Controls.Add(this.textBoxAllData);
            this.Controls.Add(this.textBoxName_input);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGPA_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxGPA_input;
        private Label label1;
        private Button button1;
        private TextBox textBoxGPAx;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Button button2;
        private Label label4;
        private TextBox textBoxMaxGPA;
        private TextBox textBoxMinGPA;
        private TextBox textBoxMinName;
        private TextBox textBoxMaxName;
        private TextBox textBoxName_input;
        private TextBox textBoxAllData;
    }
}