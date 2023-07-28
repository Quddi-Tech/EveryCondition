using Attributes;
using UnityEngine;

namespace Workshop
{
    public class MonoBehaviourPropertiesClass : MonoBehaviour
    {
        [Checkable] [field: SerializeField] public int MyProperty { get; set; }
        [Checkable] public string AnotherProperty { get; set; }
    }
}