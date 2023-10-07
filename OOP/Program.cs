using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        var messenge = "hello";

        var studentA = new Student();

        //studentA.Age = 1;
        studentA.ShowInfo();

        
    }

    public static void Print(string messenge)
    {
        Console.WriteLine(messenge);
    }

    public class Student
    {
        public static string className = "Student";

        private int age;

        public int Age
        {
            get {
                Console.WriteLine("get");
                return age; 
                }

            set {
                Console.WriteLine("set");
                age = value; 
                }
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Age : {age}");
            var a = Age;
        }
    }
}