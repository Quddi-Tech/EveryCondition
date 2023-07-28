using System;

namespace Operations
{
    [Serializable]
    public class BoolOrOperation : IBinaryOperation<bool>
    {
        public bool Execute(bool first, bool second)
        {
            return first || second;
        }
    }
}