using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker_C_sharp
{
    public partial class SettingsForm : Form
    {
        string path = "settings.txt";
        public SettingsForm() {
            InitializeComponent();
            if (StartForm.PlayerName == "Guest") {
                AccDelBtn.Enabled = false;
                AccDelBtn.BackColor = Color.FromArgb(52, 54, 75);
            }
            Refr();
        }
        private void Refr() {
            FileInfo file = new FileInfo(path);
            if (!file.Exists) { FileStream fs = file.Create(); fs.Close(); }
            string[] settings = File.ReadAllLines(path);
            if (settings.Length != 0) {
                PokerBetBox.Text = settings[0]; StartForm.defpokerbet = int.Parse(settings[0]);
                BjBetBox.Text = settings[1]; StartForm.defbjbet = int.Parse(settings[1]);
                DlNameBox.Text = settings[4]; StartForm.dlname = settings[4];
                PokerDelayBox.Text = settings[5]; StartForm.pokerdelay = int.Parse(settings[5]);
                BjDelayBox.Text = settings[6]; StartForm.bjdelay = int.Parse(settings[6]);
                if (settings[2] == "0") {
                    ChatOffBtn.BackColor = Color.FromArgb(57, 62, 124);
                    ChatOffBtn.ForeColor = Color.FromArgb(221, 221, 221);
                    ChatOnBtn.BackColor = Color.FromArgb(52, 54, 75);
                    ChatOnBtn.ForeColor = Color.FromArgb(150, 150, 150);
                }
                else {
                    ChatOffBtn.BackColor = Color.FromArgb(52, 54, 75);
                    ChatOffBtn.ForeColor = Color.FromArgb(150, 150, 150);
                    ChatOnBtn.BackColor = Color.FromArgb(57, 62, 124);
                    ChatOnBtn.ForeColor = Color.FromArgb(221, 221, 221);
                }
                if (settings[3] == "0") {
                    Lang1.BackColor = Color.FromArgb(57, 62, 124);
                    Lang1.ForeColor = Color.FromArgb(221, 221, 221);
                    Lang2.BackColor = Color.FromArgb(52, 54, 75);
                    Lang2.ForeColor = Color.FromArgb(150, 150, 150);
                }
                else {
                    Lang1.BackColor = Color.FromArgb(52, 54, 75);
                    Lang1.ForeColor = Color.FromArgb(150, 150, 150);
                    Lang2.BackColor = Color.FromArgb(57, 62, 124);
                    Lang2.ForeColor = Color.FromArgb(221, 221, 221);
                }
            }
            else { ToDefault(); }
        }
        private void ReWriteSettings() {
            string[] newsettings = new string[7];
            newsettings[0] = PokerBetBox.Text;
            newsettings[1] = BjBetBox.Text;
            if (ChatOnBtn.ForeColor == Color.FromArgb(221, 221, 221)) { newsettings[2] = "1"; }
            else { newsettings[2] = "0"; }
            if (Lang2.ForeColor == Color.FromArgb(221, 221, 221)) { newsettings[3] = "1"; }
            else { newsettings[3] = "0"; }
            newsettings[4] = DlNameBox.Text;
            newsettings[5] = PokerDelayBox.Text;
            newsettings[6] = BjDelayBox.Text;
            File.WriteAllLines(path, newsettings);
            StartForm.defpokerbet = int.Parse(newsettings[0]);
            StartForm.defbjbet = int.Parse(newsettings[1]);
            StartForm.enabledchat = int.Parse(newsettings[2]);
            StartForm.lang = int.Parse(newsettings[3]);
            StartForm.dlname = newsettings[4];
            StartForm.pokerdelay = int.Parse(newsettings[5]);
            StartForm.bjdelay = int.Parse(newsettings[6]);
        }
        private void ApplyBtn_Click(object sender, EventArgs e) { ReWriteSettings(); }
        private void ToDefault() {
            string[] newsettings = new string[7];
            newsettings[0] = "100";
            newsettings[1] = "100";
            newsettings[2] = "1";
            newsettings[3] = "1";
            newsettings[4] = "Jimm";
            newsettings[5] = "1500";
            newsettings[6] = "1000";
            File.WriteAllLines(path, newsettings);
        }

        bool UpCheck;
        int c;
        Label aclab;
        private void BtnTimer_Tick(object sender, EventArgs e) {
            if (aclab == PokerDelayBox | aclab == BjDelayBox) {
                if (!UpCheck & c > 500) { c--; }
                else if (UpCheck & c < 5000) { c++; }
                aclab.Text = c.ToString();
            }
            else {
                if (!UpCheck & c > 10) { c--; }
                else if (UpCheck & c < StartForm.bal) { c++; }
                aclab.Text = c.ToString();
            }
        }
        private void DownPokerBet_MouseDown(object sender, MouseEventArgs e) {
            aclab = PokerBetBox;
            c = int.Parse(PokerBetBox.Text);
            UpCheck = false;
            BtnTimer.Enabled = true;
        }
        private void DownPokerBet_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }
        private void UpPokerBet_MouseDown(object sender, MouseEventArgs e) {
            aclab = PokerBetBox;
            c = int.Parse(PokerBetBox.Text);
            UpCheck = true;
            BtnTimer.Enabled = true;
        }
        private void UpPokerBet_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }
        private void DownBjBet_MouseDown(object sender, MouseEventArgs e) {
            aclab = BjBetBox;
            c = int.Parse(BjBetBox.Text);
            UpCheck = false;
            BtnTimer.Enabled = true;
        }
        private void DownBjBet_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }
        private void UpBjBet_MouseDown(object sender, MouseEventArgs e) {
            aclab = BjBetBox;
            c = int.Parse(BjBetBox.Text);
            UpCheck = true;
            BtnTimer.Enabled = true;
        }
        private void UpBjBet_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }
        private void DownPokerDelay_MouseDown(object sender, MouseEventArgs e) {
            aclab = PokerDelayBox;
            c = int.Parse(PokerDelayBox.Text);
            UpCheck = false;
            BtnTimer.Enabled = true;
        }
        private void DownPokerDelay_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }
        private void UpPokerDelay_MouseDown(object sender, MouseEventArgs e) {
            aclab = PokerDelayBox;
            c = int.Parse(PokerDelayBox.Text);
            UpCheck = true;
            BtnTimer.Enabled = true;
        }
        private void UpPokerDelay_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }
        private void DownBjDelay_MouseDown(object sender, MouseEventArgs e) {
            aclab = BjDelayBox;
            c = int.Parse(BjDelayBox.Text);
            UpCheck = false;
            BtnTimer.Enabled = true;
        }
        private void DownBjDelay_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }
        private void UpBjDelay_MouseDown(object sender, MouseEventArgs e) {
            aclab = BjDelayBox;
            c = int.Parse(BjDelayBox.Text);
            UpCheck = true;
            BtnTimer.Enabled = true;
        }
        private void UpBjDelay_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }

        private void ChatOffBtn_Click(object sender, EventArgs e) {
            ChatOffBtn.BackColor = Color.FromArgb(57, 62, 124);
            ChatOffBtn.ForeColor = Color.FromArgb(221, 221, 221);
            ChatOnBtn.BackColor = Color.FromArgb(52, 54, 75);
            ChatOnBtn.ForeColor = Color.FromArgb(150, 150, 150);
            ReWriteSettings();
        }
        private void ChatOnBtn_Click(object sender, EventArgs e) {
            ChatOffBtn.BackColor = Color.FromArgb(52, 54, 75);
            ChatOffBtn.ForeColor = Color.FromArgb(150, 150, 150);
            ChatOnBtn.BackColor = Color.FromArgb(57, 62, 124);
            ChatOnBtn.ForeColor = Color.FromArgb(221, 221, 221);
            ReWriteSettings();
        }
        private void Lang1_Click(object sender, EventArgs e) {
            Lang1.BackColor = Color.FromArgb(57, 62, 124);
            Lang1.ForeColor = Color.FromArgb(221, 221, 221);
            Lang2.BackColor = Color.FromArgb(52, 54, 75);
            Lang2.ForeColor = Color.FromArgb(150, 150, 150);
            ReWriteSettings();
        }
        private void Lang2_Click(object sender, EventArgs e) {
            Lang1.BackColor = Color.FromArgb(52, 54, 75);
            Lang1.ForeColor = Color.FromArgb(150, 150, 150);
            Lang2.BackColor = Color.FromArgb(57, 62, 124);
            Lang2.ForeColor = Color.FromArgb(221, 221, 221);
            ReWriteSettings();
        }

        private void DlNameBox_TextChanged(object sender, EventArgs e) {
            if (DlNameBox.Text.IndexOf("\r\n") > 0) { DlNameBox.Text = ""; }
        }
        private void DefaultBtn_Click(object sender, EventArgs e) {
            ToDefault();
            Refr();
        }
        private void EmailLink_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start("mailto:enottvk@gmail.com?subject=Hello&body=I love your card games"); }
        private void VkLink_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start("https://vk.com/webnosok"); }
        private void AccDelBtn_Click(object sender, EventArgs e) {
            if (StartForm.PlayerName != "Guest") {
                FileInfo file = new FileInfo("code.txt");
                string name = StartForm.PlayerName;
                if (file.Exists) {
                    string[] logins = File.ReadAllLines("code.txt");
                    if (logins.Length != 0) {
                        for (int i = 0; i < logins.Length; i++) {
                            logins[i] = crypt(logins[i], key);
                        }
                        for (int i = 0; i < logins.Length; i++) {
                            if (Cut(logins[i], 1, logins[i].IndexOf("#")) == name) {
                                string[] newlogins = new string[logins.Length - 1];
                                int ind = 0;
                                for (int k = 0; k < newlogins.Length; k++) {
                                    if (ind == i) { ind++; }
                                    newlogins[k] = crypt(logins[ind], key);
                                    ind++;
                                }
                                File.WriteAllLines("code.txt", newlogins);
                                StartForm.bal = 10000;
                                StartForm.PlayerName = "Guest";
                                break;
                            }
                        }
                    }
                    string[] profiles = File.ReadAllLines("profiles.txt");
                    if (profiles.Length != 0) {
                        for (int i = 0; i < profiles.Length; i++) {
                            profiles[i] = crypt(profiles[i], key);
                        }
                        for (int i = 0; i < profiles.Length; i++) {
                            if (Cut(profiles[i], 1, profiles[i].IndexOf(":")) == name) {
                                string[] newprofiles = new string[profiles.Length - 1];
                                int ind = 0;
                                for (int k = 0; k < newprofiles.Length; k++) {
                                    if (ind == i) { ind++; }
                                    newprofiles[k] = crypt(profiles[ind], key);
                                    ind++;
                                }
                                File.WriteAllLines("profiles.txt", newprofiles);
                                break;
                            }
                        }
                    }
                    AccDelBtn.Enabled = false;
                    AccDelBtn.BackColor = Color.FromArgb(52, 54, 75);
                }
            }
        }

        private static string Cut(string s, int i1, int i2)
        {
            i1--;
            s = s.Substring(i1, i2 - i1);
            return s;
        }
        private string crypt(string str, ushort key)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++) { result += (char)(str[i] ^ key); }
            return result;
        }
        ushort key = 0x4792;
    }
}
