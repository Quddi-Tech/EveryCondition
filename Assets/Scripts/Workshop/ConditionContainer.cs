using Conditions;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Workshop
{
    public class ConditionContainer : SerializedMonoBehaviour
    {
        [SerializeField] private ICondition _condition;
    }
}