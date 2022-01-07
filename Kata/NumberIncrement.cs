namespace Kata;

class NumberIncrement
{
    public NumberIncrement(int increment, string incrementChar, int ?upperLimit, string upperLimitChar)
    {
        UpperLimitChar = upperLimitChar;
        UpperLimit = upperLimit;
        IncrementChar = incrementChar;
        Increment = increment;
    }

    public int Increment { get; }
    public string IncrementChar { get; }
    public int ?UpperLimit { get; }
    public string UpperLimitChar { get; }
}