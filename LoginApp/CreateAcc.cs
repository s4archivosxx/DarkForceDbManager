using LoginApp;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace LoginDB
{
    public partial class CreateAcc : Form
    {
        MySqlConnection con = new MySqlConnection("server=158.69.101.201;port=3306;username=s4new;password=s4new");
        //MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=admin");
        MySqlCommand cmd;
        MySqlDataReader mdr;
        private string Casillasvacías = "Por favor, inserte carácteres en las casillas vacías.";
        private string nw = Environment.NewLine;

        public CreateAcc()
        {
            InitializeComponent();
            MenuInsertAccount.Click += InsertAccount;
            MenuUpdateNick.Click += UpdateNick;
            MenuUpdatePassword.Click += UpdatePassword;
            MenuSearchAccount.Click += SearchAccount;
            MenuDeleteAccount.Click += DeleteAccount;
        }

        public void InsertAccount(object sender, EventArgs e)
        {
            if (txtbPassword.Text == "" || txtbSalt.Text == "" || txtbSecurityLevel.Text == "" ||
                 txtbEmail.Text == "" || txtBNickname.Text == "" || txtbEmail.Text == "" || 
                 txtbUsername.Text == "")
            {
                MessageBox.Show(Casillasvacías, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #region Time
            var sec = DateTime.Now.Second;
            #endregion

            try
            {
                string Query = "INSERT INTO s4auth.accounts(Id,Username,Password,Salt,SecurityLevel,Email) VALUES('" + "" + "','" + txtbUsername.Text + "','" + txtbPassword.Text + "','" + txtbSalt.Text + "','" + txtbSecurityLevel.Text + "','" + txtbEmail.Text + "');";

                con.Open();
                cmd = new MySqlCommand(Query, con);
                mdr = cmd.ExecuteReader();
                if (mdr.Read()) { }
                con.Close();
                File.WriteAllText($"Log_Account_Created_{txtbUsername.Text}_{sec}", $"[USUARIO REGISTRADO]{nw}Id: {txtbId.Text}{nw}Username: {txtbUsername.Text}{nw}Password: {txtbPassword.Text}{nw}SecurityLevel: {txtbSecurityLevel.Text}{nw}Email: {txtbEmail.Text}{nw}Fecha: {DateTime.Now}{nw}");
                MessageBox.Show($"[USUARIO REGISTRADO]\nId: {txtbId.Text}\nUsername: {txtbUsername.Text}\nPassword: {txtbPassword.Text}\nSecurityLevel: {txtbSecurityLevel.Text}\nEmail: {txtbEmail.Text}\nFecha: {DateTime.Now}", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbId.Text = "";
                txtBNickname.Text = "";
                txtbPassword.Text = "";
                txtbSalt.Text = "";
                txtbSecurityLevel.Text = "";
                txtbUsername.Text = "";
                txtbEmail.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                return;
            }
        }

        public void UpdateNick(object sender, EventArgs e)
        {

        }

        public void UpdatePassword(object sender, EventArgs e)
        {

        }

        public void SearchAccount(object sender, EventArgs e)
        {

        }

        public void DeleteAccount(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRestarApp_Click(object sender, EventArgs e)
        {
            Hide();
            DBGeneral DBG = new DBGeneral();
            DBG.ShowDialog();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from s4auth.accounts where Id='" + txtbId.Text + "';";
               // MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                if (txtbId.Text == "")
                {
                    MessageBox.Show("Falta Insertar Id", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Cuenta eliminada", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbId.Text = "";
                    txtBNickname.Text = "";
                    txtbPassword.Text = "";
                    txtbSalt.Text = "";
                    txtbSecurityLevel.Text = "";
                    txtbUsername.Text = "";
                    while (MyReader2.Read())
                    {

                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //string MyConnection2 = "server=198.50.218.64;port=3306;username=gmcmd;password=gmcmd";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update s4auth.accounts set Id='" + txtbId.Text  + "',Nickname='" + txtBNickname.Text + "' where Id='" + txtbId.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                //if (txtbId.Text == "")
                //{
                //    MessageBox.Show("Inserta Id para enviar el item", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //if (txtbUsername.Text == "")
                //{
                //    MessageBox.Show("Falta Insertar Username", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                if (txtBNickname.Text == "")
                {
                    MessageBox.Show("Falta Insertar Nickname", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //else if (txtbPassword.Text == "")
                //{
                //    MessageBox.Show("Falta Insertar Password", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (txtbSalt.Text == "")
                //{
                //    MessageBox.Show("Falta Insertar Salt", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (txtbSecurityLevel.Text == "")
                //{
                //    MessageBox.Show("Falta Insertar SecurityLevel", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                else
                {
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Nick Actualizado", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbId.Text = "";
                    txtbPassword.Text = "";
                    txtbSalt.Text = "";
                    txtbSecurityLevel.Text = "";
                    txtbUsername.Text = "";
                    while (MyReader2.Read())
                    {

                    }
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();//Connection closed here
            }
        }

        private void btnGPw_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string Query = "SELECT * FROM s4auth.accounts WHERE Nickname='" + txtBNickname.Text + "';";
                cmd = new MySqlCommand(Query, con);
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    txtbId.Text = mdr.GetString("Id");
                    txtbUsername.Text = mdr.GetString("Username");
                    txtbPassword.Text = mdr.GetString("Password");
                    txtbSalt.Text = mdr.GetString("Salt");
                    txtbSecurityLevel.Text = mdr.GetString("SecurityLevel");
                }
                else if (txtBNickname.Text == "")
                {
                    MessageBox.Show("Falta Insertar Nickname", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nickname No Existe", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //string MyConnection2 = "server=198.50.218.64;port=3306;username=gmcmd;password=gmcmd";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update s4auth.accounts set Id='" + txtbId.Text + "',Password='" + txtbPassword.Text + "',Salt='" + txtbSalt.Text + "' where Id='" + txtbId.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                //if (txtbId.Text == "")
                //{
                //    MessageBox.Show("Inserta Id para enviar el item", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //if (txtbUsername.Text == "")
                //{
                //    MessageBox.Show("Falta Insertar Username", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (txtBNickname.Text == "")
                //{
                //    MessageBox.Show("Falta Insertar Nickname", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                if (txtbPassword.Text == "")
                {
                    MessageBox.Show("Falta Insertar Password", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtbSalt.Text == "")
                {
                    MessageBox.Show("Falta Insertar Salt", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //else if (txtbSecurityLevel.Text == "")
                //{
                //    MessageBox.Show("Falta Insertar SecurityLevel", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                else
                {
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Password Actualizado", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbId.Text = "";
                    txtbPassword.Text = "";
                    txtbSalt.Text = "";
                    txtbSecurityLevel.Text = "";
                    txtbUsername.Text = "";
                    while (MyReader2.Read())
                    {

                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();//Connection closed here
            }
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //string MyConnection2 = "server=198.50.218.64;port=3306;username=gmcmd;password=gmcmd";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update s4auth.accounts set Id='" + txtbId.Text + "',SecurityLevel='" + txtbSecurityLevel.Text + "' where Id='" + txtbId.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                //if (txtbId.Text == "")
                //{
                //    MessageBox.Show("Inserta Id para enviar el item", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //if (txtbUsername.Text == "")
                //{
                //    MessageBox.Show("Falta Insertar Username", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (txtBNickname.Text == "")
                //{
                //    MessageBox.Show("Falta Insertar Nickname", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //if (txtbPassword.Text == "")
                //{
                //    MessageBox.Show("Falta Insertar Password", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (txtbSalt.Text == "")
                //{
                //    MessageBox.Show("Falta Insertar Salt", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                if (txtbSecurityLevel.Text == "")
                {
                    MessageBox.Show("Falta Insertar SecurityLevel", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("SecurityLevel Actualizado", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbId.Text = "";
                    txtbPassword.Text = "";
                    txtbSalt.Text = "";
                    txtbSecurityLevel.Text = "";
                    txtbUsername.Text = "";
                    while (MyReader2.Read())
                    {

                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();//Connection closed here
            }
        }
    }
}
