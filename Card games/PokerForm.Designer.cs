
namespace Poker_C_sharp
{
    partial class PokerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EventBox = new System.Windows.Forms.TextBox();
            this.FirstBetPanel = new System.Windows.Forms.Panel();
            this.ChipImage1 = new System.Windows.Forms.Label();
            this.FirstBetLabel = new System.Windows.Forms.Label();
            this.JustStartLabel = new System.Windows.Forms.Label();
            this.DenyStackBtn = new System.Windows.Forms.Button();
            this.ApplyStackBtn = new System.Windows.Forms.Button();
            this.DownBetBtn = new System.Windows.Forms.Button();
            this.UpBetBtn = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Timer(this.components);
            this.BankLabel = new System.Windows.Forms.Label();
            this.BetLabel = new System.Windows.Forms.Label();
            this.PlBetLabel = new System.Windows.Forms.Label();
            this.DlBetLabel = new System.Windows.Forms.Label();
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.FoldTimer = new System.Windows.Forms.Timer(this.components);
            this.RaiseTimer = new System.Windows.Forms.Timer(this.components);
            this.PlEventBox = new System.Windows.Forms.Label();
            this.DlEventBox = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.DillerNameLabel = new System.Windows.Forms.Label();
            this.DillerPicture = new System.Windows.Forms.PictureBox();
            this.PlayerPicture = new System.Windows.Forms.PictureBox();
            this.RaiseBtn = new System.Windows.Forms.Button();
            this.FoldBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.DillerSlot2 = new System.Windows.Forms.PictureBox();
            this.DillerSlot1 = new System.Windows.Forms.PictureBox();
            this.PlayerSlot2 = new System.Windows.Forms.PictureBox();
            this.PlayerSlot1 = new System.Windows.Forms.PictureBox();
            this.TableSlot5 = new System.Windows.Forms.PictureBox();
            this.TableSlot4 = new System.Windows.Forms.PictureBox();
            this.TableSlot3 = new System.Windows.Forms.PictureBox();
            this.TableSlot1 = new System.Windows.Forms.PictureBox();
            this.TableSlot2 = new System.Windows.Forms.PictureBox();
            this.StackLabel = new System.Windows.Forms.Label();
            this.ChipImage2 = new System.Windows.Forms.Label();
            this.FirstBetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DillerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DillerSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DillerSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSlot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSlot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSlot2)).BeginInit();
            this.SuspendLayout();
            // 
            // EventBox
            // 
            this.EventBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.EventBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.EventBox.Location = new System.Drawing.Point(12, 380);
            this.EventBox.Multiline = true;
            this.EventBox.Name = "EventBox";
            this.EventBox.ReadOnly = true;
            this.EventBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EventBox.Size = new System.Drawing.Size(257, 131);
            this.EventBox.TabIndex = 9;
            this.EventBox.Visible = false;
            // 
            // FirstBetPanel
            // 
            this.FirstBetPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.FirstBetPanel.Controls.Add(this.ChipImage1);
            this.FirstBetPanel.Controls.Add(this.FirstBetLabel);
            this.FirstBetPanel.Controls.Add(this.JustStartLabel);
            this.FirstBetPanel.Controls.Add(this.DenyStackBtn);
            this.FirstBetPanel.Controls.Add(this.ApplyStackBtn);
            this.FirstBetPanel.Controls.Add(this.DownBetBtn);
            this.FirstBetPanel.Controls.Add(this.UpBetBtn);
            this.FirstBetPanel.Location = new System.Drawing.Point(279, 126);
            this.FirstBetPanel.Name = "FirstBetPanel";
            this.FirstBetPanel.Size = new System.Drawing.Size(383, 249);
            this.FirstBetPanel.TabIndex = 18;
            // 
            // ChipImage1
            // 
            this.ChipImage1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChipImage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ChipImage1.Image = global::Poker_C_sharp.Properties.Resources.chip16x;
            this.ChipImage1.Location = new System.Drawing.Point(123, 125);
            this.ChipImage1.Name = "ChipImage1";
            this.ChipImage1.Size = new System.Drawing.Size(33, 33);
            this.ChipImage1.TabIndex = 22;
            this.ChipImage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstBetLabel
            // 
            this.FirstBetLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstBetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.FirstBetLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstBetLabel.Location = new System.Drawing.Point(111, 110);
            this.FirstBetLabel.Name = "FirstBetLabel";
            this.FirstBetLabel.Size = new System.Drawing.Size(166, 60);
            this.FirstBetLabel.TabIndex = 21;
            this.FirstBetLabel.Text = "100";
            this.FirstBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JustStartLabel
            // 
            this.JustStartLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JustStartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.JustStartLabel.Location = new System.Drawing.Point(83, 36);
            this.JustStartLabel.Name = "JustStartLabel";
            this.JustStartLabel.Size = new System.Drawing.Size(218, 60);
            this.JustStartLabel.TabIndex = 22;
            this.JustStartLabel.Text = "Выберите размер стека";
            this.JustStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DenyStackBtn
            // 
            this.DenyStackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.DenyStackBtn.FlatAppearance.BorderSize = 0;
            this.DenyStackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DenyStackBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DenyStackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.DenyStackBtn.Image = global::Poker_C_sharp.Properties.Resources.close;
            this.DenyStackBtn.Location = new System.Drawing.Point(3, 188);
            this.DenyStackBtn.Name = "DenyStackBtn";
            this.DenyStackBtn.Size = new System.Drawing.Size(186, 58);
            this.DenyStackBtn.TabIndex = 19;
            this.DenyStackBtn.UseVisualStyleBackColor = false;
            this.DenyStackBtn.Click += new System.EventHandler(this.DenyStackBtn_Click);
            // 
            // ApplyStackBtn
            // 
            this.ApplyStackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.ApplyStackBtn.FlatAppearance.BorderSize = 0;
            this.ApplyStackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyStackBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyStackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ApplyStackBtn.Image = global::Poker_C_sharp.Properties.Resources.check;
            this.ApplyStackBtn.Location = new System.Drawing.Point(195, 187);
            this.ApplyStackBtn.Name = "ApplyStackBtn";
            this.ApplyStackBtn.Size = new System.Drawing.Size(185, 59);
            this.ApplyStackBtn.TabIndex = 19;
            this.ApplyStackBtn.UseVisualStyleBackColor = false;
            this.ApplyStackBtn.Click += new System.EventHandler(this.ApplyStackBtn_Click);
            // 
            // DownBetBtn
            // 
            this.DownBetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.DownBetBtn.FlatAppearance.BorderSize = 0;
            this.DownBetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownBetBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownBetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.DownBetBtn.Location = new System.Drawing.Point(40, 110);
            this.DownBetBtn.Name = "DownBetBtn";
            this.DownBetBtn.Size = new System.Drawing.Size(60, 60);
            this.DownBetBtn.TabIndex = 20;
            this.DownBetBtn.Text = "<";
            this.DownBetBtn.UseVisualStyleBackColor = false;
            this.DownBetBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownBetBtn_MouseDown);
            this.DownBetBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DownBetBtn_MouseUp);
            // 
            // UpBetBtn
            // 
            this.UpBetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.UpBetBtn.FlatAppearance.BorderSize = 0;
            this.UpBetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpBetBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpBetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.UpBetBtn.Location = new System.Drawing.Point(283, 110);
            this.UpBetBtn.Name = "UpBetBtn";
            this.UpBetBtn.Size = new System.Drawing.Size(60, 60);
            this.UpBetBtn.TabIndex = 19;
            this.UpBetBtn.Text = ">";
            this.UpBetBtn.UseVisualStyleBackColor = false;
            this.UpBetBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBetBtn_MouseDown);
            this.UpBetBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpBetBtn_MouseUp);
            // 
            // BtnTimer
            // 
            this.BtnTimer.Interval = 10;
            this.BtnTimer.Tick += new System.EventHandler(this.BtnTimer_Tick);
            // 
            // BankLabel
            // 
            this.BankLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.BankLabel.Location = new System.Drawing.Point(420, 186);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(101, 58);
            this.BankLabel.TabIndex = 24;
            this.BankLabel.Text = "Банк: ----";
            this.BankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BetLabel
            // 
            this.BetLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.BetLabel.Location = new System.Drawing.Point(709, 451);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(121, 58);
            this.BetLabel.TabIndex = 25;
            this.BetLabel.Text = "Ставка: ----";
            this.BetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BetLabel.Visible = false;
            // 
            // PlBetLabel
            // 
            this.PlBetLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlBetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.PlBetLabel.Location = new System.Drawing.Point(148, 335);
            this.PlBetLabel.Name = "PlBetLabel";
            this.PlBetLabel.Size = new System.Drawing.Size(252, 40);
            this.PlBetLabel.TabIndex = 26;
            this.PlBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DlBetLabel
            // 
            this.DlBetLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DlBetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.DlBetLabel.Location = new System.Drawing.Point(541, 335);
            this.DlBetLabel.Name = "DlBetLabel";
            this.DlBetLabel.Size = new System.Drawing.Size(252, 40);
            this.DlBetLabel.TabIndex = 27;
            this.DlBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckTimer
            // 
            this.CheckTimer.Interval = 1500;
            this.CheckTimer.Tick += new System.EventHandler(this.CheckTimer_Tick);
            // 
            // FoldTimer
            // 
            this.FoldTimer.Interval = 1500;
            this.FoldTimer.Tick += new System.EventHandler(this.FoldTimer_Tick);
            // 
            // RaiseTimer
            // 
            this.RaiseTimer.Interval = 1500;
            this.RaiseTimer.Tick += new System.EventHandler(this.RaiseTimer_Tick);
            // 
            // PlEventBox
            // 
            this.PlEventBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlEventBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.PlEventBox.Location = new System.Drawing.Point(12, 145);
            this.PlEventBox.Name = "PlEventBox";
            this.PlEventBox.Size = new System.Drawing.Size(120, 120);
            this.PlEventBox.TabIndex = 33;
            this.PlEventBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DlEventBox
            // 
            this.DlEventBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DlEventBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.DlEventBox.Location = new System.Drawing.Point(810, 145);
            this.DlEventBox.Name = "DlEventBox";
            this.DlEventBox.Size = new System.Drawing.Size(120, 120);
            this.DlEventBox.TabIndex = 34;
            this.DlEventBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.PlayerNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.PlayerNameLabel.Location = new System.Drawing.Point(12, 107);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(120, 25);
            this.PlayerNameLabel.TabIndex = 35;
            this.PlayerNameLabel.Text = "Guest";
            this.PlayerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerNameLabel.Visible = false;
            // 
            // DillerNameLabel
            // 
            this.DillerNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.DillerNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DillerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.DillerNameLabel.Location = new System.Drawing.Point(811, 107);
            this.DillerNameLabel.Name = "DillerNameLabel";
            this.DillerNameLabel.Size = new System.Drawing.Size(120, 25);
            this.DillerNameLabel.TabIndex = 36;
            this.DillerNameLabel.Text = "Jimm";
            this.DillerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DillerNameLabel.Visible = false;
            // 
            // DillerPicture
            // 
            this.DillerPicture.Image = global::Poker_C_sharp.Properties.Resources.diller;
            this.DillerPicture.Location = new System.Drawing.Point(810, 12);
            this.DillerPicture.Name = "DillerPicture";
            this.DillerPicture.Size = new System.Drawing.Size(120, 120);
            this.DillerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DillerPicture.TabIndex = 30;
            this.DillerPicture.TabStop = false;
            this.DillerPicture.Visible = false;
            // 
            // PlayerPicture
            // 
            this.PlayerPicture.Image = global::Poker_C_sharp.Properties.Resources.player;
            this.PlayerPicture.Location = new System.Drawing.Point(12, 12);
            this.PlayerPicture.Name = "PlayerPicture";
            this.PlayerPicture.Size = new System.Drawing.Size(120, 120);
            this.PlayerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerPicture.TabIndex = 29;
            this.PlayerPicture.TabStop = false;
            this.PlayerPicture.Visible = false;
            // 
            // RaiseBtn
            // 
            this.RaiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.RaiseBtn.FlatAppearance.BorderSize = 0;
            this.RaiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RaiseBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RaiseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.RaiseBtn.Image = global::Poker_C_sharp.Properties.Resources.uparrow;
            this.RaiseBtn.Location = new System.Drawing.Point(541, 451);
            this.RaiseBtn.Name = "RaiseBtn";
            this.RaiseBtn.Size = new System.Drawing.Size(121, 60);
            this.RaiseBtn.TabIndex = 17;
            this.RaiseBtn.UseVisualStyleBackColor = false;
            this.RaiseBtn.Visible = false;
            this.RaiseBtn.Click += new System.EventHandler(this.RaiseBtn_Click);
            // 
            // FoldBtn
            // 
            this.FoldBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.FoldBtn.FlatAppearance.BorderSize = 0;
            this.FoldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoldBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoldBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.FoldBtn.Image = global::Poker_C_sharp.Properties.Resources.close;
            this.FoldBtn.Location = new System.Drawing.Point(279, 451);
            this.FoldBtn.Name = "FoldBtn";
            this.FoldBtn.Size = new System.Drawing.Size(121, 60);
            this.FoldBtn.TabIndex = 16;
            this.FoldBtn.UseVisualStyleBackColor = false;
            this.FoldBtn.Visible = false;
            this.FoldBtn.Click += new System.EventHandler(this.FoldBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.CheckBtn.FlatAppearance.BorderSize = 0;
            this.CheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.CheckBtn.Image = global::Poker_C_sharp.Properties.Resources.check;
            this.CheckBtn.Location = new System.Drawing.Point(410, 451);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(121, 60);
            this.CheckBtn.TabIndex = 15;
            this.CheckBtn.UseVisualStyleBackColor = false;
            this.CheckBtn.Visible = false;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // DillerSlot2
            // 
            this.DillerSlot2.Location = new System.Drawing.Point(672, 177);
            this.DillerSlot2.Name = "DillerSlot2";
            this.DillerSlot2.Size = new System.Drawing.Size(121, 155);
            this.DillerSlot2.TabIndex = 14;
            this.DillerSlot2.TabStop = false;
            // 
            // DillerSlot1
            // 
            this.DillerSlot1.Location = new System.Drawing.Point(541, 177);
            this.DillerSlot1.Name = "DillerSlot1";
            this.DillerSlot1.Size = new System.Drawing.Size(121, 155);
            this.DillerSlot1.TabIndex = 13;
            this.DillerSlot1.TabStop = false;
            // 
            // PlayerSlot2
            // 
            this.PlayerSlot2.Location = new System.Drawing.Point(279, 177);
            this.PlayerSlot2.Name = "PlayerSlot2";
            this.PlayerSlot2.Size = new System.Drawing.Size(121, 155);
            this.PlayerSlot2.TabIndex = 12;
            this.PlayerSlot2.TabStop = false;
            // 
            // PlayerSlot1
            // 
            this.PlayerSlot1.Location = new System.Drawing.Point(148, 177);
            this.PlayerSlot1.Name = "PlayerSlot1";
            this.PlayerSlot1.Size = new System.Drawing.Size(121, 155);
            this.PlayerSlot1.TabIndex = 11;
            this.PlayerSlot1.TabStop = false;
            // 
            // TableSlot5
            // 
            this.TableSlot5.Location = new System.Drawing.Point(672, 12);
            this.TableSlot5.Name = "TableSlot5";
            this.TableSlot5.Size = new System.Drawing.Size(121, 155);
            this.TableSlot5.TabIndex = 10;
            this.TableSlot5.TabStop = false;
            // 
            // TableSlot4
            // 
            this.TableSlot4.Location = new System.Drawing.Point(541, 12);
            this.TableSlot4.Name = "TableSlot4";
            this.TableSlot4.Size = new System.Drawing.Size(121, 155);
            this.TableSlot4.TabIndex = 9;
            this.TableSlot4.TabStop = false;
            // 
            // TableSlot3
            // 
            this.TableSlot3.Location = new System.Drawing.Point(410, 12);
            this.TableSlot3.Name = "TableSlot3";
            this.TableSlot3.Size = new System.Drawing.Size(121, 155);
            this.TableSlot3.TabIndex = 8;
            this.TableSlot3.TabStop = false;
            // 
            // TableSlot1
            // 
            this.TableSlot1.Location = new System.Drawing.Point(148, 12);
            this.TableSlot1.Name = "TableSlot1";
            this.TableSlot1.Size = new System.Drawing.Size(121, 155);
            this.TableSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TableSlot1.TabIndex = 6;
            this.TableSlot1.TabStop = false;
            // 
            // TableSlot2
            // 
            this.TableSlot2.Location = new System.Drawing.Point(279, 12);
            this.TableSlot2.Name = "TableSlot2";
            this.TableSlot2.Size = new System.Drawing.Size(121, 155);
            this.TableSlot2.TabIndex = 7;
            this.TableSlot2.TabStop = false;
            // 
            // StackLabel
            // 
            this.StackLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StackLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.StackLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StackLabel.Location = new System.Drawing.Point(410, 381);
            this.StackLabel.Name = "StackLabel";
            this.StackLabel.Size = new System.Drawing.Size(121, 58);
            this.StackLabel.TabIndex = 23;
            this.StackLabel.Text = "100";
            this.StackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StackLabel.Visible = false;
            // 
            // ChipImage2
            // 
            this.ChipImage2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChipImage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ChipImage2.Image = global::Poker_C_sharp.Properties.Resources.chip16x;
            this.ChipImage2.Location = new System.Drawing.Point(402, 394);
            this.ChipImage2.Name = "ChipImage2";
            this.ChipImage2.Size = new System.Drawing.Size(33, 33);
            this.ChipImage2.TabIndex = 23;
            this.ChipImage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChipImage2.Visible = false;
            // 
            // PokerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(942, 523);
            this.Controls.Add(this.ChipImage2);
            this.Controls.Add(this.StackLabel);
            this.Controls.Add(this.DillerNameLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.FirstBetPanel);
            this.Controls.Add(this.DlEventBox);
            this.Controls.Add(this.PlEventBox);
            this.Controls.Add(this.DillerPicture);
            this.Controls.Add(this.PlayerPicture);
            this.Controls.Add(this.DlBetLabel);
            this.Controls.Add(this.PlBetLabel);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.BankLabel);
            this.Controls.Add(this.RaiseBtn);
            this.Controls.Add(this.FoldBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.DillerSlot2);
            this.Controls.Add(this.DillerSlot1);
            this.Controls.Add(this.PlayerSlot2);
            this.Controls.Add(this.PlayerSlot1);
            this.Controls.Add(this.TableSlot5);
            this.Controls.Add(this.TableSlot4);
            this.Controls.Add(this.TableSlot3);
            this.Controls.Add(this.TableSlot1);
            this.Controls.Add(this.EventBox);
            this.Controls.Add(this.TableSlot2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PokerForm";
            this.Text = "PokerForm";
            this.FirstBetPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DillerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DillerSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DillerSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSlot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSlot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSlot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSlot2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EventBox;
        private System.Windows.Forms.PictureBox TableSlot1;
        private System.Windows.Forms.PictureBox TableSlot2;
        private System.Windows.Forms.PictureBox TableSlot3;
        private System.Windows.Forms.PictureBox TableSlot4;
        private System.Windows.Forms.PictureBox TableSlot5;
        private System.Windows.Forms.PictureBox PlayerSlot1;
        private System.Windows.Forms.PictureBox PlayerSlot2;
        private System.Windows.Forms.PictureBox DillerSlot1;
        private System.Windows.Forms.PictureBox DillerSlot2;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button FoldBtn;
        private System.Windows.Forms.Button RaiseBtn;
        private System.Windows.Forms.Panel FirstBetPanel;
        private System.Windows.Forms.Label FirstBetLabel;
        private System.Windows.Forms.Button DownBetBtn;
        private System.Windows.Forms.Button UpBetBtn;
        private System.Windows.Forms.Timer BtnTimer;
        private System.Windows.Forms.Label JustStartLabel;
        private System.Windows.Forms.Button DenyStackBtn;
        private System.Windows.Forms.Button ApplyStackBtn;
        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Label PlBetLabel;
        private System.Windows.Forms.Label DlBetLabel;
        private System.Windows.Forms.Timer CheckTimer;
        private System.Windows.Forms.Timer FoldTimer;
        private System.Windows.Forms.Timer RaiseTimer;
        private System.Windows.Forms.Label ChipImage1;
        private System.Windows.Forms.PictureBox PlayerPicture;
        private System.Windows.Forms.PictureBox DillerPicture;
        private System.Windows.Forms.Label PlEventBox;
        private System.Windows.Forms.Label DlEventBox;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label DillerNameLabel;
        private System.Windows.Forms.Label StackLabel;
        private System.Windows.Forms.Label ChipImage2;
    }
}