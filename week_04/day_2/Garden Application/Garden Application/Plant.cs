using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Plant
    {
        public string color;
        public int waterNeeds;
        public double absorbing;
        public double waterAmmount;

        public bool IsItThirsty()
        {
            return waterAmmount < waterNeeds;

            if (waterNeeds < waterAmmount)
            {
                return false;
            }
            else
            {
                return true;
            }            
        }
    }

}
