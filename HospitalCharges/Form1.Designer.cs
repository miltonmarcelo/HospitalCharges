namespace HospitalCharges
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfDaystextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.medicationTextBox = new System.Windows.Forms.TextBox();
            this.surgicalTextBox = new System.Windows.Forms.TextBox();
            this.labFeesTextBox = new System.Windows.Forms.TextBox();
            this.physicalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Days";
            // 
            // numberOfDaystextBox
            // 
            this.numberOfDaystextBox.Location = new System.Drawing.Point(665, 173);
            this.numberOfDaystextBox.Name = "numberOfDaystextBox";
            this.numberOfDaystextBox.Size = new System.Drawing.Size(100, 31);
            this.numberOfDaystextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medication Charges";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surgical Charges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lab Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Physical Rehabilitation Charges";
            // 
            // medicationTextBox
            // 
            this.medicationTextBox.Location = new System.Drawing.Point(665, 244);
            this.medicationTextBox.Name = "medicationTextBox";
            this.medicationTextBox.Size = new System.Drawing.Size(100, 31);
            this.medicationTextBox.TabIndex = 6;
            // 
            // surgicalTextBox
            // 
            this.surgicalTextBox.Location = new System.Drawing.Point(665, 315);
            this.surgicalTextBox.Name = "surgicalTextBox";
            this.surgicalTextBox.Size = new System.Drawing.Size(100, 31);
            this.surgicalTextBox.TabIndex = 7;
            // 
            // labFeesTextBox
            // 
            this.labFeesTextBox.Location = new System.Drawing.Point(665, 386);
            this.labFeesTextBox.Name = "labFeesTextBox";
            this.labFeesTextBox.Size = new System.Drawing.Size(100, 31);
            this.labFeesTextBox.TabIndex = 8;
            // 
            // physicalTextBox
            // 
            this.physicalTextBox.Location = new System.Drawing.Point(665, 457);
            this.physicalTextBox.Name = "physicalTextBox";
            this.physicalTextBox.Size = new System.Drawing.Size(100, 31);
            this.physicalTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(584, 557);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(279, 66);
            this.outputLabel.TabIndex = 11;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(405, 732);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(182, 52);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(665, 732);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 52);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(145, 732);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(182, 52);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 900);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.physicalTextBox);
            this.Controls.Add(this.labFeesTextBox);
            this.Controls.Add(this.surgicalTextBox);
            this.Controls.Add(this.medicationTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberOfDaystextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfDaystextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox medicationTextBox;
        private System.Windows.Forms.TextBox surgicalTextBox;
        private System.Windows.Forms.TextBox labFeesTextBox;
        private System.Windows.Forms.TextBox physicalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

