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

namespace LoginApp
{
    public partial class DBConection : Form
    {
        IniFile inifile = new IniFile("App.ini");
        MySqlConnection con = new MySqlConnection("server=158.69.101.201;port=3306;username=s4new;password=s4new");
        //MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=admin");
        public DBConection()
        {
            InitializeComponent();
            //PassTextBox.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //int pass2 = 1478;
            //string user = "usergm";
            //string pass = "Appgm";

            //if (user == UserTextBox.Text && pass == PassTextBox.Text)
            //{
            //    Hide();
            //    DBGeneral DBG = new DBGeneral();
            //    DBG.ShowDialog();
            //    con.Close();
            //    Close();

            //}
            //else
            //{
            //    MessageBox.Show("User and PW is incorrect");
            //}
            if (CBSaveDatos.Checked == true)
            {
                inifile.Write("User", UserTextBox.Text, "CONFIG");
                inifile.Write("Password", PassTextBox.Text, "CONFIG");
                inifile.Write("GuardarDatos", bool.TrueString, "CONFIG");
            }
            //}
            //else
            //{
            //    MessageBox.Show("User and PW is incorrect");
            //}
            try
            {
                //string MyConnection = "datasource=localhost;port=3307;username=root;password=root";
                //MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand("SELECT * FROM s4auth.accounts WHERE Username='" + UserTextBox.Text + "' AND Email='" + PassTextBox.Text + "' ;", con);
                MySqlDataReader MyReader;
                //MyReader = MyCommand.ExecuteReader();

                con.Open();
                MyReader = MyCommand.ExecuteReader();
                int count = 0;

                while (MyReader.Read())
                {
                    lbl.Text = MyReader.GetString("SecurityLevel");
                    Console.WriteLine(MyReader[count]);
                    count++;
                }
                //else if (count > 1)
                //{

                //    MessageBox.Show("Duplicate Username and passwor.\nAccess denied.");
                //}

                if (int.Parse(lbl.Text) > 1)
                {
                    //MessageBox.Show("Username and password is correct", "Data Base Conection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    DBGeneral dbgeneral = new DBGeneral();
                    dbgeneral.ShowDialog();
                    Close();
                }
                else if (count <= 0)
                {
                    MessageBox.Show("Username and password is incorrect", "Data Base Conection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Hide();
                    //DBConection DB = new DBConection();
                    //DB.ShowDialog();
                    //Close();
                }
                else
                {
                    MessageBox.Show("La Cuenta ingresada no tiene permisos de GameMaster.", "Data Base Conection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Close();
                }

                con.Close();

            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
                MessageBox.Show("El usuario o contraseña es incorrecto.\n" + ex.Message, "Data Base Conection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void StartProgram()
        {
            try
            {
                string savedata = inifile.Read("GuardarDatos", "CONFIG");
                string user = inifile.Read("User", "CONFIG");
                string pass = inifile.Read("Password", "CONFIG");
                if (savedata == bool.TrueString)
                {
                    UserTextBox.Text = user;
                    PassTextBox.Text = pass;
                }
                else
                {
                    inifile.Write("User", "", "CONFIG");
                    inifile.Write("Password", "", "CONFIG");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Data Base Conection", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void DBConection_Load(object sender, EventArgs e)
        {
            //UpdaterAppGM.CheckForUpdates();
            StartProgram();
        }
    }
}
