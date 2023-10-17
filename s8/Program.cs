    
public class s6
{
    public static void Main(string[] age)
    {
        a a1 = new a();
        a1.Foo();

        Document document = new Document();

        document.bb();
        document.IStorable();

    }

    public abstract class b
    {
        public abstract void Foo();
    }

    public class a : b
    {
        public override void Foo()
        {
            Console.WriteLine("asdsad");
        }
    }

    public interface IStorable
    {
        void Foo();
        
    }

     public interface bb
    {
        void Foo();
    }

    public class Document : IStorable,bb
    {
        void bb.Foo()
        {
            Console.WriteLine("aaaaa");
        }

        void IStorable.Foo()
        {
            Console.WriteLine("bbbbbbb");
        }

        public void bb()
        {
            bb bb1 = this;
            bb1.Foo();
        }

        public void IStorable()
        {
            IStorable Is = this;
            Is.Foo();
        }
    }

}