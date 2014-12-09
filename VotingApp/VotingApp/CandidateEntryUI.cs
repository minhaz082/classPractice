using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VotingApp
{
    public partial class CandidateEntryUI : Form
    {
        public CandidateEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Candidate aCandidate = new Candidate();
            aCandidate.Name = candidateNameTextBox.Text;
            aCandidate.Symbol = symbolTextBox.Text;

        }
    }
}
