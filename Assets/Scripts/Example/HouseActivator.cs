using System;
using Conditions;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Example
{
    public class HouseActivator : SerializedMonoBehaviour
    {
        [SerializeField] protected GameObject _house;
        [SerializeField] protected ICondition _condition;

        private void Awake()
        {
            _house.SetActive(false);
        }

        protected void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<PlayerMovement>() != null)
            {
                var conditionResult = _condition.CheckEquality();
                
                if (conditionResult) _house.SetActive(true);
            }
        }
    }
}