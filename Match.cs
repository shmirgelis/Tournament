using System;
using System.Collections.Generic;
using System.Text;
class Match
{
    public string HomeTeam { get; set; }
    public string AwayTeam { get; set; }
    public MatchResult Outcome { get; set; }

    public Match(string match)
    {
        string[] splitStrings = match.Split(';');
        HomeTeam = splitStrings[0];
        AwayTeam = splitStrings[1];
        switch (splitStrings[2])
        {
            case "win":
                Outcome = MatchResult.Win;
                break;
            case "loss":
                Outcome = MatchResult.Loss;
                break;
            case "draw":
                Outcome = MatchResult.Draw;
                break;
            default:
                throw new ArgumentException("Contact admin");
        }
    }
}

