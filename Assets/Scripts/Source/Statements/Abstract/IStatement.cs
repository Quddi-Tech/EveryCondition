using System;

namespace Statements
{
    public interface IStatement<T> where T : IComparable
    {
        bool IsSatisfying(T first, T second);
    }
}