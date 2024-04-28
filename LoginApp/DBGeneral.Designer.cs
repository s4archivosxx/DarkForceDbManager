namespace LoginApp
{
    partial class DBGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBGeneral));
            this.btnDBAccounts = new System.Windows.Forms.Button();
            this.btnBans = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDBAccounts
            // 
            this.btnDBAccounts.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnDBAccounts.Location = new System.Drawing.Point(77, 58);
            this.btnDBAccounts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDBAccounts.Name = "btnDBAccounts";
            this.btnDBAccounts.Size = new System.Drawing.Size(124, 37);
            this.btnDBAccounts.TabIndex = 3;
            this.btnDBAccounts.Text = "BANEAR ACC";
            this.btnDBAccounts.UseVisualStyleBackColor = true;
            this.btnDBAccounts.Click += new System.EventHandler(this.btnDBAccounts_Click);
            // 
            // btnBans
            // 
            this.btnBans.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBans.Location = new System.Drawing.Point(13, 13);
            this.btnBans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBans.Name = "btnBans";
            this.btnBans.Size = new System.Drawing.Size(121, 37);
            this.btnBans.TabIndex = 1;
            this.btnBans.Text = "INFO ACC";
            this.btnBans.UseVisualStyleBackColor = true;
            this.btnBans.Click += new System.EventHandler(this.btnBans_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnCreateAcc.Location = new System.Drawing.Point(142, 14);
            this.btnCreateAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(127, 37);
            this.btnCreateAcc.TabIndex = 2;
            this.btnCreateAcc.Text = "CREAR ACC";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // DBGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(287, 102);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.btnBans);
            this.Controls.Add(this.btnDBAccounts);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DBGeneral";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDBAccounts;
        private System.Windows.Forms.Button btnBans;
        private System.Windows.Forms.Button btnCreateAcc;
    }
}