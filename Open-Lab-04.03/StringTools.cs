﻿using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            original = original[1..^1];
            return "original";
        }
    }
}
