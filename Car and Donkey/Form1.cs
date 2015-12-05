using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_and_Donkey
{
    public partial class Form1 : Form
    {
        Random ran = new Random();

        bool picking = false;
        int correctDoor;

        string poss1 = "CDD";
        string poss2 = "DCD";
        string poss3 = "DDC";

        bool poss1going;
        bool poss2going;
        bool poss3going;

        int userChoice;
        int flippedDoor;

        int winsCtr;
        int lossesCtr;


        public Form1()
        {
            InitializeComponent();
        }

        private void RunSimulation(int timesToRun)
        {

            Simulation_part1();


        }

        private void reset()
        {
            choice1btn.BackColor = Color.Gray;
            choice2btn.BackColor = Color.Gray;
            choice3btn.BackColor = Color.Gray;
            //activityLog.Items.Clear();
            //resultsList.Items.Clear();
            poss1going = false;
            poss2going = false;
            poss3going = false;

            choice1btn.BackgroundImage = null;
            choice2btn.BackgroundImage = null;
            choice3btn.BackgroundImage = null;

            switchPanel.Visible = false;

            PickADoor.Text = "PICK A DOOR";
        }

        

        private void Simulation_part1()
        {
            reset();
            startButton.Enabled = false;

            PickADoor.Visible = true;


            correctDoor = ran.Next(1, 4);

            LogActivity("CORRECT DOOR IS: " + correctDoor.ToString());
            if (correctDoor == 1)
            {
                poss1going = true;
                //LogActivity("THE POSSIBILITY GOING IS: " + poss1going);

            }
            else if (correctDoor == 2)
            {
                poss2going = true;
                //LogActivity("THE POSSIBILITY GOING IS: " + poss2going);

            }
            else
            {
                poss3going = true;
                //LogActivity("THE POSSIBILITY GOING IS: " + poss3going);

            }

           
            picking = true;
        }

        private void Simulation_part2(int doorChoice)
        {
            if (poss1going)
            {
                int doorToReveal = ran.Next(2, 4);
                flippedDoor = doorToReveal;

                //LogActivity("The flipped door is: " + flippedDoor.ToString());
                if (doorChoice == 1)
                {
                    
                    if (doorToReveal == 2)
                    {
                        //choice2btn.Text = "DONKEY";
                        choice2btn.BackgroundImage = Properties.Resources.donkey1;
                    } else
                    {
                        //choice3btn.Text = "DONKEY";
                        choice3btn.BackgroundImage = Properties.Resources.donkey1;

                    }
                }
                else if(doorChoice == 2)
                {
                        //choice3btn.Text = "DONKEY";
                    choice3btn.BackgroundImage = Properties.Resources.donkey1;

                }
                else
                {
                       // choice2btn.Text = "DONKEY";
                    choice2btn.BackgroundImage = Properties.Resources.donkey1;

                }
            }
            else if (poss2going)
            {
                int doorToReveal = ran.Next(2, 4);
                flippedDoor = doorToReveal;
                //LogActivity("The flipped door is: " + flippedDoor.ToString());

                if (doorChoice == 2)
                {
                    

                    if (doorToReveal == 2)
                    {
                        //choice1btn.Text = "DONKEY";
                        choice1btn.BackgroundImage = Properties.Resources.donkey1;

                    }
                    else
                    {
                        //choice3btn.Text = "DONKEY";
                        choice3btn.BackgroundImage = Properties.Resources.donkey1;

                    }
                }
                else if (doorChoice == 1)
                {
                    //choice3btn.Text = "DONKEY";
                    choice3btn.BackgroundImage = Properties.Resources.donkey1;

                }
                else
                {
                    //choice1btn.Text = "DONKEY";
                    choice1btn.BackgroundImage = Properties.Resources.donkey1;

                }
            }
            else if (poss3going)
            {
                int doorToReveal = ran.Next(2, 4);
                flippedDoor = doorToReveal;
                LogActivity("The flipped door is: " + flippedDoor.ToString());

                if (doorChoice == 3)
                {
                   

                    if (doorToReveal == 2)
                    {
                        choice1btn.BackgroundImage = Properties.Resources.donkey1;

                        //choice1btn.Text = "DONKEY";
                    }
                    else
                    {
                        choice2btn.BackgroundImage = Properties.Resources.donkey1;

                        //choice2btn.Text = "DONKEY";
                    }
                }
                else if (doorChoice == 1)
                {
                    choice2btn.BackgroundImage = Properties.Resources.donkey1;

                    //choice2btn.Text = "DONKEY";
                }
                else
                {
                    choice1btn.BackgroundImage = Properties.Resources.donkey1;

                    //choice1btn.Text = "DONKEY";
                }
            }
            wannaSwitch();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            RunSimulation(5);
        }

        private void chooseDoor(int doorChoice)
        {

        }

        private void LogActivity(string activity)
        {
            activityLog.Items.Add(activity);
        }

        private void choice1btn_Click(object sender, EventArgs e)
        {
            if (picking)
            {
                choice1btn.BackColor = Color.Green;
                userChoice = 1;
                Simulation_part2(1);

            }


        }

        private void choice2btn_Click(object sender, EventArgs e)
        {
            if (picking)
            {
                choice2btn.BackColor = Color.Green;

                userChoice = 2;

                Simulation_part2(2);

            }

        }

        private void choice3btn_Click(object sender, EventArgs e)
        {
            if (picking)
            {
                choice3btn.BackColor = Color.Green;

                userChoice = 3;

                Simulation_part2(3);

            }

        }

        

        private void endGame(string condition)
        {
            startButton.Enabled = true;

            if (condition == "win")
            {
                playerWins();
            }
            else
            {
                playerLoses();
            }
        }
        private void playerWins()
        {
            picking = false;
            switchPanel.Visible = false;
            resultsList.Items.Add("you win");
            PickADoor.Text = "YOU WIN!";
            winsCtr += 1;
            wins.Text = winsCtr.ToString();

            using (var player = new SoundPlayer(Properties.Resources.carstart))
            {
                player.Play();
            }

        }

        private void playerLoses()
        {
            picking = false;

            PickADoor.Text = "YOU LOSE!";
            switchPanel.Visible = false;

            resultsList.Items.Add("you lost");
            lossesCtr += 1;
            losses.Text = lossesCtr.ToString();
            using (var player = new SoundPlayer(Properties.Resources.donkey))
            {
                player.Play();
            }
        }


        private void wannaSwitch()
        {
            switchPanel.Visible = true;

            /*DialogResult dialogResult = MessageBox.Show("Want to switch?", "Want to switch?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (poss1going)
                {
                    if (userChoice == 1)
                    {
                        playerLoses();
                    }
                    else
                    {
                        playerWins();

                    }

                    choice1btn.Text = "CAR";
                    choice1btn.BackgroundImage = Properties.Resources.car;
                    choice2btn.BackgroundImage = Properties.Resources.donkey1;
                    choice3btn.BackgroundImage = Properties.Resources.donkey1;

                    choice2btn.Text = "DONKEY";
                    choice3btn.Text = "DONKEY";

                }
                if (poss2going)
                {
                    if (userChoice == 2)
                    {
                        playerLoses();


                    }
                    else
                    {
                        playerWins();

                    }

                    choice1btn.Text = "DONKEY";
                    choice2btn.Text = "CAR";
                    choice3btn.Text = "DONKEY";

                    choice2btn.BackgroundImage = Properties.Resources.car;
                    choice1btn.BackgroundImage = Properties.Resources.donkey1;
                    choice3btn.BackgroundImage = Properties.Resources.donkey1;

                }
                if (poss3going)
                {
                    if (userChoice == 3)
                    {
                        playerLoses();


                    }
                    else
                    {
                        playerWins();

                    }

                    choice1btn.Text = "DONKEY";
                    choice2btn.Text = "DONKEY";
                    choice3btn.Text = "CAR";

                    choice3btn.BackgroundImage = Properties.Resources.car;
                    choice2btn.BackgroundImage = Properties.Resources.donkey1;
                    choice1btn.BackgroundImage = Properties.Resources.donkey1;

                }


                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            */
        }

        private void choiceYes_Click(object sender, EventArgs e)
        {
            if (poss1going)
            {
                if (userChoice == 1)
                {
                    endGame("lose");
                }
                else
                {
                    endGame("win");

                }

                
                choice1btn.BackgroundImage = Properties.Resources.car;
                choice2btn.BackgroundImage = Properties.Resources.donkey1;
                choice3btn.BackgroundImage = Properties.Resources.donkey1;
                

            }
            if (poss2going)
            {
                if (userChoice == 2)
                {
                    endGame("lose");


                }
                else
                {
                    endGame("win");

                }

                

                choice2btn.BackgroundImage = Properties.Resources.car;
                choice1btn.BackgroundImage = Properties.Resources.donkey1;
                choice3btn.BackgroundImage = Properties.Resources.donkey1;

            }
            if (poss3going)
            {
                if (userChoice == 3)
                {
                    endGame("lose");


                }
                else
                {
                    endGame("win");

                }

                

                choice3btn.BackgroundImage = Properties.Resources.car;
                choice2btn.BackgroundImage = Properties.Resources.donkey1;
                choice1btn.BackgroundImage = Properties.Resources.donkey1;

            }
        }

        private void choiceNo_Click(object sender, EventArgs e)
        {
            if (poss1going)
            {
                if (userChoice == 1)
                {
                    endGame("win");
                    
                }
                else
                {
                    endGame("lose");

                }

                
                choice1btn.BackgroundImage = Properties.Resources.car;
                choice2btn.BackgroundImage = Properties.Resources.donkey1;
                choice3btn.BackgroundImage = Properties.Resources.donkey1;
                

            }
            if (poss2going)
            {
                if (userChoice == 2)
                {
                    endGame("win");


                }
                else
                {
                    endGame("lose");
                }

                

                choice2btn.BackgroundImage = Properties.Resources.car;
                choice1btn.BackgroundImage = Properties.Resources.donkey1;
                choice3btn.BackgroundImage = Properties.Resources.donkey1;

            }
            if (poss3going)
            {
                if (userChoice == 3)
                {
                    endGame("win");


                }
                else
                {
                    endGame("lose");
                }

                

                choice3btn.BackgroundImage = Properties.Resources.car;
                choice2btn.BackgroundImage = Properties.Resources.donkey1;
                choice1btn.BackgroundImage = Properties.Resources.donkey1;

            }
        }

        private void runSimulationBtn_Click(object sender, EventArgs e)
        {
            runSimluator(Int32.Parse(timesToRun.Text));
        }

        private void runSimluator(int timesToRun)
        {

            for (int runtimes = 0; runtimes < timesToRun; runtimes++)
            {
                var doorchoice = ran.Next(1, 4);
                LogActivity("Doorchoice was: " + doorchoice.ToString());
                userChoice = doorchoice;
                Simulation_part1();
                Simulation_part2(userChoice);
                if (yesEveryTime.Checked)
                {
                    choiceYes_Click(this, null);

                }
                else
                {
                    choiceNo_Click(this, null);

                }
                reset();
                
                
            }
           

        }

        private void noEveryTime_CheckedChanged(object sender, EventArgs e)
        {
            if (noEveryTime.Checked)
            {
                yesEveryTime.Checked = false;
            }
        }

        private void yesEveryTime_CheckedChanged(object sender, EventArgs e)
        {
            if (yesEveryTime.Checked)
            {
                noEveryTime.Checked = false;
            }
        }
    }
}
