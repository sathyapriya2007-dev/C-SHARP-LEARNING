using System;


class Program
{

    public static void Main()
    {
        //String name = "sathya";
        //long ph_no = 6384176558;

        // Console.Write(name);
        //  Console.WriteLine(ph_no);

        Student obj1 = new Student();
        obj1.stu_detail();
    }
}

class Student
{
    public string name = "sat";
    public long ph_no = 3456789065;

    public string dept = "ai";
    public void stu_detail()
    {
        Console.WriteLine(name);
        Console.WriteLine(ph_no);
        Console.WriteLine(dept);
    }
}