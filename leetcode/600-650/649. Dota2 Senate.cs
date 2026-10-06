namespace leetcode;

using System.Collections.Generic;

public class Solution649 {
    public string PredictPartyVictory(string senate) {
        
        var unbanned = new Queue<char>(senate); 

        int cntR = 0, cntD = 0;

        while(true)
        {
            for (int i = 0; i < unbanned.Count; i++)
            {
                var e = unbanned.Dequeue();
                if (e == 'R')
                {
                    if (cntD == 0) 
                    {
                        cntR++;
                        unbanned.Enqueue(e);
                    }
                    else
                    {
                        cntD--;
                    }
                        
                }
                if (e == 'D')
                {
                    if (cntR == 0) 
                    {
                        cntD++;
                        unbanned.Enqueue(e);
                    }
                    else
                    {
                        cntR--;
                    }
                }
            }


            if (cntR >= unbanned.Count)
            {
                return "Radiant";
            } 
            if (cntD >= unbanned.Count)
            {
                return "Dire";
            }
        }        

        return "none";
    }
}