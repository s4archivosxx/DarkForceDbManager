using System;
using System.Windows.Forms;
using System.Drawing;
using LogMJ.Net;
using LogMJ.Ini;
using DatabaseS4L;
using DatabaseS4L.Game;
using System.Threading.Tasks;
using System.Xml.Linq;
using DatabaseS4L.Contants;
using DatabaseS4L.Attributes;
using System.Speech.Recognition;

namespace SearchData
{
    public partial class MainForm : Form
    {
        private Point point;
        private bool mauseaction;
        private NLog Logger { get; set; }
        private IniFile IniFile { get; set; }
        private ActionsDb GetActionsDb { get; set; }
        private Constants GetConstants { get; set; }

        public MainForm()
        {
            InitializeComponent();
            ConfigObjects();
            ConfigEvents();
            // ConfigUser();
            ChargeConfigAsync(null, null);
        }

        private void ConfigObjects()
        {
            NLog.Initializate("NLogger.log");
            Logger = NLog.Logger.SetSourceContext("SEARCH-DB");
            IniFile = new IniFile("Config.dat");
            GetActionsDb = new ActionsDb(IniFile.Read("MysqlS", "CONFIG"));
            GetConstants = new Constants();
        }

        private void ConfigEvents()
        {
            AboutHelpMenuStrip.Click += AboutHelpMenuStripClick;
            SearchAccount.Click += SearchAccountClickAsync;
            ShowDataAccount.Click += ShowDataAccountClickAsync;
            SearchEffect.Click += SearchEffectClickAsync;
            SearchItemToolS.Click += SearchItemClickAsync;
            SearchPrice.Click += SearchPriceClick;
            UpdateItemTool.Click += UpdateItemToolClickAsync;
            SearchPlayerItemToolS2.Click += SearchPlayerItemClick;
            SendLevelToolS.Click += SendLevelToolSClickAsync;
            SendPenToolS.Click += SendPenToolSClickAsync;
            SendApToolS.Click += SendApToolSClickAsync;
            RestPenToolS.Click += RestPenToolSClickAsync;
            RestApToolS.Click += RestApToolSClickAsync;
            DeleteItemToolS.Click += DeleteItemToolSClickAsync;
            SearchStateAccountTS.Click += SearchStateAccountTSClickAsync;
            TxtbLvl.KeyPress += DetectNumberInKeyPress;
            TxtbColor.KeyPress += DetectNumberInKeyPress;
            TxtbCount.KeyPress += DetectNumberInKeyPress;
            TxtbEffG.KeyPress += DetectNumberInKeyPress;
            TxtbId.KeyPress += DetectNumberInKeyPress;
            TxtbShopItemId.KeyPress += DetectNumberInKeyPress;
            TxtbItemId.KeyPress += DetectNumberInKeyPress;
            TxtbPriceG.KeyPress += DetectNumberInKeyPress;
            SendItem.Click += SendItemClickAsync;
            ChargeConfigToolStrip.Click += ChargeConfigAsync;
            ResetDataUserTS.Click += ResetDataUserTSClickAsync;
        }

        [DataBaseActions(DataBase.None, DataBaseAction.LoadConfig)]
        private async void ChargeConfigAsync(object sender, EventArgs e) => await Task.Run(() => { ReadConfig(); });

