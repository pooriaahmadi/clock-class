namespace clock
{
    class Clock
    {
        private int seconds;
        private int minutes;
        private int hours;
        private int days;
        public int Days {
            get {
                return days;
            }
            set {
                days = value;
            }
        }
        public int Hours {
            get {
                return hours;
            }
            set {
                hours = value % 24;
                Days += (value / 24);
            }
        }
        public int Minutes {
            get {
                return minutes;
            }
            set {
                minutes = value % 60;
                Hours += value / 60;
            }
        }
        public int Seconds {
            get {
                return seconds;
            }
            set {
                seconds = value % 60;
                Minutes += value / 60;
            }
        }
        public Clock(int seconds = 0, int minutes = 0, int hours = 0, int days = 0)
        {
            Days = days;
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public override string ToString()
        {
            return $"{days} Days, {(Hours < 10 ? $"0{Hours}" : Hours)}:{(Minutes < 10 ? $"0{Minutes}": Minutes)}:{(Seconds < 10 ? $"0{Seconds}": Seconds)}";
        }
        public void tick(int jumpSize = 1) {
            Seconds += jumpSize;
        }
    }
}