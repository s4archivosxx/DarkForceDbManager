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
    public partial class DBPlayer : Form
    {
        string MyConnection2 = "server=158.69.101.201;port=3306;username=s4new;password=s4new";
        //string MyConnection2 = "server=localhost;port=3306;username=root;password=admin";{
        IniFile inifile = new IniFile("App.ini");
        IniFile iniLog = new IniFile("Log.ini");

        private MySqlConnection con = new MySqlConnection("server=158.69.101.201;port=3306;username=s4new;password=s4new");
        private MySqlCommand cmd;
        private MySqlDataReader mdr;

        public DBPlayer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                MessageBox.Show("Inserta AccountId para enviar el PEN", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            #region Restrictions
            //else if (IdTextBox.Text == "3")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [ADMIN]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1254")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [ADMIN]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "18")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "839")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "78")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "82")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "838")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "550")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "557")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "578")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "971")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1001")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1278")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1620")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1694")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "780")
            //{
            //    MessageBox.Show("No puedes enviar PEN a este usuario", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "2126")
            //{
            //    MessageBox.Show("No puedes enviar PEN a este usuario", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "2127")
            //{
            //    MessageBox.Show("No puedes enviar PEN a este usuario", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1350")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1474")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "5934")
            //{
            //    MessageBox.Show("No puedes editar el PEN de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (SemesterTextBox.Text == "")
            //{
            //    MessageBox.Show("Falta Insertar el PEN", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (SemesterTextBox.Text == "")
            //{
            //    MessageBox.Show("Falta Insertar el PEN", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            #endregion

            try
            {
                string Query = "update s4game.players set Id='" + IdTextBox.Text + "',PEN='" + SemesterTextBox.Text + "' where Id='" + IdTextBox.Text + "';";

                cmd = new MySqlCommand(Query, con);

                con.Open();
                mdr = cmd.ExecuteReader();
                while (mdr.Read()) { }
                con.Close();

                MessageBox.Show($"[PEN ACTUALIZADO]\nA: {IdTextBox.Text}\nCantidad: {SemesterTextBox.Text}", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewLogPenSent();

                #region OldAppLog
                    //FileStream fs = null;
                    //Directory.CreateDirectory("Logs");
                    //using (fs = File.Create(".\\Logs\\Log_SentPen_" + IdTextBox.Text + ".log"))
                    //    {

                    //    }
                    //    using (StreamWriter rw = new StreamWriter(".\\Logs\\Log_SentPen_" + IdTextBox.Text + ".log"))
                    //    {
                    //        rw.Write("=================AppGM=================\n\n============================================\n");
                    //        rw.Write("==============DBPlayer==================\n");
                    //        rw.Write("AccountId: " + IdTextBox.Text + "\n");
                    //        rw.Write("PEN: " + SemesterTextBox.Text + "\n");
                    //        rw.Write("Fecha Y Hora: " + DateTime.Now + "\n");
                    //        rw.Write("Enviado Correctamente\n");
                    //        rw.Write("============================================");
                    //        rw.Write("\n");
                    //    }
                    #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NewLogPenSent()
        {
            iniLog.Write("AccountId", IdTextBox.Text, "PEN_SENT_" + IdTextBox.Text);
            iniLog.Write("PEN", SemesterTextBox.Text, "PEN_SENT_" + IdTextBox.Text);
            iniLog.Write("Fecha/Hora", DateTime.Now.ToString(), "PEN_SENT_" + IdTextBox.Text);
            iniLog.Write("Envío", bool.TrueString, "PEN_SENT_" + IdTextBox.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                MessageBox.Show("Inserta AccountId para enviar AP", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtboxAP.Text == "")
            {
                MessageBox.Show("Falta Insertar el AP", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string Query = "update s4game.players set Id='" + IdTextBox.Text + "',AP='" + txtboxAP.Text + "' where Id='" + IdTextBox.Text + "';";

                cmd = new MySqlCommand(Query, con);

                con.Open();
                mdr = cmd.ExecuteReader();
                while (mdr.Read()) { }
                con.Close();
                MessageBox.Show($"[AP ENVIADO]\nA: {IdTextBox.Text}\nCantidad: {txtboxAP.Text}", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewLogAPSent();

                #region OldLog
                //FileStream fs = null;
                //using (fs = File.Create(".\\Logs\\Log_SendAp_" + IdTextBox.Text + ".log"))
                //{

                //}
                //using (StreamWriter rw = new StreamWriter(".\\Logs\\Log_SendAp_" + IdTextBox.Text + ".log"))
                //{
                //    rw.Write("=================AppGM=================\n\n============================================\n");
                //    rw.Write("==============DBPlayer==================\n");
                //    rw.Write("AccountId: " + IdTextBox.Text + "\n");
                //    rw.Write("AP: " + txtboxAP.Text + "\n");
                //    rw.Write("Fecha Y Hora: " + DateTime.Now + "\n");
                //    rw.Write("Enviado Correctamente\n");
                //    rw.Write("============================================");
                //    rw.Write("\n");
                //}
                #endregion
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NewLogAPSent()
        {
            iniLog.Write("AccountId", IdTextBox.Text, "AP_SENT_" + IdTextBox.Text);
            iniLog.Write("AP", txtboxAP.Text, "AP_SENT_" + IdTextBox.Text);
            iniLog.Write("Fecha/Hora", DateTime.Now.ToString(), "AP_SENT_" + IdTextBox.Text);
            iniLog.Write("Envío", bool.TrueString, "AP_SENT_" + IdTextBox.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from s4game.players where Id='" + IdTextBox.Text + "';";
                cmd = new MySqlCommand(Query, con);

                con.Open();
                mdr = cmd.ExecuteReader();
                while (mdr.Read()) { }
                con.Close();
                MessageBox.Show("[USER ELIMINADO]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            #region Comments
            //string MyConnection2 = "server=198.50.218.64;port=3306;username=gmcmd;password=gmcmd";
            //string Query = "select * from s4game.players;";
            //MySqlConnection con2 = new MySqlConnection(MyConnection2);
            //MySqlCommand cmd = new MySqlCommand(Query, con2);

            //MySqlDataAdapter Adapter = new MySqlDataAdapter();
            //Adapter.SelectCommand = cmd;
            //DataTable dtable = new DataTable();
            //Adapter.Fill(dtable);
            //dataGridView1.DataSource = dtable;
            #endregion
            Hide();
            DBGeneral DBG = new DBGeneral();
            DBG.ShowDialog();
        }

        private void DBPlayer_Load(object sender, EventArgs e)
        {
            #region ReadTable
            //string MyConnection2 = "server=198.50.218.64;port=3306;username=gmcmd;password=gmcmd";
            //string Query = "select * from s4game.players;";
            //MySqlConnection con2 = new MySqlConnection(MyConnection2);
            //MySqlCommand cmd = new MySqlCommand(Query, con2);

            //MySqlDataAdapter Adapter = new MySqlDataAdapter();
            //Adapter.SelectCommand = cmd;
            //DataTable dtable = new DataTable();
            //Adapter.Fill(dtable);
            //dataGridView1.DataSource = dtable;
            #endregion
        }

        private void btnUpLevel_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                MessageBox.Show("Falta Insertar AccountId", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmblvl.Text == "")
            {
                MessageBox.Show("Falta Insertar Lvl", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbTX.Text == "")
            {
                MessageBox.Show("Falta Insertar TotalExperience", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            #region Restrictions
            //else if (IdTextBox.Text == "3")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [ADMIN]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1254")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [ADMIN]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "18")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "839")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "78")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "82")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "838")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "550")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "557")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "578")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "971")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1001")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1278")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1620")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1694")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "780")
            //{
            //    MessageBox.Show("No puedes editar el LVL de este usuario", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1350")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "2127")
            //{
            //    MessageBox.Show("No puedes editar el LVL de este usuario", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "2126")
            //{
            //    MessageBox.Show("No puedes editar el LVL de este usuario", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (cmblvl.Text == "")
            //{
            //    MessageBox.Show("Falta Insertar Lvl", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (cmbTX.Text == "")
            //{
            //    MessageBox.Show("Falta Insertar TotalExperience", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "1474")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (IdTextBox.Text == "5934")
            //{
            //    MessageBox.Show("No puedes editar el LVL de un [GM]", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (cmbTX.Text == "63703100")
            //{
            //    MessageBox.Show("No es posible enviar esa EXP", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (cmbTX.Text == "")
            //{
            //    MessageBox.Show("Falta Insertar TotalExperience", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            #endregion

            try
            {
               string Query = "UPDATE s4game.players SET Id='" + IdTextBox.Text + "',Level='" + cmblvl.Text + "',TotalExperience='" + cmbTX.Text + "' WHERE Id='" + IdTextBox.Text + "';";
               cmd = new MySqlCommand(Query, con);
               
               con.Open();
               mdr = cmd.ExecuteReader();
               MessageBox.Show("LVL EDITADO", "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Information);
               if (mdr.Read()) {}
               con.Close();
               NewLogUpLevel();
               
               #region OldLog
                    //FileStream fs = null;
                    //if (!Directory.Exists("Logs"))
                    //{
                    //    Directory.CreateDirectory("Logs");
                    //    using (fs = File.Create(".\\Logs\\Log_EditLvl_" + IdTextBox.Text + ".log"))
                    //    {

                    //    }
                    //    using (StreamWriter rw = new StreamWriter(".\\Logs\\Log_EditLvl_" + IdTextBox.Text + ".log"))
                    //    {
                    //        rw.Write("=================AppGM=================\n\n============================================\n");
                    //        rw.Write("==============DBPlayer==================\n");
                    //        rw.Write("AccountId: " + IdTextBox.Text + "\n");
                    //        rw.Write("Lvl: " + cmblvl.Text + "\n");
                    //        rw.Write("TotalExperience: " + cmbTX.Text + "\n");
                    //        rw.Write("Fecha Y Hora: " + DateTime.Today + "\n");
                    //        rw.Write("Editado Correctamente\n");
                    //        rw.Write("============================================");
                    //        rw.Write("\n");
                    //    }
                    //}
                    #endregion
               
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "S4League Dark Force", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NewLogUpLevel()
        {
            iniLog.Write("AccountId", IdTextBox.Text, "EDIT_LVL_" + IdTextBox.Text);
            iniLog.Write("Lvl", cmblvl.Text, "EDIT_LVL_" + IdTextBox.Text);
            iniLog.Write("TotalExperience", cmbTX.Text, "EDIT_LVL_" + IdTextBox.Text);
            iniLog.Write("Fecha/Hora", DateTime.Now.ToString(), "EDIT_LVL_" + IdTextBox.Text);
            iniLog.Write("Updated", bool.TrueString, "EDIT_LVL_" + IdTextBox.Text);
        }
    }
}
