using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class TournamentTable
{
    public Dictionary<string, Team> teams = new Dictionary<string, Team>(); // cia yra fieldas kuris turi but defainintas nurodant access modifier, type ir name // klases scope gali existuot tik definicjos: metodai, fieldai, properciai
    public void AddingTeams(Match match)
    {
        switch (match.Outcome)
        {
            case MatchResult.Win:
                if (teams.ContainsKey(match.HomeTeam))
                {
                    teams[match.HomeTeam].TeamWins();
                }
                else
                {
                    teams.Add(match.HomeTeam, new Team(match.HomeTeam, MatchResult.Win));
                }
                if (teams.ContainsKey(match.AwayTeam))
                {
                    teams[match.AwayTeam].TeamLose();
                }
                else
                {
                    teams.Add(match.AwayTeam, new Team(match.AwayTeam, MatchResult.Loss));
                }

                break;

            case MatchResult.Loss:
                if (teams.ContainsKey(match.HomeTeam))
                {
                    teams[match.HomeTeam].TeamLose();
                }
                else
                {
                    teams.Add(match.HomeTeam, new Team(match.HomeTeam, MatchResult.Loss));
                }
                if (teams.ContainsKey(match.AwayTeam))
                {
                    teams[match.AwayTeam].TeamWins();
                }
                else
                {
                    teams.Add(match.AwayTeam, new Team(match.AwayTeam, MatchResult.Win));
                }

                break;
            case MatchResult.Draw:
                if (teams.ContainsKey(match.HomeTeam))
                {
                    teams[match.HomeTeam].TeamDraw();
                }
                else
                {
                    teams.Add(match.HomeTeam, new Team(match.HomeTeam, MatchResult.Draw));
                }
                if (teams.ContainsKey(match.AwayTeam))
                {
                    teams[match.AwayTeam].TeamDraw();
                }
                else
                {
                    teams.Add(match.AwayTeam, new Team(match.AwayTeam, MatchResult.Draw));
                }

                break;

            default:
                break;
        }



        //if (teams.ContainsKey(match.HomeTeam) && teams.ContainsKey(match.AwayTeam))
        //{
        //    if (match.Outcome == MatchResult.Win)
        //    {
        //        teams[match.HomeTeam].TeamWins();
        //        teams[match.AwayTeam].TeamLose();
        //    }
        //    else if (match.Outcome == MatchResult.Loss)
        //    {
        //        teams[match.HomeTeam].TeamLose();
        //        teams[match.AwayTeam].TeamWins();
        //    }
        //    else
        //    {
        //        teams[match.HomeTeam].TeamDraw();
        //        teams[match.AwayTeam].TeamDraw();
        //    }

        //}
        //else if (teams.ContainsKey(match.HomeTeam) && !teams.ContainsKey(match.AwayTeam))
        //{
        //    if (match.Outcome == MatchResult.Win)
        //    {
        //        teams[match.HomeTeam].TeamWins();
        //        teams.Add(match.AwayTeam, new Team(match.AwayTeam, MatchResult.Loss));
        //    }
        //    else if (match.Outcome == MatchResult.Loss)
        //    {
        //        teams[match.HomeTeam].TeamLose();
        //        teams.Add(match.AwayTeam, new Team(match.AwayTeam, MatchResult.Win));
        //    }
        //    else
        //    {
        //        teams[match.HomeTeam].TeamDraw();
        //        teams.Add(match.AwayTeam, new Team(match.AwayTeam, MatchResult.Draw));
        //    }
        //}
        //else if (!teams.ContainsKey(match.HomeTeam) && teams.ContainsKey(match.AwayTeam))
        //{
        //    if (match.Outcome == MatchResult.Win)
        //    {
        //        teams[match.AwayTeam].TeamLose();
        //        teams.Add(match.HomeTeam, new Team(match.HomeTeam, MatchResult.Win));
        //    }
        //    else if (match.Outcome == MatchResult.Loss)
        //    {
        //        teams[match.AwayTeam].TeamWins();
        //        teams.Add(match.HomeTeam, new Team(match.HomeTeam, MatchResult.Loss));
        //    }
        //    else
        //    {
        //        teams[match.AwayTeam].TeamDraw();
        //        teams.Add(match.HomeTeam, new Team(match.HomeTeam, MatchResult.Draw));
        //    }
        //}
        //else
        //{
        //    if (match.Outcome == MatchResult.Win)
        //    {
        //        teams.Add(match.HomeTeam, new Team(match.HomeTeam, MatchResult.Win));
        //        teams.Add(match.AwayTeam, new Team(match.AwayTeam, MatchResult.Loss));
        //    }
        //    else if (match.Outcome == MatchResult.Loss)
        //    {
        //        teams.Add(match.HomeTeam, new Team(match.HomeTeam, MatchResult.Loss));
        //        teams.Add(match.AwayTeam, new Team(match.AwayTeam, MatchResult.Win));
        //    }
        //    else
        //    {
        //        teams.Add(match.HomeTeam, new Team(match.HomeTeam, MatchResult.Draw));
        //        teams.Add(match.AwayTeam, new Team(match.AwayTeam, MatchResult.Draw));
        //    }
        //}
    }

    public IEnumerable<Team> ListingTeams()
    {
        return teams.Values.OrderByDescending(tv => tv.Points)
                           .ThenBy(tv => tv.Name);

    }
}

