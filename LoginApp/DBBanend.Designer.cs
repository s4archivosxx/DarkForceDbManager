namespace LoginApp
{
    partial class DBBanend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBBanend));
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.GB = new System.Windows.Forms.GroupBox();
            this.lblAcc = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.GB2.SuspendLayout();
            this.GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB2
            // 
            this.GB2.BackColor = System.Drawing.Color.Transparent;
            this.GB2.Controls.Add(this.btnShow);
            this.GB2.Controls.Add(this.btnSave);
            this.GB2.Controls.Add(this.btnUpdate);
            this.GB2.Controls.Add(this.btnDelete);
            this.GB2.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.GB2.ForeColor = System.Drawing.Color.White;
            this.GB2.Location = new System.Drawing.Point(12, 114);
            this.GB2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB2.Name = "GB2";
            this.GB2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB2.Size = new System.Drawing.Size(307, 123);
            this.GB2.TabIndex = 21;
            this.GB2.TabStop = false;
            this.GB2.Text = "Acciones";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Black;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShow.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnShow.Location = new System.Drawing.Point(163, 82);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(133, 33);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Restart App";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnSave.Location = new System.Drawing.Point(7, 34);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Banear Acc";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnUpdate.Location = new System.Drawing.Point(163, 34);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Actualiar Ban";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnDelete.Location = new System.Drawing.Point(7, 82);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar Ban";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GB
            // 
            this.GB.BackColor = System.Drawing.Color.Transparent;
            this.GB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GB.Controls.Add(this.lblAcc);
            this.GB.Controls.Add(this.NameTextBox);
            this.GB.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB.ForeColor = System.Drawing.Color.White;
            this.GB.Location = new System.Drawing.Point(12, 13);
            this.GB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB.Name = "GB";
            this.GB.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB.Size = new System.Drawing.Size(307, 80);
            this.GB.TabIndex = 20;
            this.GB.TabStop = false;
            this.GB.Text = "DATOS";
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.lblAcc.ForeColor = System.Drawing.Color.White;
            this.lblAcc.Location = new System.Drawing.Point(6, 34);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(91, 24);
            this.lblAcc.TabIndex = 1;
            this.lblAcc.Text = "AccountId";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.NameTextBox.ForeColor = System.Drawing.Color.Black;
            this.NameTextBox.Location = new System.Drawing.Point(155, 34);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(141, 28);
            this.NameTextBox.TabIndex = 1;
            // 
            // DBBanend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(330, 247);
            this.Controls.Add(this.GB2);
            this.Controls.Add(this.GB);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DBBanend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos de Bloqueo";
            this.Load += new System.EventHandler(this.DBBanend_Load);
            this.GB2.ResumeLayout(false);
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}