namespace LoginDB
{
    partial class CreateAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAcc));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGAcc = new System.Windows.Forms.Button();
            this.btnRestarApp = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupbD = new System.Windows.Forms.GroupBox();
            this.txtbSecurityLevel = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbSalt = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtbId = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSalt = new System.Windows.Forms.Label();
            this.lblSecurityLevel = new System.Windows.Forms.Label();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.txtBNickname = new System.Windows.Forms.TextBox();
            this.lvlAdd = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUpdateNick = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInsertAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUpdatePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupbD.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnCS);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnGAcc);
            this.groupBox2.Controls.Add(this.btnRestarApp);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(31, 401);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Size = new System.Drawing.Size(314, 246);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnCS
            // 
            this.btnCS.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnCS.ForeColor = System.Drawing.Color.Black;
            this.btnCS.Location = new System.Drawing.Point(9, 137);
            this.btnCS.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(140, 42);
            this.btnCS.TabIndex = 12;
            this.btnCS.Text = "Cambiar SL";
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(152, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cambiar Pw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGAcc
            // 
            this.btnGAcc.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnGAcc.ForeColor = System.Drawing.Color.Black;
            this.btnGAcc.Location = new System.Drawing.Point(152, 85);
            this.btnGAcc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGAcc.Name = "btnGAcc";
            this.btnGAcc.Size = new System.Drawing.Size(137, 40);
            this.btnGAcc.TabIndex = 11;
            this.btnGAcc.Text = "Generar Acc";
            this.btnGAcc.UseVisualStyleBackColor = true;
            this.btnGAcc.Click += new System.EventHandler(this.btnGPw_Click);
            // 
            // btnRestarApp
            // 
            this.btnRestarApp.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnRestarApp.ForeColor = System.Drawing.Color.Black;
            this.btnRestarApp.Location = new System.Drawing.Point(73, 191);
            this.btnRestarApp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRestarApp.Name = "btnRestarApp";
            this.btnRestarApp.Size = new System.Drawing.Size(144, 43);
            this.btnRestarApp.TabIndex = 14;
            this.btnRestarApp.Text = "Restart App";
            this.btnRestarApp.UseVisualStyleBackColor = true;
            this.btnRestarApp.Click += new System.EventHandler(this.btnRestarApp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(9, 85);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Eliminar Acc";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(9, 32);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(140, 40);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Crear Acc";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(152, 32);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Actualizar Nick";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupbD
            // 
            this.groupbD.BackColor = System.Drawing.Color.Transparent;
            this.groupbD.Controls.Add(this.txtbSecurityLevel);
            this.groupbD.Controls.Add(this.txtbEmail);
            this.groupbD.Controls.Add(this.lblEmail);
            this.groupbD.Controls.Add(this.txtbSalt);
            this.groupbD.Controls.Add(this.txtbPassword);
            this.groupbD.Controls.Add(this.lblId);
            this.groupbD.Controls.Add(this.txtbId);
            this.groupbD.Controls.Add(this.lblUsername);
            this.groupbD.Controls.Add(this.lblNickname);
            this.groupbD.Controls.Add(this.lblPassword);
            this.groupbD.Controls.Add(this.lblSalt);
            this.groupbD.Controls.Add(this.lblSecurityLevel);
            this.groupbD.Controls.Add(this.txtbUsername);
            this.groupbD.Controls.Add(this.txtBNickname);
            this.groupbD.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.groupbD.ForeColor = System.Drawing.Color.White;
            this.groupbD.Location = new System.Drawing.Point(17, 84);
            this.groupbD.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupbD.Name = "groupbD";
            this.groupbD.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupbD.Size = new System.Drawing.Size(344, 305);
            this.groupbD.TabIndex = 32;
            this.groupbD.TabStop = false;
            this.groupbD.Text = "DATOS";
            // 
            // txtbSecurityLevel
            // 
            this.txtbSecurityLevel.Location = new System.Drawing.Point(154, 217);
            this.txtbSecurityLevel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbSecurityLevel.Name = "txtbSecurityLevel";
            this.txtbSecurityLevel.Size = new System.Drawing.Size(162, 28);
            this.txtbSecurityLevel.TabIndex = 6;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(154, 254);
            this.txtbEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(162, 28);
            this.txtbEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 257);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 22);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Correo";
            // 
            // txtbSalt
            // 
            this.txtbSalt.Location = new System.Drawing.Point(154, 181);
            this.txtbSalt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbSalt.Name = "txtbSalt";
            this.txtbSalt.Size = new System.Drawing.Size(162, 28);
            this.txtbSalt.TabIndex = 5;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(154, 145);
            this.txtbPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(162, 28);
            this.txtbPassword.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.lblId.Location = new System.Drawing.Point(16, 39);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 22);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id";
            // 
            // txtbId
            // 
            this.txtbId.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbId.Location = new System.Drawing.Point(154, 37);
            this.txtbId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbId.Name = "txtbId";
            this.txtbId.Size = new System.Drawing.Size(162, 29);
            this.txtbId.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 75);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 22);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(16, 112);
            this.lblNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(83, 22);
            this.lblNickname.TabIndex = 1;
            this.lblNickname.Text = "Nickname";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 148);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 22);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Location = new System.Drawing.Point(16, 184);
            this.lblSalt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(39, 22);
            this.lblSalt.TabIndex = 3;
            this.lblSalt.Text = "Salt";
            // 
            // lblSecurityLevel
            // 
            this.lblSecurityLevel.AutoSize = true;
            this.lblSecurityLevel.Location = new System.Drawing.Point(16, 220);
            this.lblSecurityLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecurityLevel.Name = "lblSecurityLevel";
            this.lblSecurityLevel.Size = new System.Drawing.Size(109, 22);
            this.lblSecurityLevel.TabIndex = 4;
            this.lblSecurityLevel.Text = "SecurityLevel";
            // 
            // txtbUsername
            // 
            this.txtbUsername.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtbUsername.Location = new System.Drawing.Point(154, 73);
            this.txtbUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(162, 29);
            this.txtbUsername.TabIndex = 2;
            // 
            // txtBNickname
            // 
            this.txtBNickname.Location = new System.Drawing.Point(154, 109);
            this.txtBNickname.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBNickname.Name = "txtBNickname";
            this.txtBNickname.Size = new System.Drawing.Size(162, 28);
            this.txtBNickname.TabIndex = 3;
            // 
            // lvlAdd
            // 
            this.lvlAdd.AutoSize = true;
            this.lvlAdd.BackColor = System.Drawing.Color.Transparent;
            this.lvlAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lvlAdd.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lvlAdd.Location = new System.Drawing.Point(68, 38);
            this.lvlAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlAdd.Name = "lvlAdd";
            this.lvlAdd.Size = new System.Drawing.Size(241, 40);
            this.lvlAdd.TabIndex = 34;
            this.lvlAdd.Text = "AÑADIR DATOS";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(384, 30);
            this.MenuStrip.TabIndex = 35;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInsert,
            this.MenuUpdate,
            this.MenuSearch,
            this.MenuDelete});
            this.Menu.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(63, 26);
            this.Menu.Text = "Menu";
            // 
            // MenuInsert
            // 
            this.MenuInsert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInsertAccount});
            this.MenuInsert.Name = "MenuInsert";
            this.MenuInsert.Size = new System.Drawing.Size(153, 26);
            this.MenuInsert.Text = "Insertar";
            // 
            // MenuUpdate
            // 
            this.MenuUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUpdateNick,
            this.MenuUpdatePassword});
            this.MenuUpdate.Name = "MenuUpdate";
            this.MenuUpdate.Size = new System.Drawing.Size(153, 26);
            this.MenuUpdate.Text = "Actualizar";
            // 
            // MenuDelete
            // 
            this.MenuDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDeleteAccount});
            this.MenuDelete.Name = "MenuDelete";
            this.MenuDelete.Size = new System.Drawing.Size(153, 26);
            this.MenuDelete.Text = "Eliminar";
            // 
            // MenuSearch
            // 
            this.MenuSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSearchAccount});
            this.MenuSearch.Name = "MenuSearch";
            this.MenuSearch.Size = new System.Drawing.Size(153, 26);
            this.MenuSearch.Text = "Buscar";
            // 
            // MenuSearchAccount
            // 
            this.MenuSearchAccount.Name = "MenuSearchAccount";
            this.MenuSearchAccount.Size = new System.Drawing.Size(152, 26);
            this.MenuSearchAccount.Text = "Cuenta";
            // 
            // MenuUpdateNick
            // 
            this.MenuUpdateNick.Name = "MenuUpdateNick";
            this.MenuUpdateNick.Size = new System.Drawing.Size(164, 26);
            this.MenuUpdateNick.Text = "Nick";
            // 
            // MenuInsertAccount
            // 
            this.MenuInsertAccount.Name = "MenuInsertAccount";
            this.MenuInsertAccount.Size = new System.Drawing.Size(152, 26);
            this.MenuInsertAccount.Text = "Cuenta";
            // 
            // MenuUpdatePassword
            // 
            this.MenuUpdatePassword.Name = "MenuUpdatePassword";
            this.MenuUpdatePassword.Size = new System.Drawing.Size(164, 26);
            this.MenuUpdatePassword.Text = "Contraseña";
            // 
            // MenuDeleteAccount
            // 
            this.MenuDeleteAccount.Name = "MenuDeleteAccount";
            this.MenuDeleteAccount.Size = new System.Drawing.Size(152, 26);
            this.MenuDeleteAccount.Text = "Cuenta";
            // 
            // CreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 667);
            this.Controls.Add(this.lvlAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbD);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "CreateAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creador de Cuentas";
            this.groupBox2.ResumeLayout(false);
            this.groupbD.ResumeLayout(false);
            this.groupbD.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRestarApp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupbD;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtbId;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.Label lblSecurityLevel;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.TextBox txtBNickname;
        private System.Windows.Forms.Label lvlAdd;
        private System.Windows.Forms.TextBox txtbSalt;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Button btnGAcc;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.TextBox txtbSecurityLevel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuInsert;
        private System.Windows.Forms.ToolStripMenuItem MenuInsertAccount;
        private System.Windows.Forms.ToolStripMenuItem MenuUpdate;
        private System.Windows.Forms.ToolStripMenuItem MenuUpdateNick;
        private System.Windows.Forms.ToolStripMenuItem MenuUpdatePassword;
        private System.Windows.Forms.ToolStripMenuItem MenuSearch;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchAccount;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteAccount;
    }
}