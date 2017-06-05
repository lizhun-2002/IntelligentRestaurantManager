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
        void PredictWaitingTime(List<Table> ptables, List<Customer> pcustomers);
    }
}
