using System;

namespace TradingCards_Lipnica
{
    partial class Add
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReboundsPerGame = new System.Windows.Forms.TextBox();
            this.txtAssistsPerGame = new System.Windows.Forms.TextBox();
            this.txtPointsPerGame = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtClubTeam = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(151, 852);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(152, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Location = new System.Drawing.Point(310, 852);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 47);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(204, 761);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Rebounds Per Game";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(215, 685);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Assists Per Game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(222, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Points Per Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(251, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(253, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Team";
            // 
            // txtReboundsPerGame
            // 
            this.txtReboundsPerGame.Location = new System.Drawing.Point(164, 784);
            this.txtReboundsPerGame.Name = "txtReboundsPerGame";
            this.txtReboundsPerGame.Size = new System.Drawing.Size(232, 26);
            this.txtReboundsPerGame.TabIndex = 28;
            // 
            // txtAssistsPerGame
            // 
            this.txtAssistsPerGame.Location = new System.Drawing.Point(164, 708);
            this.txtAssistsPerGame.Name = "txtAssistsPerGame";
            this.txtAssistsPerGame.Size = new System.Drawing.Size(232, 26);
            this.txtAssistsPerGame.TabIndex = 27;
            // 
            // txtPointsPerGame
            // 
            this.txtPointsPerGame.Location = new System.Drawing.Point(164, 641);
            this.txtPointsPerGame.Name = "txtPointsPerGame";
            this.txtPointsPerGame.Size = new System.Drawing.Size(232, 26);
            this.txtPointsPerGame.TabIndex = 26;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(164, 574);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(232, 26);
            this.txtPosition.TabIndex = 25;
            // 
            // txtClubTeam
            // 
            this.txtClubTeam.Location = new System.Drawing.Point(164, 511);
            this.txtClubTeam.Name = "txtClubTeam";
            this.txtClubTeam.Size = new System.Drawing.Size(232, 26);
            this.txtClubTeam.TabIndex = 24;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(164, 448);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(232, 26);
            this.txtPlayerName.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(232, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Player Name";
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUploadPhoto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUploadPhoto.Location = new System.Drawing.Point(208, 359);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(143, 39);
            this.btnUploadPhoto.TabIndex = 36;
            this.btnUploadPhoto.Text = "Upload Photo";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // Add
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 921);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReboundsPerGame);
            this.Controls.Add(this.txtAssistsPerGame);
            this.Controls.Add(this.txtPointsPerGame);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtClubTeam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Name = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReboundsPerGame;
        private System.Windows.Forms.TextBox txtAssistsPerGame;
        private System.Windows.Forms.TextBox txtPointsPerGame;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtClubTeam;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
