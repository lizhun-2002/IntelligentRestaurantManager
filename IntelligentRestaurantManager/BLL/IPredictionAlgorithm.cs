using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    interface IPredictionAlgorithm
    {
        int Max_Active_Seat(List<Table> tables, int currID);

        int Max_Active_Cleaning_Seat(List<Table> tables, int currID);

        void PredictWaitingTime(List<Table> ptables, List<Customer> pcustomers);
    }
}
