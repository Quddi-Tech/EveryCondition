using System;
using UnityEngine;

namespace ValueDealers
{
    [Serializable]
    public class ConstValueDealer<T> : ValueDealer<T> where T : IComparable
    {
        [SerializeField] protected T _value;
        
        public override T GetValue()
        {
            return _value;
        }
    }
}