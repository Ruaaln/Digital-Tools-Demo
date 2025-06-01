public class Counter
{
    private int min;
    private int max;
    private int current;

    public Counter(int min, int max)
    {
        this.min = min;
        this.max = max;
        this.current = min;
    }

    public void Increment()
    {
        current++;
        if (current > max)
            current = min;
    }

    public int GetCurrent()
    {
        return current;
    }
}
