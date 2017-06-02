using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentRestaurantManager.Model
{
    class Reservation
    {
        public int id;
        public int tableId;
        public int year;
        public int month;
        public int day;
        public int hour;
        public int number;
        public string name;

        

        public int getId()
        {
            return id;
        }
        public int getTableId()
        {
            return tableId;
        }
        public int getYear()
        {
            return year;
        }
        public int getMonth()
        {
            return month;
        }
        public int getDay()
        {
            return day;
        }
        public int getHour()
        {
            return hour;
        }
        public int getNumber()
        {
            return number;
        }
        public string getName()
        {
            return name;
        }
    }
}
