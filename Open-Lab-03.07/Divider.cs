using System;

namespace Open_Lab_03._07
{
    public class Divider
    {
        public bool EqualSlices(int total, int people, int each)
        {
            int t = people * each;
            if (t > total)
            {
                return false;
            }
            else if (t == total)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
