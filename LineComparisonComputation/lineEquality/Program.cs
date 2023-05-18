using System;

public class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Point other = (Point)obj;
        return X == other.X && Y == other.Y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}

class Program
{
    static void Main()
    {
        Point startPoint1 = new Point(0, 0);
        Point endPoint1 = new Point(1, 1);

        Point startPoint2 = new Point(0, 0);
        Point endPoint2 = new Point(1, 1);

        if (startPoint1.Equals(startPoint2) && endPoint1.Equals(endPoint2))
        {
            Console.WriteLine("The lines are equal.");
        }
        else
        {
            Console.WriteLine("The lines are not equal.");
        }
    }
}
