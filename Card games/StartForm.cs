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

namespace Poker_C_sharp {
    public partial class StartForm : Form {
        public static float bal = 10000;
        public static Form RunningForm = new GamesForm();
        public static string PlayerName = "Guest";
        public static int gamefinished = 1;
        public static int defpokerbet = 100, defbjbet = 100, enabledchat = 1, lang = 1, pokerdelay = 1500, bjdelay = 1000;
        public static string dlname;
        public StartForm() { 
            InitializeComponent();
            ReadSettings();
            SwitchPanel(new GamesForm());
        }

        private void ReadSettings() {
            FileInfo file = new FileInfo("settings.txt");
            if (file.Exists) {
            string[] settings = File.ReadAllLines("settings.txt");
            if (settings.Length == 7) {
                defpokerbet = int.Parse(settings[0]);
                defbjbet = int.Parse(settings[1]);
                enabledchat = int.Parse(settings[2]);
                lang = int.Parse(settings[3]);
                dlname = settings[4];
                pokerdelay = int.Parse(settings[5]);
                bjdelay = int.Parse(settings[6]);
                }
            }
        }
        private void SwitchPanel(Form panel) {
            if (RunningForm.Text == "PokerForm" & gamefinished == 1) { 
                bal += (int)PokerForm.stack; 
                PokerForm.stack = 0; }
            else if (RunningForm.Text == "PokerForm" & gamefinished == 0) { 
                bal += (int)(PokerForm.stack - PokerForm.bet);
                PokerForm.stack = 0;
                PokerForm.bet = 0;
            }
            RunningForm = panel;
            FormPanel.Controls.Clear();
            panel.TopLevel = false;
            FormPanel.Controls.Add(panel);
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }
        private void SwitchBtns(Button obj = null) {
            if (obj != null) { obj.Visible = true; }
            if (Del1 != obj) { Del1.Visible = false; ProfileBtn.BackColor = Color.FromArgb(14, 18, 65); ProfileBtn.ForeColor = Color.FromArgb(210, 210, 210); }
            if (Del2 != obj) { Del2.Visible = false; RatingBtn.BackColor = Color.FromArgb(14, 18, 65); RatingBtn.ForeColor = Color.FromArgb(210, 210, 210); }
            if (Del3 != obj) { Del3.Visible = false; RulesBtn.BackColor = Color.FromArgb(14, 18, 65); RulesBtn.ForeColor = Color.FromArgb(210, 210, 210); }
            if (Del4 != obj) { Del4.Visible = false; SettingsBtn.BackColor = Color.FromArgb(14, 18, 65); SettingsBtn.ForeColor = Color.FromArgb(210, 210, 210); }
            if (Del5 != obj) { Del5.Visible = false; PlayBtn.BackColor = Color.FromArgb(14, 18, 65); PlayBtn.ForeColor = Color.FromArgb(210, 210, 210); }
        }
        private void ProfileBtn_Click(object sender, EventArgs e) {
            if (PlayerName == "Guest") { SwitchPanel(new LoginForm()); }
            else { SwitchPanel(new ProfileForm()); }
            ProfileBtn.BackColor = Color.FromArgb(16, 21, 80) ;
            ProfileBtn.ForeColor = Color.FromArgb(43, 50, 208) ;
            SwitchBtns(Del1);
        }
        private void RatingBtn_Click(object sender, EventArgs e) {
            SwitchPanel(new RatingForm());
            RatingBtn.BackColor = Color.FromArgb(16, 21, 80);
            RatingBtn.ForeColor = Color.FromArgb(43, 50, 208);
            SwitchBtns(Del2);
        }
        private void RulesBtn_Click(object sender, EventArgs e) {
            SwitchPanel(new RulesPokerForm());
            RulesBtn.BackColor = Color.FromArgb(16, 21, 80);
            RulesBtn.ForeColor = Color.FromArgb(43, 50, 208);
            SwitchBtns(Del3);
        }
        private void SettingsBtn_Click(object sender, EventArgs e) {
            SwitchPanel(new SettingsForm());
            SettingsBtn.BackColor = Color.FromArgb(16, 21, 80);
            SettingsBtn.ForeColor = Color.FromArgb(43, 50, 208);
            SwitchBtns(Del4);
        }
        private void PlayBtn_Click(object sender, EventArgs e) {
            SwitchPanel(new GamesForm());
            PlayBtn.BackColor = Color.FromArgb(16, 21, 80);
            PlayBtn.ForeColor = Color.FromArgb(43, 50, 208);
            SwitchBtns(Del5);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e) { 
            BalLabel.Text = bal.ToString(); 
        }
        private void ExitBtn_Click(object sender, EventArgs e) { this.Close(); }

        ushort key = 0x4792;

        string path = "profiles.txt";
        public string crypt(string str, ushort key)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++) { result += (char)(str[i] ^ key); }
            return result;
        }
        public static string Cut(string s, int i1, int i2)
        {
            i1--;
            s = s.Substring(i1, i2 - i1);
            return s;
        }
        private void ReWrite(string item, int rise = 1, int mode = 0)
        {
            int ind = 0;
            if (StartForm.PlayerName != "Guest")
            {
                FileInfo file = new FileInfo(path);
                string[] profiles = File.ReadAllLines(path);
                if (profiles.Length != 0)
                {
                    for (int i = 0; i < profiles.Length; i++)
                    {
                        profiles[i] = crypt(profiles[i], key);
                        if (Cut(profiles[i], 1, profiles[i].IndexOf(":")) == StartForm.PlayerName)
                        {
                            ind = i;
                        }
                    }
                    string newvalue;
                    newvalue = Cut(profiles[ind], profiles[ind].IndexOf(item) + item.Length + 2, profiles[ind].Length);
                    newvalue = Cut(newvalue, 1, newvalue.IndexOf(" "));
                    int ind2 = profiles[ind].IndexOf(item) + item.Length + 2 + newvalue.Length;
                    if (mode == 0) { newvalue = (int.Parse(newvalue) + rise).ToString(); }
                    else { newvalue = rise.ToString(); }
                    profiles[ind] = Cut(profiles[ind], 1, profiles[ind].IndexOf(item) + item.Length + 1)
                        + newvalue + Cut(profiles[ind], ind2, profiles[ind].Length);
                    for (int i = 0; i < profiles.Length; i++) { profiles[i] = crypt(profiles[i], key); }
                    File.WriteAllLines(path, profiles);
                }
            }
        }
        private void BalLabel_TextChanged(object sender, EventArgs e) {
            ReWrite("bal", (int)bal, 1);
        }
    }
}