using System;

namespace Operations
{
    [Serializable]
    public class FloatDivideOperation : IBinaryOperation<float>
    {
        public float Execute(float first, float second)
        {
            return first / second;
        }
    }
}