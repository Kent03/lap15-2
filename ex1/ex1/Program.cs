using System;

// Shape lớp trừu tượng
//Lê Hoàng Khôi-20mc-20it438
public abstract class Shape
{
    protected int x, y;

    public Shape(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move(int deltaX, int deltaY)
    {
        x += deltaX;
        y += deltaY;
    }

    public abstract void Show();
}

// Line subclass
public class Line : Shape
{
    protected int x2, y2;

    public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
    {
        this.x2 = x2;
        this.y2 = y2;
    }

    public override void Show()
    {
        Console.WriteLine($"Line: ({x},{y}) to ({x2},{y2})");
    }

    public override string ToString()
    {
        return $"Line: ({x},{y}) to ({x2},{y2})";
    }
}

// Circle subclass
public class Circle : Shape
{
    protected int radius;

    public Circle(int x, int y, int radius) : base(x, y)
    {
        this.radius = radius;
    }

    public override void Show()
    {
        Console.WriteLine($"Circle: center ({x},{y}), radius {radius}");
    }

    public override string ToString()
    {
        return $"Circle: center ({x},{y}), radius {radius}";
    }
}

// Rectangle subclass
public class Rectangle : Shape
{
    protected int x2, y2, x3, y3;
    private int v1;
    private int v2;

    public Rectangle(int x, int y, int v1, int v2) : base(x, y)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
    {
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
    }

    public override void Show()
    {
        Console.WriteLine($"Rectangle: ({x},{y}), ({x2},{y2}), ({x3},{y3})");
    }

    public override string ToString()
    {
        return $"Rectangle: ({x},{y}), ({x2},{y2}), ({x3},{y3})";
    }
}

// PolyLine class
public class PolyLine : Shape
{
    private Line[] lines;

    public PolyLine(int x, int y, Line[] lines) : base(x, y)
    {
        this.lines = lines;
    }

    public override void Show()
    {
        Console.Write("PolyLine: ");
        foreach (Line line in lines)
        {
            Console.Write($"{line}, ");
        }
        Console.WriteLine();
    }

    public override string ToString()
    {
        string result = "PolyLine: ";
        foreach (Line line in lines)
        {
            result += $"{line}, ";
        }
        return result;
    }
}

// Testing
class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng line
        Line line = new Line(1, 2, 3, 4);
        Console.WriteLine(line.ToString());

        // Di chuyển đối tượng Line
        line.Move(1, 1);

        // Hiển thị thông tin của đối tượng Line
        line.Show();

        // Tạo một đối tượng Vòng tròn
        Circle circle = new Circle(5, 5, 3);
        Console.WriteLine(circle.ToString());

        // Di chuyển đối tượng Vòng tròn
        circle.Move(-2, 1);

        // Hiển thị thông tin của đối tượng Circle
        circle.Show();

        // Tạo một đối tượng Rectangle
        Rectangle rect = new Rectangle(2, 2, 4, 3);
        Console.WriteLine(rect.ToString());

        // Di chuyển đối tượng Rectangle
        rect.Move(1, -1);

        // Hiển thị thông tin của đối tượng Rectangle
        rect.Show();

        Console.ReadKey();
    }
}
