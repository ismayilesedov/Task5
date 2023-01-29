namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var r=new Duzbucaqli(20,30);
            Console.WriteLine(r);
            var y = new Romb(5, 40);
            Console.WriteLine(y);
            var x = new Kvadrat(6);
            Console.WriteLine(x);
            var o = new Trapesiya(4, 10, 5, 4);
            Console.WriteLine(o);

        }
    }
}