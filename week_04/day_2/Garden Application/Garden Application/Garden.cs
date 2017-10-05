using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Garden
    {
        List<Plant> plants = new List<Plant>();
        
        public void Add(Plant plant)
        {
            plants.Add(plant);
        }
    }
}
