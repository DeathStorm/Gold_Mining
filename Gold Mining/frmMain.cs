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

        private double gold = 0;
        private double storage = 10;
        private double power = 0;
        private double consumption = 0;

        private double goldPerHit = 1;
        private double DiamondChance = 0.01d;

        private double curStorageLevel = 0;
        const double maxStorageLevel = 4;

        private Dictionary<double, Storage> storages = Storage.GetStorages();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RefreshDisplay();
        }


        private void RefreshDisplay()
        {
            btnMine.Text = "Mine\n(" + goldPerHit.ToString() + ")";

            consumption = 0;
            storage = storages[curStorageLevel].storage;
            consumption += storages[curStorageLevel].consumption;

            tbGold.Text = gold.ToString();
            tbStorage.Text = storage.ToString();
            tbPower.Text = power.ToString();
            tbConsumption.Text = consumption.ToString();

            tbDiamondChance.Text = DiamondChance.ToString("0.00")+"%";


            Storage curStorage = storages[curStorageLevel];
            btnStorage.Text = curStorage.title + "(" + curStorageLevel + ")";
            if (curStorageLevel < maxStorageLevel) btnStorage.Text += "\n Update (" + storages[curStorageLevel + 1].cost + ")";
       
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            if (gold < storage)
            {
                gold = CT.Clamp(gold + goldPerHit, 0, storage);

                Random rnd = new Random();
                double rndNumber = rnd.NextDouble()/10;
                Console.WriteLine(rndNumber+ " <= "+DiamondChance+" ???");
                if (rndNumber <= DiamondChance) Console.WriteLine("FOUND DIAMOND");
                RefreshDisplay();
            }
            else
            { Console.WriteLine("Lohnt nicht mehr zu arbeiten, hab keinen Platz mehr."); }
            
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            //TODO: Abfrage ob bauen oder nicht
            if (curStorageLevel != maxStorageLevel)
            {
                Storage nextStorage = storages[curStorageLevel + 1];
                if (gold >= nextStorage.cost)
                {
                    curStorageLevel++;
                    gold = CT.Clamp(gold - nextStorage.cost, 0, gold);
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
    }
}
