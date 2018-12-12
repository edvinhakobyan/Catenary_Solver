namespace Cable
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
            this.textBox_S = new System.Windows.Forms.TextBox();
            this.textBox_H = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_S = new System.Windows.Forms.CheckBox();
            this.checkBox_Y = new System.Windows.Forms.CheckBox();
            this.checkBox_H = new System.Windows.Forms.CheckBox();
            this.checkBox_X = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_T = new System.Windows.Forms.CheckBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.textBox_W = new System.Windows.Forms.TextBox();
            this.textBox_T = new System.Windows.Forms.TextBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_S
            // 
            this.textBox_S.Enabled = false;
            this.textBox_S.Location = new System.Drawing.Point(140, 20);
            this.textBox_S.Name = "textBox_S";
            this.textBox_S.Size = new System.Drawing.Size(120, 20);
            this.textBox_S.TabIndex = 0;
            // 
            // textBox_H
            // 
            this.textBox_H.Enabled = false;
            this.textBox_H.Location = new System.Drawing.Point(140, 70);
            this.textBox_H.Name = "textBox_H";
            this.textBox_H.Size = new System.Drawing.Size(120, 20);
            this.textBox_H.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_S
            // 
            this.checkBox_S.AutoSize = true;
            this.checkBox_S.Location = new System.Drawing.Point(15, 20);
            this.checkBox_S.Name = "checkBox_S";
            this.checkBox_S.Size = new System.Drawing.Size(105, 17);
            this.checkBox_S.TabIndex = 8;
            this.checkBox_S.Text = "S - Cable Length";
            this.checkBox_S.UseVisualStyleBackColor = true;
            this.checkBox_S.CheckedChanged += new System.EventHandler(this.checkBox_S_CheckedChanged);
            // 
            // checkBox_Y
            // 
            this.checkBox_Y.AutoSize = true;
            this.checkBox_Y.Location = new System.Drawing.Point(15, 45);
            this.checkBox_Y.Name = "checkBox_Y";
            this.checkBox_Y.Size = new System.Drawing.Size(106, 17);
            this.checkBox_Y.TabIndex = 8;
            this.checkBox_Y.Text = "Y - Tower Height";
            this.checkBox_Y.UseVisualStyleBackColor = true;
            this.checkBox_Y.CheckedChanged += new System.EventHandler(this.checkBox_Y_CheckedChanged);
            // 
            // checkBox_H
            // 
            this.checkBox_H.AutoSize = true;
            this.checkBox_H.Location = new System.Drawing.Point(15, 70);
            this.checkBox_H.Name = "checkBox_H";
            this.checkBox_H.Size = new System.Drawing.Size(104, 17);
            this.checkBox_H.TabIndex = 8;
            this.checkBox_H.Text = "H - Sag of Cable";
            this.checkBox_H.UseVisualStyleBackColor = true;
            this.checkBox_H.CheckedChanged += new System.EventHandler(this.checkBox_H_CheckedChanged);
            // 
            // checkBox_X
            // 
            this.checkBox_X.AutoSize = true;
            this.checkBox_X.Location = new System.Drawing.Point(15, 95);
            this.checkBox_X.Name = "checkBox_X";
            this.checkBox_X.Size = new System.Drawing.Size(117, 17);
            this.checkBox_X.TabIndex = 8;
            this.checkBox_X.Text = "X - Tower Distance";
            this.checkBox_X.UseVisualStyleBackColor = true;
            this.checkBox_X.CheckedChanged += new System.EventHandler(this.checkBox_X_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.checkBox_T);
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Controls.Add(this.textBox16);
            this.groupBox2.Controls.Add(this.textBox14);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.textBox_Y);
            this.groupBox2.Controls.Add(this.textBoxW);
            this.groupBox2.Controls.Add(this.textBox_W);
            this.groupBox2.Controls.Add(this.textBox_T);
            this.groupBox2.Controls.Add(this.textBox_X);
            this.groupBox2.Controls.Add(this.textBox_H);
            this.groupBox2.Controls.Add(this.textBox_S);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.checkBox_Y);
            this.groupBox2.Controls.Add(this.checkBox_S);
            this.groupBox2.Controls.Add(this.checkBox_X);
            this.groupBox2.Controls.Add(this.checkBox_H);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 212);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cable Variables";
            // 
            // checkBox_T
            // 
            this.checkBox_T.AutoSize = true;
            this.checkBox_T.Location = new System.Drawing.Point(15, 120);
            this.checkBox_T.Name = "checkBox_T";
            this.checkBox_T.Size = new System.Drawing.Size(93, 17);
            this.checkBox_T.TabIndex = 13;
            this.checkBox_T.Text = "T - Total Load";
            this.checkBox_T.UseVisualStyleBackColor = true;
            this.checkBox_T.CheckedChanged += new System.EventHandler(this.checkBox_T_CheckedChanged);
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(242, 183);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(36, 20);
            this.textBox13.TabIndex = 12;
            this.textBox13.Text = " Kg/m";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(262, 120);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(31, 20);
            this.textBox16.TabIndex = 12;
            this.textBox16.Text = "KgF";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(262, 95);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(16, 20);
            this.textBox14.TabIndex = 12;
            this.textBox14.Text = " m";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(262, 70);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(16, 20);
            this.textBox11.TabIndex = 12;
            this.textBox11.Text = " m";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(262, 45);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(16, 20);
            this.textBox10.TabIndex = 12;
            this.textBox10.Text = " m";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(262, 20);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(16, 20);
            this.textBox12.TabIndex = 12;
            this.textBox12.Text = " m";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Enabled = false;
            this.textBox_Y.Location = new System.Drawing.Point(140, 45);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(120, 20);
            this.textBox_Y.TabIndex = 1;
            // 
            // textBoxW
            // 
            this.textBoxW.Enabled = false;
            this.textBoxW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxW.Location = new System.Drawing.Point(100, 183);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(32, 20);
            this.textBoxW.TabIndex = 2;
            this.textBoxW.Text = "W := ";
            // 
            // textBox_W
            // 
            this.textBox_W.Location = new System.Drawing.Point(140, 183);
            this.textBox_W.Name = "textBox_W";
            this.textBox_W.Size = new System.Drawing.Size(84, 20);
            this.textBox_W.TabIndex = 0;
            // 
            // textBox_T
            // 
            this.textBox_T.Enabled = false;
            this.textBox_T.Location = new System.Drawing.Point(140, 120);
            this.textBox_T.Name = "textBox_T";
            this.textBox_T.Size = new System.Drawing.Size(120, 20);
            this.textBox_T.TabIndex = 1;
            // 
            // textBox_X
            // 
            this.textBox_X.Enabled = false;
            this.textBox_X.Location = new System.Drawing.Point(140, 95);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(120, 20);
            this.textBox_X.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clean";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(317, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 111);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(272, 72);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(115, 20);
            this.textBox9.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(145, 72);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(115, 20);
            this.textBox6.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(272, 46);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(115, 20);
            this.textBox8.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(145, 46);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(115, 20);
            this.textBox5.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(272, 20);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(115, 20);
            this.textBox7.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(145, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(115, 20);
            this.textBox4.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cable.Properties.Resources.Capture11;
            this.ClientSize = new System.Drawing.Size(744, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Catenary Solver";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_S;
        private System.Windows.Forms.TextBox textBox_H;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_S;
        private System.Windows.Forms.CheckBox checkBox_Y;
        private System.Windows.Forms.CheckBox checkBox_H;
        private System.Windows.Forms.CheckBox checkBox_X;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.TextBox textBox_W;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox_T;
        private System.Windows.Forms.CheckBox checkBox_T;
    }
}

