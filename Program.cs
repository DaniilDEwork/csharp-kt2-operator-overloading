using System;

class MyArr
{
    public int x, y, z;

    public MyArr(int x = 0, int y = 0, int z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static bool operator ==(MyArr obj1, MyArr obj2)
    {
        if (ReferenceEquals(obj1, obj2))
            return true;

        if ((object)obj1 == null || (object)obj2 == null)
            return false;

        if ((obj1.x == obj2.x) && (obj1.y == obj2.y) && (obj1.z == obj2.z))
            return true;

        return false;
    }

    public static bool operator !=(MyArr obj1, MyArr obj2)
    {
        return !(obj1 == obj2);
    }

    public override bool Equals(object obj)
    {
        MyArr other = obj as MyArr;

        if (other == null)
            return false;

        return x == other.x && y == other.y && z == other.z;
    }

    public override int GetHashCode()
    {
        return x + y + z;
    }
}

class MyArrTF
{
    public int x, y, z;

    public MyArrTF(int x = 0, int y = 0, int z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static bool operator true(MyArrTF obj)
    {
        if ((obj.x > 0) && (obj.y > 0) && (obj.z > 0))
            return true;

        return false;
    }

    public static bool operator false(MyArrTF obj)
    {
        if ((obj.x <= 0) || (obj.y <= 0) || (obj.z <= 0))
            return true;

        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyArr myObject1 = new MyArr(x: 4, y: 12, z: 5);
        MyArr myObject2 = new MyArr(x: 4, y: 12, z: 5);
        MyArr myObject3 = new MyArr(x: 1, y: 2, z: 3);

        if (myObject1 == myObject2)
            Console.WriteLine("Объекты равны");

        if (myObject1 != myObject3)
            Console.WriteLine("Объекты не равны");

        MyArrTF myObject4 = new MyArrTF(x: 4, y: 12, z: 5);
        MyArrTF myObject5 = new MyArrTF(x: -1, y: 12, z: 5);

        if (myObject4)
            Console.WriteLine("Все координаты объекта myObject4 положительны");

        if (myObject5)
            Console.WriteLine("Все координаты объекта myObject5 положительны");
        else
            Console.WriteLine("Не все координаты объекта myObject5 положительны");

        Console.ReadLine();
    }
}