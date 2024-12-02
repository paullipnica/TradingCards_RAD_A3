using System;
using System.Drawing;
using System.Windows.Forms;

namespace TradingCards_Lipnica
{
    public partial class Add : Form
    {
        // Properties to hold the data
        public string PlayerName { get; private set; }
        public string ClubTeam { get; private set; }
        public string Position { get; private set; }
        public double PointsPerGame { get; private set; }
        public double AssistsPerGame { get; private set; }
        public double ReboundsPerGame { get; private set; }
        public Color ImageColor { get; private set; }
        public Image PlayerImage { get; private set; }  
        public Rarity PlayerRarity { get; private set; }  

     
        public enum Rarity
        {
            Red,
            Green,
            Gold
        }

        public Add()
        {
            InitializeComponent();
            ImageColor = Color.Gray; 
            PlayerImage = null; 
            PlayerRarity = Rarity.Green;  

          
            openFileDialog1 = new OpenFileDialog
            {
                Title = "Select Player Image",  
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"  
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrWhiteSpace(txtPlayerName.Text) ||
                string.IsNullOrWhiteSpace(txtClubTeam.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                !double.TryParse(txtPointsPerGame.Text, out double points) ||
                !double.TryParse(txtAssistsPerGame.Text, out double assists) ||
                !double.TryParse(txtReboundsPerGame.Text, out double rebounds))
            {
                MessageBox.Show("Please fill out all fields correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlayerName = txtPlayerName.Text;
            ClubTeam = txtClubTeam.Text;
            Position = txtPosition.Text;
            PointsPerGame = points;
            AssistsPerGame = assists;
            ReboundsPerGame = rebounds;

           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
           
            txtPlayerName.Clear();
            txtClubTeam.Clear();
            txtPosition.Clear();
            txtPointsPerGame.Clear();
            txtAssistsPerGame.Clear();
            txtReboundsPerGame.Clear();

           
            PlayerImage = null;
            pictureBox1.Image = null;  
            pictureBox1.BackColor = Color.Gray;  
        }

       
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PlayerImage = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = PlayerImage;
            }
        }

    }
}
