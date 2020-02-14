using System;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ClockListener listener = new ClockListener();
                ClockSubscriber subscriber = new ClockSubscriber();

                Clock clock = new Clock();

                subscriber.Register(clock);
                listener.Register(clock);

                Console.WriteLine("Введите время в миллисекундах: ");

                if (int.TryParse(Console.ReadLine(), out int time))
                {
                    Console.WriteLine("Запуск таймера");
                    clock.Start(time);
                }
                else
                {
                    Console.WriteLine("Время введено неверно!");
                }
            }
        }
    }
}
