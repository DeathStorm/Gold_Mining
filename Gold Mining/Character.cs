using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Mining
{
    class Character
    {
        public enum SKILLS { Mining, Building };
        public enum PERKS { Miner };

        public String name;

        public double level = 1;
        public double XP = 0;
        public double gold = 0;
        public double power = 0;
        public double diamonds = 0;

        public int pickAxe = 0;
        public int storage = 0;

        public int skillPoints = 0;
        public int perkPoints = 0;

        public Dictionary<SKILLS, int> skills = new Dictionary<SKILLS, int>();
        public List<PERKS> perks = new List<PERKS>();

        public Character(String name)
        {
            this.name = name;
            Console.WriteLine("Skillanzahl = " + Enum.GetNames(typeof(SKILLS)).Length);
            for (int i = 0; i< Enum.GetNames(typeof(SKILLS)).Length;i++){skills.Add((SKILLS)i, 0);}


        }
    }


}
