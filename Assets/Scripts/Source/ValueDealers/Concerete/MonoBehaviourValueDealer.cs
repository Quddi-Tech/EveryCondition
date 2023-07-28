using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ValueDealers
{
    [Serializable]
    public class MonoBehaviourValueDealer<T> : ValueDealer<T> where T : IComparable
    {
        [SerializeField, HorizontalGroup] 
        protected Type _type;
        [Button, HorizontalGroup] 
        protected void ResetType() => _type = null;

        [SerializeField, ShowIf("@this._type != null && this._type.IsSubclassOf(typeof(MonoBehaviour))")] 
        [ValueDropdown("GetCheckableProperties")]
        protected string _propertyName;
        
        [SerializeField] protected GameObject _object;
        
        public override T GetValue()
        {
            return (T)_type?.GetProperty(_propertyName)?.GetValue(_object.GetComponent(_type));
        }
        
        protected IEnumerable<string> GetCheckableProperties()
        {
            if (_type == null) return null;

            return Extensions.GetCheckableProperties(_type, BindingFlags.Public | BindingFlags.Instance)
                .Where(property => property.PropertyType == typeof(T))
                .Select(property => property.Name);
        }
    }
}