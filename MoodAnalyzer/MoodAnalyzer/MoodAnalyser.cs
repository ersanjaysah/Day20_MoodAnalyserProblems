﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalizeMood()
        {
            if (this.message.Contains(" "))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
