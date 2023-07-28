using System;

namespace Operations
{
    public interface IBinaryOperation<T> where T : IComparable
    {
        T Execute(T first, T second);
    }
}