namespace LoginApp
{
    partial class DBPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBPlayer));
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpLevel = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.GB = new System.Windows.Forms.GroupBox();
            this.cmbTX = new System.Windows.Forms.ComboBox();
            this.cmblvl = new System.Windows.Forms.ComboBox();
            this.lblAP = new System.Windows.Forms.Label();
            this.txtboxAP = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.llbTotalExperience = new System.Windows.Forms.Label();
            this.lblPEN = new System.Windows.Forms.Label();
            this.SemesterTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.lblCurrentCharacterSlot = new System.Windows.Forms.Label();
            this.txtboxCurrentCharacterSlot = new System.Windows.Forms.TextBox();
            this.lblCoins2 = new System.Windows.Forms.Label();
            this.txtboxCoins2 = new System.Windows.Forms.TextBox();
            this.lblCoins1 = new System.Windows.Forms.Label();
            this.txtboxCoins1 = new System.Windows.Forms.TextBox();
            this.lblTutorialState = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(80, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 56);
            this.label6.TabIndex = 27;
            this.label6.Text = "AÑADIR DATOS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnUpLevel);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(66, 329);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(263, 188);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnUpLevel
            // 
            this.btnUpLevel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnUpLevel.Location = new System.Drawing.Point(10, 92);
            this.btnUpLevel.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpLevel.Name = "btnUpLevel";
            this.btnUpLevel.Size = new System.Drawing.Size(107, 38);
            this.btnUpLevel.TabIndex = 8;
            this.btnUpLevel.Text = "Subir Lvl";
            this.btnUpLevel.UseVisualStyleBackColor = true;
            this.btnUpLevel.Click += new System.EventHandler(this.btnUpLevel_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnShow.Location = new System.Drawing.Point(55, 140);
            this.btnShow.Margin = new System.Windows.Forms.Padding(5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(134, 37);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Restart App";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(10, 42);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Enviar PEN";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDelete.Location = new System.Drawing.Point(127, 92);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 38);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar Acc";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnUpdate.Location = new System.Drawing.Point(127, 42);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 40);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Enviar AP";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // GB
            // 
            this.GB.BackColor = System.Drawing.Color.Transparent;
            this.GB.Controls.Add(this.cmbTX);
            this.GB.Controls.Add(this.cmblvl);
            this.GB.Controls.Add(this.lblAP);
            this.GB.Controls.Add(this.txtboxAP);
            this.GB.Controls.Add(this.lblId);
            this.GB.Controls.Add(this.lblLevel);
            this.GB.Controls.Add(this.llbTotalExperience);
            this.GB.Controls.Add(this.lblPEN);
            this.GB.Controls.Add(this.SemesterTextBox);
            this.GB.Controls.Add(this.IdTextBox);
            this.GB.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB.ForeColor = System.Drawing.Color.White;
            this.GB.Location = new System.Drawing.Point(20, 86);
            this.GB.Margin = new System.Windows.Forms.Padding(5);
            this.GB.Name = "GB";
            this.GB.Padding = new System.Windows.Forms.Padding(5);
            this.GB.Size = new System.Drawing.Size(352, 233);
            this.GB.TabIndex = 25;
            this.GB.TabStop = false;
            this.GB.Text = "DATOS";
            // 
            // cmbTX
            // 
            this.cmbTX.FormattingEnabled = true;
            this.cmbTX.Items.AddRange(new object[] {
            "1-1400",
            "2-3000",
            "3-4800",
            "4-6800",
            "5-9000",
            "6-11400",
            "7-14200",
            "8-17400",
            "9-21000",
            "10-25000",
            "11-29400",
            "12-34800",
            "13-41200",
            "14-48600",
            "15-57000",
            "16-66400",
            "17-77400",
            "18-90400",
            "19-105400",
            "20-122400",
            "21-141400",
            "22-164400",
            "23-191400",
            "24-222400",
            "25-257400",
            "26-296400",
            "27-341400",
            "28-391400",
            "29-446400",
            "30-506400",
            "31-571400",
            "32-645220",
            "33-727860",
            "34-819320",
            "35-919600",
            "36-1028700",
            "37-1149320",
            "38-1281460",
            "39-1425120",
            "40-1580300",
            "41-1747000",
            "42-1928280",
            "43-2124140",
            "44-2334580",
            "45-2559600",
            "46-2799200",
            "47-3056800",
            "48-3332400",
            "49-3626000",
            "50-3937600",
            "51-4267200",
            "52-4618580",
            "53-4991740",
            "54-5386680",
            "55-5803400",
            "56-6241900",
            "57-6706320",
            "58-7196660",
            "59-7712920",
            "60-8255100",
            "61-8823200",
            "62-9421720",
            "63-10050660",
            "64-10710020",
            "65-11399800",
            "66-12120000",
            "67-12875480",
            "68-13666240",
            "69-14492280",
            "70-15353600",
            "71-16250200",
            "72-17187300",
            "73-18164900",
            "74-19183000",
            "75-20241600",
            "76-21340700",
            "77-22485880",
            "78-23677140",
            "79-24914480",
            "80-26197900",
            "81-27527400",
            "82-28908920",
            "83-30342460",
            "84-31828020",
            "85-33365600",
            "86-34955200",
            "87-36603120",
            "88-38309360",
            "89-40073920",
            "90-41896800",
            "91-43778000",
            "92-45724180",
            "93-47735340",
            "94-49811480",
            "95-51952600",
            "96-54158700",
            "97-56436800",
            "98-58786900",
            "99-61209000",
            "100-63703100",
            "101-93703100",
            "102-99445795"});
            this.cmbTX.Location = new System.Drawing.Point(186, 107);
            this.cmbTX.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTX.Name = "cmbTX";
            this.cmbTX.Size = new System.Drawing.Size(144, 30);
            this.cmbTX.TabIndex = 3;
            // 
            // cmblvl
            // 
            this.cmblvl.FormattingEnabled = true;
            this.cmblvl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102"});
            this.cmblvl.Location = new System.Drawing.Point(186, 67);
            this.cmblvl.Margin = new System.Windows.Forms.Padding(5);
            this.cmblvl.Name = "cmblvl";
            this.cmblvl.Size = new System.Drawing.Size(144, 30);
            this.cmblvl.TabIndex = 2;
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Location = new System.Drawing.Point(13, 182);
            this.lblAP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(31, 22);
            this.lblAP.TabIndex = 12;
            this.lblAP.Text = "AP";
            // 
            // txtboxAP
            // 
            this.txtboxAP.Location = new System.Drawing.Point(185, 179);
            this.txtboxAP.Margin = new System.Windows.Forms.Padding(5);
            this.txtboxAP.MaxLength = 11;
            this.txtboxAP.Name = "txtboxAP";
            this.txtboxAP.Size = new System.Drawing.Size(145, 28);
            this.txtboxAP.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 35);
            this.lblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(81, 22);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "AccountID";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(13, 70);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(49, 22);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Level";
            // 
            // llbTotalExperience
            // 
            this.llbTotalExperience.AutoSize = true;
            this.llbTotalExperience.Location = new System.Drawing.Point(13, 110);
            this.llbTotalExperience.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.llbTotalExperience.Name = "llbTotalExperience";
            this.llbTotalExperience.Size = new System.Drawing.Size(130, 22);
            this.llbTotalExperience.TabIndex = 3;
            this.llbTotalExperience.Text = "TotalExperience";
            // 
            // lblPEN
            // 
            this.lblPEN.AutoSize = true;
            this.lblPEN.Location = new System.Drawing.Point(13, 148);
            this.lblPEN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPEN.Name = "lblPEN";
            this.lblPEN.Size = new System.Drawing.Size(41, 22);
            this.lblPEN.TabIndex = 4;
            this.lblPEN.Text = "PEN";
            // 
            // SemesterTextBox
            // 
            this.SemesterTextBox.Location = new System.Drawing.Point(186, 145);
            this.SemesterTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SemesterTextBox.MaxLength = 11;
            this.SemesterTextBox.Name = "SemesterTextBox";
            this.SemesterTextBox.Size = new System.Drawing.Size(145, 28);
            this.SemesterTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            this.IdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.IdTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.IdTextBox.Location = new System.Drawing.Point(185, 32);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(145, 28);
            this.IdTextBox.TabIndex = 1;
            // 
            // lblCurrentCharacterSlot
            // 
            this.lblCurrentCharacterSlot.AutoSize = true;
            this.lblCurrentCharacterSlot.Location = new System.Drawing.Point(615, 621);
            this.lblCurrentCharacterSlot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurrentCharacterSlot.Name = "lblCurrentCharacterSlot";
            this.lblCurrentCharacterSlot.Size = new System.Drawing.Size(166, 22);
            this.lblCurrentCharacterSlot.TabIndex = 16;
            this.lblCurrentCharacterSlot.Text = "CurrentCharacterSlot";
            this.lblCurrentCharacterSlot.Visible = false;
            // 
            // txtboxCurrentCharacterSlot
            // 
            this.txtboxCurrentCharacterSlot.Enabled = false;
            this.txtboxCurrentCharacterSlot.Location = new System.Drawing.Point(902, 616);
            this.txtboxCurrentCharacterSlot.Margin = new System.Windows.Forms.Padding(5);
            this.txtboxCurrentCharacterSlot.Name = "txtboxCurrentCharacterSlot";
            this.txtboxCurrentCharacterSlot.Size = new System.Drawing.Size(212, 28);
            this.txtboxCurrentCharacterSlot.TabIndex = 17;
            this.txtboxCurrentCharacterSlot.Visible = false;
            // 
            // lblCoins2
            // 
            this.lblCoins2.AutoSize = true;
            this.lblCoins2.Location = new System.Drawing.Point(615, 552);
            this.lblCoins2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCoins2.Name = "lblCoins2";
            this.lblCoins2.Size = new System.Drawing.Size(59, 22);
            this.lblCoins2.TabIndex = 14;
            this.lblCoins2.Text = "Coins2";
            this.lblCoins2.Visible = false;
            // 
            // txtboxCoins2
            // 
            this.txtboxCoins2.Enabled = false;
            this.txtboxCoins2.Location = new System.Drawing.Point(902, 547);
            this.txtboxCoins2.Margin = new System.Windows.Forms.Padding(5);
            this.txtboxCoins2.Name = "txtboxCoins2";
            this.txtboxCoins2.Size = new System.Drawing.Size(212, 28);
            this.txtboxCoins2.TabIndex = 15;
            this.txtboxCoins2.Visible = false;
            // 
            // lblCoins1
            // 
            this.lblCoins1.AutoSize = true;
            this.lblCoins1.Location = new System.Drawing.Point(615, 496);
            this.lblCoins1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCoins1.Name = "lblCoins1";
            this.lblCoins1.Size = new System.Drawing.Size(59, 22);
            this.lblCoins1.TabIndex = 10;
            this.lblCoins1.Text = "Coins1";
            this.lblCoins1.Visible = false;
            // 
            // txtboxCoins1
            // 
            this.txtboxCoins1.Enabled = false;
            this.txtboxCoins1.Location = new System.Drawing.Point(902, 491);
            this.txtboxCoins1.Margin = new System.Windows.Forms.Padding(5);
            this.txtboxCoins1.Name = "txtboxCoins1";
            this.txtboxCoins1.Size = new System.Drawing.Size(212, 28);
            this.txtboxCoins1.TabIndex = 11;
            this.txtboxCoins1.Visible = false;
            // 
            // lblTutorialState
            // 
            this.lblTutorialState.AutoSize = true;
            this.lblTutorialState.Location = new System.Drawing.Point(615, 181);
            this.lblTutorialState.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTutorialState.Name = "lblTutorialState";
            this.lblTutorialState.Size = new System.Drawing.Size(105, 22);
            this.lblTutorialState.TabIndex = 1;
            this.lblTutorialState.Text = "TutorialState";
            this.lblTutorialState.Visible = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Location = new System.Drawing.Point(902, 176);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(212, 28);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.Visible = false;
            // 
            // DBPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 527);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblCurrentCharacterSlot);
            this.Controls.Add(this.txtboxCurrentCharacterSlot);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.lblCoins2);
            this.Controls.Add(this.lblTutorialState);
            this.Controls.Add(this.txtboxCoins2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.txtboxCoins1);
            this.Controls.Add(this.lblCoins1);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "DBPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos de Jugadores";
            this.Load += new System.EventHandler(this.DBPlayer_Load);
            this.groupBox2.ResumeLayout(false);
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTutorialState;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label llbTotalExperience;
        private System.Windows.Forms.Label lblPEN;
        private System.Windows.Forms.TextBox SemesterTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label lblCurrentCharacterSlot;
        private System.Windows.Forms.TextBox txtboxCurrentCharacterSlot;
        private System.Windows.Forms.Label lblCoins2;
        private System.Windows.Forms.TextBox txtboxCoins2;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.TextBox txtboxAP;
        private System.Windows.Forms.Label lblCoins1;
        private System.Windows.Forms.TextBox txtboxCoins1;
        private System.Windows.Forms.Button btnUpLevel;
        private System.Windows.Forms.ComboBox cmbTX;
        private System.Windows.Forms.ComboBox cmblvl;
    }
}