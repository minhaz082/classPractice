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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void candidateEntryButton_Click(object sender, EventArgs e)
        {
            CandidateEntryUI anCandidateEntry = new CandidateEntryUI();
            anCandidateEntry.ShowDialog();
        }

        private void winnerEntryButton_Click(object sender, EventArgs e)
        {
            WinnerUI aWinnerUI = new WinnerUI();
            aWinnerUI.ShowDialog();
        }

        private void voteCastButton_Click(object sender, EventArgs e)
        {
            VoteCastingUI aVoteCastingUI = new VoteCastingUI();
            aVoteCastingUI.ShowDialog();
        }
    }
}
