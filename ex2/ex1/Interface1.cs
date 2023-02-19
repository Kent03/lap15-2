using System;
using System.Collections.Generic;
using System.Text;

internal class Program
{
    //Để kiểm tra các lớp này,
    //bạn có thể tạo các đối tượng của các lớp dẫn xuất
    //và gọi các phương thức của chúng:
    private static void Main(string[] args)
    {
        Dog myDog = new Dog(name: "Fido", "Spaniel");
        Console.WriteLine(myDog.MakeSound());
        Console.WriteLine(myDog.GetInfo());

        Cat myCat = new Cat("Whiskers");
        Console.WriteLine(myCat.MakeSound());
        Console.WriteLine(myCat.GetInfo());
        myCat.Climb("a tree");

        Duck myDuck = new Duck("Donald");
        Console.WriteLine(myDuck.MakeSound());
        Console.WriteLine(myDuck.GetInfo());
        myDuck.Swim("a pond");
    }
}


