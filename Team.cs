using System;
using System.Collections.Generic;
using System.Text;


class Team
{
    public string Name { get; set; }
    public int MatchesPlayed { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int Draws { get; set; }
    public int Points { get; set; }
    public Team(string name, MatchResult outcome)
    {
        Name = name;
        MatchesPlayed = 1;

        switch (outcome)
        {
            case MatchResult.Win:
                Wins = 1;
                Losses = 0;
                Draws = 0;
                Points = 3;
                break;
            case MatchResult.Loss:
                Wins = 0;
                Losses = 1;
                Draws = 0;
                Points = 0;
                break;
            case MatchResult.Draw:
                Wins = 0;
                Losses = 0;
                Draws = 1;
                Points = 1;
                break;
            
            default:
                break;
        }

        

    }

    public void TeamWins()
    {
        MatchesPlayed += 1;
        Wins += 1;
        Points += 3;
    }

    public void TeamLose()
    {
        MatchesPlayed += 1;
        Losses += 1;
    }

    public void TeamDraw()
    {
        MatchesPlayed += 1;
        Draws += 1;
        Points += 1;
    }

}

