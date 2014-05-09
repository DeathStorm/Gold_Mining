namespace Gold_Mining
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMine = new System.Windows.Forms.Button();
            this.groupBoxInfos = new System.Windows.Forms.GroupBox();
            this.btnSkillsPerks = new System.Windows.Forms.Button();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.tbXPPerHit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbXP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDiamonds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDiamondChance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStorage = new System.Windows.Forms.Button();
            this.tbConsumption = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStorage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGold = new System.Windows.Forms.TextBox();
            this.lblGold = new System.Windows.Forms.Label();
            this.btnCheatGold = new System.Windows.Forms.Button();
            this.tbNameOfMine = new System.Windows.Forms.TextBox();
            this.btnCheatXP500 = new System.Windows.Forms.Button();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.btnPickAxe = new System.Windows.Forms.Button();
            this.groupBoxInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMine
            // 
            this.btnMine.Location = new System.Drawing.Point(12, 60);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(363, 252);
            this.btnMine.TabIndex = 0;
            this.btnMine.Text = "Mine";
            this.btnMine.UseVisualStyleBackColor = true;
            this.btnMine.Click += new System.EventHandler(this.btnMine_Click);
            // 
            // groupBoxInfos
            // 
            this.groupBoxInfos.Controls.Add(this.btnPickAxe);
            this.groupBoxInfos.Controls.Add(this.btnSkillsPerks);
            this.groupBoxInfos.Controls.Add(this.tbLevel);
            this.groupBoxInfos.Controls.Add(this.tbXPPerHit);
            this.groupBoxInfos.Controls.Add(this.label6);
            this.groupBoxInfos.Controls.Add(this.tbXP);
            this.groupBoxInfos.Controls.Add(this.label7);
            this.groupBoxInfos.Controls.Add(this.tbDiamonds);
            this.groupBoxInfos.Controls.Add(this.label1);
            this.groupBoxInfos.Controls.Add(this.tbDiamondChance);
            this.groupBoxInfos.Controls.Add(this.label3);
            this.groupBoxInfos.Controls.Add(this.btnStorage);
            this.groupBoxInfos.Controls.Add(this.tbConsumption);
            this.groupBoxInfos.Controls.Add(this.label5);
            this.groupBoxInfos.Controls.Add(this.tbPower);
            this.groupBoxInfos.Controls.Add(this.label4);
            this.groupBoxInfos.Controls.Add(this.tbStorage);
            this.groupBoxInfos.Controls.Add(this.label2);
            this.groupBoxInfos.Controls.Add(this.tbGold);
            this.groupBoxInfos.Controls.Add(this.lblGold);
            this.groupBoxInfos.Location = new System.Drawing.Point(381, 12);
            this.groupBoxInfos.Name = "groupBoxInfos";
            this.groupBoxInfos.Size = new System.Drawing.Size(200, 480);
            this.groupBoxInfos.TabIndex = 1;
            this.groupBoxInfos.TabStop = false;
            // 
            // btnSkillsPerks
            // 
            this.btnSkillsPerks.Location = new System.Drawing.Point(6, 315);
            this.btnSkillsPerks.Name = "btnSkillsPerks";
            this.btnSkillsPerks.Size = new System.Drawing.Size(188, 50);
            this.btnSkillsPerks.TabIndex = 12;
            this.btnSkillsPerks.Text = "Skills / Perks";
            this.btnSkillsPerks.UseVisualStyleBackColor = true;
            this.btnSkillsPerks.Click += new System.EventHandler(this.btnSkillsPerks_Click);
            // 
            // tbLevel
            // 
            this.tbLevel.Location = new System.Drawing.Point(94, 19);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.ReadOnly = true;
            this.tbLevel.Size = new System.Drawing.Size(30, 20);
            this.tbLevel.TabIndex = 22;
            this.tbLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbXPPerHit
            // 
            this.tbXPPerHit.Location = new System.Drawing.Point(94, 45);
            this.tbXPPerHit.Name = "tbXPPerHit";
            this.tbXPPerHit.ReadOnly = true;
            this.tbXPPerHit.Size = new System.Drawing.Size(100, 20);
            this.tbXPPerHit.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "XP / Hit";
            // 
            // tbXP
            // 
            this.tbXP.Location = new System.Drawing.Point(130, 19);
            this.tbXP.Name = "tbXP";
            this.tbXP.ReadOnly = true;
            this.tbXP.Size = new System.Drawing.Size(64, 20);
            this.tbXP.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Level / XP";
            // 
            // tbDiamonds
            // 
            this.tbDiamonds.Location = new System.Drawing.Point(94, 253);
            this.tbDiamonds.Name = "tbDiamonds";
            this.tbDiamonds.ReadOnly = true;
            this.tbDiamonds.Size = new System.Drawing.Size(100, 20);
            this.tbDiamonds.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Diamonds";
            // 
            // tbDiamondChance
            // 
            this.tbDiamondChance.Location = new System.Drawing.Point(94, 279);
            this.tbDiamondChance.Name = "tbDiamondChance";
            this.tbDiamondChance.ReadOnly = true;
            this.tbDiamondChance.Size = new System.Drawing.Size(100, 20);
            this.tbDiamondChance.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Diamond-Chance";
            // 
            // btnStorage
            // 
            this.btnStorage.Location = new System.Drawing.Point(6, 371);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(188, 50);
            this.btnStorage.TabIndex = 11;
            this.btnStorage.Text = "Storage";
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // tbConsumption
            // 
            this.tbConsumption.Location = new System.Drawing.Point(94, 201);
            this.tbConsumption.Name = "tbConsumption";
            this.tbConsumption.ReadOnly = true;
            this.tbConsumption.Size = new System.Drawing.Size(100, 20);
            this.tbConsumption.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Consumption";
            // 
            // tbPower
            // 
            this.tbPower.Location = new System.Drawing.Point(94, 175);
            this.tbPower.Name = "tbPower";
            this.tbPower.ReadOnly = true;
            this.tbPower.Size = new System.Drawing.Size(100, 20);
            this.tbPower.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Power";
            // 
            // tbStorage
            // 
            this.tbStorage.Location = new System.Drawing.Point(94, 123);
            this.tbStorage.Name = "tbStorage";
            this.tbStorage.ReadOnly = true;
            this.tbStorage.Size = new System.Drawing.Size(100, 20);
            this.tbStorage.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Storage Capacity";
            // 
            // tbGold
            // 
            this.tbGold.Location = new System.Drawing.Point(94, 97);
            this.tbGold.Name = "tbGold";
            this.tbGold.ReadOnly = true;
            this.tbGold.Size = new System.Drawing.Size(100, 20);
            this.tbGold.TabIndex = 2;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(6, 100);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(29, 13);
            this.lblGold.TabIndex = 0;
            this.lblGold.Text = "Gold";
            // 
            // btnCheatGold
            // 
            this.btnCheatGold.Location = new System.Drawing.Point(12, 435);
            this.btnCheatGold.Name = "btnCheatGold";
            this.btnCheatGold.Size = new System.Drawing.Size(81, 57);
            this.btnCheatGold.TabIndex = 2;
            this.btnCheatGold.Text = "CHEAT: Gold 100.000";
            this.btnCheatGold.UseVisualStyleBackColor = true;
            this.btnCheatGold.Click += new System.EventHandler(this.btnCheatGold_Click);
            // 
            // tbNameOfMine
            // 
            this.tbNameOfMine.Location = new System.Drawing.Point(12, 31);
            this.tbNameOfMine.Name = "tbNameOfMine";
            this.tbNameOfMine.ReadOnly = true;
            this.tbNameOfMine.Size = new System.Drawing.Size(363, 20);
            this.tbNameOfMine.TabIndex = 3;
            this.tbNameOfMine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheatXP500
            // 
            this.btnCheatXP500.Location = new System.Drawing.Point(99, 435);
            this.btnCheatXP500.Name = "btnCheatXP500";
            this.btnCheatXP500.Size = new System.Drawing.Size(81, 57);
            this.btnCheatXP500.TabIndex = 4;
            this.btnCheatXP500.Text = "CHEAT: XP 500";
            this.btnCheatXP500.UseVisualStyleBackColor = true;
            this.btnCheatXP500.Click += new System.EventHandler(this.btnCheatXP500_Click);
            // 
            // tbMessages
            // 
            this.tbMessages.AcceptsReturn = true;
            this.tbMessages.Location = new System.Drawing.Point(12, 318);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.Size = new System.Drawing.Size(363, 111);
            this.tbMessages.TabIndex = 5;
            // 
            // btnPickAxe
            // 
            this.btnPickAxe.Location = new System.Drawing.Point(6, 427);
            this.btnPickAxe.Name = "btnPickAxe";
            this.btnPickAxe.Size = new System.Drawing.Size(188, 47);
            this.btnPickAxe.TabIndex = 23;
            this.btnPickAxe.Text = "Pickaxe";
            this.btnPickAxe.UseVisualStyleBackColor = true;
            this.btnPickAxe.Click += new System.EventHandler(this.btnPickAxe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 501);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.btnCheatXP500);
            this.Controls.Add(this.tbNameOfMine);
            this.Controls.Add(this.btnCheatGold);
            this.Controls.Add(this.groupBoxInfos);
            this.Controls.Add(this.btnMine);
            this.Name = "frmMain";
            this.Text = "Gold Miner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBoxInfos.ResumeLayout(false);
            this.groupBoxInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMine;
        private System.Windows.Forms.GroupBox groupBoxInfos;
        private System.Windows.Forms.TextBox tbConsumption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStorage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGold;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Button btnCheatGold;
        private System.Windows.Forms.TextBox tbDiamondChance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDiamonds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameOfMine;
        private System.Windows.Forms.TextBox tbXPPerHit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbXP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.Button btnSkillsPerks;
        private System.Windows.Forms.Button btnCheatXP500;
        private System.Windows.Forms.TextBox tbMessages;
        private System.Windows.Forms.Button btnPickAxe;
    }
}

