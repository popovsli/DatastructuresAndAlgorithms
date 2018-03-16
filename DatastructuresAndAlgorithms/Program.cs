using System;

namespace DatastructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Base[] shapes = new Base[3];
            shapes[0] = new Base();
            shapes[1] = new A();
            shapes[2] = new Model();

            foreach (var item in shapes)
            {
                item.Write();
            }

            A downCast = (A)shapes[1];

            downCast.Write();
            downCast.WriteA();

            Console.ReadLine();
        }
    }

    public class Base
    {
        public string NameBase { get; set; }

        public virtual void Write()
        {
            Console.WriteLine("Im class Base class");
        }
    }

    public class A : Base
    {
        public string NameA { get; set; }

        public void WriteA()
        {
            Console.WriteLine("Im class A class");
        }

        public new void Write()
        {
            Console.WriteLine("Im new class A class");
        }
    }

    public class Model : Base
    {
        public string NameModel { get; set; }

        public override void Write()
        {
            Console.WriteLine("Im class Model class");
        }
    }
}
