using System;
using UnityEngine;

namespace ValueDealers.Decorators
{
    [Serializable]
    public class IntAbsValueDealer : ValueDealer<int>
    {
        [SerializeField] protected ValueDealer<int> _valueDealer;

        public override int GetValue()
        {
            return Mathf.Abs(_valueDealer.GetValue());
        }
    }
    
    [Serializable]
    public class FloatAbsValueDealer : ValueDealer<float>
    {
        [SerializeField] protected ValueDealer<float> _valueDealer;

        public override float GetValue()
        {
            return Mathf.Abs(_valueDealer.GetValue());
        }
    }
}