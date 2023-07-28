using System;

namespace Operations
{
    [Serializable]
    public class BoolAndOperation : IBinaryOperation<bool>
    {
        public bool Execute(bool first, bool second)
        {
            return first && second;
        }
    }
}