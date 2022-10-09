namespace BMIcalcform
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
            this.label1 = new System.Windows.Forms.Label();
            this.radImperial = new System.Windows.Forms.RadioButton();
            this.radmetric = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI CALCULATOR";
            // 
            // radImperial
            // 
            this.radImperial.AutoSize = true;
            this.radImperial.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radImperial.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radImperial.Location = new System.Drawing.Point(37, 80);
            this.radImperial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radImperial.Name = "radImperial";
            this.radImperial.Size = new System.Drawing.Size(69, 18);
            this.radImperial.TabIndex = 1;
            this.radImperial.Text = "Imperial";
            this.radImperial.UseVisualStyleBackColor = true;
            this.radImperial.CheckedChanged += new System.EventHandler(this.radImperial_CheckedChanged);
            // 
            // radmetric
            // 
            this.radmetric.AutoSize = true;
            this.radmetric.Checked = true;
            this.radmetric.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radmetric.Location = new System.Drawing.Point(177, 80);
            this.radmetric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radmetric.Name = "radmetric";
            this.radmetric.Size = new System.Drawing.Size(60, 18);
            this.radmetric.TabIndex = 1;
            this.radmetric.TabStop = true;
            this.radmetric.Text = "Metric";
            this.radmetric.UseVisualStyleBackColor = true;
            this.radmetric.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Weight";
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.height.Location = new System.Drawing.Point(127, 161);
            this.height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(110, 25);
            this.height.TabIndex = 3;
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weight.Location = new System.Drawing.Point(127, 195);
            this.weight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(110, 25);
            this.weight.TabIndex = 4;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblinfo.ForeColor = System.Drawing.Color.Red;
            this.lblinfo.Location = new System.Drawing.Point(49, 114);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(167, 14);
            this.lblinfo.TabIndex = 5;
            this.lblinfo.Text = "The weight in KG and height M";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalc.Location = new System.Drawing.Point(86, 239);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(108, 22);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "GET BMI";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbldisplay
            // 
            this.lbldisplay.BackColor = System.Drawing.SystemColors.Info;
            this.lbldisplay.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldisplay.Location = new System.Drawing.Point(37, 278);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(197, 34);
            this.lbldisplay.TabIndex = 7;
            this.lbldisplay.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 338);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radmetric);
            this.Controls.Add(this.radImperial);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BMI Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radImperial;
        private System.Windows.Forms.RadioButton radmetric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lbldisplay;
    }
}

