using System;

namespace Timer
{
    public class ClockEventsArgs : EventArgs
    {
        private int _milliseconds;
        private string _message;


        public ClockEventsArgs(int interval)
        {
            _milliseconds = interval;
            _message = string.Empty;
        }

        public ClockEventsArgs(int interval, string msg)
        {
            _milliseconds = interval;
            _message = msg;
        }
        public override string ToString()
        {
            return $" {_message}, {_milliseconds} мс";
        }
    }
}
