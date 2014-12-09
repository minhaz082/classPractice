namespace VotingApp
{
    partial class VoteCastingUI
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
            this.voteCastButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.symbolComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voteCastButton
            // 
            this.voteCastButton.Location = new System.Drawing.Point(276, 133);
            this.voteCastButton.Name = "voteCastButton";
            this.voteCastButton.Size = new System.Drawing.Size(100, 23);
            this.voteCastButton.TabIndex = 2;
            this.voteCastButton.Text = "Cast";
            this.voteCastButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Candidate Symbol";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.symbolComboBox);
            this.groupBox1.Controls.Add(this.voteCastButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cast Your Vote";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(160, 39);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(217, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voter\'s Email Address";
            // 
            // symbolComboBox
            // 
            this.symbolComboBox.FormattingEnabled = true;
            this.symbolComboBox.Location = new System.Drawing.Point(160, 83);
            this.symbolComboBox.Name = "symbolComboBox";
            this.symbolComboBox.Size = new System.Drawing.Size(217, 21);
            this.symbolComboBox.TabIndex = 3;
            // 
            // VoteCastingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 246);
            this.Controls.Add(this.groupBox1);
            this.Name = "VoteCastingUI";
            this.Text = "VoteCastingUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button voteCastButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox symbolComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
    }
}