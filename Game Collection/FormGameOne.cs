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
    public partial class FormGameOne : Form
    {
        PlayerG1 Player;
        BadGuyG1 BadOne;
        BadGuyG1 BadTwo;
        BadGuyG1 BadThree;
        BadGuyG1 BadFour;
        BadGuyG1 BadFive;
        BadGuyG1 BadSix;
        BadGuyG1 BadSeven;
        BadGuyG1 BadEight;

        Label[,] Dirt;

        Label Score;
        Label EnemiesLeft;
        Label ReadyCountdown;

        char up = 'U', down = 'D', left = 'L', right = 'R', noDirection = 'n';

        int airgunSize = 5;

        int enemiesLeft;

        int score = 0;

        bool beginAnimation;
        bool beginCountdown;
        int animationTimer;

        int BoomCounter = 0;

        int dirtWidth = 31;
        int dirtHeight = 19;

        int level = 1;

        //Create the form, Init objects, and prep Level One
        public FormGameOne()
        {
            InitializeComponent();
            InitGround();
            InitCharacters();
            InitGameInformation();
            PrepareLevel();
        }

        //Create the dirt blocks and line them up on the form
        private void InitGround()
        {
            Dirt = new Label[dirtHeight , dirtWidth];

            int x, y = 240;
            int startX = 7;
            int numX;
            int numY = 1;

            for(int i = 0; i < dirtHeight; i++)
            {
                x = startX;
                numX = 1;

                for(int j = 0; j < dirtWidth; j++)
                {
                    Dirt[i , j] = new Label();
                    Dirt[i, j].Text = "###\r\n###\r\n###";
                    Dirt[i, j].Tag = "Dirt";
                    Dirt[i, j].Name = "Dirt " + numX +" " + numY;
                    Dirt[i, j].BackColor = Color.Peru;
                    Dirt[i, j].AutoSize = false;
                    Dirt[i, j].Size = new Size(28, 38);
                    Dirt[i, j].Location = new Point(x, y);
                    Dirt[i, j].Visible = true;
                    this.Controls.Add(Dirt[i, j]);
                    Dirt[i, j].BringToFront();

                    numX++;
                    x += 32;
                }
                numY++;
                y += 41;
            }
        }

        //Create the Characters and set up the airguns for each character
        private void InitCharacters()
        {
            CreateNewCharacters("BadOne");
            CreateNewCharacters("BadTwo");
            CreateNewCharacters("BadThree");
            CreateNewCharacters("BadFour");
            CreateNewCharacters("BadFive");
            CreateNewCharacters("BadSix");
            CreateNewCharacters("BadSeven");
            CreateNewCharacters("BadEight");
            CreateNewCharacters("Player");

            SetupAirguns();
        }

        //Set up the labels that will handle providing Game information to the player
        private void InitGameInformation()
        {
            //Score tells the players score
            Score = new Label();
            Score.AutoSize = true;
            Score.Font = new Font("Arial Narrow", 24.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Score.Location = new Point(14, 9);
            Score.Text = "Score: 0";
            Score.Visible = true;
            this.Controls.Add(Score);

            //EnemiesLeft tells how many enemies are left
            EnemiesLeft = new Label();
            EnemiesLeft.AutoSize = true;
            EnemiesLeft.Font = new Font("Arial Narrow", 24.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            EnemiesLeft.Location = new Point(780, 9);
            EnemiesLeft.Text = "Enimies Left: 0";
            EnemiesLeft.Visible = true;
            this.Controls.Add(EnemiesLeft);

            //ReadyCountdown is used to transfer control to the Player after intro animation
            ReadyCountdown = new Label();
            ReadyCountdown.AutoSize = false;
            ReadyCountdown.Font = new Font("Pristina", 72F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            ReadyCountdown.Location = new Point(281, 370);
            ReadyCountdown.Text = "Ready??";
            ReadyCountdown.BackColor = Color.Peru;
            ReadyCountdown.Size = new Size(389, 137);
            ReadyCountdown.TextAlign = ContentAlignment.MiddleCenter;
            ReadyCountdown.Visible = false;
            this.Controls.Add(ReadyCountdown);
            ReadyCountdown.BringToFront();
        }

        //Sets up the Label for each Character ands adds them to the list of Controls
        private void CreateNewCharacters(string CharacterName)
        {
            switch (CharacterName)
            {
                case "Player":
                    Player = new PlayerG1();
                    this.Controls.Add(Player);
                    Player.BringToFront();
                    break;
                case "BadOne":
                    BadOne = new BadGuyG1("BadOne");
                    this.Controls.Add(BadOne);
                    BadOne.Visible = false;
                    BadOne.BringToFront();
                    break;
                case "BadTwo":
                    BadTwo = new BadGuyG1("BadTwo");
                    this.Controls.Add(BadTwo);
                    BadTwo.Visible = false;
                    BadTwo.BringToFront();
                    break;
                case "BadThree":
                    BadThree = new BadGuyG1("BadThree");
                    this.Controls.Add(BadThree);
                    BadThree.Visible = false;
                    BadThree.BringToFront();
                    break;
                case "BadFour":
                    BadFour = new BadGuyG1("BadFour");
                    this.Controls.Add(BadFour);
                    BadFour.Visible = false;
                    BadFour.BringToFront();
                    break;
                case "BadFive":
                    BadFive = new BadGuyG1("BadFive");
                    this.Controls.Add(BadFive);
                    BadFive.Visible = false;
                    BadFive.BringToFront();
                    break;
                case "BadSix":
                    BadSix = new BadGuyG1("BadSix");
                    this.Controls.Add(BadSix);
                    BadSix.Visible = false;
                    BadSix.BringToFront();
                    break;
                case "BadSeven":
                    BadSeven = new BadGuyG1("BadSeven");
                    this.Controls.Add(BadSeven);
                    BadSeven.Visible = false;
                    BadSeven.BringToFront();
                    break;
                case "BadEight":
                    BadEight = new BadGuyG1("BadEight");
                    this.Controls.Add(BadEight);
                    BadEight.Visible = false;
                    BadEight.BringToFront();
                    break;
            }
        }

        //Sets up the characters Airguns
        private void SetupAirguns()
        {
            Player.SetupAirgun(airgunSize);
            BadOne.SetupAirgun(airgunSize);
            BadTwo.SetupAirgun(airgunSize);
            BadThree.SetupAirgun(airgunSize);
            BadFour.SetupAirgun(airgunSize);
            BadFive.SetupAirgun(airgunSize);
            BadSix.SetupAirgun(airgunSize);
            BadSeven.SetupAirgun(airgunSize);
            BadEight.SetupAirgun(airgunSize);

            //Adds the airguns to the list of controls
            for (int i = 0; i < airgunSize; i++)
            {
                this.Controls.Add(Player.MyAirgun[i]);
                Player.MyAirgun[i].BringToFront();

                this.Controls.Add(BadOne.MyAirgun[i]);
                BadOne.MyAirgun[i].BringToFront();

                this.Controls.Add(BadTwo.MyAirgun[i]);
                BadTwo.MyAirgun[i].BringToFront();

                this.Controls.Add(BadThree.MyAirgun[i]);
                BadThree.MyAirgun[i].BringToFront();

                this.Controls.Add(BadFour.MyAirgun[i]);
                BadFour.MyAirgun[i].BringToFront();

                this.Controls.Add(BadFive.MyAirgun[i]);
                BadFive.MyAirgun[i].BringToFront();

                this.Controls.Add(BadSix.MyAirgun[i]);
                BadSix.MyAirgun[i].BringToFront();

                this.Controls.Add(BadSeven.MyAirgun[i]);
                BadSeven.MyAirgun[i].BringToFront();

                this.Controls.Add(BadEight.MyAirgun[i]);
                BadEight.MyAirgun[i].BringToFront();
            }

            //Brings characters to the front so they are the top most Labels
            Player.BringToFront();
            BadOne.BringToFront();
            BadTwo.BringToFront();
            BadThree.BringToFront();
            BadFour.BringToFront();
            BadFive.BringToFront();
            BadSix.BringToFront();
            BadSeven.BringToFront();
            BadEight.BringToFront();
        }

        //Level one All Prep
        private void PrepareLevel()
        {
            //Turn on Timer to begin Game Functionality
            GameOneTimer.Enabled = true;

            //Get the Player and BadGuys ready 
            GetPlayerReady();
            GetBadGuysReady();
            
            //Set the player as alive
            Player.Alive = true;

            //Set up the dirt for the level
            PrepLevelOneDirt();

            //Reset and allow intro animation to begin
            beginAnimation = true;
            beginCountdown = false;
            animationTimer = 0;
        }

        //Get the player ready for beginning the game
        private void GetPlayerReady()
        {
            Player.Location = new Point(-100, 200);
            Player.moveDirection = noDirection;
        }

        //Get the BadGuys ready for beginning the game
        private void GetBadGuysReady()
        {

            BadOne.Location = new Point(110, 440);
            BadOne.Reset();

            BadTwo.Location = new Point(750, 320);
            BadTwo.Reset();

            BadThree.Location = new Point(650, 770);
            BadThree.Reset();

            enemiesLeft = 3;

            //If level is greater then level 1, allow these characters to join the match
            if (level > 1)
            {
                BadFour.Location = new Point(810, 570);
                BadFour.Reset();

                BadFive.Location = new Point(300, 855);
                BadFive.Reset();

                enemiesLeft = 5;
            }
            //If level is greater then level 2, allow these characters to join the match
            if (level > 2)
            {
                BadSix.Location = new Point(170, 690);
                BadSix.Reset();

                BadSeven.Location = new Point(900, 900);
                BadSeven.Reset();

                BadEight.Location = new Point(620, 450);
                BadEight.Reset();

                enemiesLeft = 8;
            }
        }

        //When the Player dies, Provide the GameOver Form
        private void GameOver()
        {
            //turn off the Timer to pause the game
            GameOneTimer.Enabled = false;

            FormYouLose YouLose = new FormYouLose();
            DialogResult retryResult = YouLose.ShowDialog();

            //If Player decides to quit, Close this form as well
            if (retryResult == DialogResult.Abort)
                Close();

            //If Player decides to Continue, Retry the game
            retryGame();
        }

        //When the Player wins, Provide the YouWin Form

        private void LevelWin()
        {
            //turn off the Timer to pause the game
            GameOneTimer.Enabled = false;

            //Go to the next level
            level++;

            //if level is less then 4, provide YouWin Form
            if (level < 4)
            {
                FormYouWin YouWin = new FormYouWin();
                DialogResult winResult = YouWin.ShowDialog();

                //If Player decides not to continue, Leave
                if (winResult == DialogResult.Abort)
                    Close();
                //Else Prepare the next level
                else
                    PrepareLevel();
            }
            //else Player has completed the final level so provide Final Win Form and Close this Form 
            else
            {
                FormFinalWin GameWon = new FormFinalWin();
                GameWon.ShowDialog();
                Close();
            }
        }

        //If Player chooses to retry, prep level and turn the timer back on
        private void retryGame()
        {
            PrepareLevel();
            GameOneTimer.Enabled = true;
        }

        //Turn off the animation to hand over control to the Player
        private void beginGame()
        {
            beginAnimation = false;
        }

        //Update the game information that is provided to the Player
        private void UpdateGameInformation()
        {
            Score.Text = "Score: " + score;
            EnemiesLeft.Text = "Enemies Left: " + enemiesLeft;
        }

        //Timer Ticks allow for Game functionality
        private void GameOneTimer_Tick(object sender, EventArgs e)
        {
            //Check for and adjust the players background if needed to match current background
            CheckCharacterBackground();

            //Check for any collisions to see if an action is needed
            CheckCollisions();

            //Update the score and enemies left game information
            UpdateGameInformation();

            //If beginning of the game, run the intro animation
            if (beginAnimation == true)
                RunAnimation();

            //Else animation is over so play the game
            else
            {
                //If all enemies are dead, complete the level
                if (enemiesLeft == 0)
                    LevelWin();

                //if the player dies, run Game over
                if (Player.Alive == false)
                    GameOver();

                //move the player 
                MoveCharacters();

                //Shoot character Air Guns if they wish to shoot
                ShootAirgun();

                //If Player has hit a BadGuy, Have Proper Bad Guy react
                if (Player.targetHit != "")
                    BadGuyHit(Player.targetHit);

                //Check for any needed animation changes
                CheckForAnimations();

                BadGuyAI();
            }
        }

        //If Bad guy is alive, run the AI
        private void BadGuyAI()
        {
            if (BadOne.Alive)
                BadOne.BadGuyAI();

            if (BadTwo.Alive)
                BadTwo.BadGuyAI();

            if (BadThree.Alive)
                BadThree.BadGuyAI();

            if (BadFour.Alive)
                BadFour.BadGuyAI();

            if (BadFive.Alive)
                BadFive.BadGuyAI();

            if (BadSix.Alive)
                BadSix.BadGuyAI();

            if (BadSeven.Alive)
                BadSeven.BadGuyAI();

            if (BadEight.Alive)
                BadEight.BadGuyAI();
        }

        //Run the intro animation
        private void RunAnimation()
        {
            if (beginCountdown == false)
            {
                //Bring Player to middle of the screen
                if (Player.Location.X < 460 && animationTimer == 0)
                    Player.MoveRight();
                else
                {
                    animationTimer++;
                    //Look and move left
                    if (animationTimer == 10 || animationTimer == 20)
                        Player.MoveLeft();
                    //Look and move right
                    else if (animationTimer == 30 || animationTimer == 40)
                        Player.MoveRight();
                    else if (animationTimer > 50)
                    {
                        //Move Player down to proper spot underground
                        if (Player.Location.Y < 570)
                            Player.MoveDown();
                        //look to the left and end the animation
                        else
                        {
                            Player.MoveLeft();
                            animationTimer = -1;
                            beginCountdown = true;
                        }
                    }
                }
            }
            //Begin and run the Coundown
            else
            {
                animationTimer++;
                switch (animationTimer)
                {
                    case 0:
                        ReadyCountdown.Text = "Ready";
                        ReadyCountdown.Visible = true;
                        break;
                    case 10:
                        ReadyCountdown.Text = "3";
                        break;
                    case 20:
                        ReadyCountdown.Text = "2";
                        break;
                    case 30:
                        ReadyCountdown.Text = "1";
                        break;
                    case 40:
                        ReadyCountdown.Text = "Go!!";
                        break;
                    case 50:
                        ReadyCountdown.Visible = false;
                        beginGame();
                        break;
                }
            }
        }

        //If Bad Guy is Rit, Run animations on Proper BadGuy
        private void BadGuyHit(string TargetName)
        {
            switch (TargetName)
            { 
                case "BadOne":
                    BadOne.IsHit();
                    break;
                case "BadTwo":
                    BadTwo.IsHit();
                    break;
                case "BadThree":
                    BadThree.IsHit();
                    break;
                case "BadFour":
                    BadFour.IsHit();
                    break;
                case "BadFive":
                    BadFive.IsHit();
                    break;
                case "BadSix":
                    BadSix.IsHit();
                    break;
                case "BadSeven":
                    BadSeven.IsHit();
                    break;
                case "BadEight":
                    BadEight.IsHit();
                    break;
            }
        }

        //Check for needed animations
        private void CheckForAnimations()
        {
            foreach (Control x in this.Controls)
            {
                if(x is Label)
                {
                    if((string)x.Tag == "BadGuy")
                    {
                        //If BadGuy has the Boom animation currently set, make it disappear and adjust the proper game information fields
                        if (x.Text == Player.HitAnimationBOOM && x.Visible == true)
                        {
                            BoomCounter++;

                            if(BoomCounter % 20 == 0)
                            {
                                x.Visible = false;
                                enemiesLeft--;
                                BoomCounter = 0;
                                score += 10;
                            }
                        }
                        
                        //If BadGuy has been hit and Player decides to let go, Reverse the hit animaition
                        if (((string)x.Text == Player.HitAnimation0 || (string)x.Text == Player.HitAnimation1 || (string)x.Text == Player.HitAnimation2 || (string)x.Text == Player.HitAnimation3) && Player.targetHit != x.Name)
                            ReverseAnimations(x.Name);
                    }
                }
            }
        }

        //Reverse the hit animation for the proper BadGuy
        private void ReverseAnimations(string Name)
        {
            switch (Name)
            {
                case "BadOne":
                    BadOne.ReverseAnimation();
                    break;
                case "BadTwo":
                    BadTwo.ReverseAnimation();
                    break;
                case "BadThree":
                    BadThree.ReverseAnimation();
                    break;
                case "BadFour":
                    BadFour.ReverseAnimation();
                    break;
                case "BadFive":
                    BadFive.ReverseAnimation();
                    break;
                case "BadSix":
                    BadSix.ReverseAnimation();
                    break;
                case "BadSeven":
                    BadSeven.ReverseAnimation();
                    break;
                case "BadEight":
                    BadEight.ReverseAnimation();
                    break;
            }
        }

        //Allow the proper character to shoot their Airgun
        private void ShootAirgun()
        {
            if (Player.shootAirgun == true)
                Player.Shoot();

            if (BadOne.shootAirgun == true)
                BadOne.Shoot();

            if (BadTwo.shootAirgun == true)
                BadTwo.Shoot();

            if (BadThree.shootAirgun == true)
                BadThree.Shoot();

            if (BadFour.shootAirgun == true)
                BadFour.Shoot();

            if (BadFive.shootAirgun == true)
                BadFive.Shoot();

            if (BadSix.shootAirgun == true)
                BadSix.Shoot();

            if (BadSeven.shootAirgun == true)
                BadSeven.Shoot();

            if (BadEight.shootAirgun == true)
                BadEight.Shoot();
        }


        //Check for in game collisions
        private void CheckCollisions()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Label)
                { 
                    if ((string)x.Tag == "Dirt")
                    {
                        //If player interacts with the dirt, make the dirt disappear
                        if (x.Bounds.IntersectsWith(Player.Bounds))
                            x.Visible = false;

                        //if character airgun hits the dirt, set collision to true
                        if (x.Bounds.IntersectsWith(Player.MyAirgun[0].Bounds) && x.Visible == true)
                            Player.shotCollision = true;
                        if (x.Bounds.IntersectsWith(BadOne.MyAirgun[0].Bounds) && x.Visible == true)
                            BadOne.shotCollision = true;
                        if (x.Bounds.IntersectsWith(BadTwo.MyAirgun[0].Bounds) && x.Visible == true)
                            BadTwo.shotCollision = true;
                        if (x.Bounds.IntersectsWith(BadThree.MyAirgun[0].Bounds) && x.Visible == true)
                            BadThree.shotCollision = true;
                        if (x.Bounds.IntersectsWith(BadFour.MyAirgun[0].Bounds) && x.Visible == true)
                            BadFour.shotCollision = true;
                        if (x.Bounds.IntersectsWith(BadFive.MyAirgun[0].Bounds) && x.Visible == true)
                            BadFive.shotCollision = true;
                        if (x.Bounds.IntersectsWith(BadSix.MyAirgun[0].Bounds) && x.Visible == true)
                            BadSix.shotCollision = true;
                        if (x.Bounds.IntersectsWith(BadSeven.MyAirgun[0].Bounds) && x.Visible == true)
                            BadSeven.shotCollision = true;
                        if (x.Bounds.IntersectsWith(BadEight.MyAirgun[0].Bounds) && x.Visible == true)
                            BadEight.shotCollision = true;
                    }

                    if ((string)x.Tag == "BadGuy")
                    {
                        //If Player touches Badguy, kill the Player
                        if (x.Bounds.IntersectsWith(Player.Bounds) && x.Visible == true)
                            Player.Alive = false;

                        //If Player shoots a BadGuy, label it as hit and reset their shot if they are currently shooting
                        if (x.Bounds.IntersectsWith(Player.MyAirgun[0].Bounds) && x.Visible == true && Player.MyAirgun[0].Visible == true)
                        {
                            Player.TargetHit(x.Name);
                            ShotReset(x.Name);
                        }
                    }
                }
            }
        }

        //Reset the BadGuys airgun shot so it no longer appears
        private void ShotReset(string Name)
        {
            switch (Name)
            {
                case "BadOne":
                    BadOne.ShotReset();
                    break;
                case "BadTwo":
                    BadTwo.ShotReset();
                    break;
                case "BadThree":
                    BadThree.ShotReset();
                    break;
                case "BadFour":
                    BadFour.ShotReset();
                    break;
                case "BadFive":
                    BadFive.ShotReset();
                    break;
                case "BadSix":
                    BadSix.ShotReset();
                    break;
                case "BadSeven":
                    BadSeven.ShotReset();
                    break;
                case "BadEight":
                    BadEight.ShotReset();
                    break;
            }
        }

        //
        private void MoveCharacters()
        {
            Player.MoveCharacter();
        }

        //Adjust Character Background color to match the level background
        private void CheckCharacterBackground()
        {
            Player.CheckBackground();
            BadOne.CheckBackground();
            BadTwo.CheckBackground();
            BadThree.CheckBackground();
            BadFour.CheckBackground();
            BadFive.CheckBackground();
            BadSix.CheckBackground();
            BadSeven.CheckBackground();
            BadEight.CheckBackground();
        }

        //Control events from pressing keys
        private void KeyPressedDown(object sender, KeyEventArgs e)
        {
            if (Player.shootAirgun == false && beginAnimation == false)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                    case Keys.Up:
                        Player.moveDirection = up;
                        break;

                    case Keys.S:
                    case Keys.Down:
                        Player.moveDirection = down;
                        break;

                    case Keys.D:
                    case Keys.Right:
                        Player.moveDirection = right;
                        break;

                    case Keys.A:
                    case Keys.Left:
                        Player.moveDirection = left;
                        break;

                    case Keys.Space:
                        Player.moveDirection = noDirection;
                        Player.shootAirgun = true;
                        break;

                    case Keys.Z:
                        enemiesLeft--;
                        break;
                }
            }
        }

        //Control events from releasing keys
        private void KeyReleased(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                case Keys.S:
                case Keys.Down:
                case Keys.D:
                case Keys.Right:
                case Keys.A:
                case Keys.Left:
                    Player.moveDirection = noDirection;
                    break;

                case Keys.Space:
                    Player.ShotReset();
                    break;

                //Escape serves as the pause button, turn off timer to pause the game and bring up the proper menu, turn timer back on if Player decides to continue
                case Keys.Escape:
                    GameOneTimer.Enabled = false;

                    FormPauseMenu Pause = new FormPauseMenu();
                    DialogResult result = Pause.ShowDialog();

                    if (result == DialogResult.Abort)
                        Close();

                    GameOneTimer.Enabled = true;
                    break;
            }
        }

        //Takes all the dirt and replaces it to make the level look like new
        private void ResetDirt()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    if ((string)x.Tag == "Dirt")
                    {
                        x.Visible = true;
                    }
                }
            }
        }

        //Dig out dirt spots to set up the level
        private void PrepLevelOneDirt()
        {
            ResetDirt();

            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    if ((string)x.Tag == "Dirt")
                    {
                        if (x.Name == "Dirt 13 9" || x.Name == "Dirt 14 9" || x.Name == "Dirt 15 9" || x.Name == "Dirt 16 9" || x.Name == "Dirt 17 9")
                            x.Visible = false;

                        if (x.Name == "Dirt 22 3" || x.Name == "Dirt 23 3" || x.Name == "Dirt 24 3" || x.Name == "Dirt 25 3" || x.Name == "Dirt 26 3")
                            x.Visible = false;

                        if (x.Name == "Dirt 4 4" || x.Name == "Dirt 4 5" || x.Name == "Dirt 4 6" || x.Name == "Dirt 4 7" || x.Name == "Dirt 4 8")
                            x.Visible = false;

                        if (x.Name == "Dirt 19 15" || x.Name == "Dirt 19 14" || x.Name == "Dirt 20 14" || x.Name == "Dirt 21 14" || x.Name == "Dirt 22 14" || x.Name == "Dirt 23 14" || x.Name == "Dirt 23 15")
                            x.Visible = false;

                        //dig out extra spots for level 2
                        if (level > 1)
                        {
                            if (x.Name == "Dirt 8 16" || x.Name == "Dirt 9 16" || x.Name == "Dirt 10 16" || x.Name == "Dirt 11 16" || x.Name == "Dirt 12 16")
                                x.Visible = false;

                            if (x.Name == "Dirt 26 7" || x.Name == "Dirt 26 8" || x.Name == "Dirt 26 9" || x.Name == "Dirt 26 10" || x.Name == "Dirt 26 11")
                                x.Visible = false;
                        }
                        //dig out extra spots for level 3
                        if (level > 2)
                        {
                            if (x.Name == "Dirt 4 12" || x.Name == "Dirt 5 12" || x.Name == "Dirt 6 12" || x.Name == "Dirt 7 12" || x.Name == "Dirt 8 12" || x.Name == "Dirt 6 11" || x.Name == "Dirt 6 10" || x.Name == "Dirt 6 13" || x.Name == "Dirt 6 14")
                                x.Visible = false;

                            if (x.Name == "Dirt 20 5" || x.Name == "Dirt 20 6" || x.Name == "Dirt 20 7" || x.Name == "Dirt 20 8" || x.Name == "Dirt 21 8" || x.Name == "Dirt 21 5")
                                x.Visible = false;

                            if (x.Name == "Dirt 28 16" || x.Name == "Dirt 29 16" || x.Name == "Dirt 30 16" || x.Name == "Dirt 28 17" || x.Name == "Dirt 29 17" || x.Name == "Dirt 30 17" || x.Name == "Dirt 28 18" || x.Name == "Dirt 29 18" || x.Name == "Dirt 30 18")
                                x.Visible = false;
                        }
                    }
                }
            }
        }
    }
}
