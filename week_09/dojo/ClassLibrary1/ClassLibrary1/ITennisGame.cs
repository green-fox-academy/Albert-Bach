namespace Tennis
{   
    public interface ITennisGame
    {
        void AddPoint(string playerName);
        string GetScore();
    }
}