        private void ConfigUser()
        {
            try
            {
                string[] users = new string[20];
                bool access = false;
                byte usersj = 0;
                var xml = XDocument.Load("http://localhost/XmlConfig/ConfigUsers.xml");

                foreach (var i in xml.Descendants("UserDto"))
                {
                    string name = i.Attribute("Name").Value;
                    string version = i.Attribute("Version").Value;

                    while (!access && users.Length > usersj)
                    {
                        users = name.Split(',');

                        if (users[usersj].ToUpper().Equals(Environment.MachineName.ToUpper() + "-" + Environment.ProcessorCount))
                            access = true;
                        usersj++;
                    }

                    if (!access)
                    {
                        Logger.Message("No tiene licencia para utilizar este programa.");
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WarnMsg(ex.Message);
                Environment.Exit(0);
            }
        }

        [DataBaseActions(DataBase.None, DataBaseAction.LoadConfig)]
        private void ReadConfig()
        {
            TxtbId.Text = IniFile.Read("Id", "CONFIG");
            TxtbNickname.Text = IniFile.Read("Nickname", "CONFIG");
        }

        [DataBaseActions(DataBase.None, DataBaseAction.DeleteAP)]
        private async void RestApToolSClickAsync(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbAccountId))
            {
                GetConstants.SetControlColor(TxtbNickname, Color.Red, Color.White);
                return;
            }

            if (!TxtbAp.Enabled)
            {
                var msg = Logger.MessageDialog("¿Desea restar el AP a {0}?", Nickname);
                if (msg == DialogResult.Yes)
                {
                    GetConstants.SetControlEnabled(TxtbAp, true);
                    TxtbAp.Text = "0";
                }
                return;
            }

            if (GetConstants.DetectNull(TxtbAp))
            {
                GetConstants.SetControlColor(TxtbAp, Color.Red, Color.White);
                return;
            }

            var ap = uint.Parse(LabelUserAP.Text) - AP;
            await GetActionsDb.UpdatePlayerAPAsync(ulong.Parse(TxtbAccountId.Text), ap);
            Logger.InfoMsg("Se restó correctamente el AP a {0}", Nickname);
            GetConstants.SetControlEnabled(TxtbAp, false);
            GetConstants.SetControlColor(TxtbAp, Color.White, Color.Black);
            ShowDataAccountClickAsync(null, null);
        }

        [DataBaseActions(DataBase.None, DataBaseAction.DeletePEN)]
        private async void RestPenToolSClickAsync(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbAccountId))
            {
                GetConstants.SetControlColor(TxtbNickname, Color.Red, Color.White);
                return;
            }

            if (!TxtbPen.Enabled)
            {
                var msg = Logger.MessageDialog("¿Desea restar el PEN a {0}?", Nickname);
                if (msg == DialogResult.Yes)
                {
                    GetConstants.SetControlEnabled(TxtbPen, true);
                    TxtbPen.Text = "0";
                }
                return;
            }

            if (GetConstants.DetectNull(TxtbPen))
            {
                GetConstants.SetControlColor(TxtbPen, Color.Red, Color.White);
                return;
            }

