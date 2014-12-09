using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VotingApp.DAL.Gateway;

namespace VotingApp.BLL
{
    class VotingBll
    {
        //private VotingGateway aVotingGateway = new VotingGateway();
        CandidateGateway aCandidateGateway = new CandidateGateway();
        VoterGateway aVoterGAteway = new VoterGateway();

        public string SaveCandidateInfo(Candidate aCandidate)
        {
            if (aCandidate.Name == string.Empty || aCandidate.Symbol== string.Empty)
            {
                return "Fil up all Fields before Saving";
            }
            else
            {
                if (IsSmbolUnique(aCandidate.Symbol))
                {
                    return "Symbol already Exist";
                }
                    //aVotingGateway.SaveCandidate(aCandidate);
                    aCandidateGateway.SaveCandidate(aCandidate);
                    return "Candidate info saved";
            }

        }

        private bool IsSmbolUnique(string symbol)
        {
            //return aVotingGateway.HasThisSymbol(symbol);
            return aCandidateGateway.HasThisSymbol(symbol);
        }

        public List<Candidate> GetAllSymbol()
        {
            //return aVotingGateway.GetAllShop();
            return aCandidateGateway.GetAllSymbols();
        }

        public string CastVote(VoteCast aVoteCast)
        {
            if (aVoteCast.VoterID == null || aVoteCast .CandidateID == null )
            {
                return "Fill up the fields";
            }
            else
            {
                if (HasThisEmailValid(aVoteCast.Email))
                {
                    
                    aVoterGAteway.CastVote(aVoteCast);
                    return "Vote Casted";
                }
                return "Email not Exist";
            }
        }

        private bool HasThisEmailValid(string email)
        {
            return aVoterGAteway.HasThisEmail(email);
        }
    }
}
