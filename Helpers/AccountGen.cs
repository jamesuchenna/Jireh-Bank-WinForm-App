using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class AccountGen
    {
        /// <summary>
        /// Method for account number generation
        /// </summary>
        public static string RandomNum(int count)
        {
            var randomNum = new Random();
            string num = "01";
            for (int i = 0; i < count; i++)
                num = String.Concat(num, randomNum.Next(10).ToString());
            return num;
        }
    }
}
