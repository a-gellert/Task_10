using System;
using System.Threading;

namespace Timer
{
    //Класс для иммитации часов
    public class Clock
    {
        private void OnTimeIsOver(ClockEventsArgs e)
        {
            TimeIsOver(this, e);
        }

        //Событие выполняется когда заканчивается время
        public event EventHandler<ClockEventsArgs> TimeIsOver = delegate { };

        //Метод начала отсчета, в качестве параметра положительное число(миллисекунды)
        public void Start(int milliseconds)
        {
            if (milliseconds < 0)
            {
                Console.WriteLine("Время не может быть отрицательным!");
            }

            Thread.Sleep(milliseconds);

            OnTimeIsOver(new ClockEventsArgs(milliseconds, "Время вышло!"));
        }
    }
}
