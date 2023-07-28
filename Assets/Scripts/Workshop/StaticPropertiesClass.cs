using Attributes;

namespace Workshop
{
    public static class StaticPropertiesClass
    {
        [Checkable] public static int Property1 => 4;
        [Checkable] public static string Property2 => "Value2";
    }
}