            var pen = uint.Parse(LabelUserPEN.Text) - PEN;
            await GetActionsDb.UpdatePlayerPENAsync(ulong.Parse(TxtbAccountId.Text), pen);
            Logger.InfoMsg("Se restó correctamente el PEN a {0}", Nickname);
            GetConstants.SetControlEnabled(TxtbPen, false);
            GetConstants.SetControlColor(TxtbPen, Color.White, Color.Black);
            ShowDataAccountClickAsync(null, null);
        }

        [DataBaseActions(DataBase.None, DataBaseAction.ShowStateAccount)]
        private async void SearchStateAccountTSClickAsync(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbAccountId))
            {
                GetConstants.SetControlColor(TxtbNickname, Color.Red, Color.White);
                return;
            }

            var ban = await GetActionsDb.GetBanAsync(ulong.Parse(TxtbAccountId.Text));
            if (ban != null)
                LabelStateAcc.Visible = true;
            else
                LabelStateAcc.Visible = false;

            Logger.InfoMsg("El jugador {0} {1} bloqueado", Nickname, (ban == null ? "no fue" : "está"));
        }

        [DataBaseActions(DataBase.None, DataBaseAction.DeleteItem)]
        private async void DeleteItemToolSClickAsync(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbId))
            {
                GetConstants.SetControlColor(TxtbId, Color.Red, Color.White);
                return;
            }

            if (GetConstants.DetectNull(TxtbAccountId))
            {
                GetConstants.SetControlColor(TxtbNickname, Color.Red, Color.White);
                return;
            }

            var msg = Logger.MessageDialog("¿Está seguro de eliminar el item?");
            if (msg == DialogResult.Yes)
            {
                await GetActionsDb.RemoveItemAsync(int.Parse(TxtbId.Text));
                Logger.DebugMsg("Se eliminó el item[{0}] del jugador {1} correctamente", ItemId, Nickname);
                msg = Logger.MessageDialog("¿Desea restablecer los valores?");
                if (msg == DialogResult.Yes)
                {
                    ResetValuesS();
                    ChargeConfigAsync(null, null);
                }
            }
        }

        [DataBaseActions(DataBase.None, DataBaseAction.SendAP)]
        private async void SendApToolSClickAsync(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbAccountId))
            {
                GetConstants.SetControlColor(TxtbNickname, Color.Red, Color.White);
                return;
            }

            if (!TxtbAp.Enabled)
            {
                var msg = Logger.MessageDialog("¿Desea enviar AP a {0}?", Nickname);
                if (msg == DialogResult.Yes)
                {
                    GetConstants.SetControlEnabled(TxtbAp, true);
                    TxtbAp.Text = "0";
                }
                return;
            }

            if (GetConstants.DetectNull(TxtbAp))
            {
                GetConstants.SetControlColor(TxtbAp, Color.Red, Color.White);
                return;
            }

            var ap = uint.Parse(LabelUserAP.Text) + AP;
            await GetActionsDb.UpdatePlayerAPAsync(ulong.Parse(TxtbAccountId.Text), ap);
            Logger.InfoMsg("Se envió correctamente el AP a {0}", Nickname);
            GetConstants.SetControlEnabled(TxtbAp, false);
            GetConstants.SetControlColor(TxtbAp, Color.White, Color.Black);
            ShowDataAccountClickAsync(null, null);
        }

        [DataBaseActions(DataBase.None, DataBaseAction.SendPEN)]
        private async void SendPenToolSClickAsync(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbAccountId))
            {
                GetConstants.SetControlColor(TxtbNickname, Color.Red, Color.White);
                return;
            }

            if (!TxtbPen.Enabled)
            {
                var msg = Logger.MessageDialog("¿Desea enviar PEN a {0}?", Nickname);
                if (msg == DialogResult.Yes)
                {
                    GetConstants.SetControlEnabled(TxtbPen, true);
                    TxtbPen.Text = "0";
                }
                return;
            }

            if (GetConstants.DetectNull(TxtbPen))
            {
                GetConstants.SetControlColor(TxtbPen, Color.Red, Color.White);
                return;
            }

            var pen = uint.Parse(LabelUserPEN.Text) + PEN;
            await GetActionsDb.UpdatePlayerPENAsync(ulong.Parse(TxtbAccountId.Text), pen);
            Logger.InfoMsg("Se envió correctamente el PEN a {0}", Nickname);
            GetConstants.SetControlEnabled(TxtbPen, false);
            GetConstants.SetControlColor(TxtbPen, Color.White, Color.Black);
            ShowDataAccountClickAsync(null, null);
        }

        [DataBaseActions(DataBase.None, DataBaseAction.SendLvl)]
        private async void SendLevelToolSClickAsync(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbAccountId))
            {
                GetConstants.SetControlColor(TxtbNickname, Color.Red, Color.White);
                return;
            }

            if (!TxtbLvl.Enabled)
            {
                var msg = Logger.MessageDialog("¿Desea actualizar el nivel de {0}?", Nickname);
                if (msg == DialogResult.Yes) { GetConstants.SetControlEnabled(TxtbLvl, true); return; }
                return;
            }

            if (GetConstants.DetectNull(TxtbLvl))
            {
                GetConstants.SetControlColor(TxtbLvl, Color.Red, Color.White);
                return;
            }

            var exp = uint.Parse(IniFile.Read($"LEVEL_{TxtbLvl.Text}", "EXPERIENCE"));

            var plr = new PlayerDto
            {
                Id = int.Parse(TxtbAccountId.Text),
                Level = byte.Parse(TxtbLvl.Text),
                TotalExperience = exp
            };

            await GetActionsDb.UpdatePlayerLvlAsync(plr);
            Logger.InfoMsg("Se ha actualizado correctamente el nivel de {0}", Nickname);
            GetConstants.SetControlEnabled(TxtbLvl, false);
        }

        [DataBaseActions(DataBase.None, DataBaseAction.SearchPlayer)]
        private void SearchPlayerItemClick(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbAccountId))
            {
                GetConstants.SetControlColor(TxtbNickname, Color.Red, Color.White);
                return;
            }

            if (GetConstants.DetectNull(TxtbShopItemId) || GetConstants.DetectNull(TxtbItemId))
            {
                GetConstants.SetControlColor(TxtbShopItemId, Color.Red, Color.White);
                return;
            }

            try
            {
                var item = GetActionsDb.GetPlayerItem(ulong.Parse(TxtbAccountId.Text), int.Parse(TxtbItemId.Text));
                TxtbId.Text = item?.Id.ToString() ?? TxtbId.Text;
                TxtbEnchantMP.Text = item?.EnchantMP.ToString() ?? TxtbEnchantMP.Text;
                TxtbEnchantLvl.Text = item?.EnchantLvl.ToString() ?? TxtbEnchantLvl.Text;
            }
            catch (Exception ex)
            {
                Logger.WarnMsg(ex.Message);
            }
        }

        [DataBaseActions(DataBase.None, DataBaseAction.UpdateItem)]
        private async void UpdateItemToolClickAsync(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbAccountId))
            {
                GetConstants.SetControlColor(TxtbNickname, Color.Red, Color.White);
                return;
            }

            if (GetConstants.DetectNull(TxtbShopItemId) || GetConstants.DetectNull(TxtbItemId))
            {
                GetConstants.SetControlColor(TxtbShopItemId, Color.Red, Color.White);
                return;
            }

            if (GetConstants.DetectNull(TxtbEffG))
            {
                GetConstants.SetControlColor(TxtbEffG, Color.Red, Color.White);
                return;
            }

            if (GetConstants.DetectNull(TxtbPriceG) || GetConstants.DetectEquality(LabelShopPriceId.Text, "ShopPriceId") 
                || GetConstants.DetectEquality(LabelDurability.Text, "Durability") || GetConstants.DetectNull(LabelShopPriceId)
                || GetConstants.DetectNull(LabelDurability))
            {
                GetConstants.SetControlColor(TxtbPriceG, Color.Red, Color.White);
                return;
            }

            if (GetConstants.DetectNull(TxtbId))
            {
                GetConstants.SetControlColor(TxtbId, Color.Red, Color.White);
                return;
            }

            try
            {
                var date = TimeSpan.FromSeconds(0);
                var dto = new PlayerItemDto
                {
                    Id = int.Parse(TxtbId.Text),
                    PlayerId = int.Parse(TxtbAccountId.Text),
                    ShopItemInfoId = int.Parse(TxtbItemId.Text),
                    ShopPriceId = int.Parse(LabelShopPriceId.Text),
                    Effects = TxtbEff.Text,
                    Durability = int.Parse(LabelDurability.Text),
                    Color = byte.Parse(TxtbColor.Text),
                    Count = int.Parse(TxtbCount.Text),
                    PurchaseDate = DateTimeOffset.Now.Add(date).ToUnixTimeSeconds()
                };

                await GetActionsDb.UpdateItemAsync(dto);
                Logger.DebugMsg("Se actualizó correctamente el item: {0} a {1}", TxtbShopItemId.Text, Nickname);
                var result = MessageBox.Show("[CONSULT]\n¿Desea restablecer los valores?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ResetValuesS();
                    ChargeConfigAsync(null, null);
                }
            }
            catch (Exception ex)
            {
                Logger.WarnMsg(ex.Message);
            }
        }

        [DataBaseActions(DataBase.None, DataBaseAction.SendItem)]
        private async void SendItemClickAsync(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbAccountId))
            {
                GetConstants.SetControlColor(TxtbNickname, Color.Red, Color.White);
                return;
            }

            if (GetConstants.DetectNull(TxtbShopItemId) || GetConstants.DetectNull(TxtbItemId))
            {
                GetConstants.SetControlColor(TxtbShopItemId, Color.Red, Color.White);
                return;
            }

            if (GetConstants.DetectNull(TxtbEffG))
            {
                GetConstants.SetControlColor(TxtbEffG, Color.Red, Color.White);
                return;
            }

            if (GetConstants.DetectNull(TxtbPriceG) || GetConstants.DetectEquality(LabelShopPriceId.Text, "ShopPriceId")
                || GetConstants.DetectEquality(LabelDurability.Text, "Durability") || GetConstants.DetectNull(LabelShopPriceId)
                || GetConstants.DetectNull(LabelDurability))
            {
                GetConstants.SetControlColor(TxtbPriceG, Color.Red, Color.White);
                return;
            }

            if (GetConstants.DetectNull(TxtbId))
            {
                GetConstants.SetControlColor(TxtbId, Color.Red, Color.White);
                return;
            }

            try
            {
                var date = TimeSpan.FromSeconds(0);
                var dto = new PlayerItemDto
                {
                    Id = int.Parse(TxtbId.Text),
                    PlayerId = int.Parse(TxtbAccountId.Text),
                    ShopItemInfoId = int.Parse(TxtbItemId.Text),
                    ShopPriceId = int.Parse(LabelShopPriceId.Text),
                    Effects = TxtbEff.Text,
                    Durability = int.Parse(LabelDurability.Text),
                    Color = byte.Parse(TxtbColor.Text),
                    Count = int.Parse(TxtbCount.Text),
                    PurchaseDate = DateTimeOffset.Now.Add(date).ToUnixTimeSeconds()
                };

                await GetActionsDb.CreateItemAsync(dto);
                ItemId++;
                IniFile.Write("Id", ItemId.ToString(), "CONFIG");
                Logger.DebugMsg("Se envió correctamente el item: {0} a {1}", TxtbShopItemId.Text, Nickname);
                var result = MessageBox.Show("[CONSULT]\n¿Desea restablecer los valores?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ResetValuesS();
                    ChargeConfigAsync(null, null);
                }
            }
            catch (Exception ex)
            {
                Logger.WarnMsg(ex.Message);
            }
        }

        [DataBaseActions(DataBase.None, DataBaseAction.SearchShopPrice)]
        private void SearchPriceClick(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbPriceG))
            {
                GetConstants.SetControlColor(TxtbPriceG, Color.Red, Color.White);
                return;
            }

            try
            {
                var shop = GetActionsDb.GetShopPriceIdAsync(int.Parse(TxtbPriceG.Text));
                LabelShopPriceId.Text = shop?.Id.ToString() ?? "0";
                LabelDurability.Text = shop?.Durability.ToString() ?? "0";
                GetConstants.SetControlColor(TxtbPriceG, Color.White, Color.Black);
            }
            catch (Exception ex)
            {
                Logger.WarnMsg(ex.Message);
            }
        }

        [DataBaseActions(DataBase.None, DataBaseAction.SearchItemById)]
        private async void SearchItemClickAsync(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbShopItemId))
            {
                GetConstants.SetControlColor(TxtbShopItemId, Color.Red, Color.White);
                return;
            }

            try
            {
                var shop = await GetActionsDb.GetItemIdAsync(ulong.Parse(TxtbShopItemId.Text));
                TxtbItemId.Text = shop?.Id.ToString() ?? "0";
                TxtbPriceG.Text = shop?.PriceGroupId.ToString() ?? "0";
                TxtbEffG.Text = shop?.EffectGroupId.ToString() ?? "14";
                SearchEffectClickAsync(null, null);
                GetConstants.SetControlColor(TxtbShopItemId, Color.White, Color.Black);
            }
            catch (Exception ex)
            {
                Logger.WarnMsg(ex.Message);
            }
        }

        [DataBaseActions(DataBase.None, DataBaseAction.SearchItemEff)]
        private void SearchEffectClickAsync(object sender, EventArgs e)
        {
            if (GetConstants.DetectNull(TxtbEffG))
            {
                GetConstants.SetControlColor(TxtbEffG, Color.Red, Color.White);
                return;
            }

            switch (int.Parse(TxtbEffG.Text))
            {
                case 14:
                    ToolTip.SetToolTip(TxtbEffG, "None");
                    TxtbEff.Text = "0";
                    break;

                case 15:
                    ToolTip.SetToolTip(TxtbEffG, "Stats PEN of Head");
                    TxtbEff.Text = "1100313002,1100315002,1100317002";
                    break;

                case 16:
                    ToolTip.SetToolTip(TxtbEffG, "Stat PEN for Face and Accesory");
                    TxtbEff.Text = "1101301006";
                    break;

                case 17:
                    ToolTip.SetToolTip(TxtbEffG, "Stat PEN for Weapons");
                    TxtbEff.Text = "1299600001";
                    break;

                case 18:
                    ToolTip.SetToolTip(TxtbEffG, "Stat PEN of Jacket");
                    TxtbEff.Text = "1102303003";
                    break;

                case 19:
                    ToolTip.SetToolTip(TxtbEffG, "Stat Attack+10%\nUsualmente para armas.");
                    TxtbEff.Text = "1299600006";
                    break;

                case 20:
                    ToolTip.SetToolTip(TxtbEffG, "Stat PEN of Pants");
                    TxtbEff.Text = "1103302004";
                    break;

                case 21:
                    ToolTip.SetToolTip(TxtbEffG, "Stat PEN for Gloves and Shoes");
                    TxtbEff.Text = "1105300004";
                    break;

                case 22:
                    ToolTip.SetToolTip(TxtbEffG, "HP+30\nUsualmente para Skill.");
                    TxtbEff.Text = "1999300011";
                    break;

                case 23:
                    ToolTip.SetToolTip(TxtbEffG, "HP+15\nUsualmente para Skill.");
                    TxtbEff.Text = "1999300009";
                    break;

                case 24:
                    ToolTip.SetToolTip(TxtbEffG, "SP+40\nUsualmente para Skill.");
                    TxtbEff.Text = "1300301012";
                    break;

                case 25:
                    ToolTip.SetToolTip(TxtbEffG, "Dual Mastery HP/SP");
                    TxtbEff.Text = "1999300010,1999301011";
                    break;

                case 26:
                    ToolTip.SetToolTip(TxtbEffG, "Unique Dual Mastery HP/SP");
                    TxtbEff.Text = "1999300012,1999301013";
                    break;

                case 27:
                    ToolTip.SetToolTip(TxtbEffG, "Stats FP of Head");
                    TxtbEff.Text = "1100313007,1100315007,1100317007,1100800001";
                    break;

                case 28:
                    ToolTip.SetToolTip(TxtbEffG, "Stats FP of Face");
                    TxtbEff.Text = "1101301008,1101800001";
                    break;

                case 29:
                    ToolTip.SetToolTip(TxtbEffG, "Stats FP of Jacket");
                    TxtbEff.Text = "1102303008,1102800001";
                    break;

                case 30:
                    ToolTip.SetToolTip(TxtbEffG, "Stats FP of Pants");
                    TxtbEff.Text = "1103302009,1103800001";
                    break;

                case 31:
                    ToolTip.SetToolTip(TxtbEffG, "Stats FP of Gloves");
                    TxtbEff.Text = "1104300008,1104800001";
                    break;

                case 32:
                    ToolTip.SetToolTip(TxtbEffG, "Stats FP of Shoes");
                    TxtbEff.Text = "1105300008,1105800001";
                    break;

                case 33:
                    ToolTip.SetToolTip(TxtbEffG, "Stats FP of Accesory");
                    TxtbEff.Text = "1106301008,1106800001";
                    break;

                case 34:
                    ToolTip.SetToolTip(TxtbEffG, "Stats FP of Pet's");
                    TxtbEff.Text = "1107301006,1107302002,1107307001,1107800000";
                    break;

                case 35:
                case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                case 43:
                case 44:
                    ToolTip.SetToolTip(TxtbEffG, "Stats FP for Weapons");
                    TxtbEff.Text = "1299600007,1299602002,1208300005,1208301005";
                    break;

                case 41:
                    ToolTip.SetToolTip(TxtbEffG, "Stats Stationary Weapon FP");
                    TxtbEff.Text = "1299600007,1299602002,1206308001,1206601001";
                    break;

                case 42:
                    ToolTip.SetToolTip(TxtbEffG, "Stats Throwing Weapon FP");
                    TxtbEff.Text = "1299600007,1299602002,1208300005,1208301005,1208613001";
                    break;

                default:
                    ToolTip.SetToolTip(TxtbEffG, "None");
                    TxtbEff.Text = "0";
                    break;
            }

            GetConstants.SetControlColor(TxtbEffG, Color.White, Color.Black);
        }

        [DataBaseActions(DataBase.Mysql, DataBaseAction.SearchAccount)]
        private async void SearchAccountClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (GetConstants.DetectNull(TxtbNickname))
                {
                    TxtbNickname.Focus();
                    return;
                }

                var account = await GetActionsDb.GetAccountAsync(TxtbNickname.Text);
                TxtbAccountId.Text = account?.Id.ToString() ?? "0";
                TxtbUser.Text = account?.Username ?? "Unk";
                IniFile.Write("Nickname", TxtbNickname.Text, "CONFIG");
                GetConstants.SetControlColor(TxtbNickname, Color.White, Color.Black);
                ShowDataAccountClickAsync(null, null);
            }
            catch (Exception ex)
            {
                Logger.WarnMsg(ex.Message);
            }
        }

        private async void ShowDataAccountClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (GetConstants.DetectNull(TxtbNickname))
                {
                    TxtbNickname.Focus();
                    return;
                }

                var plr = await GetActionsDb.GetPlayerAsync(ulong.Parse(TxtbAccountId.Text));
                TxtbPen.Text = plr?.PEN.ToString() ?? "0";
                TxtbLvl.Text = plr?.Level.ToString() ?? "0";
                TxtbAp.Text = plr?.AP.ToString() ?? "0";
                LabelUserPEN.Text = plr?.PEN.ToString() ?? "0";
                LabelUserAP.Text = plr?.AP.ToString() ?? "0";

                if (TxtbPen.Enabled)
                {
                    GetConstants.SetControlColor(TxtbPen, Color.White, Color.Black);
                    TxtbPen.Enabled = false;
                }

                if (TxtbAp.Enabled)
                {
                    GetConstants.SetControlColor(TxtbPen, Color.White, Color.Black);
                    TxtbPen.Enabled = false;
                }

                if (TxtbLvl.Enabled)
                {
                    TxtbLvl.Enabled = false;
                    GetConstants.SetControlColor(TxtbLvl, Color.White, Color.Black);
                }
            }
            catch (Exception ex)
            {
                Logger.WarnMsg(ex.Message);
            }
        }

        [DataBaseActions(DataBase.None, DataBaseAction.AboutUs)]
        private void AboutHelpMenuStripClick(object sender, EventArgs e) => MessageBox.Show("Programación: S4Archivos\nMail: s4archivos@gmail.com\nYoutube: www.youtube.com/S4Archivos/", "ACERCA DE", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void MenuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mauseaction = true;
        }

        private void MenuStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (mauseaction == true)
            {
                Location = new Point(Cursor.Position.X - point.X, Cursor.Position.Y - point.Y);
            }
        }

        private void MenuStrip_MouseUp(object sender, MouseEventArgs e)
        {
            mauseaction = false;
        }

        private void SearchDB_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mauseaction = true;
        }

        private void SearchDB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mauseaction == true)
            {
                Location = new Point(Cursor.Position.X - point.X, Cursor.Position.Y - point.Y);
            }
        }

        private void SearchDB_MouseUp(object sender, MouseEventArgs e)
        {
            mauseaction = false;
        }

        [DataBaseActions(DataBase.None, DataBaseAction.Exit)]
        private void MenuExit_Click(object sender, EventArgs e) => Environment.Exit(0);

        public void DetectNumberInKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= (int)Keys.D9 && e.KeyChar <= (int)Keys.NumPad9) && e.KeyChar != 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ResetValuesS()
        {
            TxtbItemId.Clear();
            TxtbShopItemId.Clear();
            TxtbPriceG.Clear();
            TxtbItemId.Clear();
            TxtbEffG.ResetText();
            TxtbEff.Clear();
            TxtbColor.Text = "0";
            TxtbCount.Text = "0";
            TxtbAccountId.Clear();
            TxtbNickname.Clear();
            TxtbUser.Clear();
            TxtbLvl.ResetText();
            TxtbPen.Clear();
            TxtbAp.Clear();
            LabelDurability.Text = "Durability";
            LabelShopPriceId.Text = "ShopPriceId";
        }

        private async void ResetDataUserTSClickAsync(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                TxtbAccountId.Clear();
                TxtbUser.Clear();
                TxtbNickname.Clear();
                TxtbLvl.ResetText();
                TxtbPen.ResetText();
                TxtbAp.ResetText();
            });
        }

        private void TxtbEffG_SelectedIndexChanged(object sender, EventArgs e) => SearchEffectClickAsync(null, null);

        private int ItemId
        {
            get => int.Parse(TxtbId.Text);
            set
            {
                if (int.Parse(TxtbId.Text) == value)
                    return;
                TxtbId.Text = value.ToString();
            }
        }

        private string Nickname
        {
            get => TxtbNickname.Text;
            set
            {
                if (TxtbNickname.Text == value)
                    return;
                TxtbNickname.Text = value;
            }
        }

        private uint PEN
        {
            get => uint.Parse(TxtbPen.Text);
            set
            {
                if (uint.Parse(TxtbPen.Text) == value)
                    return;
                TxtbPen.Text = value.ToString();
            }
        }

        private uint AP
        {
            get => uint.Parse(TxtbAp.Text);
            set
            {
                if (uint.Parse(TxtbAp.Text) == value)
                    return;
                TxtbAp.Text = value.ToString();
            }
        }
    }
}
