using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VotingApp.BLL;
using VotingApp.DAL.DAO;

namespace VotingApp
{
    public partial class VoteCastingUI : Form
    {
        public VoteCastingUI()
        {
            InitializeComponent();
            LoadDropDown();
        }

        private VotingBll aVotingBll = new VotingBll();
        private VoteCast aVoteCast = new VoteCast();
        private void LoadDropDown()
        {
            List<Candidate> symbolList = aVotingBll.GetAllSymbol();
            foreach (var shop in symbolList)
            {
                symbolComboBox.Items.Add(shop);
            }
            symbolComboBox.DisplayMember = "Symbol";
            symbolComboBox.ValueMember = "C_ID";
        }

        private Voter aVoter = new Voter();
        private Candidate aCandidate = new Candidate();

        private void voteCastButton_Click(object sender, EventArgs e)
        {
            aVoteCast.CandidateID = symbolComboBox.SelectedIndex;
            aVoteCast.Email = emailTextBox.Text;
            aVoteCast.Symbol = symbolComboBox.SelectedItem.ToString();
            //aVoteCast.VoterID = 
             
            
            //aVoter.Email = emailTextBox.Text;
            //aCandidate.Symbol = symbolComboBox.SelectedItem.ToString();
            string msg = aVotingBll.CastVote(aVoteCast);
            MessageBox.Show(msg);

        }
    }
}
