using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TradingCards_Lipnica
{
    public partial class Edit : Form
    {
        public string PlayerName { get; set; }
        public string ClubTeam { get; set; }
        public string Position { get; set; }
        public double PointsPerGame { get; set; }
        public double AssistsPerGame { get; set; }
        public double ReboundsPerGame { get; set; }
        public string PlayerImagePath { get; set; }
        public string NewImagePath { get; private set; }

        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            txtName.Text = PlayerName;
            txtClubTeam.Text = ClubTeam;
            txtPosition.Text = Position;
            txtPointsPerGame.Text = PointsPerGame.ToString("F1");
            txtAssistsPerGame.Text = AssistsPerGame.ToString("F1");
            txtReboundsPerGame.Text = ReboundsPerGame.ToString("F1");

            if (!string.IsNullOrEmpty(PlayerImagePath) && File.Exists(PlayerImagePath))
            {
                picturePlayer.Image = Image.FromFile(PlayerImagePath);
            }
            else
            {
                picturePlayer.Image = null;
            }
        }

        private void btnEditPhoto_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    NewImagePath = openFileDialog.FileName;
                    picturePlayer.Image = Image.FromFile(NewImagePath);
                }
            }
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtClubTeam.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                !double.TryParse(txtPointsPerGame.Text, out double pointsPerGame) ||
                !double.TryParse(txtAssistsPerGame.Text, out double assistsPerGame) ||
                !double.TryParse(txtReboundsPerGame.Text, out double reboundsPerGame))
            {
                MessageBox.Show("Please fill in all fields with valid values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PlayerName = txtName.Text;
            ClubTeam = txtClubTeam.Text;
            Position = txtPosition.Text;
            PointsPerGame = pointsPerGame;
            AssistsPerGame = assistsPerGame;
            ReboundsPerGame = reboundsPerGame;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
