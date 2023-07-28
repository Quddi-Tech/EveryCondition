using System;
using Operations;
using UnityEngine;

namespace ValueDealers
{
    [Serializable]
    public class OperationValueDealer<T> : ValueDealer<T> where T : IComparable
    {
        [SerializeField] protected ValueDealer<T> _firstValueDealers;
        [SerializeField] protected ValueDealer<T> _secondValueDealers;
        [SerializeField] protected IBinaryOperation<T> _binaryOperation;

        public override T GetValue()
        {
            return _binaryOperation.Execute(_firstValueDealers.GetValue(), _secondValueDealers.GetValue());
        }
    }
}