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
    public partial class ProfileForm : Form
    {
        private static string Cut(string s, int i1, int i2) {
            i1--;
            s = s.Substring(i1, i2 - i1);
            return s;
        }
        private string crypt(string str, ushort key) {
            string result = "";
            for (int i = 0; i < str.Length; i++) { result += (char)(str[i] ^ key); }
            return result;
        }
        private void SwitchPanel(Form panel) {
            this.Controls.Clear();
            panel.TopLevel = false;
            this.Controls.Add(panel);
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }
        ushort key = 0x4792;
        string path = "profiles.txt";
        public static string ActivePr = "";

        private string CreateNewProfile() {
            return StartForm.PlayerName + ": lvl=0 pokergames=0 pokerwins=0 bjgames=0 bjwins=0 bal=" + StartForm.bal + " ";
        }
        public ProfileForm()
        {
            InitializeComponent();
            ActivePr = "";
            PlayerNameLabel.Text = StartForm.PlayerName;
            FileInfo file = new FileInfo(path);
            if (!file.Exists) { FileStream fs = file.Create(); fs.Close(); }
            string[] profiles = File.ReadAllLines(path);
            if (profiles.Length != 0) {
                for (int i = 0; i < profiles.Length; i++) {
                    profiles[i] = crypt(profiles[i], key);
                    if (Cut(profiles[i], 1, profiles[i].IndexOf(":")) == StartForm.PlayerName) {
                        ActivePr = profiles[i];
                        profiles[i] = crypt(profiles[i], key);
                        break;
                    }
                    profiles[i] = crypt(profiles[i], key);
                }
                if (ActivePr == "") {
                    ActivePr = CreateNewProfile();
                    string[] newprofiles = new string[profiles.Length + 1];
                    for (int i = 0; i < profiles.Length; i++) { newprofiles[i] = profiles[i]; }
                    newprofiles[profiles.Length] = crypt(ActivePr, key);
                    File.WriteAllLines(path, newprofiles);
                }
            }
            else {
                ActivePr = CreateNewProfile();
                string[] newprofiles = new string[profiles.Length + 1];
                for (int i = 0; i < profiles.Length; i++) { newprofiles[i] = profiles[i]; }
                newprofiles[profiles.Length] = crypt(ActivePr, key);
                File.WriteAllLines(path, newprofiles);
            }
            DebugLabel.Text = ActivePr;
            PrintDetails();
        }
        private void PrintDetails() {
            string s;
            s = Cut(ActivePr, ActivePr.IndexOf("lvl=") + 1, ActivePr.Length);
            s = Cut(s, 5, s.IndexOf(" "));
            LvlBox.Text = "Уровень \r\n" + int.Parse(s) / 100;
            int lv;
            if (s.Length >= 3) { lv = int.Parse(Cut(s, s.Length - 1, s.Length)); } else { lv = int.Parse(s); }
            LvlBar.Size = new Size(panel2.Width * lv / 100, LvlBar.Height);
            s = Cut(ActivePr, ActivePr.IndexOf("bal=") + 1, ActivePr.Length);
            s = Cut(s, 5, s.IndexOf(" "));
            StartForm.bal = int.Parse(s);
            BalBox.Text = "Баланс \r\n" + s;
            s = Cut(ActivePr, ActivePr.IndexOf("pokergames=") + 1, ActivePr.Length);
            s = Cut(s, 12, s.IndexOf(" "));
            PokerGamesBox.Text = "Игр в покер \r\n" + s;
            s = Cut(ActivePr, ActivePr.IndexOf("pokerwins=") + 1, ActivePr.Length);
            s = Cut(s, 11, s.IndexOf(" "));
            PokerWinsBox.Text = "Побед в покер \r\n" + s;
            s = Cut(ActivePr, ActivePr.IndexOf("bjgames=") + 1, ActivePr.Length);
            s = Cut(s, 9, s.IndexOf(" "));
            BjGamesBox.Text = "Игр в блэк джек \r\n" + s;
            s = Cut(ActivePr, ActivePr.IndexOf("bjwins=") + 1, ActivePr.Length);
            s = Cut(s, 8, s.IndexOf(" "));
            BjWinsBox.Text = "Побед в блэк джек \r\n" + s;
        }

        private void AccExitBtn_Click(object sender, EventArgs e) {
            StartForm.PlayerName = "Guest";
            StartForm.bal = 10000;
            SwitchPanel(new LoginForm());
        }
    }
}
