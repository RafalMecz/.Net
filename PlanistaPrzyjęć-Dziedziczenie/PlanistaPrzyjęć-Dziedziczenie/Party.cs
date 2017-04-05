using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanistaPrzyjęć_Dziedziczenie
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }   

        private decimal CalculateCostOfDecorations()
        {
            decimal costDecorations;
            if (FancyDecorations)
            {
                costDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costDecorations;
        }

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;

                if (NumberOfPeople > 12)
                    totalCost += 100;
                return totalCost;
            }
        }


    }
}
