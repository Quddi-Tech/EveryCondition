using System;

namespace Operations
{
    [Serializable]
    public class IntMinusOperation : IBinaryOperation<int>
    {
        public int Execute(int first, int second)
        {
            return first - second;
        }
    }
    
    [Serializable]
    public class FloatMinusOperation : IBinaryOperation<float>
    {
        public float Execute(float first, float second)
        {
            return first - second;
        }
    }
}