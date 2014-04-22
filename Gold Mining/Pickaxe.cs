using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Mining
{
    class Pickaxe
    {
        public string title = "Storage Title";
        public double storage = 10;
        public double cost = 0;
        public double consumption = 0;

        public const double maxStorageLevel = 4;

        public Pickaxe(string title, double storage, double cost, double consumption)
        {
            this.title = title;
            this.storage = storage;
            this.cost = cost;
            this.consumption = consumption;
        }

        public static Dictionary<double, Storage> GetStorages()
        {
            Dictionary<double, Storage> storages = new Dictionary<double, Storage>();

            storages.Add(0, new Storage("Zelt", 10, 0, 0));
            storages.Add(1, new Storage("Lagerzelt", 100, 10, 0));
            storages.Add(2, new Storage("Holzhütte", 1000, 100, 0));
            storages.Add(3, new Storage("Holzlager", 10000, 1000, 0));
            storages.Add(4, new Storage("Steinlager", 100000, 10000, 100));

            return storages;
        }


    }


    
}
