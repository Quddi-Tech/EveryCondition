using System;

namespace ValueDealers
{
    public abstract class ValueDealer<T> : IValueDealer where T : IComparable
    {
        public abstract T GetValue();
    }
}