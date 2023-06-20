namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            const double g = 9.81;
            double h, v, t;
            Console.Write("Введите высоту (м): ");

                h = double.Parse(Console.ReadLine());
                v = Math.Sqrt(2 * g * h);
                t = Math.Sqrt(2 * h / g);

            Console.WriteLine("");
            Console.WriteLine("Скорость падения: {0:F1} м/с", v);
            Console.WriteLine("Время падения: {0:F2} сек", t);
        }
    }
}