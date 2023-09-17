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
    public partial class RatingForm : Form
    {
        public RatingForm() {
            InitializeComponent();
            list = DoSomeFuckinMagic("lvl");
            for (int i = 0; i < list.GetLength(0); i++) {
                if (list[i, 1].Length > 2) {
                    list[i, 1] = Cut(list[i, 1], 1, list[i, 1].Length - 2);
                }
                else { list[i, 1] = "0"; }
            }
            RefreshList(1, list);
            list = DoSomeFuckinMagic("pokergames");
            RefreshList(2, list);
            list = DoSomeFuckinMagic("bjgames");
            RefreshList(3, list);
        }
        string[,] list = new string[5, 5];
        string path = "profiles.txt";
        ushort key = 0x4792;
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
        private string[,] GiveMeArr(string item) {
            string name, value;
            FileInfo file = new FileInfo(path);
            if (file.Exists) {
                string[] profiles = File.ReadAllLines(path);
                string[,] arr = new string[5, 2];
                if (profiles.Length != 0) {
                    for (int i = 0; i < profiles.Length; i++) {
                        profiles[i] = crypt(profiles[i], key);
                        name = Cut(profiles[i], 1, profiles[i].IndexOf(":"));
                        value = Cut(profiles[i], profiles[i].IndexOf(item) + item.Length + 2, profiles[i].Length);
                        value = Cut(value, 1, value.IndexOf(" "));
                        arr[i, 0] = name; arr[i, 1] = value;
                    }
                    for (int i = profiles.Length; i < arr.GetLength(0); i++) {
                        arr[i, 0] = "-"; arr[i, 1] = "0";
                    }
                    return arr;
                }
            }
            string[,] a = new string[0, 0];
            return a;
        }
        private void SortArr(ref string[,] arr) {
            string swap;
            int[] values = new int [arr.GetLength(0)];
            for (int i = 0; i < values.Length; i++) {
                values[i] = int.Parse(arr[i, 1]);
            }
            for (int i = 0; i < values.Length - 1; i++) {
            int j = i;
                while (values[j] < values[j + 1]) {
                    swap = values[j].ToString(); 
                    values[j] = values[j + 1]; 
                    values[j + 1] = int.Parse(swap);

                    swap = arr[j, 0];
                    arr[j, 0] = arr[j + 1, 0];
                    arr[j + 1, 0] = swap;

                    swap = arr[j, 1];
                    arr[j, 1] = arr[j + 1, 1];
                    arr[j + 1, 1] = swap;

                    j--;
                    if (j == -1) { break; }
                }
            }
        }
        private string[,] DoSomeFuckinMagic(string item, int mode = 0) {
            FileInfo file = new FileInfo(path);
            if (file.Exists) {
                string[] a = File.ReadAllLines(path);
                if (a.Length != 0) {
                    string[,] arr = GiveMeArr(item);
                    SortArr(ref arr);
                    string[,] FinalList = new string[5, 2];
                    for (int i = 0; i < FinalList.GetLength(0); i++)
                    {
                        FinalList[i, 0] = arr[i, 0];
                        FinalList[i, 1] = arr[i, 1];
                    }
                    return FinalList;
                }
                else {
                    for (int i = 0; i < list.GetLength(0); i++) {
                        list[i, 0] = "-"; list[i, 1] = "0";
                    }
                    return list;
                }
            }
            else {
                for (int i = 0; i < list.GetLength(0); i++) {
                    list[i, 0] = "-"; list[i, 1] = "0";
                }
                return list;
            }
        }
        private void RefreshList(int ListIndex, string[,] List) {
            for (int i = 0; i < List.GetLength(0); i++) {
                this.Controls["lb" + ListIndex + i + "0"].Text = List[i, 0];
                this.Controls["lb" + ListIndex + i + "1"].Text = List[i, 1];
            }
        }

        private void LvlBtn_Click(object sender, EventArgs e) {
            LvlBtn.BackColor = Color.FromArgb(26, 27, 43);
            LvlBtn.ForeColor = Color.FromArgb(221, 221, 221);
            BalBtn.BackColor = Color.FromArgb(42, 43, 51);
            BalBtn.ForeColor = Color.FromArgb(130, 130, 130);
            list = DoSomeFuckinMagic("lvl");
            for (int i = 0; i < list.GetLength(0); i++){
                if (list[i, 1].Length > 2) {
                    list[i, 1] = Cut(list[i, 1], 1, list[i, 1].Length - 2);
                }
                else { list[i, 1] = "0"; }
            }
            RefreshList(1, list);
        }
        private void BalBtn_Click(object sender, EventArgs e) {
            LvlBtn.BackColor = Color.FromArgb(42, 43, 51);
            LvlBtn.ForeColor = Color.FromArgb(130, 130, 130);
            BalBtn.BackColor = Color.FromArgb(26, 27, 43);
            BalBtn.ForeColor = Color.FromArgb(221, 221, 221);
            list = DoSomeFuckinMagic("bal");
            RefreshList(1, list);
        }
        private void PokerPlayBtn_Click(object sender, EventArgs e) {
            PokerPlayBtn.BackColor = Color.FromArgb(26, 27, 43);
            PokerPlayBtn.ForeColor = Color.FromArgb(221, 221, 221);
            PokerWinsBtn.BackColor = Color.FromArgb(42, 43, 51);
            PokerWinsBtn.ForeColor = Color.FromArgb(130, 130, 130);
            list = DoSomeFuckinMagic("pokergames");
            RefreshList(2, list);
        }
        private void PokerWinsBtn_Click(object sender, EventArgs e) {
            PokerPlayBtn.BackColor = Color.FromArgb(42, 43, 51);
            PokerPlayBtn.ForeColor = Color.FromArgb(130, 130, 130);
            PokerWinsBtn.BackColor = Color.FromArgb(26, 27, 43);
            PokerWinsBtn.ForeColor = Color.FromArgb(221, 221, 221);
            list = DoSomeFuckinMagic("pokerwins");
            RefreshList(2, list);
        }
        private void BjPlayBtn_Click(object sender, EventArgs e) {
            BjPlayBtn.BackColor = Color.FromArgb(26, 27, 43);
            BjPlayBtn.ForeColor = Color.FromArgb(221, 221, 221);
            BjWinsBtn.BackColor = Color.FromArgb(42, 43, 51);
            BjWinsBtn.ForeColor = Color.FromArgb(130, 130, 130);
            list = DoSomeFuckinMagic("bjgames");
            RefreshList(3, list);
        }
        private void BjWinsBtn_Click(object sender, EventArgs e) {
            BjPlayBtn.BackColor = Color.FromArgb(42, 43, 51);
            BjPlayBtn.ForeColor = Color.FromArgb(130, 130, 130);
            BjWinsBtn.BackColor = Color.FromArgb(26, 27, 43);
            BjWinsBtn.ForeColor = Color.FromArgb(221, 221, 221);
            list = DoSomeFuckinMagic("bjwins");
            RefreshList(3, list);
        }
    }
}
