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
    public partial class FormGameTwo : Form
    {
        Label Score;
        Label BallLeft;
        Label Player;
        BallG2[] Ball;
        Label[,] Blocks;

        char MoveLeft = 'L', MoveRight = 'M', NoDirection = 'N';

        char currentDirection;

        int StructSizeX = 12;
        int StructSizeY = 20;

        int moveSpeed = 5;

        int numOfBalls = 10;
        int ballLeft;
        int score;
        int maxScore;

        bool ballSpawn;

        int level = 1;

        public FormGameTwo()
        {
            InitializeComponent();
            CreatePlayerBlock();
            CreateBlockStructure();
            CreateBall();
            CreateInfo(); 
            PrepareLevel();
        }

        private void CreateInfo()
        {
            Score = new Label();
            Score.Location = new Point(50, 950);
            Score.Text = "Score: 0";
            Score.AutoSize = true;
            Score.Font = new Font("Arial Narrow", 24.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Score.Visible = true;
            Controls.Add(Score);
            Score.BringToFront();


            BallLeft = new Label();
            BallLeft.Location = new Point(800, 950);
            BallLeft.Text = "Balls Left: 0";
            BallLeft.AutoSize = true;
            BallLeft.Font = new Font("Arial Narrow", 24.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            BallLeft.Visible = true;
            Controls.Add(BallLeft);
            BallLeft.BringToFront();


        }

        private void PrepareLevel()
        {
            Ball[0].Location = new Point(500, 650);
            Ball[0].Visible = true;
            Ball[0].X = 3;
            Ball[0].Y = 3;

            for (int i = 1; i < numOfBalls; i++)
                Ball[i].Visible = false;

            ballLeft = 1;
            score = 0;

            Player.Location = new Point(500, 900);
            currentDirection = NoDirection;

            maxScore = 0;

            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    if ((string)x.Tag == "Block")
                    {
                        x.Visible = true;
                        maxScore += 10;
                    }
                }
            }

            SetUpBlockDesign();


            mainTimer.Enabled = true;

        }

        private void SetUpBlockDesign()
        {
            if (level == 1)
            {
                foreach (Control x in Controls)
                {
                    if(x is Label)
                    {
                        if((String)x.Tag == "Block")
                        {
                            //left eye
                            if (x.Name == "Block 2 2" || x.Name == "Block 3 3" || x.Name == "Block 4 4" || x.Name == "Block 4 6" || x.Name == "Block 4 7" || x.Name == "Block 4 8" || x.Name == "Block 4 9" || x.Name == "Block 4 10")
                                x.Visible = false;

                            //right eye
                            if (x.Name == "Block 11 2" || x.Name == "Block 10 3" || x.Name == "Block 9 4" || x.Name == "Block 9 6" || x.Name == "Block 9 7" || x.Name == "Block 9 8" || x.Name == "Block 9 9" || x.Name == "Block 9 10")
                                x.Visible = false;

                            //nose
                            if (x.Name == "Block 5 13" || x.Name == "Block 6 14" || x.Name == "Block 7 14" || x.Name == "Block 8 13")
                                x.Visible = false;

                            //mouth
                            if (x.Name == "Block 2 20" || x.Name == "Block 3 19" || x.Name == "Block 4 18" || x.Name == "Block 5 17" || x.Name == "Block 6 18" || x.Name == "Block 7 18" || x.Name == "Block 8 17" || x.Name == "Block 9 18" || x.Name == "Block 10 19" || x.Name == "Block 11 20")
                                x.Visible = false;
                        }

                    }
                }

                maxScore -= 300;
            }

            if (level == 2)
            {
                foreach (Control x in Controls)
                {
                    if (x is Label)
                    {
                        if ((String)x.Tag == "Block")
                        {
                            if (x.Name == "Block 6 1" || x.Name == "Block 7 1" || x.Name == "Block 4 2" || x.Name == "Block 5 2" || x.Name == "Block 3 3" || x.Name == "Block 4 3" || x.Name == "Block 2 4" || x.Name == "Block 3 4" || x.Name == "Block 1 5" || x.Name == "Block 2 5" || x.Name == "Block 1 6")
                                x.Visible = false;

                            if (x.Name == "Block 1 7" || x.Name == "Block 2 7" || x.Name == "Block 2 8" || x.Name == "Block 3 8" || x.Name == "Block 3 9" || x.Name == "Block 4 9" || x.Name == "Block 4 10" || x.Name == "Block 5 10" || x.Name == "Block 6 11" || x.Name == "Block 7 11")
                                x.Visible = false;

                            if (x.Name == "Block 8 2" || x.Name == "Block 9 2" || x.Name == "Block 9 3" || x.Name == "Block 10 3" || x.Name == "Block 10 4" || x.Name == "Block 11 4" || x.Name == "Block 11 5" || x.Name == "Block 12 5" || x.Name == "Block 12 6")
                                x.Visible = false;

                            if (x.Name == "Block 12 7" || x.Name == "Block 11 7" || x.Name == "Block 11 8" || x.Name == "Block 10 8" || x.Name == "Block 10 9" || x.Name == "Block 9 9" || x.Name == "Block 9 10" || x.Name == "Block 8 10")
                                x.Visible = false;

                            if (x.Name == "Block 6 13" || x.Name == "Block 5 14" || x.Name == "Block 5 15" || x.Name == "Block 4 16" || x.Name == "Block 4 17" || x.Name == "Block 3 18" || x.Name == "Block 3 19" || x.Name == "Block 2 20")
                                x.Visible = false;

                            if (x.Name == "Block 7 13" || x.Name == "Block 8 14" || x.Name == "Block 8 15" || x.Name == "Block 9 16" || x.Name == "Block 9 17" || x.Name == "Block 10 18" || x.Name == "Block 10 19" || x.Name == "Block 11 20")
                                x.Visible = false;
                        }
                    }
                }

                maxScore -= 540;
            }

            if (level == 3)
            {
                foreach (Control x in Controls)
                {
                    if (x is Label)
                    {
                        if ((String)x.Tag == "Block")
                        {
                            if (x.Name == "Block 6 1" || x.Name == "Block 7 1" || x.Name == "Block 4 2" || x.Name == "Block 5 2" || x.Name == "Block 3 3" || x.Name == "Block 4 3" || x.Name == "Block 2 4" || x.Name == "Block 3 4" || x.Name == "Block 1 5" || x.Name == "Block 2 5" || x.Name == "Block 1 6")
                                x.Visible = false;

                            if (x.Name == "Block 1 7" || x.Name == "Block 2 7" || x.Name == "Block 2 8" || x.Name == "Block 3 8" || x.Name == "Block 3 9" || x.Name == "Block 4 9" || x.Name == "Block 4 10" || x.Name == "Block 5 10" || x.Name == "Block 6 11" || x.Name == "Block 7 11")
                                x.Visible = false;

                            if (x.Name == "Block 8 2" || x.Name == "Block 9 2" || x.Name == "Block 9 3" || x.Name == "Block 10 3" || x.Name == "Block 10 4" || x.Name == "Block 11 4" || x.Name == "Block 11 5" || x.Name == "Block 12 5" || x.Name == "Block 12 6")
                                x.Visible = false;

                            if (x.Name == "Block 12 7" || x.Name == "Block 11 7" || x.Name == "Block 11 8" || x.Name == "Block 10 8" || x.Name == "Block 10 9" || x.Name == "Block 9 9" || x.Name == "Block 9 10" || x.Name == "Block 8 10")
                                x.Visible = false;

                            if (x.Name == "Block 6 13" || x.Name == "Block 5 14" || x.Name == "Block 5 15" || x.Name == "Block 4 16" || x.Name == "Block 4 17" || x.Name == "Block 3 18" || x.Name == "Block 3 19" || x.Name == "Block 2 20")
                                x.Visible = false;

                            if (x.Name == "Block 7 13" || x.Name == "Block 8 14" || x.Name == "Block 8 15" || x.Name == "Block 9 16" || x.Name == "Block 9 17" || x.Name == "Block 10 18" || x.Name == "Block 10 19" || x.Name == "Block 11 20")
                                x.Visible = false;
                        }
                    }
                }

                maxScore -= 540;
            }

        }


        private void CreatePlayerBlock()
        {
            Player = new Label();
            Player.Size = new Size(100, 10);
            Player.Visible = true;
            Player.BackColor = Color.Black;
            Controls.Add(Player);
            
        }

        private void CreateBall()
        {
            Ball = new BallG2[numOfBalls];

            for (int i = 0; i < numOfBalls; i++)
            {
                Ball[i] = new BallG2();
                Ball[i].Name = "Ball " + i;
                Controls.Add(Ball[i]);
                Ball[i].BringToFront();
            }

            Ball[0].BackColor = Color.Purple;
            Ball[1].BackColor = Color.White;
            Ball[2].BackColor = Color.Green;
            Ball[3].BackColor = Color.Blue;
            Ball[4].BackColor = Color.Red;
            Ball[5].BackColor = Color.Gold;
            Ball[6].BackColor = Color.Black;
            Ball[7].BackColor = Color.Yellow;
            Ball[8].BackColor = Color.Brown;
            Ball[9].BackColor = Color.HotPink;

        }


        private void CreateBlockStructure()
        {
            Blocks = new Label[StructSizeY, StructSizeX];

            int x, y = 0;
            int startX = 7;
            int numX;
            int numY = 1;

            for (int i = 0; i < StructSizeY; i++)
            {
                x = startX;
                numX = 1;

                for (int j = 0; j < StructSizeX; j++)
                {
                    Blocks[i, j] = new Label();
                    Blocks[i, j].Tag = "Block";
                    Blocks[i, j].Name = "Block " + numX + " " + numY;
                    Blocks[i, j].BackColor = Color.Blue;
                    Blocks[i, j].AutoSize = false;
                    Blocks[i, j].Size = new Size(75, 20);
                    Blocks[i, j].Location = new Point(x, y);
                    Blocks[i, j].Visible = false;
                    this.Controls.Add(Blocks[i, j]);
                    Blocks[i, j].BringToFront();

                    numX++;
                    x += 83;
                }
                numY++;
                y += 25;
            }
        }


        private void mainTimer_Tick(object sender, EventArgs e)
        {
            UpdateInfo();


            MovePlayer();
            MoveBall();

            BallHitsFormEdges();

            CheckCollisions();

            CheckStatus();

        }



        private void UpdateInfo()
        {
            Score.Text = "Score: " + score;
            BallLeft.Text = "Balls Left: " + ballLeft;
        }


        private void CheckStatus()
        {
            for (int i = 0; i < numOfBalls; i++)
            {
                //If ball goes below the screen kill the ball
                if (Ball[i].Top > 1000 && Ball[i].Visible == true)
                {
                    ballLeft--;
                    Ball[i].Visible = false;
                }
            }

            if(ballLeft == 0)
                GameOver();

            if (score >= maxScore)
                LevelWin();
            

        }


        private void LevelWin()
        {
            //turn off the Timer to pause the game
            mainTimer.Enabled = false;

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


        //When the Player dies, Provide the GameOver Form
        private void GameOver()
        {
            //turn off the Timer to pause the game
            mainTimer.Enabled = false;

            FormYouLose YouLose = new FormYouLose();
            DialogResult retryResult = YouLose.ShowDialog();

            //If Player decides to quit, Close this form as well
            if (retryResult == DialogResult.Abort)
                Close();

            //If Player decides to Continue, Retry the game
            retryGame();
        }

        private void retryGame()
        {
            PrepareLevel();
            mainTimer.Enabled = true;
        }





        private void MovePlayer()
        {
            if (currentDirection == MoveLeft && Player.Left > 0)
                Player.Left -= moveSpeed;
            if (currentDirection == MoveRight && Player.Right < 1000)
                Player.Left += moveSpeed;
        }


        private void MoveBall()
        {
            for(int i = 0; i < numOfBalls; i++)
            {
                if (Ball[i].Visible == true)
                    Ball[i].MoveBall();
            }
        }

        private void BallHitsFormEdges()
        {
            for(int i = 0; i < numOfBalls; i++)
            {
                //if ball hits right or left side of the form, reverse the x direction
                if (Ball[i].Right >= 1000 || Ball[i].Left <= 0)
                    Ball[i].X = -Ball[i].X;

                //if ball hits the top of the form, reverse the y direction
                if (Ball[i].Top <= 0)
                    Ball[i].Y = -Ball[i].Y;
                
            }
        }


        private void BallHitPlayer(string BallName)
        {
            for (int i = 0; i < numOfBalls; i++)
            {
                if (Ball[i].Name == BallName)
                    Ball[i].HitPlayer(Player.Left, Player.Right, currentDirection);
            }
        }


        private void CheckCollisions()
        {

            foreach (Control x in this.Controls)
            {
                if (x is BallG2)
                {


                    //If ball collides with Player
                    if (x.Bounds.IntersectsWith(Player.Bounds))
                        BallHitPlayer(x.Name);

                    foreach (Control y in this.Controls)
                    {
                        if (y is Label)
                        {
                            if ((string)y.Tag == "Block")
                            {
                                if (x.Bounds.IntersectsWith(y.Bounds) && y.Visible == true && x.Visible == true)
                                {
                                    BallHitBlock(x.Name, y.Top, y.Bottom, y.Left, y.Right);
                                    y.Visible = false;
                                    score += 10;

                                    if(score != 0)
                                        CheckForBallSpawn(x.Name);


                                }
                            }
                        }
                    }
                }

            }
        }


        private void CheckForBallSpawn(string BallName)
        {
            int i;
            int j;


            if (ballLeft < 10 && ballSpawn == false && score % 100 == 0)
            {
                for(i = 0; i < numOfBalls; i++)
                {
                    if (Ball[i].Name == BallName)
                        break;
                }

                for (j = 0; j < numOfBalls; j++)
                {
                    if (Ball[j].Visible == false)
                        break;
                }


                Ball[j].Location = Ball[i].Location;
                Ball[j].X = 2;
                Ball[j].Y = Ball[i].Y - 2;
                Ball[j].Visible = true;
                ballLeft++;
                ballSpawn = true;

                if (0 <= Ball[j].Y && Ball[j].Y < 3 || Ball[j].Y > 6 )
                    Ball[j].Y = 2;
                if (-3 < Ball[j].Y && Ball[j].Y < 0 || Ball[j].Y < -6)
                    Ball[j].Y = -2;


            }

            if (score % 100 == 10)
                ballSpawn = false;


        }

        private void BallHitBlock(string BallName, int BlockTop, int BlockBottom, int BlockLeft, int BlockRight)
        {
            int width = BlockRight - BlockLeft;

            for (int i = 0; i < numOfBalls; i++)
            {
                if (Ball[i].Name == BallName)
                {
                    if ((Ball[i].Bottom > BlockBottom && Ball[i].Y < 0) || (Ball[i].Top < BlockTop && Ball[i].Y > 0))
                        Ball[i].Y = -Ball[i].Y;

                    if ((Ball[i].Left < BlockLeft && Ball[i].X > 0) || (Ball[i].Right > BlockRight && Ball[i].X < 0))
                        Ball[i].X = -Ball[i].X;
                }
            }

        }


        private void KeyPressed(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                case Keys.Left:
                    currentDirection = MoveLeft;
                    break;

                case Keys.D:
                case Keys.Right:
                    currentDirection = MoveRight;
                    break;

                case Keys.Space:
                    moveSpeed = 10;
                    break;
            }
        }



        private void KeyReleased(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                case Keys.Left:
                case Keys.D:
                case Keys.Right:
                    currentDirection = NoDirection;
                    break;

                case Keys.Escape:
                    mainTimer.Enabled = false;
                    FormPauseMenu Pause = new FormPauseMenu();
                    DialogResult result = Pause.ShowDialog();

                    if (result == DialogResult.Abort)
                        Close();

                    mainTimer.Enabled = true;                    
                    break;

                case Keys.Space:
                    moveSpeed = 5;
                    break;

                case Keys.Z:
                    score += 20;
                    for (int i = 0; i < numOfBalls; i++)
                        Ball[i].Y = 0;
                    Ball[0].Y = -1;
                    break;
            }
        }
    }
}
