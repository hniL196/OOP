using s6;
using System.Threading.Channels;

namespace a

{
    public class s6
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Display(student1);   
           
            Student student1b = new Student(2, "linh");
            student1b.Display(student1b);

            Student student2 = new Student();
            student2.Show(34, "2");

            Class1 class1a = new Class1();
            Class1 class1b = new Class1();

            Class1.Sum(6);           
            Class1.Sum(4, 7);

            class1a.Add(5.1, 4.6);
            class1a.Add(6, 8);

            Console.WriteLine($"{Class1.Sum(6)}");
            Console.WriteLine($"{Class1.Sum(6,8)}");
            Console.WriteLine($"{class1a.Add(8,8)}");
            Console.WriteLine($"{class1a.Add(5.5,5.8)}");

            Console.WriteLine($"{class1b.Add(4,6)}");
        }

        public class Student
        {
            public int id;
            public string name {  get; set; }

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public void Show(int id, string name)
            {
                Console.WriteLine($"{id},{name}");
            }

            public Student()
            {
                id = 10;
                name = "Linh";
            }

            public Student(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public void Display(Student student)
            {
                Console.WriteLine($"{id},{name}");
            }
        }   
    }
}