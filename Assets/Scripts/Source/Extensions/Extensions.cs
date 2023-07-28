using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Attributes;

public static class Extensions
{
    public static IEnumerable<PropertyInfo> GetCheckableProperties(Type type, BindingFlags bindingFlags)
    {
        IEnumerable<PropertyInfo> properties = type
            .GetProperties(bindingFlags)
            .Where(property => property.IsDefined(typeof(Checkable)));
        
        return properties;
    }

}