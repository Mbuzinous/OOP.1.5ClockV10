namespace ClockV10
{
    public class Clock
    {
        #region Instance fields
        private int _hour;
        private int _minute;
        #endregion

        #region Constructor

        public Clock(int hour, int minute)
        {
            _hour = hour;
            _minute = minute;
        }
        #endregion

        #region Properties
        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                _hour = value; 
            } 

        }
        public int Minute
        {
            get
            {
                return _minute;

            }
            set
            {
                _minute = value;

            }

        }
        #endregion 

        #region Method

        public bool Over60Minutes()
        {
            bool isValid = _minute > 60;
            return isValid;
        }

        public void Tick()
        {
            Minute = _minute + 1;
        }

        #endregion

        #region To String

        public override string ToString()
        {
            return $"{Hour}:{Minute}";
        }
        #endregion
    }
}