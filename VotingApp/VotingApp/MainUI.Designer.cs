namespace VotingApp
{
    partial class MainUI
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
            this.candidateEntryButton = new System.Windows.Forms.Button();
            this.voteCastButton = new System.Windows.Forms.Button();
            this.winnerEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // candidateEntryButton
            // 
            this.candidateEntryButton.Location = new System.Drawing.Point(61, 33);
            this.candidateEntryButton.Name = "candidateEntryButton";
            this.candidateEntryButton.Size = new System.Drawing.Size(151, 36);
            this.candidateEntryButton.TabIndex = 0;
            this.candidateEntryButton.Text = "Candidate Entry";
            this.candidateEntryButton.UseVisualStyleBackColor = true;
            this.candidateEntryButton.Click += new System.EventHandler(this.candidateEntryButton_Click);
            // 
            // voteCastButton
            // 
            this.voteCastButton.Location = new System.Drawing.Point(61, 156);
            this.voteCastButton.Name = "voteCastButton";
            this.voteCastButton.Size = new System.Drawing.Size(151, 36);
            this.voteCastButton.TabIndex = 0;
            this.voteCastButton.Text = "Vote Cast";
            this.voteCastButton.UseVisualStyleBackColor = true;
            this.voteCastButton.Click += new System.EventHandler(this.voteCastButton_Click);
            // 
            // winnerEntryButton
            // 
            this.winnerEntryButton.Location = new System.Drawing.Point(61, 94);
            this.winnerEntryButton.Name = "winnerEntryButton";
            this.winnerEntryButton.Size = new System.Drawing.Size(151, 36);
            this.winnerEntryButton.TabIndex = 0;
            this.winnerEntryButton.Text = "Winner Entry";
            this.winnerEntryButton.UseVisualStyleBackColor = true;
            this.winnerEntryButton.Click += new System.EventHandler(this.winnerEntryButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 243);
            this.Controls.Add(this.winnerEntryButton);
            this.Controls.Add(this.voteCastButton);
            this.Controls.Add(this.candidateEntryButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button candidateEntryButton;
        private System.Windows.Forms.Button voteCastButton;
        private System.Windows.Forms.Button winnerEntryButton;
    }
}