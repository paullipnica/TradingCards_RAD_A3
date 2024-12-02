using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TradingCards_Lipnica
{
    public partial class Form1 : Form
    {  
      private class Player
        {
            public string Name { get; set; }
            public string ClubTeam { get; set; }
            public string Position { get; set; }
            public double PointsPerGame { get; set; }
            public double AssistsPerGame { get; set; }
            public double ReboundsPerGame { get; set; }
            public string ImagePath { get; set; } 
            public string Rarity { get; set; } = "Bronze";
        }

        private List<Player> players;

        public Form1()
        {
            InitializeComponent();
            InitializePlayers();
            DisplayPlayers();    
            lstPlayers.SelectedIndexChanged += LstPlayers_SelectedIndexChanged;

            
            picturePlayer.Paint += PicturePlayer_Paint;
        }

        private void InitializePlayers()
        {
          
            players = new List<Player>
            {
                new Player { Name = "LeBron James", ClubTeam = "Los Angeles Lakers", Position = "SF", PointsPerGame = 27.2, AssistsPerGame = 7.4, ReboundsPerGame = 7.5, ImagePath = @"C:\Users\plipn\OneDrive\Desktop\RAD\TradingCards_Lipnica\TradingCards_Lipnica\Images\lebron.jpg", Rarity = "Bronze" },
                new Player { Name = "Stephen Curry", ClubTeam = "Golden State Warriors", Position = "PG", PointsPerGame = 24.6, AssistsPerGame = 6.5, ReboundsPerGame = 4.6, ImagePath = @"C:\Users\plipn\OneDrive\Desktop\RAD\TradingCards_Lipnica\TradingCards_Lipnica\Images\steph.jpg", Rarity = "Bronze" },
                new Player { Name = "Kevin Durant", ClubTeam = "Phoenix Suns", Position = "SF", PointsPerGame = 27.0, AssistsPerGame = 5.0, ReboundsPerGame = 7.1, ImagePath = @"C:\Users\plipn\OneDrive\Desktop\RAD\TradingCards_Lipnica\TradingCards_Lipnica\Images\kevin.jpg", Rarity = "Silver" },
                new Player { Name = "Giannis Antetokounmpo", ClubTeam = "Milwaukee Bucks", Position = "PF", PointsPerGame = 24.8, AssistsPerGame = 5.4, ReboundsPerGame = 10.2, ImagePath = @"C:\Users\plipn\OneDrive\Desktop\RAD\TradingCards_Lipnica\TradingCards_Lipnica\Images\giannis.jpg", Rarity = "Silver" },
                new Player { Name = "James Harden", ClubTeam = "Philadelphia 76ers", Position = "SG", PointsPerGame = 24.7, AssistsPerGame = 7.0, ReboundsPerGame = 5.6, ImagePath = @"C:\Users\plipn\OneDrive\Desktop\RAD\TradingCards_Lipnica\TradingCards_Lipnica\Images\james.jpg", Rarity = "Silver" },
                new Player { Name = "Jayson Tatum", ClubTeam = "Boston Celtics", Position = "SF", PointsPerGame = 26.9, AssistsPerGame = 8.0, ReboundsPerGame = 10.3, ImagePath = @"C:\Users\plipn\OneDrive\Desktop\RAD\TradingCards_Lipnica\TradingCards_Lipnica\Images\jayson.jpg" , Rarity = "Gold" },
                new Player { Name = "Victor Wembanyama", ClubTeam = "San Antonio Spurs", Position = "C", PointsPerGame = 17.7, AssistsPerGame = 2.2, ReboundsPerGame = 9.4, ImagePath = @"C:\Users\plipn\OneDrive\Desktop\RAD\TradingCards_Lipnica\TradingCards_Lipnica\Images\victor.jpg", Rarity = "Bronze" },
                new Player { Name = "Kawhi Leonard", ClubTeam = "Los Angeles Clippers", Position = "SF", PointsPerGame = 26.6, AssistsPerGame = 5.5, ReboundsPerGame = 7.2, ImagePath = @"C:\Users\plipn\OneDrive\Desktop\RAD\TradingCards_Lipnica\TradingCards_Lipnica\Images\kawhi.jpg", Rarity = "Bronze" },
                new Player { Name = "Lamelo Ball", ClubTeam = "Charlotte Hornets", Position = "PG", PointsPerGame = 23.3, AssistsPerGame = 8.3, ReboundsPerGame = 6.4, ImagePath = @"C:\Users\plipn\OneDrive\Desktop\RAD\TradingCards_Lipnica\TradingCards_Lipnica\Images\lamelo.jpg", Rarity = "Bronze" },
                new Player { Name = "Jrue Holiday", ClubTeam = "Boston Celtics", Position = "PG", PointsPerGame = 15.1, AssistsPerGame = 7.3, ReboundsPerGame = 4.3, ImagePath = @"C:\Users\plipn\OneDrive\Desktop\RAD\TradingCards_Lipnica\TradingCards_Lipnica\Images\jrue.jpg", Rarity = "Silver" }
            };
        }

        private void DisplayPlayers()
        {
            
            lstPlayers.Items.Clear();
            foreach (var player in players)
            {
                lstPlayers.Items.Add(player.Name);
            }
        }

        private void LstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex >= 0 && lstPlayers.SelectedIndex < players.Count)
            {
                var selectedPlayer = players[lstPlayers.SelectedIndex];
                lblPlayer.Text = selectedPlayer.Name;
                txtClubTeam.Text = selectedPlayer.ClubTeam;
                txtPosition.Text = selectedPlayer.Position;
                txtPointsPerGame.Text = selectedPlayer.PointsPerGame.ToString("F1");
                txtAssistsPerGame.Text = selectedPlayer.AssistsPerGame.ToString("F1");
                txtReboundsPerGame.Text = selectedPlayer.ReboundsPerGame.ToString("F1");
                lblRarity.Text = $"Rarity: {selectedPlayer.Rarity}";

                if (File.Exists(selectedPlayer.ImagePath))
                {
                    picturePlayer.Image = Image.FromFile(selectedPlayer.ImagePath);
                }
                else
                {
                    picturePlayer.Image = null;
                }

                
                picturePlayer.Invalidate();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Add addForm = new Add();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                
                string imagePath = @"C:\Users\plipn\OneDrive\Desktop\RAD\TradingCards_Lipnica\TradingCards_Lipnica\Images\" + addForm.PlayerName.ToLower() + ".jpg";

                if (addForm.PlayerImage != null)
                {
                    addForm.PlayerImage.Save(imagePath); 
                }

             
                var newPlayer = new Player
                {
                    Name = addForm.PlayerName,
                    ClubTeam = addForm.ClubTeam,
                    Position = addForm.Position,
                    PointsPerGame = addForm.PointsPerGame,
                    AssistsPerGame = addForm.AssistsPerGame,
                    ReboundsPerGame = addForm.ReboundsPerGame,
                    ImagePath = imagePath  
                };

                players.Add(newPlayer);
                DisplayPlayers(); 
                MessageBox.Show("Player added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (lstPlayers.SelectedIndex >= 0 && lstPlayers.SelectedIndex < players.Count)
            {
              
                var selectedPlayer = players[lstPlayers.SelectedIndex];

             
                var result = MessageBox.Show($"Are you sure you want to delete {selectedPlayer.Name}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                   
                    players.RemoveAt(lstPlayers.SelectedIndex);

                    
                    if (File.Exists(selectedPlayer.ImagePath))
                    {
                        try
                        {
                            File.Delete(selectedPlayer.ImagePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting image file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    
                    DisplayPlayers();

                  
                    lblPlayer.Text = "";
                    txtClubTeam.Clear();
                    txtPosition.Clear();
                    txtPointsPerGame.Clear();
                    txtAssistsPerGame.Clear();
                    txtReboundsPerGame.Clear();
                    picturePlayer.Image = null;

                    MessageBox.Show("Player deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a player to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex >= 0 && lstPlayers.SelectedIndex < players.Count)
            {
                var selectedPlayer = players[lstPlayers.SelectedIndex];
                Edit editForm = new Edit
                {
                    PlayerName = selectedPlayer.Name, 
                    ClubTeam = selectedPlayer.ClubTeam,
                    Position = selectedPlayer.Position,
                    PointsPerGame = selectedPlayer.PointsPerGame,
                    AssistsPerGame = selectedPlayer.AssistsPerGame,
                    ReboundsPerGame = selectedPlayer.ReboundsPerGame,
                    PlayerImagePath = selectedPlayer.ImagePath
                };

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    selectedPlayer.Name = editForm.PlayerName;
                    selectedPlayer.ClubTeam = editForm.ClubTeam;
                    selectedPlayer.Position = editForm.Position;
                    selectedPlayer.PointsPerGame = editForm.PointsPerGame;
                    selectedPlayer.AssistsPerGame = editForm.AssistsPerGame;
                    selectedPlayer.ReboundsPerGame = editForm.ReboundsPerGame;

                    if (!string.IsNullOrEmpty(editForm.NewImagePath))
                    {
                        selectedPlayer.ImagePath = editForm.NewImagePath;
                    }

            
                    DisplayPlayers();
                    MessageBox.Show("Player details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a player to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PicturePlayer_Paint(object sender, PaintEventArgs e)
        {
            if (lstPlayers.SelectedIndex >= 0 && lstPlayers.SelectedIndex < players.Count)
            {
                var selectedPlayer = players[lstPlayers.SelectedIndex];

                Color borderColor = Color.Brown; 
                switch (selectedPlayer.Rarity)
                {
                    case "Gold":
                        borderColor = Color.Gold;
                        break;
                    case "Silver":
                        borderColor = Color.Silver;
                        break;
                    case "Bronze":
                        borderColor = Color.SaddleBrown;
                        break;
                }

                int borderThickness = 5; 
                using (Pen pen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, picturePlayer.Width - 1, picturePlayer.Height - 1));
                }
            }
        }
        private void btnBronze_Click(object sender, EventArgs e)
        {
            SetRarity("Bronze");
        }

        private void btnSilver_Click(object sender, EventArgs e)
        {
            SetRarity("Silver");
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            SetRarity("Gold");
        }
        private void SetRarity(string rarity)
        {
            if (lstPlayers.SelectedIndex >= 0 && lstPlayers.SelectedIndex < players.Count)
            {
                var selectedPlayer = players[lstPlayers.SelectedIndex];
                selectedPlayer.Rarity = rarity;
                lblRarity.Text = $"Rarity: {rarity}";

                picturePlayer.Invalidate();
            }
            else
            {
                MessageBox.Show("Please select a player to set the rarity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
