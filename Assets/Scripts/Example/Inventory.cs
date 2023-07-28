using Attributes;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Example
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField, ReadOnly] protected int _applesCount;

        [Checkable] public int ApplesCount => _applesCount;

        [Button]
        protected void AddApple()
        {
            _applesCount++;
        }
    }
}