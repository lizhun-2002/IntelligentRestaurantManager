using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentRestaurantManager.Common
{
    class DataValidity
    {
        /// <summary>
        /// Determine if input is a number
        /// </summary>
        /// <param name="strInput"></param>
        public static bool IsOnlyNumber(string strInput)
        {
            System.Text.RegularExpressions.Match matchResult = null;
            matchResult = System.Text.RegularExpressions.Regex.Match(strInput, "^[0-9]+$");
            if (matchResult.Success)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determine if input is a positive number
        /// </summary>
        /// <param name="strInput"></param>
        public static bool IsPositiveNumber(string strInput)
        {
            System.Text.RegularExpressions.Match matchResult = null;
            matchResult = System.Text.RegularExpressions.Regex.Match(strInput, @"^[1-9]\d*$");
            if (matchResult.Success)
            {
                return true;
            }
            return false;
        }
    }
}
