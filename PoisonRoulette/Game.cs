using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace PoisonRoulette
{
    public partial class Game : Form
    {
        private List<Drink> drinks;
        private Player player;

        public Game()
        {
            InitializeComponent();
        }

        //Creates new Player object when game is loaded
        private void Game_Load(object sender, EventArgs e)
        {
            player = new Player();
        }

        //Starts a new game
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnNewGame.Hide();
            NewGame();
            btnPoison.Show();
        }

        //Executes PoisonShot method when button is clicked
        private void btnPoison_Click(object sender, EventArgs e)
        {
            btnPoison.Hide();
            PoisonShot();
        }

        //Click event for drink picturebox's
        private void ClickDrink(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            int i = Convert.ToInt32(p.Image.Tag);
            CheckDrink(i);
            RemoveItem(p);
        }

        //Method to set up a new game
        private void NewGame()
        {
            ClearBar();
            lblInvincible.Hide();
            drinks = new List<Drink>();

            int x = 250;
            int y = 45;

            //Creates Shot objects and adds them to a list of Drinks
            for (int i = 0; i < 6; i++)
            {
                drinks.Add(new Shot(GameResource.Shot));
                drinks[i].Picture.Image.Tag = i;
                drinks[i].Picture.Location = new Point(x,y);
                Controls.Add(drinks[i].Picture);
                drinks[i].Picture.Click += new EventHandler(ClickDrink);
                x += 80;
            }


            //Creates Antidote objects and adds them to a list of Drinks
            for (int i = 6; i < 8; i++)
            {
                drinks.Add(new Antidote(GameResource.Antidote));
                drinks[i].Picture.Image.Tag = i;
                drinks[i].Picture.Location = new Point(x, y);
                Controls.Add(drinks[i].Picture);
                drinks[i].Picture.Click += new EventHandler(ClickDrink);
                x += 100;
            }
        }

        //Method for playing soundfiles
        public void playSound(Stream s)
        {
            Stream str = s;
            SoundPlayer soundPlayer = new SoundPlayer(s);
            soundPlayer.Play();
        }

        //Method to determine if a Drink is a Shot or an Antidote and execute code accordingly
        public void CheckDrink(int i)
        {

            playSound(GameResource.Drink);
            if (drinks[i] is Shot)
            {
                Shot s = (Shot)drinks[i];
                if (s.Poison)
                {
                    if (player.Invincible)
                    {
                        playSound(GameResource.Win);
                        MessageBox.Show("Lucky you took the antidote, that was the poison! You win this time...");
                        player.Win();
                        player.ToggleInvincible();
                        UpdateScore(player.Wins, player.Losses);
                        ClearBar();
                        btnNewGame.Show();
                    }
                    else
                    {
                        playSound(GameResource.Death);
                        MessageBox.Show("You drank the poison, you lose!");
                        player.Lose();
                        UpdateScore(player.Wins, player.Losses);
                        ClearBar();
                        btnNewGame.Show();
                    }

                }
                else if (player.Invincible)
                {
                    player.ToggleInvincible();
                    lblInvincible.Hide();
                }
            }
            else
            {
                playSound(GameResource.Antidote1);
                Antidote a = (Antidote) drinks[i];
                a.DrinkAntidote(player);
                lblInvincible.Show();
            }

        }

        //Method to remove a PictureBox from the Form
        public void RemoveItem(PictureBox p)
        {
            Controls.Remove(p);
        }

        //Method to randomly add poison to one Shot in the list of Drinks
        public void PoisonShot()
        {
            playSound(GameResource.EvilLaugh);
            pbxPoison.Show();
            timer1.Start();
            Random rnd = new Random();
            int i = rnd.Next(0, 5);
            Shot s = (Shot)drinks[i];
            s.Poison = true;
            drinks[i] = s;

        }

        //Method to clean up the Drinks to prepare for a new game
        public void ClearBar()
        {
            PictureBox[] controlsToRemove = Controls.OfType<PictureBox>().ToArray();
            foreach (PictureBox p in controlsToRemove)
            {
                if (p.Name != "pbxPoison")
                {
                    p.Dispose();
                }
            }
        }

        //Updates score labels
        public void UpdateScore(int w, int l)
        {
            lblWin.Text = "Wins: " + player.Wins;
            lblLose.Text = "Losses: " + player.Losses;
            lblTotal.Text = "Total Games " + (player.Wins + player.Losses);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbxPoison.Hide();
            timer1.Stop();
        }
    }
}
