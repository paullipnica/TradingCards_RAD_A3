namespace TradingCards_Lipnica
{
    partial class Form1
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
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picturePlayer = new System.Windows.Forms.PictureBox();
            this.txtClubTeam = new System.Windows.Forms.TextBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtPointsPerGame = new System.Windows.Forms.TextBox();
            this.txtAssistsPerGame = new System.Windows.Forms.TextBox();
            this.txtReboundsPerGame = new System.Windows.Forms.TextBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPointsPerGame = new System.Windows.Forms.Label();
            this.lblAssistsPerGame = new System.Windows.Forms.Label();
            this.lblReboundsPerGame = new System.Windows.Forms.Label();
            this.lblRarity = new System.Windows.Forms.Label();
            this.btnGold = new System.Windows.Forms.Button();
            this.btnSilver = new System.Windows.Forms.Button();
            this.btnBronze = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 20;
            this.lstPlayers.Location = new System.Drawing.Point(436, 376);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(239, 204);
            this.lstPlayers.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Location = new System.Drawing.Point(392, 635);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Location = new System.Drawing.Point(623, 635);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picturePlayer
            // 
            this.picturePlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturePlayer.Location = new System.Drawing.Point(49, 64);
            this.picturePlayer.Name = "picturePlayer";
            this.picturePlayer.Size = new System.Drawing.Size(232, 204);
            this.picturePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePlayer.TabIndex = 7;
            this.picturePlayer.TabStop = false;
            // 
            // txtClubTeam
            // 
            this.txtClubTeam.Location = new System.Drawing.Point(49, 463);
            this.txtClubTeam.Name = "txtClubTeam";
            this.txtClubTeam.Size = new System.Drawing.Size(232, 26);
            this.txtClubTeam.TabIndex = 9;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(506, 343);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(51, 20);
            this.lblPlayer.TabIndex = 13;
            this.lblPlayer.Text = "label1";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.Location = new System.Drawing.Point(511, 635);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 46);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(49, 526);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(232, 26);
            this.txtPosition.TabIndex = 15;
            // 
            // txtPointsPerGame
            // 
            this.txtPointsPerGame.Location = new System.Drawing.Point(49, 593);
            this.txtPointsPerGame.Name = "txtPointsPerGame";
            this.txtPointsPerGame.Size = new System.Drawing.Size(232, 26);
            this.txtPointsPerGame.TabIndex = 16;
            // 
            // txtAssistsPerGame
            // 
            this.txtAssistsPerGame.Location = new System.Drawing.Point(49, 660);
            this.txtAssistsPerGame.Name = "txtAssistsPerGame";
            this.txtAssistsPerGame.Size = new System.Drawing.Size(232, 26);
            this.txtAssistsPerGame.TabIndex = 17;
            // 
            // txtReboundsPerGame
            // 
            this.txtReboundsPerGame.Location = new System.Drawing.Point(49, 736);
            this.txtReboundsPerGame.Name = "txtReboundsPerGame";
            this.txtReboundsPerGame.Size = new System.Drawing.Size(232, 26);
            this.txtReboundsPerGame.TabIndex = 18;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTeam.Location = new System.Drawing.Point(138, 440);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(49, 20);
            this.lblTeam.TabIndex = 19;
            this.lblTeam.Text = "Team";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPosition.Location = new System.Drawing.Point(136, 503);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 20);
            this.lblPosition.TabIndex = 20;
            this.lblPosition.Text = "Position";
            // 
            // lblPointsPerGame
            // 
            this.lblPointsPerGame.AutoSize = true;
            this.lblPointsPerGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPointsPerGame.Location = new System.Drawing.Point(107, 570);
            this.lblPointsPerGame.Name = "lblPointsPerGame";
            this.lblPointsPerGame.Size = new System.Drawing.Size(129, 20);
            this.lblPointsPerGame.TabIndex = 21;
            this.lblPointsPerGame.Text = "Points Per Game";
            // 
            // lblAssistsPerGame
            // 
            this.lblAssistsPerGame.AutoSize = true;
            this.lblAssistsPerGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAssistsPerGame.Location = new System.Drawing.Point(100, 637);
            this.lblAssistsPerGame.Name = "lblAssistsPerGame";
            this.lblAssistsPerGame.Size = new System.Drawing.Size(136, 20);
            this.lblAssistsPerGame.TabIndex = 22;
            this.lblAssistsPerGame.Text = "Assists Per Game";
            // 
            // lblReboundsPerGame
            // 
            this.lblReboundsPerGame.AutoSize = true;
            this.lblReboundsPerGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReboundsPerGame.Location = new System.Drawing.Point(89, 713);
            this.lblReboundsPerGame.Name = "lblReboundsPerGame";
            this.lblReboundsPerGame.Size = new System.Drawing.Size(159, 20);
            this.lblReboundsPerGame.TabIndex = 23;
            this.lblReboundsPerGame.Text = "Rebounds Per Game";
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRarity.Location = new System.Drawing.Point(507, 704);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(50, 20);
            this.lblRarity.TabIndex = 24;
            this.lblRarity.Text = "Rarity";
            // 
            // btnGold
            // 
            this.btnGold.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGold.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGold.Location = new System.Drawing.Point(635, 727);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(85, 46);
            this.btnGold.TabIndex = 25;
            this.btnGold.Text = "Gold";
            this.btnGold.UseVisualStyleBackColor = false;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // btnSilver
            // 
            this.btnSilver.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSilver.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSilver.Location = new System.Drawing.Point(511, 727);
            this.btnSilver.Name = "btnSilver";
            this.btnSilver.Size = new System.Drawing.Size(85, 46);
            this.btnSilver.TabIndex = 26;
            this.btnSilver.Text = "Silver";
            this.btnSilver.UseVisualStyleBackColor = false;
            this.btnSilver.Click += new System.EventHandler(this.btnSilver_Click);
            // 
            // btnBronze
            // 
            this.btnBronze.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBronze.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBronze.Location = new System.Drawing.Point(392, 727);
            this.btnBronze.Name = "btnBronze";
            this.btnBronze.Size = new System.Drawing.Size(85, 46);
            this.btnBronze.TabIndex = 27;
            this.btnBronze.Text = "Bronze";
            this.btnBronze.UseVisualStyleBackColor = false;
            this.btnBronze.Click += new System.EventHandler(this.btnBronze_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 831);
            this.Controls.Add(this.btnBronze);
            this.Controls.Add(this.btnSilver);
            this.Controls.Add(this.btnGold);
            this.Controls.Add(this.lblRarity);
            this.Controls.Add(this.lblReboundsPerGame);
            this.Controls.Add(this.lblAssistsPerGame);
            this.Controls.Add(this.lblPointsPerGame);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.txtReboundsPerGame);
            this.Controls.Add(this.txtAssistsPerGame);
            this.Controls.Add(this.txtPointsPerGame);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.txtClubTeam);
            this.Controls.Add(this.picturePlayer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstPlayers);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picturePlayer;
        private System.Windows.Forms.TextBox txtClubTeam;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtPointsPerGame;
        private System.Windows.Forms.TextBox txtAssistsPerGame;
        private System.Windows.Forms.TextBox txtReboundsPerGame;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPointsPerGame;
        private System.Windows.Forms.Label lblAssistsPerGame;
        private System.Windows.Forms.Label lblReboundsPerGame;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRarity;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.Button btnSilver;
        private System.Windows.Forms.Button btnBronze;
    }
}

