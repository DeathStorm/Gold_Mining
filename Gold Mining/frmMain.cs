using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CT_Additions;

namespace Gold_Mining
{
    public partial class frmMain : Form
    {

        
        private double storage = 10;
        private double consumption = 0;

        private const double xpBaseValue = 0.1;
        private double xpPerHit = 0;

        private const double goldBaseValue = 1;
        private double goldPerHit = 0;

        private const double DiamondBaseValue = 0.01;
        private double DiamondChance = 0;

        
        

        private Dictionary<double, Storage> storages = Storage.GetStorages();


        private Character character;

        public frmMain()
        {
            InitializeComponent();
        }

        
        private void frmMain_Load(object sender, EventArgs e)
        {
            character = new Character("Neuer");
            tbNameOfMine.Text = "Mine of " + character.name;

            CalculateXPPerHit();
            CalculateGoldPerHit();
            CalculateDiamondChance();

            RefreshDisplay();
            
        }

        private void CalculateXPPerHit()
        {
            xpPerHit = xpBaseValue;
        }

        private void CalculateGoldPerHit()
        {
            goldPerHit = goldBaseValue;
        }

        private void CalculateDiamondChance()
        {
            DiamondChance = DiamondBaseValue;
        }



        private void RefreshDisplay()
        {
            btnMine.Text = "Mine\n(" + goldPerHit.ToString() + ")";

            tbLevel.Text = character.level.ToString("0");
            tbXP.Text = character.XP.ToString("0.00");
            tbXPPerHit.Text = xpPerHit.ToString();

            consumption = 0;
            storage = storages[character.storage].storage;
            consumption += storages[character.storage].consumption;

            tbGold.Text = character.gold.ToString("0");
            tbStorage.Text = storage.ToString();
            tbPower.Text = character.power.ToString("0.00 V");
            tbConsumption.Text = consumption.ToString();

            tbDiamonds.Text = character.diamonds.ToString("0");
            tbDiamondChance.Text = DiamondChance.ToString("0.00")+"%";

            btnSkillsPerks.Text = "Skills / Perks\n(" + character.skillPoints + " / " + character.perkPoints + ")";

            Storage curStorage = storages[character.storage];
            btnStorage.Text = curStorage.title + "(" + character.storage + ")";
            if (character.storage < Storage.maxStorageLevel) btnStorage.Text += "\n Update (" + storages[character.storage + 1].cost + ")";
       
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            if (character.gold < storage)
            {
                character.gold = CT.Clamp(character.gold + goldPerHit, 0, storage);
                character.XP += xpPerHit;

                if (character.XP >= (character.level*1000))
                {
                    character.XP -= (character.level * 1000);
                    character.level++;
                    character.skillPoints++;
                    character.perkPoints++;
                }

                Random rnd = new Random();
                double rndNumber = rnd.NextDouble()/10;
                Console.WriteLine(rndNumber+ " <= "+DiamondChance+" ???");
                if (rndNumber <= DiamondChance) { Console.WriteLine("FOUND DIAMOND"); character.diamonds++; }; 
                RefreshDisplay();
            }
            else
            { Console.WriteLine("Lohnt nicht mehr zu arbeiten, hab keinen Platz mehr."); }
            
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            //TODO: Abfrage ob bauen oder nicht
            if (character.storage != Storage.maxStorageLevel)
            {
                Storage nextStorage = storages[character.storage + 1];
                if (character.gold >= nextStorage.cost)
                {
                    character.storage++;
                    character.gold = CT.Clamp(character.gold - nextStorage.cost, 0, character.gold);
                }
                RefreshDisplay();
            }

        }

        private void btnCheatGold_Click(object sender, EventArgs e)
        {
            double originGoldPerHit = goldPerHit;
            goldPerHit = 100000;
            btnMine_Click(null, null);
            goldPerHit = originGoldPerHit;
            RefreshDisplay();
        }

        private void btnSkillsPerks_Click(object sender, EventArgs e)
        {

        }

        private void btnCheatXP500_Click(object sender, EventArgs e)
        {
            character.XP += 500;
            RefreshDisplay();
        }
    }
}
