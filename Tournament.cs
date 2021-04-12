using System;
using System.IO;

public static class Tournament
{
    public static void Tally(Stream inStream, Stream outStream)
    {
        using (var sr = new StreamReader(inStream))
        {            
            while (sr.EndOfStream)
            {
                string stringLine = sr.ReadLine();
                var match = new Match(stringLine);
            }
        }

        string header = "Team                           | MP |  W |  D |  L |  P";
        using (var sw = new StreamWriter(outStream))
        {
            sw.Write(header);
        }

    }
}
