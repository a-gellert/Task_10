using System;

namespace Timer
{
    public class ClockListener
    {
        public void Register(Clock clock)
        {
            clock.TimeIsOver += TimeEvent;
        }

        public void Unregister(Clock clock)
        {
            clock.TimeIsOver -= TimeEvent;
        }

        private void TimeEvent(object sender, ClockEventsArgs watchEventsArgs)
        {
            Console.WriteLine($"Сообщение от ClockListener: {watchEventsArgs}");
        }
    }
}
