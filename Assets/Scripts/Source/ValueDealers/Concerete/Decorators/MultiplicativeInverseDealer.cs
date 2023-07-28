using System;
using UnityEngine;

namespace ValueDealers.Decorators
{
    [Serializable]
    public class FloatMultiplicativeInverseDealer : ValueDealer<float>
    {
        [SerializeField] protected ValueDealer<float> _valueDealer;

        public override float GetValue()
        {
            return 1f / _valueDealer.GetValue();
        }
    }
}