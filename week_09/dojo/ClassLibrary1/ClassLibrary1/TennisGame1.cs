namespace Tennis
{
   public  class TennisGame1 : ITennisGame
    {
        private int playerScore = 0;
        private int opponentScore = 0;
        private string player;
        private string opponent;

        public TennisGame1(string player, string opponent)
        {
            this.player = player;
            this.opponent = opponent;
        }
        
        public void AddPoint(string playerName)
        {
            if (playerName == player)
                playerScore += 1;
            else
                opponentScore += 1;
        }

        public string GetScore()
        {
            string score = "";
            var currentScore = 0;
            if (playerScore == opponentScore)
            {
                switch (playerScore)
                {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;

                }
            }
            else if (playerScore >= 4 || opponentScore >= 4)
            {
                var scoreDifference = playerScore - opponentScore;
                if (scoreDifference == 1) score = "Advantage player1";
                else if (scoreDifference == -1) score = "Advantage player2";
                else if (scoreDifference >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) currentScore = playerScore;
                    else { score += "-"; currentScore = opponentScore; }
                    switch (currentScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }
    }
}