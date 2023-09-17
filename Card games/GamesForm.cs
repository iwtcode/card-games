using System;
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
    public partial class GamesForm : Form
    {
        public GamesForm() { InitializeComponent(); }
        private void SwitchPanel(Form panel)
        {
            StartForm.RunningForm = panel;
            this.Controls.Clear();
            panel.TopLevel = false;
            this.Controls.Add(panel);
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }

        private void PokerPlayBtn_Click(object sender, EventArgs e) { SwitchPanel(new PokerForm()); }
        private void BlackJackPlayBtn_Click(object sender, EventArgs e) { SwitchPanel(new BjForm()); }

        private void PokerPlayBtn_MouseEnter(object sender, EventArgs e) { 
            PokerPlayBtn.Image = Properties.Resources.pokerdarkafter;
            PokerPlayBtn.Size = new Size(PokerPlayBtn.Width - 6, PokerPlayBtn.Height - 6);
            PokerPlayBtn.Location = new Point(PokerPlayBtn.Location.X + 3, PokerPlayBtn.Location.Y + 3);
        }
        private void PokerPlayBtn_MouseLeave(object sender, EventArgs e) { 
            PokerPlayBtn.Image = Properties.Resources.pokerdarkf;
            PokerPlayBtn.Size = new Size(PokerPlayBtn.Width + 6, PokerPlayBtn.Height + 6);
            PokerPlayBtn.Location = new Point(PokerPlayBtn.Location.X - 3, PokerPlayBtn.Location.Y - 3);
        }

        private void BlackJackPlayBtn_MouseEnter(object sender, EventArgs e) { 
            BlackJackPlayBtn.Image = Properties.Resources.bjafter;
            BlackJackPlayBtn.Size = new Size(BlackJackPlayBtn.Width - 6, BlackJackPlayBtn.Height - 6);
            BlackJackPlayBtn.Location = new Point(BlackJackPlayBtn.Location.X + 3, BlackJackPlayBtn.Location.Y + 3);
        }
        private void BlackJackPlayBtn_MouseLeave(object sender, EventArgs e) { 
            BlackJackPlayBtn.Image = Properties.Resources.bj;
            BlackJackPlayBtn.Size = new Size(BlackJackPlayBtn.Width + 6, BlackJackPlayBtn.Height + 6);
            BlackJackPlayBtn.Location = new Point(BlackJackPlayBtn.Location.X - 3, BlackJackPlayBtn.Location.Y - 3);
        }
    }
}
