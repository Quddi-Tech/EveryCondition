using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Sirenix.OdinInspector;
using Unity.VisualScripting;
using UnityEngine;

namespace ValueDealers
{
    [Serializable]
    public class StaticValueDealer<T> : ValueDealer<T> where T : IComparable
    {
        [SerializeField, HorizontalGroup] 
        protected Type _type;
        [Button, HorizontalGroup] 
        protected void ResetType() => _type = null;

        [SerializeField, ShowIf("@this._type != null && IsStatic")] 
        [ValueDropdown("GetCheckableProperties")]
        protected string _propertyName;
        
        protected bool IsStatic => _type.IsStatic();
        
        public override T GetValue()
        {
            return (T)_type?.GetProperty(_propertyName)?.GetValue(null);
        }
        
        protected IEnumerable<string> GetCheckableProperties()
        {
            if (_type == null) return null;
            
            return Extensions.GetCheckableProperties(_type, BindingFlags.Static | BindingFlags.Public)
                .Where(property => property.PropertyType == typeof(T))
                .Select(property => property.Name);
        }
    }
}