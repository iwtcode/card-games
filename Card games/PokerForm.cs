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
    public partial class PokerForm : Form {

        static Random rnd = new Random();
        int index = 2, move = 1, betcount = 1;
        string choice;
        float blind, pot, raise;
        public static float stack = 0, bet;
        bool betcheck;
        string[] tablecards = new string[5];
        string[] plcards = new string[2];
        string[] dlcards = new string[2];
        string[,] allcards = {
        {"A♥", "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥"},
        {"A♠", "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠"},
        {"A♦", "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦"},
        {"A♣", "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣"} };

        private static void GenerateCards( string[,] allcards, string[] tablecards, string[] plcards, string[] dlcards, string[] cards, int index) {
            string[,] copy = new string[allcards.GetLength(0), allcards.GetLength(1)];

            for (int i = 0; i < allcards.GetLength(0); i++) {
                for (int k = 0; k < allcards.GetLength(1); k++) {
                    copy[i, k] = allcards[i, k];
                }
            }
            for (int s = 0; s < allcards.GetLength(0); s++) {
                for (int t = 0; t < allcards.GetLength(1); t++) {
                    for (int i = 0; i <= 1; i++) {
                        if (plcards[i] == copy[s, t]) { copy[s, t] = "-"; }
                        if (dlcards[i] == copy[s, t]) { copy[s, t] = "-"; }
                    }
                    for (int i = 0; i <= index; i++) {
                        if (tablecards[i] == copy[s, t]) { copy[s, t] = "-"; }
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
        private static int CheckCombo(string[] cards, string[] tablecards) {
            int count = 0, result = 0, highcard = 0, max;
            string swap;
            for (int i = 0; i <= 1; i++) { if (cards[i] != "0") { count++; } }
            for (int i = 0; i <= 4; i++) { if (tablecards[i] != "0") { count++; } }
            int[] nums = new int[count];
            string[] colors = new string[count];

            for (int i = 0; i < cards.Length; i++) { // systematization
                if (cards[i].Substring(0, 2) == "10") { nums[i] = 10; colors[i] = cards[i].Substring(2, 1); }
                else if (cards[i].Substring(0, 1) == "J") { nums[i] = 11; colors[i] = cards[i].Substring(1, 1); }
                else if (cards[i].Substring(0, 1) == "Q") { nums[i] = 12; colors[i] = cards[i].Substring(1, 1); }
                else if (cards[i].Substring(0, 1) == "K") { nums[i] = 13; colors[i] = cards[i].Substring(1, 1); }
                else if (cards[i].Substring(0, 1) == "A") { nums[i] = 14; colors[i] = cards[i].Substring(1, 1); }
                else { nums[i] = int.Parse(cards[i].Substring(0, 1)); colors[i] = cards[i].Substring(1, 1); }
            }

            if (count == 7) { highcard = nums.Max(); }

            for (int i = 0; i <= nums.Length - cards.Length - 1; i++) {
                if (tablecards[i].Substring(0, 1) == "1") { nums[i + 2] = 10; colors[i + 2] = tablecards[i].Substring(2, 1); }
                else if (tablecards[i].Substring(0, 1) == "J") { nums[i + 2] = 11; colors[i + 2] = tablecards[i].Substring(1, 1); }
                else if (tablecards[i].Substring(0, 1) == "Q") { nums[i + 2] = 12; colors[i + 2] = tablecards[i].Substring(1, 1); }
                else if (tablecards[i].Substring(0, 1) == "K") { nums[i + 2] = 13; colors[i + 2] = tablecards[i].Substring(1, 1); }
                else if (tablecards[i].Substring(0, 1) == "A") { nums[i + 2] = 14; colors[i + 2] = tablecards[i].Substring(1, 1); }
                else { nums[i + 2] = int.Parse(tablecards[i].Substring(0, 1)); colors[i + 2] = tablecards[i].Substring(1, 1); }
            }

            for (int i = 0; i < nums.Length - 1; i++) { // sort
                int j = i;
                while (nums[j] > nums[j + 1]) {
                    swap = nums[j].ToString(); nums[j] = nums[j + 1]; nums[j + 1] = int.Parse(swap);
                    swap = colors[j]; colors[j] = colors[j + 1]; colors[j + 1] = swap;
                    j--;
                    if (j == -1) { break; }
                }
            }

            for (int i = 0; i < nums.Length; i++) { // one pair
                for (int k = 0; k < nums.Length; k++) {
                    if (nums[i] == nums[k] & i != k) { result = 100; }
                }
            }

            for (int i = 0; i < nums.Length; i++) { // two pairs
                for (int k = 0; k < nums.Length; k++) {
                    if (nums[i] == nums[k] & i != k) {
                        for (int s = 0; s < nums.Length; s++) {
                            for (int t = 0; t < nums.Length; t++) {
                                if (nums[s] == nums[t] & nums[s] != nums[i] & s != t) { result = 200; }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++) { // three of kind
                for (int k = 0; k < nums.Length; k++) {
                    for (int j = 0; j < nums.Length; j++) {
                        if (nums[i] == nums[k] & nums[k] == nums[j] & i != k & k != j & j != i) { result = 300; }
                    }
                }
            }

            for (int i = 0; i < nums.Length - 1; i++) { // straight
                max = 1;
                for (int k = i; k < nums.Length - 1; k++) {
                    if (nums[k] + 1 == nums[k + 1]) { max++; }
                    else if (nums[k] == nums[k + 1]) { }
                    else { k = nums.Length; max = 1; }
                    if (max == 5) { i = nums.Length; k = nums.Length; result = 400; }
                }
            }

            for (int i = 0; i < colors.Length; i++) { // flush
                max = 1;
                for (int k = 0; k < colors.Length; k++) {
                    if (colors[i] == colors[k] & i != k) { max++; }
                    if (max >= 5) { i = colors.Length; k = colors.Length; result = 500; }
                }
            }

            for (int i = 0; i < nums.Length; i++) { // full house
                for (int k = 0; k < nums.Length; k++) {
                    for (int j = 0; j < nums.Length; j++) {
                        if (nums[i] == nums[k] & nums[k] == nums[j] & i != k & k != j & j != i) {
                            for (int a = 0; a < nums.Length; a++) {
                                for (int b = 0; b < nums.Length; b++) {
                                    if (nums[a] == nums[b] & a != b &
                                        a != i & a != k & a != j &
                                        b != i & b != k & b != j) { result = 600; }
                                }
                            }
                        }
                    }
                }
            }

            for (int a = 0; a < nums.Length; a++) { // four of kind
                for (int b = 0; b < nums.Length; b++) {
                    for (int c = 0; c < nums.Length; c++) {
                        for (int d = 0; d < nums.Length; d++) {
                            if (nums[a] == nums[b] & nums[b] == nums[c] & nums[c] == nums[d] &
                                a != b & a != c & a != d & b != c & b != d & c != d) { result = 700; }
                        }
                    }
                }
            }

            for (int i = 0; i < nums.Length - 1; i++) { // straight flush
                max = 1;
                for (int k = i; k < nums.Length - 1; k++) {
                    if (nums[k] + 1 == nums[k + 1] & colors[i] + 1 == colors[i + 1]) { max++; }
                    else if (nums[k] == nums[k + 1]) { }
                    else { k = nums.Length; max = 1; }

                    if (max == 5) { i = nums.Length; k = nums.Length; result = 800; }
                }
            }

            for (int i = 0; i < nums.Length - 1; i++) { // royal flush
                max = 1;
                if (nums[i] == 10) {
                    for (int k = i; k < nums.Length - 1; k++) {
                        if (nums[k] + 1 == nums[k + 1] & colors[i] + 1 == colors[i + 1]) { max++; }
                        else if (nums[k] == nums[k + 1]) { }
                        else { k = nums.Length; max = 1; }

                        if (max == 5) { i = nums.Length; k = nums.Length; result = 900; }
                    }
                }
            }

            result += highcard;
            return result;
        }
        private string DefineCombos(int power) {
            string combo = "";
            if (power < 100) { combo = "старшая карта"; }
            else if (power >= 100 & power < 200) { combo = "одна пара"; }
            else if (power >= 200 & power < 300) { combo = "две пары"; }
            else if (power >= 300 & power < 400) { combo = "сет"; }
            else if (power >= 400 & power < 500) { combo = "стрит"; }
            else if (power >= 500 & power < 600) { combo = "флэш"; }
            else if (power >= 600 & power < 700) { combo = "фулл-хаус"; }
            else if (power >= 700 & power < 800) { combo = "каре"; }
            else if (power >= 800 & power < 900) { combo = "стрит-флэш"; }
            else if (power >= 900) { Console.Write("флеш-рояль"); }
            return combo;
        }
        private bool BotBet(int value) {
            Random rnd = new Random();
            if (value >= 0 & value < 100) { value = 15; }
            else if (value >= 100 & value < 300) { value = 33; }
            else if (value >= 300 & value < 400) { value = 50; }
            else if (value >= 400 & value < 700) { value = 66; }
            else if (value >= 700 & value < 1000) { value = 90; }
            if (value >= rnd.Next(0, 101)) { return true; } else { return false; }
        }
        private void DrawCards(int mode) {
            int x, y;
            Image deck = Properties.Resources.pokerdeck;
            for (int i = 0; i < tablecards.Length; i++) {
                if (tablecards[i] != "0") {
                    for (int k = 0; k < allcards.GetLength(0); k++) {
                        for (int f = 0; f < allcards.GetLength(1); f++) {
                            if (tablecards[i] == allcards[k, f]) {
                                x = f * 90;
                                y = k * 126;
                                if (i == 0) { TableSlot1.BackgroundImage = CropImage(deck, new Rectangle(x, y, 90, 126)); }
                                if (i == 1) { TableSlot2.BackgroundImage = CropImage(deck, new Rectangle(x, y, 90, 126)); }
                                if (i == 2) { TableSlot3.BackgroundImage = CropImage(deck, new Rectangle(x, y, 90, 126)); }
                                if (i == 3) { TableSlot4.BackgroundImage = CropImage(deck, new Rectangle(x, y, 90, 126)); }
                                if (i == 4) { TableSlot5.BackgroundImage = CropImage(deck, new Rectangle(x, y, 90, 126)); }
                            }
                        }
                    }
                }
                else {
                    if (i == 0) { TableSlot1.BackgroundImage = Properties.Resources.hidecard; }
                    if (i == 1) { TableSlot2.BackgroundImage = Properties.Resources.hidecard; }
                    if (i == 2) { TableSlot3.BackgroundImage = Properties.Resources.hidecard; }
                    if (i == 3) { TableSlot4.BackgroundImage = Properties.Resources.hidecard; }
                    if (i == 4) { TableSlot5.BackgroundImage = Properties.Resources.hidecard; }
                }
            }

            for (int i = 0; i < plcards.Length; i++) {
                if (plcards[i] != "0") {
                    for (int k = 0; k < allcards.GetLength(0); k++) {
                        for (int f = 0; f < allcards.GetLength(1); f++) {
                            if (plcards[i] == allcards[k, f]) {
                                x = f * 90;
                                y = k * 126;
                                if (i == 0) { PlayerSlot1.BackgroundImage = CropImage(deck, new Rectangle(x, y, 90, 126)); }
                                if (i == 1) { PlayerSlot2.BackgroundImage = CropImage(deck, new Rectangle(x, y, 90, 126)); }
                            }
                        }
                    }
                }
                else {
                    if (i == 0) { PlayerSlot1.BackgroundImage = Properties.Resources.hidecard; }
                    if (i == 1) { PlayerSlot2.BackgroundImage = Properties.Resources.hidecard; }
                }
            }

            for (int i = 0; i < dlcards.Length; i++) {
                if (dlcards[i] != "0" & mode != 0) {
                    for (int k = 0; k < allcards.GetLength(0); k++) {
                        for (int f = 0; f < allcards.GetLength(1); f++) {
                            if (dlcards[i] == allcards[k, f]) {
                                x = f * 90;
                                y = k * 126;
                                if (i == 0) { DillerSlot1.BackgroundImage = CropImage(deck, new Rectangle(x, y, 90, 126)); }
                                if (i == 1) { DillerSlot2.BackgroundImage = CropImage(deck, new Rectangle(x, y, 90, 126)); }
                            }
                        }
                    }
                }
                else {
                    if (i == 0) { DillerSlot1.BackgroundImage = Properties.Resources.hidecard; }
                    if (i == 1) { DillerSlot2.BackgroundImage = Properties.Resources.hidecard; }
                }
            }
        }

        private static Image CropImage(Image img, Rectangle Area) {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(Area, bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }
        private void SwitchPanel(Form panel) {
            this.Controls.Clear();
            panel.TopLevel = false;
            this.Controls.Add(panel);
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }
        private void SwitchButtons(int mode) {
            if (mode == 0) {
                CheckBtn.Enabled = false;
                FoldBtn.Enabled = false;
                RaiseBtn.Enabled = false;
            }
            if (mode == 1) {
                CheckBtn.Enabled = true;
                FoldBtn.Enabled = true;
                RaiseBtn.Enabled = true;
            }
        }
        private string crypt(string str, ushort key) {
            string result = "";
            for (int i = 0; i < str.Length; i++) { result += (char)(str[i] ^ key); }
            return result;
        }
        private static string Cut(string s, int i1, int i2) {
            i1--;
            s = s.Substring(i1, i2 - i1);
            return s;
        }
        private void ReWrite(string item, int rise = 1) {
            int ind = 0;
            if (StartForm.PlayerName != "Guest") {
                FileInfo file = new FileInfo(path);
                string[] profiles = File.ReadAllLines(path);
                if (profiles.Length != 0) {
                    for (int i = 0; i < profiles.Length; i++) {
                        profiles[i] = crypt(profiles[i], key);
                        if (Cut(profiles[i], 1, profiles[i].IndexOf(":")) == StartForm.PlayerName) {
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

        private void PokerGame() {
            EventBox.Text = "\r\n" + EventBox.Text;
            PlBetLabel.Text = "---";
            DlBetLabel.Text = "---";
            PlEventBox.Image = null;
            DlEventBox.Image = null;
            if (move == 1) {
                betcount = 1;
                for (int i = 0; i <= 1; i++) { plcards[i] = "0"; dlcards[i] = "0"; }
                for (int i = 0; i <= 4; i++) { tablecards[i] = "0"; }
                index = 2; bet = blind; pot = 2 * blind;
                BetLabel.Text = "ставка: " + bet;
                BankLabel.Text = "Банк: " + pot;
                GenerateCards(allcards, tablecards, plcards, dlcards, plcards, 1);
                GenerateCards(allcards, tablecards, plcards, dlcards, dlcards, 1);
            }
            if (move <= 4) {
                if (stack < raise + blind + bet) { RaiseBtn.Enabled = false; }
                if (choice == "n") { FinishGame(); }
                raise = 0;
                if (stack >= blind + bet) { betcheck = BotBet(CheckCombo(dlcards, tablecards)); } else { betcheck = false; }
                betcount = 1;
                Bets();
            }
            else { FinishGame(); }
        }
        private void Bets() {
            if (betcount <= 3) {
                DrawCards(0);
                BetLabel.Text = "Ставка: " + bet;
                BankLabel.Text = "Банк: " + pot;
                if (betcheck) {
                    raise += blind;
                    EventBox.Text = "Соперник повысил ставку +" + raise + "\r\n" + EventBox.Text;
                    DlBetLabel.Text = "+" + raise;
                    DlEventBox.Image = Properties.Resources.uparrow;
                    PlEventBox.Image = null;
                }
                else {
                    choice = "y";
                    EventBox.Text = "Соперник принял ставку" + "\r\n" + EventBox.Text;
                    DlBetLabel.Text = "---";
                    DlEventBox.Image = Properties.Resources.check;
                    PlEventBox.Image = null;
                }
            }
        }
        private void FinishGame() {
            PlEventBox.Image = null;
            DlEventBox.Image = null;
            stack -= bet;
            BetLabel.Text = "Ставка: " + bet;
            BankLabel.Text = "Банк: " + pot;
            if (choice != "n") {
                DrawCards(1);
                PlBetLabel.Text = DefineCombos(CheckCombo(plcards, tablecards));
                DlBetLabel.Text = DefineCombos(CheckCombo(dlcards, tablecards));
                if (CheckCombo(dlcards, tablecards) > CheckCombo(plcards, tablecards)) {
                    EventBox.Text = "Вы проиграли: " + bet + "\r\n" + EventBox.Text;
                    ReWrite("lvl", 3);
                }
                else if (CheckCombo(dlcards, tablecards) < CheckCombo(plcards, tablecards))
                {
                    EventBox.Text = "Вы выйграли: " + bet + "\r\n" + EventBox.Text;
                    stack += pot;
                    ReWrite("pokerwins", 1);
                    ReWrite("lvl", 5);
                }
                else if (CheckCombo(dlcards, tablecards) == CheckCombo(plcards, tablecards))
                {
                    EventBox.Text = "Ничья, банк: " + pot + " делится пополам" + "\r\n" + EventBox.Text;
                    stack += pot / 2;
                    ReWrite("lvl", 3);
                }
            }
            else { EventBox.Text = "вы проиграли: " + bet + "\r\n" + EventBox.Text; }

            StackLabel.Text = stack.ToString();
            FoldBtn.Enabled = false;
            RaiseBtn.Enabled = false;
            raise = 0;
            ReWrite("pokergames", 1);
            StartForm.gamefinished = 1;
        }


        ushort key = 0x4792;
        string path = "profiles.txt";
        private void CheckBtn_Click(object sender, EventArgs e) {
            StartForm.gamefinished = 0;
            SwitchButtons(0);
            if (move != 5 & choice != "n") {
                choice = "y";
                EventBox.Text = "Вы приняли ставку" + "\r\n" + EventBox.Text;
                PlEventBox.Image = Properties.Resources.check;
                DlEventBox.Image = null;
                bet += raise; pot = 2 * bet;
                BetLabel.Text = "Ставка: " + bet;
                if (betcheck) { PlBetLabel.Text = "+" + raise; }
                else { PlBetLabel.Text = "---"; }
                if (move < 4) { GenerateCards(allcards, tablecards, plcards, dlcards, tablecards, index); index++; }
                CheckTimer.Enabled = true;
            }
            else {
                if (stack < blind) { SwitchPanel(new PokerForm()); }
                choice = "y";
                SwitchButtons(1);
                move = 1;
                PokerGame();
            }
        }
        private void FoldBtn_Click(object sender, EventArgs e) {
            SwitchButtons(0);
            PlBetLabel.Text = "---";
            DlBetLabel.Text = "---";
            FoldBtn.Enabled = false;
            RaiseBtn.Enabled = false;
            choice = "n";
            EventBox.Text = "Вы сдались" + "\r\n" + EventBox.Text;
            PlEventBox.Image = Properties.Resources.close;
            DlEventBox.Image = null;
            FoldTimer.Enabled = true; 
        }
        private void RaiseBtn_Click(object sender, EventArgs e) {
            SwitchButtons(0);
            choice = "b";
            betcount++;
            raise += blind; bet += raise; pot = 2 * bet;
            BetLabel.Text = "Ставка: " + bet;
            BankLabel.Text = "Бaнк: " + pot;
            EventBox.Text = "Вы повысили ставку +" + raise + "\r\n" + EventBox.Text;
            PlEventBox.Image = Properties.Resources.uparrow;
            DlEventBox.Image = null;
            PlBetLabel.Text = "+" + raise;
            if (stack >= blind + raise + bet) { betcheck = BotBet(CheckCombo(dlcards, tablecards)); } else { betcheck = false; }
            if (!betcheck | betcount > 3)
            {
                EventBox.Text = "Соперник принял ставку" + "\r\n" + EventBox.Text;
                DlEventBox.Image = Properties.Resources.check;
                DlBetLabel.Text = "+" + raise;
                if (move < 4) { GenerateCards(allcards, tablecards, plcards, dlcards, tablecards, index); index++; }
            }
            RaiseTimer.Enabled = true;
        }

        private void CheckTimer_Tick(object sender, EventArgs e) {
            SwitchButtons(1);
            CheckTimer.Enabled = false;
            move++;
            PokerGame();
        }
        private void FoldTimer_Tick(object sender, EventArgs e) {
            SwitchButtons(1);
            FoldTimer.Enabled = false;
            FinishGame();
        }
        private void RaiseTimer_Tick(object sender, EventArgs e) {
            SwitchButtons(1);
            RaiseTimer.Enabled = false;
            if (!betcheck | betcount > 3)
            {
                move++;
                PokerGame();
            }
            else  { Bets(); }
        }




        // 225 * 315
        // 90 * 126
        public PokerForm() { 
            InitializeComponent();
            PlayerNameLabel.Text = StartForm.PlayerName;
            DillerNameLabel.Text = StartForm.dlname;
            CheckTimer.Interval = StartForm.pokerdelay;
            FoldTimer.Interval = StartForm.pokerdelay;
            RaiseTimer.Interval = StartForm.pokerdelay;
            FirstBetLabel.Text = StartForm.defpokerbet.ToString();
        }
        private void DenyStackBtn_Click(object sender, EventArgs e) { SwitchPanel(new GamesForm()); }
        private void ApplyStackBtn_Click(object sender, EventArgs e) {
            StartForm.gamefinished = 0;
            stack = int.Parse(FirstBetLabel.Text);
            StartForm.bal -= stack;
            blind = stack * 5 / 100;
            FirstBetPanel.Visible = false;
            DillerPicture.Visible = true;
            PlayerPicture.Visible = true;
            DillerNameLabel.Visible = true;
            PlayerNameLabel.Visible = true;
            BetLabel.Visible = true;
            ChipImage2.Visible = true;
            StackLabel.Visible = true;
            CheckBtn.Visible = true;
            FoldBtn.Visible = true;
            RaiseBtn.Visible = true;
            StackLabel.Text = stack.ToString();
            if (StartForm.enabledchat == 0) { EventBox.Visible = false; } else { EventBox.Visible = true; }

            TableSlot1.Size = new Size(90, 126);
            TableSlot2.Size = new Size(90, 126);
            TableSlot3.Size = new Size(90, 126);
            TableSlot4.Size = new Size(90, 126);
            TableSlot5.Size = new Size(90, 126);

            PlayerSlot1.Size = new Size(90, 126);
            PlayerSlot2.Size = new Size(90, 126);

            DillerSlot1.Size = new Size(90, 126);
            DillerSlot2.Size = new Size(90, 126);
            PokerGame();
        }

        bool UpCheck;
        private void UpBetBtn_MouseDown(object sender, MouseEventArgs e) { BtnTimer.Enabled = true; UpCheck = true; }
        private void UpBetBtn_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }
        private void DownBetBtn_MouseDown(object sender, MouseEventArgs e) { BtnTimer.Enabled = true; UpCheck = false; }
        private void DownBetBtn_MouseUp(object sender, MouseEventArgs e) { BtnTimer.Enabled = false; }
        private void BtnTimer_Tick(object sender, EventArgs e) {
            int c = int.Parse(FirstBetLabel.Text);
            if (UpCheck & c < StartForm.bal) { c++;  }
            else if (!UpCheck & c > 10) { c--; }
            FirstBetLabel.Text = c.ToString();
        }
    }
}