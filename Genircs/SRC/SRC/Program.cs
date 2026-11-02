
namespace SRC;

internal class Program
{
    static void Main(string[] args)
    {
        Student student1 = new(1,"Gaser");
        Student student2 = new(2,"Osama");
        Student student3 = new(3,"Adel");
        Student student4 = new(4,"Mahmoud");
        Student student5 = new(5,"Mohamed");

        StudentStore studentStore = new();
        studentStore.ADD(student1);
        studentStore.ADD(student2);
        studentStore.ADD(student3);
        studentStore.ADD(student4);
        studentStore.ADD(student5);

        Course course1 = new(1,"C#",100);
        Course course2 = new(1,"OOP",100);
        Course course3 = new(1,"SQL",200);
        CourseStore courseStore = new();
        courseStore.ADD(course1);
        courseStore.ADD(course2);
        courseStore.ADD(course3);

        Console.WriteLine(studentStore.GetByID(1));
        Student student6 = new(2, "Aser");
        studentStore.ADD(student6);


        // 3. Print page 2 (size 2) of students
        Console.WriteLine("Printing Page 2 (Size 2) of Students:");
        var studentPage2 = studentStore.GetAll().Page(2, 2);
        foreach (var s in studentPage2)
        {
            Console.WriteLine($"Student Id: {s.ID}, Name: {s.Name}");
        }

        // Call FindById on a plain List<Course>
        var plainCourseList = new List<Course>
        {
            new Course(201, "Design Patterns", 400),
            new Course(202, "Clean Architecture", 500)
        };

        var foundCourseInList = plainCourseList.FindById(202);
        Console.WriteLine($"FindById on plain List<Course>: Id = {foundCourseInList?.ID}, Title = {foundCourseInList?.Title}");
        // 4. Commented-out line marked "must NOT compile"
        // var stringStore = new GenricStore<string>(); // must NOT compile

    }



}
