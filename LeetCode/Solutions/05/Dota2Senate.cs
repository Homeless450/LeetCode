﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class Dota2Senate
    {
        public string PredictPartyVictory(string senate)
        {
            int counter = 0;
            char[] arr = senate.ToArray();

            
            while (arr.Contains('D') && arr.Contains('R'))
            {
                for (int i=0; i<arr.Length; i++)
                {
                    if (arr[i] == 'D' && counter >= 0)
                    {
                        counter++;
                    }
                    else if (arr[i] == 'D' && counter < 0)
                    {
                        arr[i] = ' ';
                        counter++;
                    }
                    else if (arr[i] == 'R' && counter > 0)
                    {
                        arr[i] = ' ';
                        counter--;
                    }
                    else if (arr[i] == 'R' && counter <= 0)
                    {
                        counter--;
                    }
                }
            }

            if (arr.Contains('R'))
            {
                return "Radiant";
            }
            else
            {
                return "Dire";
            }
        }
    }
}
