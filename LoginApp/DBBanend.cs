using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace LoginApp
{
    public partial class DBBanend : Form
    {
        string MyConnection2 = "server=158.69.101.201;port=3306;username=s4new;password=s4new";
        IniFile iniLog = new IniFile("Log.ini");

        public DBBanend()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //string MyConnection2 = "server=localhost;port=3306;username=root;password=admin";
            //string Query = "select * from s4auth.bans;";
            //MySqlConnection con2 = new MySqlConnection(MyConnection2);
            //MySqlCommand cmd = new MySqlCommand(Query, con2);

            //MySqlDataAdapter Adapter = new MySqlDataAdapter();
            //Adapter.SelectCommand = cmd;
            //DataTable dtable = new DataTable();
            //Adapter.Fill(dtable);
            //dataGridView1.DataSource = dtable;
            Hide();
            DBGeneral DBG = new DBGeneral();
            DBG.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //string MyConnection2 = "server=localhost;port=3306;username=root;password=admin";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into s4auth.bans(Id,AccountId,Date,Duration,Reason) values('" + "" + "','" + NameTextBox.Text + "','" + "1500239182" + "','" + "1500239292" + "','" + "0" + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                if (NameTextBox.Text == "")
                {
                    MessageBox.Show("Inserta AccountId para Banear", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #region Restrictions
                //else if (NameTextBox.Text == "3")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [ADMIN]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "1254")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [ADMIN]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "18")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "839")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "78")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "82")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "34")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "838")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "550")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "557")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "578")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "971")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "1001")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "1278")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "1620")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "1694")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "1474")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "1350")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "5934")
                //{
                //    MessageBox.Show("No Puedes banear una Cuenta [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                #endregion
                else
                {
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("USER BANEADO", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (MyReader2.Read())
                    {

                    }
                    NewLogBannendAccount();
                    #region OldLog
                    //FileStream fs = null;
                    //if (!Directory.Exists("Logs"))
                    //{
                    //    Directory.CreateDirectory("Logs");
                    //    using (fs = File.Create(".\\Logs\\Log_Bans_" + NameTextBox.Text + ".log"))
                    //    {

                    //    }
                    //    using (StreamWriter rw = new StreamWriter(".\\Logs\\Log_Bans_" + NameTextBox.Text + ".log"))
                    //    {
                    //        rw.Write("=================AppGM=================\n\n============================================\n");
                    //        rw.Write("==============DBBanend==================\n");
                    //        rw.Write("AccountId: " + NameTextBox.Text + "\n");
                    //        rw.Write("Fecha Y Hora: " + DateTime.Now + "\n");
                    //        rw.Write("Bloqueado Correctamente\n");
                    //        rw.Write("============================================");
                    //        rw.Write("\n");
                    //    }
                    //}
                    #endregion
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void NewLogBannendAccount()
        {
            iniLog.Write("AccountId", NameTextBox.Text, "BAN_" + NameTextBox.Text);
            iniLog.Write("Fecha/Hora", DateTime.Now.ToString(), "BAN_" + NameTextBox.Text);
            iniLog.Write("Blocked", bool.TrueString, "BAN_" + NameTextBox.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                //string MyConnection2 = "server=localhost;port=3306;username=root;password=admin";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update s4auth.bans set AccountId='" + NameTextBox.Text + "' where AccountId='" + NameTextBox.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                
                if (NameTextBox.Text == "")
                {
                    MessageBox.Show("Inserta AccountId para Actualizar el Bloqueo", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("BAN ACTUALIZADO", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (MyReader2.Read())
                    {

                    }
                }
                MyConn2.Close();//Connection closed here
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //string MyConnection2 = "server=localhost;port=3306;username=root;password=admin";
                string Query = "delete from s4auth.bans where AccountId='" + NameTextBox.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();

                if (NameTextBox.Text == "")
                {
                    MessageBox.Show("Inserta Id para Eliminar Banned", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //else if (NameTextBox.Text == "1278")
                //{
                //    MessageBox.Show("No puedes eliminar esta cuenta baneada", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (NameTextBox.Text == "780")
                //{
                //    MessageBox.Show("No puedes eliminar esta cuenta baneada", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                else
                {
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("BAN ELIMINADO", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (MyReader2.Read())
                    {

                    }
                    NewLogDeleteBlock();
                    #region OldLog
                    //FileStream fs = null;
                    //if (!Directory.Exists("Logs"))
                    //{
                    //    Directory.CreateDirectory("Logs");
                    //    using (fs = File.Create(".\\Logs\\Log_DeleteBan_" + NameTextBox.Text + ".log"))
                    //    {

                    //    }
                    //    using (StreamWriter rw = new StreamWriter(".\\Logs\\Log_DeleteBan_" + NameTextBox.Text + ".log"))
                    //    {
                    //        rw.Write("=================AppGM=================\n\n============================================\n");
                    //        rw.Write("==============DBBanend==================\n");
                    //        rw.Write("AccountId: " + NameTextBox.Text + "\n");
                    //        rw.Write("Fecha Y Hora: " + DateTime.Now + "\n");
                    //        rw.Write("Eliminado Correctamente\n");
                    //        rw.Write("============================================");
                    //        rw.Write("\n");
                    //    }
                    //}
                    #endregion
                }

                MyConn2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void NewLogDeleteBlock()
        {
            iniLog.Write("AccountId", NameTextBox.Text, "DELETE_BAN_" + NameTextBox.Text);
            iniLog.Write("Fecha/Hora", DateTime.Now.ToString(), "DELETE_BAN_" + NameTextBox.Text);
            iniLog.Write("Delete", bool.TrueString, "DELETE_BAN_" + NameTextBox.Text);
        }

        private void DBBanend_Load(object sender, EventArgs e)
        {
            //string MyConnection2 = "server=localhost;port=3306;username=root;password=admin";
            //string Query = "select * from s4auth.bans;";
            //MySqlConnection con2 = new MySqlConnection(MyConnection2);
            //MySqlCommand cmd = new MySqlCommand(Query, con2);

            //MySqlDataAdapter Adapter = new MySqlDataAdapter();
            //Adapter.SelectCommand = cmd;
            //DataTable dtable = new DataTable();
            //Adapter.Fill(dtable);
            //dataGridView1.DataSource = dtable;
        }
    }
}
