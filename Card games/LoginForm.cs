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
    public partial class LoginForm : Form
    {
        public LoginForm() { InitializeComponent(); }

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
        private static bool In(string str) {
            bool result = true;
            if (str.Length < 3) { result = false; }
            for (int i = 0; i < str.Length; i++) {
                for (int k = 0; k < symbols.Length; k++) {
                    if (str[i] == symbols[k]) { break; }
                    if (k == symbols.Length - 1 & str[i] != symbols[k]) { result = false; }
                }
            }
            return result;
        }
        public static string symbols = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890-_";

        ushort key = 0x4792;
        string path = "code.txt";
        private void LoginBtn_Click(object sender, EventArgs e) {
            FileInfo file = new FileInfo(path);
            string logpass = LoginBox.Text + "#" + PassBox.Text;
            string name = LoginBox.Text;
            hint();
            bool flag = false;
            if (!file.Exists) { FileStream fs = file.Create(); fs.Close(); }
            string[] logins = File.ReadAllLines(path);
            if (logins.Length != 0) {
                for (int i = 0; i < logins.Length; i++) {
                    logins[i] = crypt(logins[i], key);
                    if (logins[i] == logpass) {
                        flag = true;
                        break;
                    }
                    logins[i] = crypt(logins[i], key);
                }
            }
            if (flag) {
                StartForm.PlayerName = name;
                SwitchPanel(new ProfileForm());
            } 
            else { ErrorLabel.Text = "Неверный логин или пароль"; }
        }
        private void RegBtn_Click(object sender, EventArgs e) {
            FileInfo file = new FileInfo(path);
            if (!file.Exists) { FileStream fs = file.Create(); fs.Close(); }
            string logpass = LoginBox.Text + "#" + PassBox.Text;
            string name = LoginBox.Text;
            bool flag = true, permission = true;
            if (!In(LoginBox.Text) | !In(PassBox.Text)) 
            { permission = false; }
            if (!permission) {
                hint();
                ErrorLabel.Text = "Недопустимые символы"; 
            }
            else {
                string[] logins = File.ReadAllLines(path);
                for (int i = 0; i < logins.Length; i++) {
                    logins[i] = crypt(logins[i], key);
                    if (LoginBox.Text == Cut(logins[i], 1, logins[i].IndexOf("#"))) { flag = false; break; }
                    logins[i] = crypt(logins[i], key);
                }
                hint();
                if (flag) {
                    string[] newlogins = new string[logins.Length + 1];
                    for (int i = 0; i < logins.Length; i++) {
                        newlogins[i] = logins[i];
                    }
                    newlogins[logins.Length] = crypt(logpass, key);
                    File.WriteAllLines(path, newlogins);
                    StartForm.PlayerName = name;
                    SwitchPanel(new ProfileForm());
                }
                else {
                    ErrorLabel.Text = "Логин уже занят";
                }
            }
        }

        private void hint() {
            LoginBox.Text = "логин";
            PassBox.Text = "пароль";
            LoginBox.ForeColor = Color.FromArgb(90, 90, 90);
            PassBox.ForeColor = Color.FromArgb(90, 90, 90);
        }
        private void LoginBox_TextChanged(object sender, EventArgs e) {
            if (LoginBox.Text.IndexOf("\r\n") > 0) { LoginBox.Text = ""; }
        }
        private void PassBox_TextChanged(object sender, EventArgs e) {
            if (PassBox.Text.IndexOf("\r\n") > 0) { PassBox.Text = ""; }
        }
        private void LoginBox_Enter(object sender, EventArgs e) {
            LoginBox.Text = "";
            LoginBox.ForeColor = Color.FromArgb(221, 221, 221);
        }
        private void PassBox_Enter(object sender, EventArgs e) {
            PassBox.Text = "";
            PassBox.ForeColor = Color.FromArgb(221, 221, 221);
        }
    }
}
