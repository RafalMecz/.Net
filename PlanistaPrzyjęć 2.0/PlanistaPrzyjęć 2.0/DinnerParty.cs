using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanistaPrzyjęć_2._0
{
        class DinnerParty
        {
            public const int CostFoodPerPerson = 25;
            public int NumberOfPeople { get; set; }
            public bool HealthyOption { get; set; }
            public bool FancyOption { get; set; }


            public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyOption)
            {
                NumberOfPeople = numberOfPeople;
                HealthyOption = healthyOption;
                FancyOption = fancyOption;
            }

            private decimal CalculateCostOfDecorations()
            {
                decimal costDecorations;
                if (FancyOption)
                {
                    costDecorations = (NumberOfPeople * 15.00M) + 50M;
                }
                else
                {
                    costDecorations = (NumberOfPeople * 7.50M) + 30M;
                }
                return costDecorations;
            }

            private decimal CalculateCostOfBeveragesPerPerson()
            {
                decimal costOfBeveragesPerPerson;
                if (HealthyOption)
                {
                    costOfBeveragesPerPerson = 5.00M;
                }
                else
                {
                    costOfBeveragesPerPerson = 20.00M;
                }
                return costOfBeveragesPerPerson;
            }

            public decimal Cost
            {
                get
                {
                    decimal totalCost = CalculateCostOfDecorations();
                    totalCost += ((CalculateCostOfBeveragesPerPerson() + CostFoodPerPerson) *
                        NumberOfPeople);
                    if (HealthyOption)
                    {
                        totalCost *= .95M;
                    }
                    return totalCost;
                }
            }




        }
    }

