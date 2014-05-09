using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Mining
{
    class Pickaxe
    {
        public string title = "Pickaxe Title";
        public double goldPerHit = 1;
        public double diamondChance = 0.01d;
        public double cost = 0;
        public double consumption = 0;
        

        public const double maxPickAxeLevel = 4;

        public Pickaxe(string title, double goldPerHit, double diamondChance, double cost, double consumption)
        {
            this.title = title;
            this.goldPerHit = goldPerHit;
            this.diamondChance = diamondChance;
            this.cost = cost;
            this.consumption = consumption;
        }

        public static Dictionary<double, Pickaxe> GetPickAxes()
        {
            Dictionary<double, Pickaxe> pickAxes = new Dictionary<double, Pickaxe>();

            pickAxes.Add(0, new Pickaxe("Selfmade Wooden Pickaxe", 1, 0.01, 0, 0));
            pickAxes.Add(1, new Pickaxe("Selfmade Stone Pickaxe", 2, 0.02, 10, 0));
            pickAxes.Add(2, new Pickaxe("Pickaxe", 5, 0.03, 100, 0));
            pickAxes.Add(3, new Pickaxe("Improved Pickaxe", 8, 0.04, 1000, 0));
            pickAxes.Add(4, new Pickaxe("Diamond Pickaxe", 15, 0.05, 10000, 0));

            return pickAxes;
        }


    }


    
}
