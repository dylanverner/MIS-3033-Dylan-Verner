using System;

namespace Review_CkassesFilesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.height = 10;
            rect1.width = 20;

            Console.WriteLine($"the are of rect1 is {rect1.area()}");


            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles.add(rect1);
            rectangles.add(rect2);

            rectangles.Add(new Rectangle(7, 7));

            foreach (var rect in Rectangle)
            {
                Console.WriteLine()
            }
        }
    }
}
