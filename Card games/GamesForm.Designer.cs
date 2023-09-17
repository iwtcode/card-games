
namespace Poker_C_sharp
{
    partial class GamesForm
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
            this.BlackJackPlayBtn = new System.Windows.Forms.Button();
            this.PokerPlayBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlackJackPlayBtn
            // 
            this.BlackJackPlayBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlackJackPlayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BlackJackPlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BlackJackPlayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BlackJackPlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlackJackPlayBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlackJackPlayBtn.ForeColor = System.Drawing.Color.White;
            this.BlackJackPlayBtn.Image = global::Poker_C_sharp.Properties.Resources.bj;
            this.BlackJackPlayBtn.Location = new System.Drawing.Point(489, 74);
            this.BlackJackPlayBtn.Name = "BlackJackPlayBtn";
            this.BlackJackPlayBtn.Size = new System.Drawing.Size(415, 376);
            this.BlackJackPlayBtn.TabIndex = 8;
            this.BlackJackPlayBtn.Text = "Black Jack";
            this.BlackJackPlayBtn.UseVisualStyleBackColor = true;
            this.BlackJackPlayBtn.Click += new System.EventHandler(this.BlackJackPlayBtn_Click);
            this.BlackJackPlayBtn.MouseEnter += new System.EventHandler(this.BlackJackPlayBtn_MouseEnter);
            this.BlackJackPlayBtn.MouseLeave += new System.EventHandler(this.BlackJackPlayBtn_MouseLeave);
            // 
            // PokerPlayBtn
            // 
            this.PokerPlayBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PokerPlayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PokerPlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PokerPlayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PokerPlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PokerPlayBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PokerPlayBtn.ForeColor = System.Drawing.Color.White;
            this.PokerPlayBtn.Image = global::Poker_C_sharp.Properties.Resources.pokerdarkf;
            this.PokerPlayBtn.Location = new System.Drawing.Point(32, 74);
            this.PokerPlayBtn.Name = "PokerPlayBtn";
            this.PokerPlayBtn.Size = new System.Drawing.Size(415, 376);
            this.PokerPlayBtn.TabIndex = 7;
            this.PokerPlayBtn.Text = "Poker";
            this.PokerPlayBtn.UseVisualStyleBackColor = true;
            this.PokerPlayBtn.Click += new System.EventHandler(this.PokerPlayBtn_Click);
            this.PokerPlayBtn.MouseEnter += new System.EventHandler(this.PokerPlayBtn_MouseEnter);
            this.PokerPlayBtn.MouseLeave += new System.EventHandler(this.PokerPlayBtn_MouseLeave);
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(942, 523);
            this.Controls.Add(this.BlackJackPlayBtn);
            this.Controls.Add(this.PokerPlayBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamesForm";
            this.Text = "GamesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PokerPlayBtn;
        private System.Windows.Forms.Button BlackJackPlayBtn;
    }
}