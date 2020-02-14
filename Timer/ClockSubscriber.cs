using System;

namespace Timer
{
    //Один из классов слушателей
    public class ClockSubscriber
    {
        //Регистрация на событие
        public void Register(Clock clock)
        {
            clock.TimeIsOver += TimeEvent;
        }
        //Отписка от события
        public void Unregister(Clock clock)
        {
            clock.TimeIsOver -= TimeEvent;
        }

        private void TimeEvent(object sender, ClockEventsArgs watchEventsArgs)
        {
            Console.WriteLine($"Сообщение от ClockSubscriber: {watchEventsArgs} ");
        }
    }
}
