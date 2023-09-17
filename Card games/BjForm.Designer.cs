
namespace Poker_C_sharp
{
    partial class BjForm
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
            this.FirstBetPanel = new System.Windows.Forms.Panel();
            this.ChipImage1 = new System.Windows.Forms.Label();
            this.FirstBetLabel = new System.Windows.Forms.Label();
            this.JustStartLabel = new System.Windows.Forms.Label();
            this.DenyStackBtn = new System.Windows.Forms.Button();
            this.ApplyStackBtn = new System.Windows.Forms.Button();
            this.DownBetBtn = new System.Windows.Forms.Button();
            this.UpBetBtn = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Timer(this.components);
            this.PlPointsLabel = new System.Windows.Forms.Label();
            this.DlPointsLabel = new System.Windows.Forms.Label();
            this.StackLabel = new System.Windows.Forms.Label();
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.DlMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.WinLabel1 = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.DillerNameLabel = new System.Windows.Forms.Label();
            this.SplitBtn = new System.Windows.Forms.Button();
            this.DillerPicture = new System.Windows.Forms.PictureBox();
            this.PlayerPicture = new System.Windows.Forms.PictureBox();
            this.RaiseBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.PlCardsBox = new System.Windows.Forms.PictureBox();
            this.DlCardsBox = new System.Windows.Forms.PictureBox();
            this.SplCardsBox = new System.Windows.Forms.PictureBox();
            this.WinLabel2 = new System.Windows.Forms.Label();
            this.ChipImage2 = new System.Windows.Forms.Label();
            this.PlEventBox = new System.Windows.Forms.Label();
            this.DlEventBox = new System.Windows.Forms.Label();
            this.FirstBetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DillerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlCardsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlCardsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplCardsBox)).BeginInit();
            this.SuspendLayout();
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
            this.FirstBetPanel.TabIndex = 19;
            // 
            // ChipImage1
            // 
            this.ChipImage1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChipImage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ChipImage1.Image = global::Poker_C_sharp.Properties.Resources.chip16x;
            this.ChipImage1.Location = new System.Drawing.Point(123, 125);
            this.ChipImage1.Name = "ChipImage1";
            this.ChipImage1.Size = new System.Drawing.Size(30, 30);
            this.ChipImage1.TabIndex = 22;
            this.ChipImage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstBetLabel
            // 
            this.FirstBetLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstBetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.FirstBetLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstBetLabel.Location = new System.Drawing.Point(106, 110);
            this.FirstBetLabel.Name = "FirstBetLabel";
            this.FirstBetLabel.Size = new System.Drawing.Size(171, 60);
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
            // PlPointsLabel
            // 
            this.PlPointsLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlPointsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.PlPointsLabel.Location = new System.Drawing.Point(281, 200);
            this.PlPointsLabel.Name = "PlPointsLabel";
            this.PlPointsLabel.Size = new System.Drawing.Size(120, 24);
            this.PlPointsLabel.TabIndex = 42;
            this.PlPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DlPointsLabel
            // 
            this.DlPointsLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DlPointsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.DlPointsLabel.Location = new System.Drawing.Point(541, 200);
            this.DlPointsLabel.Name = "DlPointsLabel";
            this.DlPointsLabel.Size = new System.Drawing.Size(120, 24);
            this.DlPointsLabel.TabIndex = 43;
            this.DlPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StackLabel
            // 
            this.StackLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StackLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.StackLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StackLabel.Location = new System.Drawing.Point(410, 378);
            this.StackLabel.Name = "StackLabel";
            this.StackLabel.Size = new System.Drawing.Size(121, 60);
            this.StackLabel.TabIndex = 23;
            this.StackLabel.Text = "100";
            this.StackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StackLabel.Visible = false;
            // 
            // Delay
            // 
            this.Delay.Interval = 1000;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // DlMoveTimer
            // 
            this.DlMoveTimer.Interval = 1000;
            this.DlMoveTimer.Tick += new System.EventHandler(this.DlMoveTimer_Tick);
            // 
            // WinLabel1
            // 
            this.WinLabel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.WinLabel1.Location = new System.Drawing.Point(140, 486);
            this.WinLabel1.Name = "WinLabel1";
            this.WinLabel1.Size = new System.Drawing.Size(105, 25);
            this.WinLabel1.TabIndex = 49;
            this.WinLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.PlayerNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.PlayerNameLabel.Location = new System.Drawing.Point(281, 175);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(120, 25);
            this.PlayerNameLabel.TabIndex = 50;
            this.PlayerNameLabel.Text = "Guest";
            this.PlayerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerNameLabel.Visible = false;
            // 
            // DillerNameLabel
            // 
            this.DillerNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.DillerNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DillerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.DillerNameLabel.Location = new System.Drawing.Point(541, 175);
            this.DillerNameLabel.Name = "DillerNameLabel";
            this.DillerNameLabel.Size = new System.Drawing.Size(120, 25);
            this.DillerNameLabel.TabIndex = 51;
            this.DillerNameLabel.Text = "Jimm";
            this.DillerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DillerNameLabel.Visible = false;
            // 
            // SplitBtn
            // 
            this.SplitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.SplitBtn.FlatAppearance.BorderSize = 0;
            this.SplitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SplitBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SplitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.SplitBtn.Image = global::Poker_C_sharp.Properties.Resources.split;
            this.SplitBtn.Location = new System.Drawing.Point(541, 381);
            this.SplitBtn.Name = "SplitBtn";
            this.SplitBtn.Size = new System.Drawing.Size(121, 60);
            this.SplitBtn.TabIndex = 48;
            this.SplitBtn.UseVisualStyleBackColor = false;
            this.SplitBtn.Visible = false;
            this.SplitBtn.Click += new System.EventHandler(this.SplitBtn_Click);
            // 
            // DillerPicture
            // 
            this.DillerPicture.Image = global::Poker_C_sharp.Properties.Resources.diller;
            this.DillerPicture.Location = new System.Drawing.Point(541, 80);
            this.DillerPicture.Name = "DillerPicture";
            this.DillerPicture.Size = new System.Drawing.Size(120, 120);
            this.DillerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DillerPicture.TabIndex = 37;
            this.DillerPicture.TabStop = false;
            this.DillerPicture.Visible = false;
            // 
            // PlayerPicture
            // 
            this.PlayerPicture.Image = global::Poker_C_sharp.Properties.Resources.player;
            this.PlayerPicture.Location = new System.Drawing.Point(281, 80);
            this.PlayerPicture.Name = "PlayerPicture";
            this.PlayerPicture.Size = new System.Drawing.Size(120, 120);
            this.PlayerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerPicture.TabIndex = 36;
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
            this.RaiseBtn.TabIndex = 25;
            this.RaiseBtn.UseVisualStyleBackColor = false;
            this.RaiseBtn.Visible = false;
            this.RaiseBtn.Click += new System.EventHandler(this.RaiseBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.AddBtn.Image = global::Poker_C_sharp.Properties.Resources.plus;
            this.AddBtn.Location = new System.Drawing.Point(410, 451);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(121, 60);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Visible = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.CheckBtn.FlatAppearance.BorderSize = 0;
            this.CheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.CheckBtn.Image = global::Poker_C_sharp.Properties.Resources.stand;
            this.CheckBtn.Location = new System.Drawing.Point(279, 451);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(121, 60);
            this.CheckBtn.TabIndex = 23;
            this.CheckBtn.UseVisualStyleBackColor = false;
            this.CheckBtn.Visible = false;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // PlCardsBox
            // 
            this.PlCardsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.PlCardsBox.Location = new System.Drawing.Point(143, 80);
            this.PlCardsBox.Name = "PlCardsBox";
            this.PlCardsBox.Size = new System.Drawing.Size(90, 363);
            this.PlCardsBox.TabIndex = 22;
            this.PlCardsBox.TabStop = false;
            // 
            // DlCardsBox
            // 
            this.DlCardsBox.Location = new System.Drawing.Point(678, 80);
            this.DlCardsBox.Name = "DlCardsBox";
            this.DlCardsBox.Size = new System.Drawing.Size(90, 363);
            this.DlCardsBox.TabIndex = 21;
            this.DlCardsBox.TabStop = false;
            // 
            // SplCardsBox
            // 
            this.SplCardsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.SplCardsBox.Location = new System.Drawing.Point(12, 80);
            this.SplCardsBox.Name = "SplCardsBox";
            this.SplCardsBox.Size = new System.Drawing.Size(90, 363);
            this.SplCardsBox.TabIndex = 46;
            this.SplCardsBox.TabStop = false;
            // 
            // WinLabel2
            // 
            this.WinLabel2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.WinLabel2.Location = new System.Drawing.Point(9, 486);
            this.WinLabel2.Name = "WinLabel2";
            this.WinLabel2.Size = new System.Drawing.Size(105, 25);
            this.WinLabel2.TabIndex = 52;
            this.WinLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChipImage2
            // 
            this.ChipImage2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChipImage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ChipImage2.Image = global::Poker_C_sharp.Properties.Resources.chip16x;
            this.ChipImage2.Location = new System.Drawing.Point(402, 393);
            this.ChipImage2.Name = "ChipImage2";
            this.ChipImage2.Size = new System.Drawing.Size(30, 30);
            this.ChipImage2.TabIndex = 54;
            this.ChipImage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChipImage2.Visible = false;
            // 
            // PlEventBox
            // 
            this.PlEventBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlEventBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.PlEventBox.Location = new System.Drawing.Point(281, 224);
            this.PlEventBox.Name = "PlEventBox";
            this.PlEventBox.Size = new System.Drawing.Size(120, 120);
            this.PlEventBox.TabIndex = 55;
            this.PlEventBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DlEventBox
            // 
            this.DlEventBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DlEventBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.DlEventBox.Location = new System.Drawing.Point(541, 224);
            this.DlEventBox.Name = "DlEventBox";
            this.DlEventBox.Size = new System.Drawing.Size(120, 120);
            this.DlEventBox.TabIndex = 56;
            this.DlEventBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(942, 523);
            this.Controls.Add(this.FirstBetPanel);
            this.Controls.Add(this.DlEventBox);
            this.Controls.Add(this.PlEventBox);
            this.Controls.Add(this.ChipImage2);
            this.Controls.Add(this.WinLabel2);
            this.Controls.Add(this.DillerNameLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.SplitBtn);
            this.Controls.Add(this.StackLabel);
            this.Controls.Add(this.DlPointsLabel);
            this.Controls.Add(this.PlPointsLabel);
            this.Controls.Add(this.DillerPicture);
            this.Controls.Add(this.PlayerPicture);
            this.Controls.Add(this.RaiseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.PlCardsBox);
            this.Controls.Add(this.DlCardsBox);
            this.Controls.Add(this.SplCardsBox);
            this.Controls.Add(this.WinLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BjForm";
            this.Text = "BjForm";
            this.FirstBetPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DillerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlCardsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlCardsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplCardsBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FirstBetPanel;
        private System.Windows.Forms.Label ChipImage1;
        private System.Windows.Forms.Label JustStartLabel;
        private System.Windows.Forms.Button DenyStackBtn;
        private System.Windows.Forms.Button ApplyStackBtn;
        private System.Windows.Forms.Button DownBetBtn;
        private System.Windows.Forms.Button UpBetBtn;
        private System.Windows.Forms.Timer BtnTimer;
        private System.Windows.Forms.PictureBox DlCardsBox;
        private System.Windows.Forms.PictureBox PlCardsBox;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RaiseBtn;
        private System.Windows.Forms.PictureBox PlayerPicture;
        private System.Windows.Forms.PictureBox DillerPicture;
        private System.Windows.Forms.Label PlPointsLabel;
        private System.Windows.Forms.Label DlPointsLabel;
        private System.Windows.Forms.PictureBox SplCardsBox;
        private System.Windows.Forms.Label StackLabel;
        private System.Windows.Forms.Button SplitBtn;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.Timer DlMoveTimer;
        private System.Windows.Forms.Label WinLabel1;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label DillerNameLabel;
        private System.Windows.Forms.Label WinLabel2;
        private System.Windows.Forms.Label FirstBetLabel;
        private System.Windows.Forms.Label ChipImage2;
        private System.Windows.Forms.Label PlEventBox;
        private System.Windows.Forms.Label DlEventBox;
    }
}