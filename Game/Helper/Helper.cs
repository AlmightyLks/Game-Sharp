using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Helper
{
    public static class Helper
    {
        /// <summary>
        /// Because for whatever reason, Math.Clamp is not available here in WinForms?
        /// </summary>
        /// <param name="val"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Clamp(this int val, int min, int max)
        {
            if (val > max)
                return max;
            if (val < min)
                return min;
            else
                return val;
        }
    }
}
