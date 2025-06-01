public class Point
{
    private int x;
    private int y;

    // Default constructor
    public Point()
    {
        x = 0;
        y = 0;
    }

    // Parametric constructor
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // Property for X
    public int X
    {
        get { return x; }
        set { x = value; }
    }

    // Property for Y
    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    // ShowData method
    public void ShowData()
    {
        Console.WriteLine($"X: {x}, Y: {y}");
    }

}
