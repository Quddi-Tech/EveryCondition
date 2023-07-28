﻿using System;

namespace Statements
{
    [Serializable]
    public class EqualStatement<T> : IStatement<T> where T : IComparable
    {
        public bool IsSatisfying(T first, T second)
        {
            return first?.CompareTo(second) == 0;
        }
    }
}