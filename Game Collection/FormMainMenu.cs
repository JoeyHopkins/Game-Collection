using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Collection
{
    public partial class FormMainMenu : Form
    {
        string GameOne = "Game 1";
        string GameTwo = "Game 2";
        string GameThree = "Game 3";

        int gameNameNextLocationX = 1500;
        int gameNamePrevLocationX = -1170;
        int gameNameLocationY = 435;

        static int lastGame = 2;

        int previousGame = lastGame;
        int currentGame = 0;
        int nextGame = 1;

        bool changedGame = false;
        char direction;

        char left = 'L';
        char right = 'R';

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelGameTwoMainMenu.Location = new Point(gameNameNextLocationX, gameNameLocationY);
            LabelGameThreeMainMenu.Location = new Point(gameNamePrevLocationX, gameNameLocationY);

        }


        private void TimerMainMenu_Tick(object sender, EventArgs e)
        {
            if(changedGame == true)
            {

                ButtonNextGameMainMenu.Enabled = false;
                ButtonPreviousGameMainMenu.Enabled = false;
                ButtonPlayMainMenu.Enabled = false;

                if (direction == 'L')
                {
                    LabelGameOneMainMenu.Left -= 30;
                    LabelGameTwoMainMenu.Left -= 30;
                }
                else
                {
                    LabelGameOneMainMenu.Left += 30;
                    LabelGameThreeMainMenu.Left += 30;
                }

                if(LabelGameTwoMainMenu.Left == 330 || LabelGameThreeMainMenu.Left == 330)
                {
                    changedGame = false;
                    
                    if(direction == left)
                    {
                        LabelGameOneMainMenu.Text = LabelGameTwoMainMenu.Text;
                        LabelGameOneMainMenu.Location = LabelGameTwoMainMenu.Location;
                        LabelGameTwoMainMenu.Location = new Point(gameNameNextLocationX, gameNameLocationY);
                    }
                    else
                    {
                        LabelGameOneMainMenu.Text = LabelGameThreeMainMenu.Text;
                        LabelGameOneMainMenu.Location = LabelGameThreeMainMenu.Location;
                        LabelGameThreeMainMenu.Location = new Point(gameNamePrevLocationX, gameNameLocationY);
                    }


                    changeGameNames();

                    ButtonNextGameMainMenu.Enabled = true;

                    ButtonPreviousGameMainMenu.Enabled = true;
                    ButtonPlayMainMenu.Enabled = true;

                    //LabelTest.Text = "Prev = " + previousGame.ToString() + "\nCurrent = " + currentGame.ToString() + "\nNext = " + nextGame.ToString();


                }

            }
        }

        public void changeGameNames()
        {
            switch (previousGame)
            {
                case 0:
                    LabelGameThreeMainMenu.Text = GameOne;
                    break;
                case 1:
                    LabelGameThreeMainMenu.Text = GameTwo;
                    break;
                case 2:
                    LabelGameThreeMainMenu.Text = GameThree;
                    break;
            }

            switch (nextGame)
            {
                case 0:
                    LabelGameTwoMainMenu.Text = GameOne;
                    break;
                case 1:
                    LabelGameTwoMainMenu.Text = GameTwo;
                    break;
                case 2:
                    LabelGameTwoMainMenu.Text = GameThree;
                    break;
            }

        }

        private void ButtonPlayMainMenu_Click(object sender, EventArgs e)
        {
            switch(currentGame)
            {
                case 0:
                    FormGameOne GameOne = new FormGameOne();
                    GameOne.ShowDialog();
                    break;
                case 1:
                    FormGameTwo GameTwo = new FormGameTwo();
                    GameTwo.ShowDialog();
                    break;
                case 2:
                    FormGameThree GameThree = new FormGameThree();
                    GameThree.ShowDialog();
                    break;
            }
        }


        private void ButtonNextGameMainMenu_Click(object sender, EventArgs e)
        {
            if (currentGame == lastGame)
            {
                previousGame = lastGame;
                currentGame = 0;
                nextGame = 1;
            }
            else if (currentGame == lastGame - 1)
            {
                previousGame++;
                currentGame++;
                nextGame = 0;
            }
            else if(currentGame == 0)
            {
                previousGame = 0;
                currentGame++;
                nextGame++;
            }
            else
            {
                previousGame++;
                currentGame++;
                nextGame++;
            }

            changedGame = true;
            direction = left;
        }

        private void ButtonPreviousGameMainMenu_Click(object sender, EventArgs e)
        {
            if (currentGame == lastGame)
            {
                previousGame--;
                currentGame--;
                nextGame = lastGame;
            }
            else if (currentGame == 1)
            {
                previousGame = lastGame;
                currentGame = 0;
                nextGame--;
            }
            else if (currentGame == 0)
            {
                previousGame--;
                currentGame = lastGame;
                nextGame--;
            }
            else
            {
                previousGame--;
                currentGame--;
                nextGame--;
            }


            changedGame = true;
            direction = right;
        }
            
        

        private void ButtonQuitMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
