using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonLibrary;

namespace Example02
{
    public partial class Form1 : Form
    {
        public Pokemon pokemon;
        public int UserStarDust;
        public int UserCandy;

        public Form1()
        {
            InitializeComponent();
            UserStarDust = 10000;
            UserCandy = 500;
            pokemon = new Pokemon()
            {
                Name = "妙蛙種子",
                hp = 60,
                maxhp = 60,
                Weight = 6.94f,
                Types = new string[] { "草", "毒" },
                Height = 0.66f,
                PowerUpCandy = 3,
                PowerUpStardust = 3000,
                EvolveCandy = 25
            };

            NameLabel.Text = pokemon.Name;
            HpLabel.Text = pokemon.hp.ToString() + "/" + pokemon.maxhp + "HP";
            HeightLabel.Text = pokemon.Height.ToString() + " m";
            TypesLabel.Text = pokemon.Types[0] + "/" + pokemon.Types[1];
            WeightLabel.Text = pokemon.Weight.ToString() + " kg";
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
            EvolveCandyLabel.Text = pokemon.EvolveCandy.ToString();
            UserStardustLabel.Text = UserStarDust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserCandy = UserCandy - pokemon.PowerUpCandy;
            UserStarDust = UserStarDust - pokemon.PowerUpStardust;
            pokemon.hp = pokemon.hp + 10;
            pokemon.maxhp = pokemon.maxhp + 10;
            HpLabel.Text = pokemon.hp.ToString() + "/" + pokemon.maxhp + "HP";
            UserStardustLabel.Text = UserStarDust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserCandy = UserCandy - pokemon.EvolveCandy;
            pokemon = new Pokemon()
            {
                Name = "妙蛙草",
                hp = 150,
                maxhp = 250,
                Weight = 10.94f,
                Types = new string[] { "草", "毒" },
                Height = 1.66f,
                PowerUpCandy = 3,
                PowerUpStardust = 3000,
                EvolveCandy = 100
            };

            NameLabel.Text = pokemon.Name;
            HpLabel.Text = pokemon.hp.ToString() + "/" + pokemon.maxhp + "HP";
            HeightLabel.Text = pokemon.Height.ToString()+ " m";
            TypesLabel.Text = pokemon.Types[0] + "/" + pokemon.Types[1];
            WeightLabel.Text = pokemon.Weight.ToString()+" kg";
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
            EvolveCandyLabel.Text = pokemon.EvolveCandy.ToString();
            UserStardustLabel.Text = UserStarDust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}