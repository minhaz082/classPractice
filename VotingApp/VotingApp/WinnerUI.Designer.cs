namespace VotingApp
{
    partial class WinnerUI
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
            this.saveWinnerNoButton = new System.Windows.Forms.Button();
            this.noOfWinnerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveWinnerNoButton
            // 
            this.saveWinnerNoButton.Location = new System.Drawing.Point(188, 82);
            this.saveWinnerNoButton.Name = "saveWinnerNoButton";
            this.saveWinnerNoButton.Size = new System.Drawing.Size(100, 23);
            this.saveWinnerNoButton.TabIndex = 2;
            this.saveWinnerNoButton.Text = "Save";
            this.saveWinnerNoButton.UseVisualStyleBackColor = true;
            // 
            // noOfWinnerTextBox
            // 
            this.noOfWinnerTextBox.Location = new System.Drawing.Point(125, 37);
            this.noOfWinnerTextBox.Name = "noOfWinnerTextBox";
            this.noOfWinnerTextBox.Size = new System.Drawing.Size(163, 20);
            this.noOfWinnerTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter No. of Winner";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveWinnerNoButton);
            this.groupBox1.Controls.Add(this.noOfWinnerTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "No. of Winners of this election";
            // 
            // WinnerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 192);
            this.Controls.Add(this.groupBox1);
            this.Name = "WinnerUI";
            this.Text = "WinnerUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveWinnerNoButton;
        private System.Windows.Forms.TextBox noOfWinnerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}