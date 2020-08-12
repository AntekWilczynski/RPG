namespace SuperAdventure
{
    partial class SuperAdventure
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblLvl = new System.Windows.Forms.Label();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Życie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Złoto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doświadczenie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poziom";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHP.Location = new System.Drawing.Point(110, 20);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(0, 13);
            this.lblHP.TabIndex = 4;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(110, 40);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 13);
            this.lblGold.TabIndex = 5;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(110, 60);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(0, 13);
            this.lblExp.TabIndex = 6;
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Location = new System.Drawing.Point(110, 80);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(0, 13);
            this.lblLvl.TabIndex = 7;
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(973, 503);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 8;
            this.btnEast.Text = "WSCHÓD";
            this.btnEast.UseVisualStyleBackColor = true;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(462, 466);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 9;
            this.btnUseWeapon.Text = "UŻYJ";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(462, 505);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 10;
            this.btnUsePotion.Text = "UŻYJ";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(914, 532);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 11;
            this.btnSouth.Text = "POŁUDNIE";
            this.btnSouth.UseVisualStyleBackColor = true;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(914, 474);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 12;
            this.btnNorth.Text = "PÓŁNOC";
            this.btnNorth.UseVisualStyleBackColor = true;
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(857, 503);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 13;
            this.btnWest.Text = "ZACHÓD";
            this.btnWest.UseVisualStyleBackColor = true;
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(326, 466);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 21);
            this.cboWeapons.TabIndex = 14;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(326, 505);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 21);
            this.cboPotions.TabIndex = 15;
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(318, 123);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(825, 323);
            this.rtbMessages.TabIndex = 16;
            this.rtbMessages.Text = "";
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(318, -3);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(825, 120);
            this.rtbLocation.TabIndex = 17;
            this.rtbLocation.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Location = new System.Drawing.Point(13, 123);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(299, 169);
            this.dgvInventory.TabIndex = 18;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Location = new System.Drawing.Point(13, 298);
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.Size = new System.Drawing.Size(299, 281);
            this.dgvQuests.TabIndex = 19;
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 591);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.lblLvl);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuperAdventure";
            this.Text = "My Game";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
    }
}

