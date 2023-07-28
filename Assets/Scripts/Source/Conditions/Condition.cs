using System;
using Sirenix.OdinInspector;
using Statements;
using UnityEngine;
using ValueDealers;

namespace Conditions
{
    [Serializable]
    public abstract class Condition<T> : ICondition where T : IComparable
    {
        [SerializeField, GUIColor(1f, 0.61f, 0.53f)] protected ValueDealer<T> _firstValueDealer;
        [SerializeField, GUIColor(0.53f, 1f, 0.61f)] protected IStatement<T> _statement;
        [SerializeField, GUIColor(0.61f, 0.53f, 1f)] protected ValueDealer<T> _secondValueDealer;

        [Button]
        public virtual bool CheckEquality()
        {
            var firstValue = _firstValueDealer.GetValue();
            var secondValue = _secondValueDealer.GetValue();

            return _statement.IsSatisfying(firstValue, secondValue);
        }
    }
}