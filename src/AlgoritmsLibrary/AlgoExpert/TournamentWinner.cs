using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLibrary.AlgoExpert
{

    /// <summary>
    /// 
    /*
     * Competetion = [
                    ["HTML", "C#"],
                    ["C#", "Python"],
                    ["Python", "HTML"],
                    ]
    Format--> [Away,. Home ]
    0 means Home winner, 1 means Away


    result  = [0, 0, 1]

    Means: C# beats HTML
           Python beats C#
           Python Beats HTML
    So Winner is Python
    
    */
    /// </summary>
    public  class TournamentWinnerClass
    {

        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {

            Dictionary<string, int> dicFinal = new Dictionary<string, int>();
            string winner = "";
            int maxVal = 0;
            for (int i = 0; i < competitions.Count(); i++)
            {
                if (!dicFinal.ContainsKey(competitions[i][0]))
                    dicFinal.Add(competitions[i][0], 0);// Home
                if(!dicFinal.ContainsKey(competitions[i][1]))
                    dicFinal.Add(competitions[i][1], 0);// Away

                if (results[i] == 1)
                {
                    dicFinal[competitions[i][0]]++;
                    if (dicFinal[competitions[i][0]] > maxVal)
                    {
                        maxVal = dicFinal[competitions[i][0]];
                        winner= competitions[i][0];
                    }
                   
                }
                else
                {
                    dicFinal[competitions[i][1]]++;
                    if (dicFinal[competitions[i][1]] > maxVal)
                    {
                        maxVal = dicFinal[competitions[i][1]];
                        winner = competitions[i][1];
                    }
                }

                
            }
            // Write your code here.
            return winner;
        }
    }
}
