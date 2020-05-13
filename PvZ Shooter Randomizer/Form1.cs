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
                        randCharacter == "Toxic Pea" || randCharacter == "Commando Pea" || randCharacter == "Agent Pea" ||
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
                            if (randCharacter1 == "Engineer" || randCharacter1 == "Welder" || randCharacter1 == "Mechanic" ||
                                randCharacter1 == "Electrician" || randCharacter1 == "Painter" || randCharacter1 == "Plumber" ||
                                randCharacter1 == "Landscaper" || randCharacter1 == "Sanitation Expert")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw1EngineerAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw1EngineerAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw1EngineerAbility3.Count);

                                label6.Text = $"{gw1EngineerAbility1[randAbility1]}";
                                label8.Text = $"{gw1EngineerAbility2[randAbility2]}";
                                label9.Text = $"{gw1EngineerAbility3[randAbility3]}";
                            }
                            if (randCharacter1 == "Scientist" || randCharacter1 == "Marine Biologist" || randCharacter1 == "Dr. Toxic" ||
                                randCharacter1 == "Physicist" || randCharacter1 == "Astronaut" || randCharacter1 == "Chemist" ||
                                randCharacter1 == "Archaeologist" || randCharacter1 == "Dr. Chester" || randCharacter1 == "Paleontologist")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw1ScientistAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw1ScientistAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw1ScientistAbility3.Count);

                                label6.Text = $"{gw1ScientistAbility1[randAbility1]}";
                                label8.Text = $"{gw1ScientistAbility2[randAbility2]}";
                                label9.Text = $"{gw1ScientistAbility3[randAbility3]}";
                            }
                            if (randCharacter1 == "All-Star" || randCharacter1 == "Cricket Star" || randCharacter1 == "Hockey Star" ||
                                randCharacter1 == "Goalie Star" || randCharacter1 == "Rugby Star" || randCharacter1 == "Baseball Star" ||
                                randCharacter1 == "Wrestling Star" || randCharacter1 == "Golf Star")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw1AllStarAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw1AllStarAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw1AllStarAbility3.Count);

                                label6.Text = $"{gw1AllStarAbility1[randAbility1]}";
                                label8.Text = $"{gw1AllStarAbility2[randAbility2]}";
                                label9.Text = $"{gw1AllStarAbility3[randAbility3]}";
                            }
                            if (randCharacter1 == "Boss Mode")
                                DisableRandomAbilities();
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
        List<string> gw1EngineerAbility1 = new List<string>
        {
            "Sonic Grenade", "Proximity Sonic Mines"
        };
        List<string> gw1EngineerAbility2 = new List<string>
        {
            "Zombot Drone", "Rocket Drone"
        };
        List<string> gw1EngineerAbility3 = new List<string>
        {
            "Jackhammer", "Turbo Jackhammer"
        };
        List<string> gw1ScientistAbility1 = new List<string>
        {
            "Zombie Heal Station", "Armored Heal Station", "Cheetah Heal Station"
        };
        List<string> gw1ScientistAbility2 = new List<string>
        {
            "Warp", "Energy Warp", "Cheesey Warp"
        };
        List<string> gw1ScientistAbility3 = new List<string>
        {
            "Sticky Explody Bomb", "Mega Heal Bomb", "Sticky Cheetah Bomb"
        };
        List<string> gw1AllStarAbility1 = new List<string>
        { 
            "Imp Punt", "Long Bomb"
        };
        List<string> gw1AllStarAbility2 = new List<string>
        {
            "Sprint Tackle", "Ultra Tackle"
        };
        List<string> gw1AllStarAbility3 = new List<string>
        { 
            "Dummy Shield", "Shield Decoy"
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

                    switch (gw2RandomAbilities.Checked)
                    {
                        case true:

                            //Randomized Peashooter Abilities
                            if (randCharacter == "Peashooter" || randCharacter == "Fire Pea" || randCharacter == "Ice Pea" ||
                        randCharacter == "Toxic Pea" || randCharacter == "Commando Pea" || randCharacter == "Agent Pea" ||
                        randCharacter == "Law Pea" || randCharacter == "Rock Pea" || randCharacter == "Plasma Pea" ||
                        randCharacter == "Electro Pea")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2PeaAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2PeaAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw2PeaAbility3.Count);

                                label21.Text = $"{gw2PeaAbility1[randAbility1]}";
                                label22.Text = $"{gw2PeaAbility2[randAbility2]}";
                                label23.Text = $"{gw2PeaAbility3[randAbility3]}";
                            }

                            //Randomized Chomper Abilities
                            if (randCharacter == "Chomper" || randCharacter == "Fire Chomper" || randCharacter == "Power Chomper" ||
                        randCharacter == "Hot-Rod Chomper" || randCharacter == "Count Chompula" || randCharacter == "Toxic Chomper" ||
                        randCharacter == "Armor Chomper" || randCharacter == "Yeti Chomper" || randCharacter == "Chomp Thing" || 
                        randCharacter == "Disco Chomper" || randCharacter == "Unicorn Chomper" || randCharacter == "Twilight Chomper")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2ChomperAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2ChomperAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw2ChomperAbility3.Count);

                                label21.Text = $"{gw2ChomperAbility1[randAbility1]}";
                                label22.Text = $"{gw2ChomperAbility2[randAbility2]}";
                                label23.Text = $"{gw2ChomperAbility3[randAbility3]}";
                            }

                            //Randomized Sunflower Abilities
                            if (randCharacter == "Sunflower" || randCharacter == "Fire Flower" || randCharacter == "Power Flower" ||
                                randCharacter == "Shadow Flower" || randCharacter == "Mystic Flower" || randCharacter == "Metal Petal" ||
                                randCharacter == "Sun Pharaoh" || randCharacter == "Alien Flower")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2SunflowerAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2SunflowerAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw2SunflowerAbility3.Count);

                                label21.Text = $"{gw2SunflowerAbility1[randAbility1]}";
                                label22.Text = $"{gw2SunflowerAbility2[randAbility2]}";
                                label23.Text = $"{gw2SunflowerAbility3[randAbility3]}";
                            }

                            //Randomized Cactus Abilities
                            if (randCharacter == "Cactus" || randCharacter == "Fire Cactus" || randCharacter == "Ice Cactus" ||
                                randCharacter == "Power Cactus" || randCharacter == "Future Cactus" || randCharacter == "Camo Cactus" ||
                                randCharacter == "Bandit Cactus" || randCharacter == "Zen Cactus" || randCharacter == "Jade Cactus" ||
                                randCharacter == "Petrified Cactus")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2CactusAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2CactusAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw2CactusAbility3.Count);

                                label21.Text = $"{gw2CactusAbility1[randAbility1]}";
                                label22.Text = $"{gw2CactusAbility2[randAbility2]}";
                                label23.Text = $"{gw2CactusAbility3[randAbility3]}";
                            }
                            if (randCharacter == "Citron" || randCharacter == "Frozen Citron" || randCharacter == "Electro Citron" ||
                                randCharacter == "Iron Citron" || randCharacter == "Party Citron" || randCharacter == "Toxic Citron")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2CitronAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2CitronAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw2CitronAbility3.Count);

                                label21.Text = $"{gw2CitronAbility1[randAbility1]}";
                                label22.Text = $"{gw2CitronAbility2[randAbility2]}";
                                label23.Text = $"{gw2CitronAbility3[randAbility3]}";
                            }
                            if (randCharacter == "Rose" || randCharacter == "Druid Rose" || randCharacter == "Fire Rose" ||
                                randCharacter == "Frost Rose" || randCharacter == "Party Rose" || randCharacter == "Nec'Rose")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2RoseAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2RoseAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw2RoseAbility3.Count);

                                label21.Text = $"{gw2RoseAbility1[randAbility1]}";
                                label22.Text = $"{gw2RoseAbility2[randAbility2]}";
                                label23.Text = $"{gw2RoseAbility3[randAbility3]}";
                            }
                            if (randCharacter == "Kernel Corn" || randCharacter == "BBQ Corn" || randCharacter == "Pops Corn" ||
                                randCharacter == "Mob Cob" || randCharacter == "Party Corn" || randCharacter == "Commando Corn")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2CornAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2CornAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw2CornAbility3.Count);

                                label21.Text = $"{gw2CornAbility1[randAbility1]}";
                                label22.Text = $"{gw2CornAbility2[randAbility2]}";
                                label23.Text = $"{gw2CornAbility3[randAbility3]}";
                            }

                            break;

                        case false:
                            DisableRandomAbilities();
                            break;
                    }

                    break;

                case 2:
                    var randomZombie = new Random();
                    int randSelection1 = randomZombie.Next(gw2Zombies.Count);
                    string randCharacter1 = gw2Zombies[randSelection1];
                    gw2CharacterOutput.Text = randCharacter1;

                    switch (gw2RandomAbilities.Checked)
                    {
                        case true:
                            //Randomized Foot Soldier Abilities
                            if (randCharacter1 == "Foot Soldier" || randCharacter1 == "Arctic Trooper" || randCharacter1 == "Super Commando" ||
                                randCharacter1 == "Tank Commander" || randCharacter1 == "General Supremo" || randCharacter1 == "Camo Ranger" ||
                                randCharacter1 == "Sky Trooper" || randCharacter1 == "Centurion" || randCharacter1 == "Park Ranger" ||
                                randCharacter1 == "Scuba Soldier")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2SoldierAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2SoldierAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw2SoldierAbility3.Count);

                                label21.Text = $"{gw2SoldierAbility1[randAbility1]}";
                                label22.Text = $"{gw2SoldierAbility2[randAbility2]}";
                                label23.Text = $"{gw2SoldierAbility3[randAbility3]}";
                            }
                            if (randCharacter1 == "Engineer" || randCharacter1 == "Welder" || randCharacter1 == "Mechanic" ||
                                randCharacter1 == "Electrician" || randCharacter1 == "Painter" || randCharacter1 == "Plumber" ||
                                randCharacter1 == "Landscaper" || randCharacter1 == "Sanitation Expert" || randCharacter1 == "Roadie-Z" ||
                                randCharacter1 == "AC Perry")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2EngineerAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2EngineerAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw2EngineerAbility3.Count);

                                label21.Text = $"{gw2EngineerAbility1[randAbility1]}";
                                label22.Text = $"{gw2EngineerAbility2[randAbility2]}";
                                label23.Text = $"{gw2EngineerAbility3[randAbility3]}";
                            }
                            if (randCharacter1 == "Scientist" || randCharacter1 == "Marine Biologist" || randCharacter1 == "Dr. Toxic" ||
                                randCharacter1 == "Physicist" || randCharacter1 == "Astronaut" || randCharacter1 == "Chemist" ||
                                randCharacter1 == "Archaeologist" || randCharacter1 == "Zoolgost" || randCharacter1 == "Paleontologist" ||
                                randCharacter1 == "Computer Scientist")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2ScientistAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2ScientistAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw2ScientistAbility3.Count);

                                label21.Text = $"{gw2ScientistAbility1[randAbility1]}";
                                label22.Text = $"{gw2ScientistAbility2[randAbility2]}";
                                label23.Text = $"{gw2ScientistAbility3[randAbility3]}";
                            }
                            if (randCharacter1 == "All-Star" || randCharacter1 == "Cricket Star" || randCharacter1 == "Hockey Star" ||
                                randCharacter1 == "Goalie Star" || randCharacter1 == "Rugby Star" || randCharacter1 == "Baseball Star" ||
                                randCharacter1 == "Wrestling Star" || randCharacter1 == "Golf Star" || randCharacter1 == "Tennis Star" ||
                                randCharacter1 == "Moto-X Star")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2AllStarAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2AllStarAbility2.Count);
                                int randAbility3 = randomAbility.Next(gw2AllStarAbility3.Count);

                                label21.Text = $"{gw2AllStarAbility1[randAbility1]}";
                                label22.Text = $"{gw2AllStarAbility2[randAbility2]}";
                                label23.Text = $"{gw2AllStarAbility3[randAbility3]}";
                            }
                            if (randCharacter1 == "Imp")
                            {
                                label21.Text = "Gravity Grenade";
                                label22.Text = "Robo Call";
                                label23.Text = "Impkata";
                            }    
                            if (randCharacter1 == "Lil' Drake")
                            {
                                label21.Text = "Gravity Grenade";
                                label22.Text = "Drake Call";
                                label23.Text = "Impkata";
                            }
                            if (randCharacter1 == "Pylon Imp")
                            {
                                var randomAbility = new Random();
                                int randAbility2 = randomAbility.Next(gw2ImpAbility2.Count);
                                label21.Text = "Gravity Grenade";
                                label22.Text = $"{gw2ImpAbility2[randAbility2]}";
                                label23.Text = "Impkata";
                            }
                            if (randCharacter1 == "S.H.R.Imp")
                            {
                                label21.Text = "Gravity Grenade";
                                label22.Text = "S.H.R.IMP Call";
                                label23.Text = "Impkata";
                            }
                            if (randCharacter1 == "Z7 Imp")
                            {
                                label21.Text = "Gravity Grenade";
                                label22.Text = "Z7 Call";
                                label23.Text = "Impkata";
                            }
                            if (randCharacter1 == "Party Imp")
                            {
                                label21.Text = "Gravity Grenade";
                                label22.Text = "Party Call";
                                label23.Text = "Impkata";
                            }
                            if (randCharacter1 == "Scallywag Imp")
                            {
                                label21.Text = "Gravity Grenade";
                                label22.Text = "Scallywag Call";
                                label23.Text = "Impkata";
                            }
                            if (randCharacter1 == "Super Brainz" || randCharacter1 == "Cozmic Brainz" || randCharacter1 == "Electro Brainz" ||
                                randCharacter1 == "Toxic Brainz" || randCharacter1 == "Party Brainz" || randCharacter1 == "Breakfast Brainz")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2SuperBrainzAbility1.Count);
                                label21.Text = $"{gw2SuperBrainzAbility1[randAbility1]}";
                                label22.Text = "Turbo Twister";
                                label23.Text = "Heroic Kick";
                            }
                            if (randCharacter1 == "Captain Deadbeard" || randCharacter1 == "Captain Cannon" || randCharacter1 == "Captain Flameface" ||
                                randCharacter1 == "Captain Sharkbite" || randCharacter1 == "Captain Partyman" || randCharacter1 == "Captain Squawk")
                            {
                                var randomAbility = new Random();
                                int randAbility1 = randomAbility.Next(gw2DeadbeardAbility1.Count);
                                int randAbility2 = randomAbility.Next(gw2DeadbeardAbility2.Count);
                                label21.Text = $"{gw2DeadbeardAbility1[randAbility1]}";
                                label22.Text = $"{gw2DeadbeardAbility2[randAbility2]}";
                                label23.Text = "Cannon Rodeo";
                            }
                            break;
                    }
                    break;
            }
        }

        private void gw2SettingsButton_Click(object sender, EventArgs e)
        {
            UnavailbaleFeature();
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


        //Plant Abilities
        List<string> gw2PeaAbility1 = new List<string>
        {
            "Chili Bean Bomb", "Sombrero Bean Bomb", "Dark Bean Bomb"
        };
        List<string> gw2PeaAbility2 = new List<string>
        {
            "Pea Gatling", "Retro Gatling", "Bling Gatling"
        };
        List<string> gw2PeaAbility3 = new List<string>
        {
            "Hyper", "Super Pea Jump"
        };
        List<string> gw2ChomperAbility1 = new List<string>
        {
            "Spikeweed", "Spiky Spikeweed", "Vampweed"
        };
        List<string> gw2ChomperAbility2 = new List<string>
        {
            "Burrow", "Sprint Burrow"
        };
        List<string> gw2ChomperAbility3 = new List<string>
        {
            "Goop", "Super Sticky Goop", "Chomp Cannon"
        };
        List<string> gw2SunflowerAbility1 = new List<string>
        {
            "Heal Beam", "Rainbow Heal Beam"
        };
        List<string> gw2SunflowerAbility2 = new List<string>
        {
            "Sunbeam", "Solar Flare Beam"
        };
        List<string> gw2SunflowerAbility3 = new List<string>
        {
            "Heal Flower", "Dark Flower", "Rainbow Heal Flower"
        };
        List<string> gw2CactusAbility1 = new List<string>
        {
            "Potato Mine", "Potato Nugget Mine", "Bling Potato Mine"
        };
        List<string> gw2CactusAbility2 = new List<string>
        {
            "Garlic Drone", "Artichoke Drone", "Dark Garlic Drone", "Red Artichoke Drone"
        };
        List<string> gw2CactusAbility3 = new List<string>
        {
            "Tallnut Battlements", "Iron Maiden", "Bling Maiden"
        };
        List<string> gw2CornAbility1 = new List<string>
        { 
            "Butter Barrage", "Bigger Better Butter"
        };
        List<string> gw2CornAbility2 = new List<string>
        {
            "Husk Hop"
        };
        List<string> gw2CornAbility3 = new List<string>
        {
            "Shuck Shot", "Multi-Shuck"
        };
        List<string> gw2CitronAbility1 = new List<string>
        {
            "Peel Shield", "Mood Shield"
        };
        List<string> gw2CitronAbility2 = new List<string>
        {
            "Citron Ball"
        };
        List<string> gw2CitronAbility3 = new List<string>
        {
            "E.M.Peach"
        };
        List<string> gw2RoseAbility1 = new List<string>
        {
            "Time Snare"
        };
        List<string> gw2RoseAbility2 = new List<string>
        {
            "Arcane Enigma", "Arcane Lotus"
        };
        List<string> gw2RoseAbility3 = new List<string>
        {
            "Goatify", "Psychedelic Goat"
        };

        //Zombie Abilities
        List<string> gw2SoldierAbility1 = new List<string>
        {
            "Zombie Stink Cloud", "Super Stink Cloud"
        };
        List<string> gw2SoldierAbility2 = new List<string>
        {
            "Rocket Jump", "Rocket Leap"
        };
        List<string> gw2SoldierAbility3 = new List<string>
        {
            "ZPG", "Multi-Rocket"
        };
        List<string> gw2EngineerAbility1 = new List<string>
        {
            "Sonic Grenade", "Proximity Sonic Mines"
        };
        List<string> gw2EngineerAbility2 = new List<string>
        {
            "Big Bolt Blaster", "Bedazzled Bolt Blaster"
        };
        List<string> gw2EngineerAbility3 = new List<string>
        {
            "Jackhammer", "Turbo Jackhammer"
        };
        List<string> gw2ScientistAbility1 = new List<string>
        {
            "Sticky Explody Bomb", "Mega Heal Bomb"
        };
        List<string> gw2ScientistAbility2 = new List<string>
        {
            "Warp", "Energy Warp"
        };
        List<string> gw2ScientistAbility3 = new List<string>
        {
            "Zombie Heal Beam", "Zombie Heal Station", "Bling Heal Station", "Armored Bling Station"
        };
        List<string> gw2AllStarAbility1 = new List<string>
        {
            "Imp Punt", "Long Bomb"
        };
        List<string> gw2AllStarAbility2 = new List<string>
        {
            "Sprint Tackle", "Ultra Tackle"
        };
        List<string> gw2AllStarAbility3 = new List<string>
        {
            "Dummy Shield", "Shield Decoy", "Future Dummy"
        };
        List<string> gw2ImpAbility2 = new List<string>
        {
            "Pylon Call", "Bling Pylon Call"
        };
        List<string> gw2SuperBrainzAbility1 = new List<string>
        {
            "Super Ultra Ball", "Super Multi Ball", "Super Guided Ultra Ball"
        };
        List<string> gw2DeadbeardAbility1 = new List<string>
        {
            "Barrel Blast", "Looty Booty Barrel Blast"
        };
        List<string> gw2DeadbeardAbility2 = new List<string>
        {
            "Parrot Pal", "Future Parrot Pal"
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