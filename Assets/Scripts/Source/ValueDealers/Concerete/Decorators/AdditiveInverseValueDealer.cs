using System;
using UnityEngine;

namespace ValueDealers.Decorators
{
    [Serializable]
    public class IntAdditiveInverseValueDealer : ValueDealer<int>
    {
        [SerializeField] protected ValueDealer<int> _valueDealer;

        public override int GetValue()
        {
            return _valueDealer.GetValue() * -1;
        }
    }
    
    [Serializable]
    public class FloatAdditiveInverseValueDealer : ValueDealer<float>
    {
        [SerializeField] protected ValueDealer<float> _valueDealer;

        public override float GetValue()
        {
            return _valueDealer.GetValue() * -1;
        }
    }
}