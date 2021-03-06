﻿using System;
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
        private Dictionary<double, Pickaxe> pickAxes = Pickaxe.GetPickAxes();

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
            btnMine.Text = "Mine\n(" + pickAxes[character.pickAxe].goldPerHit.ToString() + ")";

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
            tbDiamondChance.Text = pickAxes[character.pickAxe].diamondChance.ToString("0.00")+"%";

            btnSkillsPerks.Text = "Skills / Perks\n(" + character.skillPoints + " / " + character.perkPoints + ")";

            Storage curStorage = storages[character.storage];
            btnStorage.Text = curStorage.title + "(" + character.storage + ")";
            if (character.storage < Storage.maxStorageLevel) btnStorage.Text += "\n Update (" + storages[character.storage + 1].cost + ")";

            Pickaxe curPickAxe= pickAxes[character.pickAxe];
            btnPickAxe.Text = curPickAxe.title + "(" + character.pickAxe + ")";
            if (character.pickAxe < Pickaxe.maxPickAxeLevel) btnPickAxe.Text += "\n Update (" + pickAxes[character.pickAxe + 1].cost + ")";
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            if (character.gold < storage)
            {
                double goldEarned = CT.Clamp(pickAxes[character.pickAxe].goldPerHit, 0, storage - character.gold);
                NewMessage("Earned "+goldEarned+" Gold ("+(character.gold +goldEarned)+"\\"+storage+")");
                character.gold = CT.Clamp(character.gold + pickAxes[character.pickAxe].goldPerHit, 0, storage);
                character.XP += xpPerHit;

                if (character.XP >= (character.level*1000))
                {
                    character.XP -= (character.level * 1000);
                    character.level++;
                    character.skillPoints++;
                    character.perkPoints++;
                    NewMessage("Level UP");
                }

                Random rnd = new Random();
                double rndNumber = rnd.NextDouble()/10;
                Console.WriteLine(rndNumber + " <= " + pickAxes[character.pickAxe].diamondChance + " ???");
                if (rndNumber <= pickAxes[character.pickAxe].diamondChance) { NewMessage("FOUND DIAMOND"); character.diamonds++; }; 
                RefreshDisplay();
            }
            else
            { NewMessage("Don't want to work, I haven't enough storage anymore."); }
            
        }

        private void NewMessage(String message)
        {
            tbMessages.Text = message + Environment.NewLine + tbMessages.Text;
             Console.WriteLine(message);
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

        private void btnPickAxe_Click(object sender, EventArgs e)
        {
            //TODO: Abfrage ob bauen oder nicht
            if (character.pickAxe != Pickaxe.maxPickAxeLevel)
            {
                Pickaxe nextPickAxe = pickAxes[character.pickAxe + 1];
                if (character.gold >= nextPickAxe.cost)
                {
                    character.pickAxe++;
                    character.gold = CT.Clamp(character.gold - nextPickAxe.cost, 0, character.gold);
                }
                RefreshDisplay();
            }

        }

        private void btnCheatGold_Click(object sender, EventArgs e)
        {
            //double originGoldPerHit = goldPerHit;
            character.gold = CT.Clamp(character.gold + 100000, 0, storages[character.storage].storage); ;
                //btnMine_Click(null, null);
            //goldPerHit = originGoldPerHit;
            RefreshDisplay();
        }

        private void btnSkillsPerks_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Start");
            //Random rnd = new Random();
            //for (int i = 0; i < 10000; i++)
            //{
                
            //    double rndNumber = rnd.NextDouble() * 100;
            //    if (rndNumber <= 0.1) tbMessages.Text += rndNumber + Environment.NewLine;
            //    if (rndNumber <= 0.01) Console.WriteLine("Found a Diamond");

            //}
            //Console.WriteLine("End");
        }

        private void btnCheatXP500_Click(object sender, EventArgs e)
        {
            character.XP += 500;
            RefreshDisplay();
        }
    }
}
