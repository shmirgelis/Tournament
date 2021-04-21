using System;
using System.IO;

public static class Tournament
{
    public static void Tally(Stream inStream, Stream outStream)
    {
        var tournamentTable = new TournamentTable();
        using (var sr = new StreamReader(inStream))
        {

            while (!sr.EndOfStream)
            {
                string stringLine = sr.ReadLine();
                var match = new Match(stringLine);
                tournamentTable.AddingTeams(match);
            }
        }

        string header = "Team                           | MP |  W |  D |  L |  P";

        using (var sw = new StreamWriter(outStream))
        {
            sw.Write(header);
            foreach (var item in tournamentTable.ListingTeams())
            {
                string teamStats = $"{item.Name,-30} | {item.MatchesPlayed,2} | {item.Wins,2} | {item.Draws,2} | {item.Losses,2} | {item.Points,2}";
                sw.Write("\n");
                sw.Write(teamStats);
            }
        }


    }
}
