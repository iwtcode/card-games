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
    public partial class RulesPokerForm : Form
    {
        private void SwitchPanel(Form panel) {
            this.Controls.Clear();
            panel.TopLevel = false;
            this.Controls.Add(panel);
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }
        public RulesPokerForm() {
            InitializeComponent();
        }
        private void SwBtn_Click(object sender, EventArgs e) {
            SwitchPanel(new RulesBjForm());
        }
    }
}
