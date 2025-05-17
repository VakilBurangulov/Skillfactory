using Skillfactory;

namespace  Skillfactory;

class Program
{
    static void Main(string[] args)
    {
        var classes = new []
        {
            new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
            new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
            new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
        };
        var allStudents = GetAllStudents(classes);
         
        Console.WriteLine(string.Join(" ", allStudents));
    }

    static string[] GetAllStudents(Classroom[] classes, bool isSorted = true)
    {
        var allStudents = 
            (from classroom in classes
            from student in classroom.Students
            select student)
            .ToArray();
        
        if (isSorted)
            allStudents = allStudents.OrderBy(student => student).ToArray();
        
        return  allStudents;
    }
}