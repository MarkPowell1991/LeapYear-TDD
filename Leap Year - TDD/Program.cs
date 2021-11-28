

namespace Leap_Year___TDD
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }



    public class Year
    {

        private int _year { get; }

        public Year(int year)
        {
            _year = year;
        }


        public bool IsLeapYear()
        {

            if (IsDivisibleBy(100))
            {
                //a year is a leap year if divisable by 400
                if (IsDivisibleBy(400))
                {
                    return true;
                }
                //a year is NOT a leap year if divisable by 100 but not by 400
                return false;
            }
            //a year is a leap year if divisable by 4
            if (IsDivisibleBy(4))
            {
                return true;
            }
            //a year is NOT a leap year if not divisable by 4
            return false;

        }

        //A Method created to minimise code which would be duplicated multiple times.
        private bool IsDivisibleBy(int value)
        {
            return _year % value == 0;
        }

    }


}
