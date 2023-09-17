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
    public partial class BjForm : Form
    {
        static Random rnd = new Random();
        int move = 0, plindex, splindex, dlindex, splitActive, ft = 0;
        float stack, bet;
        string[] plcards = new string[10];
        string[] splcards = new string[10];
        string[] dlcards = new string[10];
        string[,] allcards = {
        {"A♥", "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥"},
        {"A♠", "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠"},
        {"A♦", "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦"},
        {"A♣", "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣"} };

        private static void GenerateCards(string[,] allcards, string[] plcards, string[] splcards, string[] dlcards, string[] cards, int index) {
            string[,] copy = new string[allcards.GetLength(0), allcards.GetLength(1)];

            for (int i = 0; i < allcards.GetLength(0); i++) {
                for (int k = 0; k < allcards.GetLength(1); k++) {
                    copy[i, k] = allcards[i, k];
                }
            }
            for (int s = 0; s < allcards.GetLength(0); s++) {
                for (int t = 0; t < allcards.GetLength(1); t++) {
                    for (int i = 0; i <= index; i++) {
                        if (plcards[i] == copy[s, t]) { copy[s, t] = "-"; }
                        if (dlcards[i] == copy[s, t]) { copy[s, t] = "-"; }
                        if (splcards[i] == copy[s, t]) { copy[s, t] = "-"; }
                    }
                }
            }
            for (int i = 0; i <= index; i++) {
                if (cards[i] == "0") {
                    do { cards[i] = copy[rnd.Next(0, 4), rnd.Next(0, 13)]; } while (cards[i] == "-");
                }
                for (int s = 0; s < allcards.GetLength(0); s++) {
                    for (int t = 0; t < allcards.GetLength(1); t++) {
                        if (cards[i] == copy[s, t]) { copy[s, t] = "-"; }
                    }
                }
            }
        }
        private void Check4Split(string[] cards) {
            int count = 0;
            for (int i = 0; i < cards.Length; i++) { if (cards[i] != "0") { count++; } }
            int[] nums = new int[count];

            for (int i = 0; i < nums.Length; i++)
            {
                if (Cut(cards[i], 1, 2) == "10") { nums[i] = 10; }
                else if (Cut(cards[i], 1, 1) == "J") { nums[i] = 10; }
                else if (Cut(cards[i], 1, 1) == "Q") { nums[i] = 10; }
                else if (Cut(cards[i], 1, 1) == "K") { nums[i] = 10; }
                else if (Cut(cards[i], 1, 1) == "A") { nums[i] = 11; }
                else { nums[i] = int.Parse(Cut(cards[i], 1, 1)); }
            }
            if (nums[0] == nums[1]) { SplitBtn.Visible = true; }
        }
        private static int CheckCards(string[] cards) {
            int result = 0, count = 0, swap;
            for (int i = 0; i < cards.Length; i++) { if (cards[i] != "0") { count++; } }
            int[] nums = new int[count];

            for (int i = 0; i < nums.Length; i++) {
                if (Cut(cards[i], 1, 2) == "10") { nums[i] = 10; }
                else if (Cut(cards[i], 1, 1) == "J") { nums[i] = 10; }
                else if (Cut(cards[i], 1, 1) == "Q") { nums[i] = 10; }
                else if (Cut(cards[i], 1, 1) == "K") { nums[i] = 10; }
                else if (Cut(cards[i], 1, 1) == "A") { nums[i] = 11; }
                else { nums[i] = int.Parse(Cut(cards[i], 1, 1)); }
            }

            for (int i = 0; i < nums.Length - 1; i++) { // sort
                int j = i;
                while (nums[j] > nums[j + 1])
                {
                    swap = nums[j]; 
                    nums[j] = nums[j + 1]; 
                    nums[j + 1] = swap;
                    j--;
                    if (j == -1) { break; }
                }
            }

            for (int i = 0; i < nums.Length; i++) {
                if (i != nums.Length - 1 & nums[i] == 11) { 
                    if (result + 11 + nums[i+1] > 21) { result++; } else { result += nums[i]; }
                }
                else if (i == nums.Length - 1 & nums[i] == 11) {
                    if (result + 11 > 21) { result++; } else { result += nums[i]; }
                }
                else { result += nums[i]; }
            }

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
        private static Image CropImage(Image img, Rectangle Area) {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(Area, bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }
        private void AddPic(PictureBox pb, string[] cards, int mode = 0, int plab = -1) {
            int x, y, cnt = 126;
            for (int i = 1; i < cards.Length; i++) { if (cards[i] != "0") { cnt += 30; } }
            pb.Size = new Size(90, cnt);

            for (int i = 0; i < cards.Length; i++) {
                if (cards[i] != "0"){
                    if (mode == 1 & i == 1) {
                        PictureBox nPic = new PictureBox
                        {
                            Size = new Size(90, 126),
                            Location = new Point(0, 0),
                            BackColor = Color.Transparent,
                        };
                        nPic.Image = Properties.Resources.hidecardw;
                        pb.Controls.Add(nPic);
                        nPic.Location = new Point(0, 30 * i);
                        nPic.BringToFront();
                    }
                    else {
                        for (int k = 0; k < allcards.GetLength(0); k++) {
                            for (int f = 0; f < allcards.GetLength(1); f++) {
                                if (cards[i] == allcards[k, f]) {
                                    x = f * 90;
                                    y = k * 126;
                                    PictureBox nPic = new PictureBox {
                                        Size = new Size(90, 126),
                                        Location = new Point(0, 0),
                                        BackColor = Color.Transparent,
                                    };
                                    if (i == 0) { nPic.Image = CropImage(Properties.Resources.pokerdeck, new Rectangle(x, y, 90, 126)); }
                                    else { nPic.Image = CropImage(Properties.Resources.pokerdeckw, new Rectangle(x, y, 90, 126)); }
                                    pb.Controls.Add(nPic);
                                    nPic.Location = new Point(0, 30 * i);
                                    nPic.BringToFront();
                                }
                            }
                        }
                        if (plab == 1) { WinLabel1.Location = new Point(PlCardsBox.Location.X - 5, PlCardsBox.Location.Y + cnt); }
                        if (plab == 2) { WinLabel2.Location = new Point(SplCardsBox.Location.X - 5, SplCardsBox.Location.Y + cnt); }
                    }
                }
            }
        }
        private void SwBtns(int mode) {
            if (mode == 0) {
                CheckBtn.Enabled = false;
                AddBtn.Enabled = false;
                RaiseBtn.Enabled = false;
                SplitBtn.Visible = false;
            }
            else {
                CheckBtn.Enabled = true;
                AddBtn.Enabled = true;
                RaiseBtn.Enabled = true;
                SplitBtn.Enabled = true;
            }
        }

        Point x;
        private void AddBtn_Click(object sender, EventArgs e) {
            PlayerPicture.Focus();
            AddBtn.Image = Properties.Resources.plus;
            if (move == 0) {
                ChipImage2.Location = x;
                RaiseBtn.Enabled = true;
                CheckBtn.Enabled = true;
                WinLabel1.Text = "";
                WinLabel2.Text = "";
                PlPointsLabel.Text = "";
                DlPointsLabel.Text = "";
                PlCardsBox.Controls.Clear();
                SplCardsBox.Controls.Clear();
                DlCardsBox.Controls.Clear();
                PlEventBox.Image = null;
                DlEventBox.Image = null;
                StackLabel.Text = stack.ToString();
                bet = stack;
                for (int i = 0; i < plcards.Length; i++) { plcards[i] = "0"; splcards[i] = "0"; dlcards[i] = "0"; }
                SwBtns(0);
                dlindex = -2;
                plindex = -1;
                Delay.Enabled = true;
            }
            else if (splitActive == 0) {
                move++;
                PlEventBox.Image = Properties.Resources.plus;
                SplitBtn.Visible = false;
                RaiseBtn.Enabled = false;
                plindex++;
                GenerateCards(allcards, plcards, splcards, dlcards, plcards, plindex);
                PlPointsLabel.Text = CheckCards(plcards).ToString();
                AddPic(PlCardsBox, plcards, plab: 1);
                if (CheckCards(plcards) >= 21) { FinishGame(); }
            }
            else if (splitActive == 1) {
                move++;
                PlEventBox.Image = Properties.Resources.plus;
                plindex++;
                RaiseBtn.Enabled = false;
                GenerateCards(allcards, plcards, splcards, dlcards, plcards, plindex);
                PlPointsLabel.Text = CheckCards(plcards).ToString() + "  " + CheckCards(splcards).ToString();
                AddPic(PlCardsBox, plcards, plab: 1);
                if (CheckCards(plcards) >= 21) { 
                    splitActive = 2;
                    WinLabel1.Image = null;
                    WinLabel2.Image = Properties.Resources.minus;
                }
            }
            else if (splitActive == 2)
            {
                move++;
                PlEventBox.Image = Properties.Resources.plus;
                RaiseBtn.Enabled = false;
                splindex++;
                GenerateCards(allcards, plcards, splcards, dlcards, splcards, splindex);
                PlPointsLabel.Text = CheckCards(plcards).ToString() + "  " + CheckCards(splcards).ToString();
                AddPic(SplCardsBox, splcards, plab: 2);
                if (CheckCards(splcards) >= 21) { 
                    SwBtns(0); 
                    DlMoveTimer.Enabled = true;
                    WinLabel1.Image = null;
                    WinLabel2.Image = null;
                }
            }
        }
        private void SplitBtn_Click(object sender, EventArgs e) {
            PlEventBox.Image = Properties.Resources.split;
            x = new Point(ChipImage2.Location.X, ChipImage2.Location.Y);
            ChipImage2.Location = new Point(ChipImage2.Location.X - 30, ChipImage2.Location.Y);
            splitActive = 1;
            move++;
            WinLabel1.Image = Properties.Resources.minus;
            plindex = 0;
            splindex = 0;
            splcards[0] = plcards[1];
            plcards[1] = "0";
            StackLabel.Text = bet.ToString() + "  " + bet.ToString();
            PlPointsLabel.Text = CheckCards(plcards).ToString() + "  " + CheckCards(splcards).ToString(); ;
            PlCardsBox.Controls.Clear();
            SplCardsBox.Controls.Clear();
            AddPic(PlCardsBox, plcards, plab: 1);
            AddPic(SplCardsBox, splcards, plab: 2);
            SplitBtn.Visible = false;
        }
        private void CheckBtn_Click(object sender, EventArgs e) {
            PlEventBox.Image = Properties.Resources.stand;
            if (splitActive == 1) { 
                splitActive = 2;
                WinLabel1.Image = null;
                WinLabel2.Image = Properties.Resources.minus;
            }
            else { 
                SwBtns(0); 
                DlMoveTimer.Enabled = true;
                WinLabel1.Image = null;
                WinLabel2.Image = null;
            }
        }
        private void RaiseBtn_Click(object sender, EventArgs e) {
            move++;
            PlEventBox.Image = Properties.Resources.uparrow;
            if (splitActive == 0) {
                SplitBtn.Visible = false;
                bet *= 2;
                StackLabel.Text = bet.ToString();
                RaiseBtn.Enabled = false;
                plindex++;
                GenerateCards(allcards, plcards, splcards, dlcards, plcards, plindex);
                PlPointsLabel.Text = CheckCards(plcards).ToString();
                AddPic(PlCardsBox, plcards, plab: 1);
                if (CheckCards(plcards) > 21) { FinishGame(); }
                else { SwBtns(0); DlMoveTimer.Enabled = true; }
            }
            else {
                bet *= 2;
                StackLabel.Text = bet.ToString() + "  " + bet.ToString();
                RaiseBtn.Enabled = false;
                plindex++;
                splindex++;
                GenerateCards(allcards, plcards, splcards, dlcards, plcards, plindex);
                GenerateCards(allcards, plcards, splcards, dlcards, splcards, splindex);
                PlPointsLabel.Text = CheckCards(plcards).ToString() + "  " + CheckCards(splcards).ToString();
                AddPic(PlCardsBox, plcards, plab: 1);
                AddPic(SplCardsBox, splcards, plab: 2);
                SwBtns(0); DlMoveTimer.Enabled = true;
            }
        }

        private void DlMoveTimer_Tick(object sender, EventArgs e) {
            PlEventBox.Image = null;
            DlMoveTimer.Enabled = false;
            DlPointsLabel.Text = CheckCards(dlcards).ToString();
            if (splitActive == 0) {
                if (CheckCards(dlcards) < 17 & CheckCards(dlcards) < CheckCards(plcards)) { DlLoop(); }
                else { FinishGame(); }
            }
            else {
                if (CheckCards(dlcards) < 17) { DlLoop(); }
                else { FinishGame(); }
            }
        }
        private void DlLoop() {
            if (ft == 0) { ft++; AddPic(DlCardsBox, dlcards); }
            else {
            dlindex++;
            DlEventBox.Image = Properties.Resources.plus;
            GenerateCards(allcards, plcards, splcards, dlcards, dlcards, dlindex);
            DlPointsLabel.Text = CheckCards(dlcards).ToString();
            AddPic(DlCardsBox, dlcards);
            }
            DlMoveTimer.Enabled = true;
        }
        private void FinishGame() {
            DlPointsLabel.Text = CheckCards(dlcards).ToString();
            if (int.Parse(DlPointsLabel.Text) <= 21) { DlEventBox.Image = Properties.Resources.stand; }
            ft = 0;
            RaiseBtn.Enabled = false;
            CheckBtn.Enabled = false;
            SplitBtn.Visible = false;
            AddBtn.Enabled = true;
            int dlpoints, plpoints, splpoints;
            plpoints = CheckCards(plcards);
            splpoints = CheckCards(splcards);
            dlpoints = CheckCards(dlcards);
            AddPic(DlCardsBox, dlcards);
            int dbwin = 0;
            if (move == 1 & plpoints == 21) { StartForm.bal += (float)(bet * 1.5); WinLabel1.Text = "Вы победили";
                ReWrite("bjwins", 1);
                ReWrite("lvl", 5);
            }
            else if (dlpoints > 21) {
                if (splitActive == 0) { StartForm.bal += bet; WinLabel1.Text = "Вы победили";
                    ReWrite("bjwins", 1);
                    ReWrite("lvl", 5);
                }
                else if (splitActive != 0) {
                    if (plpoints <= 21) { StartForm.bal += bet; WinLabel1.Text = "Вы победили"; dbwin = 1; } else { WinLabel1.Text = "Вы проиграли"; }
                    if (splpoints <= 21) { StartForm.bal += bet; WinLabel2.Text = "Вы победили"; dbwin = 1; } else { WinLabel2.Text = "Вы проиграли"; }
                    if (dbwin == 1) {
                        ReWrite("bjwins", 1);
                        ReWrite("lvl", 8);
                    }
                    else { ReWrite("lvl", 5); }
                }
            }
            else {
                if (plpoints > dlpoints & plpoints <= 21) { StartForm.bal += bet; WinLabel1.Text = "Вы победили";
                    ReWrite("bjwins", 1);
                    ReWrite("lvl", 5);
                }
                else if (plpoints < dlpoints | plpoints > 21) { StartForm.bal -= bet; WinLabel1.Text = "Вы проиграли";
                    ReWrite("lvl", 3);
                }
                else { WinLabel1.Text = "Ничья";
                    ReWrite("lvl", 3);
                }
                if (splitActive != 0) {
                    if (splpoints > dlpoints & splpoints <= 21) { StartForm.bal += bet; WinLabel2.Text = "Вы победили";
                        ReWrite("bjwins", 1);
                        ReWrite("lvl", 5);
                    }
                    else if (splpoints < dlpoints | splpoints > 21) { StartForm.bal -= bet; WinLabel2.Text = "Вы проиграли";
                        ReWrite("lvl", 3);
                    }
                    else { WinLabel2.Text = "Ничья";
                        ReWrite("lvl", 3);
                    }
                }
            }
            move = 0; splitActive = 0;
            AddBtn.Image = Properties.Resources.check;
            ReWrite("bjgames", 1);
        }





        private string crypt(string str, ushort key)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++) { result += (char)(str[i] ^ key); }
            return result;
        }
        private static string Cut(string s, int i1, int i2)
        {
            i1--;
            s = s.Substring(i1, i2 - i1);
            return s;
        }
        private void ReWrite(string item, int rise = 1)
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
                    newvalue = (int.Parse(newvalue) + rise).ToString();
                    profiles[ind] = Cut(profiles[ind], 1, profiles[ind].IndexOf(item) + item.Length + 1)
                        + newvalue + Cut(profiles[ind], ind2, profiles[ind].Length);
                    for (int i = 0; i < profiles.Length; i++) { profiles[i] = crypt(profiles[i], key); }
                    File.WriteAllLines(path, profiles);
                }
            }
        }
        ushort key = 0x4792;
        string path = "profiles.txt";
        public BjForm() { 
            InitializeComponent();
            PlayerNameLabel.Text = StartForm.PlayerName;
            DillerNameLabel.Text = StartForm.dlname;
            Delay.Interval = StartForm.bjdelay;
            DlMoveTimer.Interval = StartForm.bjdelay;
            FirstBetLabel.Text = StartForm.defbjbet.ToString();
        }
        private void Delay_Tick(object sender, EventArgs e) {
            if (dlindex == -2) {
                plindex++;
                GenerateCards(allcards, plcards, splcards, dlcards, plcards, plindex);
                // для проверки split'a
                // plcards[0] = "8♥"; plcards[1] = "8♣";
                GenerateCards(allcards, plcards, splcards, dlcards, plcards, plindex);
                PlPointsLabel.Text = CheckCards(plcards).ToString();
                AddPic(PlCardsBox, plcards, plab: 1);
                if (plindex == 1) { dlindex = -1; }
            }
            else {
                dlindex++;
                GenerateCards(allcards, plcards, splcards, dlcards, dlcards, dlindex);
                AddPic(DlCardsBox, dlcards, 1);
                if (dlindex == 1) {
                    Delay.Enabled = false;
                    SwBtns(1);
                    move++;
                    if (CheckCards(plcards) == 21 | CheckCards(dlcards) == 21) { FinishGame(); }
                    else { Check4Split(plcards); }
                }
            }
        }
        private void ApplyStackBtn_Click(object sender, EventArgs e) {
            x = new Point(ChipImage2.Location.X, ChipImage2.Location.Y);
            stack = int.Parse(FirstBetLabel.Text);
            FirstBetPanel.Visible = false;
            ChipImage2.Visible = true;
            StackLabel.Visible = true;
            CheckBtn.Visible = true;
            AddBtn.Visible = true;
            RaiseBtn.Visible = true;
            DillerPicture.Visible = true;
            PlayerPicture.Visible = true;
            DillerNameLabel.Visible = true;
            PlayerNameLabel.Visible = true;

            WinLabel1.Size = new Size(100, 25);
            WinLabel2.Size = new Size(100, 25);
            PlCardsBox.Size = new Size(90, 400);
            DlCardsBox.Size = new Size(90, 400);
            SplCardsBox.Size = new Size(90, 300);

            StackLabel.Text = stack.ToString();
            bet = stack;
            for (int i = 0; i < plcards.Length; i++) { plcards[i] = "0"; splcards[i] = "0"; dlcards[i] = "0"; }
            SwBtns(0);
            plindex = -1;
            dlindex = -2;
            Delay.Enabled = true;
        }
        private void DenyStackBtn_Click(object sender, EventArgs e){ SwitchPanel(new GamesForm());}

        bool UpCheck;
        private void DownBetBtn_MouseDown(object sender, MouseEventArgs e) { BtnTimer.Enabled = true; UpCheck = false; }
        private void DownBetBtn_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }
        private void UpBetBtn_MouseDown(object sender, MouseEventArgs e) { BtnTimer.Enabled = true; UpCheck = true; }
        private void UpBetBtn_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }
        private void BtnTimer_Tick(object sender, EventArgs e) {
            int c = int.Parse(FirstBetLabel.Text);
            if (UpCheck & c < StartForm.bal) { c++; }
            else if (!UpCheck & c > 10) { c--; }
            FirstBetLabel.Text = c.ToString();
        }
    }
}
