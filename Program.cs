namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);  //radien på första cirkeln är 5
            Console.WriteLine("Arean på första cirkeln är: "+circle.getArea());  //kallar på metoden från Circle klassen

            Circle circle2 = new Circle(6);  //radien på andra cirkeln är 6
            Console.WriteLine("Arean på andra cirkeln är: "+circle2.getArea());  //kallar på metoden från Circle klassen
        }
    }
}