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
            this.tbDiamondChance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMine
            // 
            this.btnMine.Location = new System.Drawing.Point(12, 18);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(363, 252);
            this.btnMine.TabIndex = 0;
            this.btnMine.Text = "Mine";
            this.btnMine.UseVisualStyleBackColor = true;
            this.btnMine.Click += new System.EventHandler(this.btnMine_Click);
            // 
            // groupBoxInfos
            // 
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
            // btnStorage
            // 
            this.btnStorage.Location = new System.Drawing.Point(9, 423);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(185, 50);
            this.btnStorage.TabIndex = 11;
            this.btnStorage.Text = "Lager";
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // tbConsumption
            // 
            this.tbConsumption.Location = new System.Drawing.Point(94, 123);
            this.tbConsumption.Name = "tbConsumption";
            this.tbConsumption.ReadOnly = true;
            this.tbConsumption.Size = new System.Drawing.Size(100, 20);
            this.tbConsumption.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stromverbrauch";
            // 
            // tbPower
            // 
            this.tbPower.Location = new System.Drawing.Point(94, 97);
            this.tbPower.Name = "tbPower";
            this.tbPower.ReadOnly = true;
            this.tbPower.Size = new System.Drawing.Size(100, 20);
            this.tbPower.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Strom";
            // 
            // tbStorage
            // 
            this.tbStorage.Location = new System.Drawing.Point(94, 45);
            this.tbStorage.Name = "tbStorage";
            this.tbStorage.ReadOnly = true;
            this.tbStorage.Size = new System.Drawing.Size(100, 20);
            this.tbStorage.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lagerkapazität";
            // 
            // tbGold
            // 
            this.tbGold.Location = new System.Drawing.Point(94, 19);
            this.tbGold.Name = "tbGold";
            this.tbGold.ReadOnly = true;
            this.tbGold.Size = new System.Drawing.Size(100, 20);
            this.tbGold.TabIndex = 2;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(6, 22);
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
            // tbDiamondChance
            // 
            this.tbDiamondChance.Location = new System.Drawing.Point(94, 175);
            this.tbDiamondChance.Name = "tbDiamondChance";
            this.tbDiamondChance.ReadOnly = true;
            this.tbDiamondChance.Size = new System.Drawing.Size(100, 20);
            this.tbDiamondChance.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "DiamantChance";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 504);
            this.Controls.Add(this.btnCheatGold);
            this.Controls.Add(this.groupBoxInfos);
            this.Controls.Add(this.btnMine);
            this.Name = "frmMain";
            this.Text = "Gold Miner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBoxInfos.ResumeLayout(false);
            this.groupBoxInfos.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

