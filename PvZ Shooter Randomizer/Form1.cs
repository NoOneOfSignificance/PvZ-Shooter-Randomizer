using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PvZ_Shooter_Randomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void BadOption()
        {
            MessageBox.Show("Please choose a different option in the Select Team box.");
        }
        void DisableRandomAbilities()
        {
            label6.Text = "N/A";
            label8.Text = "N/A";
            label9.Text = "N/A";
            label21.Text = "N/A";
            label22.Text = "N/A";
            label23.Text = "N/A";
        }
        static void UnavailbaleFeature()
        {
            MessageBox.Show("Sorry, this feature isn't available right now");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for trying out my program. Please note that the program isn't " +
                "finished and some features such as Randomized Abilities/Upgrades for GW2 and BFN " +
                "don't have any function. Please let me know what you think of it.");
            gw1TeamSelect.SelectedIndex = 0;
            gw2TeamSelect.SelectedIndex = 0;
            bfnTeamSelect.SelectedIndex = 0;
            DisableRandomAbilities();
        }

        private void gw1IncludeBossMode_CheckedChanged(object sender, EventArgs e)
        {
            switch (gw1IncludeBossMode.Checked)
            {
                case true:

                    gw1Plants.Add("Boss Mode");
                    gw1Zombies.Add("Boss Mode");
                    break;
                case false:

                    gw1Plants.Remove("Boss Mode");
                    gw1Zombies.Remove("Boss Mode");
                    break;
            }
        }

        private void gw1RandomizeButton_Click(object sender, EventArgs e)
        {
            switch (gw1TeamSelect.SelectedIndex)
            {
                case 0:

                    BadOption();
                    break;

                case 1:

                    var randomPlant = new Random();
                    int randSelection = randomPlant.Next(gw1Plants.Count);
                    gw1CharacterOutput.Text = gw1Plants[randSelection];
                    string randCharacter = gw1Plants[randSelection];


                    switch (gw1RandomAbilities.Checked)
                    {
                        case true:

                            //Randomized Peashooter Abilities
                            if (randCharacter == "Peashooter" || randCharacter == "Fire Pea" || randCharacter == "Ice Pea" ||
                        randCharacter == "Toxic Pea" || randCharacter == "Full Auto Pea" || randCharacter == "Agent Pea" ||
                        randCharacter == "Law Pea" || randCharacter == "Berry Pea" || randCharacter == "Plasma Pea")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw1PeaAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw1PeaAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw1PeaAbility3.Count);

                                label6.Text = $"{gw1PeaAbility1[randAbility1]}";
                                label8.Text = $"{gw1PeaAbility2[randAbility2]}";
                                label9.Text = $"{gw1PeaAbility3[randAbility3]}";
                            }

                            //Randomized Chomper Abilities
                            if (randCharacter == "Chomper" || randCharacter == "Fire Chomper" || randCharacter == "Power Chomper" ||
                        randCharacter == "Hot-Rod Chomper" || randCharacter == "Count Chompula" || randCharacter == "Toxic Chomper" ||
                        randCharacter == "Armor Chomper" || randCharacter == "Chester Chomper" || randCharacter == "Chomp Thing")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw1ChompAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw1ChompAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw1ChompAbility3.Count);

                                label6.Text = $"{gw1ChompAbility1[randAbility1]}";
                                label8.Text = $"{gw1ChompAbility2[randAbility2]}";
                                label9.Text = $"{gw1ChompAbility3[randAbility3]}";
                            }

                            //Randomized Sunflower Abilities
                            if (randCharacter == "Sunflower" || randCharacter == "Fire Flower" || randCharacter == "Power Flower" ||
                                randCharacter == "Shadow Flower" || randCharacter == "Mystic Flower" || randCharacter == "Metal Petal" ||
                                randCharacter == "Sun Pharaoh" || randCharacter == "Alien Flower")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw1SunAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw1SunAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw1SunAbility3.Count);

                                label6.Text = $"{gw1SunAbility1[randAbility1]}";
                                label8.Text = $"{gw1SunAbility2[randAbility2]}";
                                label9.Text = $"{gw1SunAbility3[randAbility3]}";
                            }

                            //Randomized Cactus Abilities
                            if (randCharacter == "Cactus" || randCharacter == "Fire Cactus" || randCharacter == "Ice Cactus" ||
                                randCharacter == "Power Cactus" || randCharacter == "Future Cactus" || randCharacter == "Camo Cactus" ||
                                randCharacter == "Bandit Cactus" || randCharacter == "Citrus Cactus" || randCharacter == "Jade Cactus")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw1CactusAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw1CactusAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw1CactusAbility3.Count);

                                label6.Text = $"{gw1CactusAbility1[randAbility1]}";
                                label8.Text = $"{gw1CactusAbility2[randAbility2]}";
                                label9.Text = $"{gw1CactusAbility3[randAbility3]}";
                            }

                            if (randCharacter == "Boss Mode")
                                DisableRandomAbilities();
                            break;

                        case false:
                            DisableRandomAbilities();
                            break;
                    }
                    break;

                case 2:
                    var randomZombie = new Random();
                    int randSelection1 = randomZombie.Next(gw1Zombies.Count);
                    gw1CharacterOutput.Text = gw1Zombies[randSelection1];
                    string randCharacter1 = gw1Zombies[randSelection1];

                    switch (gw1RandomAbilities.Checked)
                    {

                        case true:
                            //Randomized Foot Soldier Abilities
                            if (randCharacter1 == "Foot Soldier" || randCharacter1 == "Arctic Trooper" || randCharacter1 == "Super Commando" ||
                                randCharacter1 == "Tank Commander" || randCharacter1 == "General Supremo" || randCharacter1 == "Camo Ranger" ||
                                randCharacter1 == "Sky Trooper" || randCharacter1 == "Centurion")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw1SoldierAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw1SoldierAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw1SoldierAbility3.Count);

                                label6.Text = $"{gw1SoldierAbility1[randAbility1]}";
                                label8.Text = $"{gw1SoldierAbility2[randAbility2]}";
                                label9.Text = $"{gw1SoldierAbility3[randAbility3]}";
                            }
                            break;

                        case false:
                            DisableRandomAbilities();
                            break;
                    }
                    break;
            }
        }

        private void gw1SettingsButton_Click(object sender, EventArgs e)
        {
            UnavailbaleFeature();
        }

        //GW1 Lists

        //Plants
        List<string> gw1Plants = new List<string>()
        {
            "Peashooter", "Fire Pea", "Ice Pea", "Toxic Pea", "Commando Pea", "Agent Pea",
            "Law Pea", "Berry Pea", "Plasma Pea", "Chomper", "Fire Chomper", "Power Chomper",
            "Count Chompula", "Hot-Rod Chomper", "Armor Chomper", "Chester Chomper", "Chomp Thing",
            "Sunflower", "Fire Flower", "Power Flower", "Shadow Flower", "Mystic Flower",
            "Metal Petal", "Sun Pharaoh", "Alien Flower", "Cactus", "Fire Cactus", "Ice Cactus",
            "Power Cactus", "Future Cactus", "Camo Cactus", "Bandit Cactus", "Citrus Cactus",
            "Jade Cactus"
        };

        //Zombies
        List<string> gw1Zombies = new List<string>()
        {
            "Foot Soldier", "Arctic Trooper", "Super Commando", "Tank Commander", "General Supremo",
            "Camo Ranger", "Sky Trooper", "Centurion", "Engineer", "Welder", "Mechanic", "Electrician",
            "Painter", "Plumber", "Landscaper", "Sanitation Expert", "Scientist", "Marine Biologist",
            "Dr. Toxic", "Physicist", "Astronaut", "Chemist", "Archaeologist", "Dr. Chester", "Paleontologist",
            "All-Star", "Cricket Star", "Hockey Star", "Goalie Star", "Rugby Star", "Baseball Star",
            "Wrestling Star", "Golf Star"
        };

        //Peashooter Abilities
        List<string> gw1PeaAbility1 = new List<string>()
        {
            "Chili Bean Bomb", "Sombrero Bean Bomb"
        };
        List<string> gw1PeaAbility2 = new List<string>()
        {
            "Pea Gatling", "Retro Gatling"
        };
        List<string> gw1PeaAbility3 = new List<string>()
        {
            "Hyper", "Super Pea Jump"
        };

        //Chomper Abilities
        List<string> gw1ChompAbility1 = new List<string>()
        {
            "Spikeweed", "Spiky Spikeweed", "Chesterweed"
        };
        List<string> gw1ChompAbility2 = new List<string>()
        {
            "Burrow", "Sprint Burrow"
        };
        List<string> gw1ChompAbility3 = new List<string>()
        {
            "Goop", "Super Sticky Goop", "Cheesey Goop"
        };

        //Sunflower Abilities
        List<string> gw1SunAbility1 = new List<string>()
        {
            "Heal Beam", "Rainbow Heal Bean"
        };
        List<string> gw1SunAbility2 = new List<string>()
        {
            "Sunbeam", "Solar Flare Beam"
        };
        List<string> gw1SunAbility3 = new List<string>()
        {
            "Heal Flower", "Dark Flower"
        };

        //Cactus Abilities
        List<string> gw1CactusAbility1 = new List<string>()
        {
            "Potato Mine", "Potato Nugget Mine"
        };
        List<string> gw1CactusAbility2 = new List<string>()
        {
            "Garlic Drone", "Artichoke Drone"
        };
        List<string> gw1CactusAbility3 = new List<string>()
        {
            "Tallnut Battlements", "Iron Maiden"
        };

        //Soldier Abilities
        List<string> gw1SoldierAbility1 = new List<string>()
        {
            "Zombie Stink Cloud", "Super Stink Cloud"
        };
        List<string> gw1SoldierAbility2 = new List<string>()
        {
            "Rocket Jump", "Rocket Leap"
        };
        List<string> gw1SoldierAbility3 = new List<string>()
        {
            "ZPG", "Multi Rocket"
        };


        ///
        /// Garden Warfare 2
        ///

        private void gw2RandomizeButton_Click(object sender, EventArgs e)
        {
            switch (gw2TeamSelect.SelectedIndex)
            {
                case 0:
                    BadOption();
                    break;

                case 1:
                    var randomPlant = new Random();
                    int randSelection = randomPlant.Next(gw2Plants.Count);
                    string randCharacter = gw2Plants[randSelection];
                    gw2CharacterOutput.Text = randCharacter;

                    break;

                case 2:
                    var randomZombie = new Random();
                    int randSelection1 = randomZombie.Next(gw2Zombies.Count);
                    string randCharacter1 = gw2Zombies[randSelection1];
                    gw2CharacterOutput.Text = randCharacter1;

                    break;
            }
        }

        private void gw2SettingsButton_Click(object sender, EventArgs e)
        {
            UnavailbaleFeature();
        }

        private void gw2RandomAbilities_CheckedChanged(object sender, EventArgs e)
        {
            UnavailbaleFeature();
            gw2RandomAbilities.Checked = false;
        }

        private void gw2RandomUpgrades_CheckedChanged(object sender, EventArgs e)
        {
            UnavailbaleFeature();
            gw2RandomUpgrades.Checked = false;
        }

        //Garden Warfare 2 Characters

        List<string> gw2Plants = new List<string>()
        {
            "Peashooter", "Fire Pea", "Ice Pea", "Toxic Pea", "Commando Pea", "Agent Pea",
            "Law Pea", "Plasma Pea", "Chomper", "Fire Chomper", "Power Chomper",
            "Count Chompula", "Hot-Rod Chomper", "Armor Chomper", "Chomp Thing",
            "Sunflower", "Fire Flower", "Power Flower", "Shadow Flower", "Mystic Flower",
            "Metal Petal", "Sun Pharaoh", "Alien Flower", "Cactus", "Fire Cactus", "Ice Cactus",
            "Power Cactus", "Future Cactus", "Camo Cactus", "Bandit Cactus", "Jade Cactus",
            "Rock Pea", "Electro Pea", "Vampire Flower", "Stuffy Flower", "Yeti Chomper", "Disco Chomper",
            "Unicorn Chomper", "Twilight Chomper", "Zen Cactus", "Petrified Cactus", "Citron", "Frozen Citron",
            "Electro Citron", "Iron Citron", "Party Citron", "Toxic Citron", "Rose", "Druid Rose", "Fire Rose",
            "Frost Rose", "Party Rose", "Nec'Rose", "Kernel Corn", "BBQ Corn", "Pops Corn", "Mob Cob", "Party Corn",
            "Commando Corn", "Torchwood"
        };

        List<string> gw2Zombies = new List<string>()
        {
            "Foot Soldier", "Arctic Trooper", "Super Commando", "Tank Commander", "General Supremo",
            "Camo Ranger", "Sky Trooper", "Centurion", "Engineer", "Welder", "Mechanic", "Electrician",
            "Painter", "Plumber", "Landscaper", "Sanitation Expert", "Scientist", "Marine Biologist",
            "Dr. Toxic", "Physicist", "Astronaut", "Chemist", "Archaeologist", "Paleontologist",
            "All-Star", "Cricket Star", "Hockey Star", "Goalie Star", "Rugby Star", "Baseball Star",
            "Wrestling Star", "Golf Star", "Park Ranger", "Scuba Soldier", "Roadie-Z", "AC Perry", "Zoologist",
            "Computer Scientist", "Tennis Star", "Moto-X Star", "Imp", "Lil' Drake", "Pylon Imp", "S.H.R.Imp",
            "Party Imp", "Z-7 Imp", "Scallywag Imp", "Super Brainz", "Cozmic Brainz", "Electro Brainz",
            "Toxic Brainz", "Party Brainz", "Breakfast Brainz", "Captain Deadbeard", "Captain Flameface", "Captain Sharkbite",
            "Captain Cannon", "Captain Partyman", "Captain Squawk", "Hover Goat-3000"
        };

        ///
        /// Battle for Neighborville
        ///

        private void bfnRandomizeButton_Click(object sender, EventArgs e)
        {
            switch (bfnTeamSelect.SelectedIndex)
            {
                case 0:
                    BadOption();
                    break;

                case 1:
                    var randomPlant = new Random();
                    int randSelection = randomPlant.Next(bfnPlants.Count);
                    string randCharacter = bfnPlants[randSelection];
                    bfnCharacterOutput.Text = randCharacter;

                    break;

                case 2:
                    var randomZombie = new Random();
                    int randSelection1 = randomZombie.Next(bfnZombies.Count);
                    string randCharacter1 = bfnZombies[randSelection1];
                    bfnCharacterOutput.Text = randCharacter1;

                    break;
            }
        }

        private void bfnRandomUpgrades_CheckedChanged(object sender, EventArgs e)
        {
            UnavailbaleFeature();
            bfnRandomUpgrades.Checked = false;
        }
        private void bfnLegendaryUpgrades_CheckedChanged(object sender, EventArgs e)
        {
            UnavailbaleFeature();
            bfnLegendaryUpgrades.Checked = false;
            /*
            if (bfnLegendaryUpgrades.Checked)
                legendaryUpgradeImage.Image = Properties.Resources.legendary_upgrade1;
            else
                legendaryUpgradeImage.Image = Properties.Resources.legendary_upgrade_grayscale;
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UnavailbaleFeature();
        }

        //Battle for Neighborville Characters

        List<string> bfnPlants = new List<string>()
        {
            "Peashooter", "Chomper", "Kernel Corn", "Nightcap", "Snapdragon", "Cactus", "Citron", "Acorn", "Sunflower", "Rose"
        };

        List<string> bfnZombies = new List<string>()
        {
            "Foot Soldier", "Imp", "Super Brainz", "80's Action Hero", "Electric Slide", "All-Star", "Captain Deadbeard", "Space Cadet", "Scientist", "Engineer", "Wizard"
        };
    }
}