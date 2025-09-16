using System;

class Class1
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(1, "qwe");
        students.Add(2, "fhs");

        foreach (var student in students)
        {
            console.WriteLine($"{student.key},{student.value}");
        }
    }
}
