namespace PoisonRoulette
{
    partial class Game
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.btnPoison = new System.Windows.Forms.Button();
            this.lblInvincible = new System.Windows.Forms.Label();
            this.pbxPoison = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPoison)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Red;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewGame.Location = new System.Drawing.Point(442, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(306, 49);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.White;
            this.lblWin.Location = new System.Drawing.Point(12, 36);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(34, 13);
            this.lblWin.TabIndex = 1;
            this.lblWin.Text = "Wins:";
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.BackColor = System.Drawing.Color.White;
            this.lblLose.Location = new System.Drawing.Point(12, 63);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(43, 13);
            this.lblLose.TabIndex = 2;
            this.lblLose.Text = "Losses:";
            // 
            // btnPoison
            // 
            this.btnPoison.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPoison.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoison.Location = new System.Drawing.Point(251, 43);
            this.btnPoison.Name = "btnPoison";
            this.btnPoison.Size = new System.Drawing.Size(699, 128);
            this.btnPoison.TabIndex = 3;
            this.btnPoison.Text = "Add poison to a random shot!";
            this.btnPoison.UseVisualStyleBackColor = false;
            this.btnPoison.Visible = false;
            this.btnPoison.Click += new System.EventHandler(this.btnPoison_Click);
            // 
            // lblInvincible
            // 
            this.lblInvincible.AutoSize = true;
            this.lblInvincible.BackColor = System.Drawing.Color.Green;
            this.lblInvincible.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvincible.Location = new System.Drawing.Point(504, 496);
            this.lblInvincible.Name = "lblInvincible";
            this.lblInvincible.Size = new System.Drawing.Size(203, 37);
            this.lblInvincible.TabIndex = 4;
            this.lblInvincible.Text = "INVINCIBLE!";
            this.lblInvincible.Visible = false;
            // 
            // pbxPoison
            // 
            this.pbxPoison.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxPoison.Image = global::PoisonRoulette.GameResource.poison;
            this.pbxPoison.Location = new System.Drawing.Point(-24, 217);
            this.pbxPoison.Name = "pbxPoison";
            this.pbxPoison.Size = new System.Drawing.Size(308, 382);
            this.pbxPoison.TabIndex = 5;
            this.pbxPoison.TabStop = false;
            this.pbxPoison.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(12, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total Games:";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1113, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PoisonRoulette.GameResource.Bar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pbxPoison);
            this.Controls.Add(this.lblInvincible);
            this.Controls.Add(this.btnPoison);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPoison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Button btnPoison;
        private System.Windows.Forms.Label lblInvincible;
        private System.Windows.Forms.PictureBox pbxPoison;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnQuit;
    }
}

