using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Game_Collection 
{
    class PlayerG1 : Label
    {
        public Label[] MyAirgun;

        public bool Alive = true;

        public bool playerControl;

        public bool shotCollision;
        public bool shootAirgun;
        public string targetHit;
        int shotTimer;
        int shotStage;
        int tubeLength = 20;
        int isHitCounter;

        public char FaceLeft = 'L', FaceRight = 'R';
        public char DirectionFacing;
        public char moveDirection; 
        int moveSpeed = 10;

        public string MoveLeftAnimation = " 0\r\n/||\\\r\n/  \\";
        public string MoveRightAnimation = "  0\r\n/||\\\r\n/  \\";
        string ShootLeftAnimation = " 0\r\n<||\r\n/  \\";
        string ShootRightAnimation = "  0\r\n  ||>\r\n/  \\";

        public string HitAnimation0 = "  0\r\n/| |\\\r\n/  \\";
        public string HitAnimation1 = "   0\r\n/(   )\\\r\n/    \\";
        public string HitAnimation2 = "    0\r\n/(     )\\\r\n/      \\";
        public string HitAnimation3 = "     0\r\n/(       )\\\r\n/        \\";
        public string HitAnimationBOOM = "    /\\/\\/\\\r\n< BOOM >\r\n    VVVV";

        string AirgunHeadLeft = "/|\r\n\\|";
        string AirgunHeadRight = "|\\\r\n|/";

        public PlayerG1()
        {
            this.Text = MoveRightAnimation;
            this.AutoSize = true;
            this.Tag = "Player";
            this.Location = new Point(200, 200);
            this.Alive = false;
        }

        //Move the character based on the direction set
        public void MoveCharacter()
        {
            switch (moveDirection)
            {
                case 'U':
                    MoveUp();
                    break;
                case 'D':
                    MoveDown();
                    break;
                case 'L':
                    MoveLeft();
                    break;
                case 'R':
                    MoveRight();
                    break;
            }
        }

        public void MoveUp()
        {
            if (this.Top > 200)
                this.Top -= moveSpeed;
        }

        public void MoveDown()
        {
            if (this.Bottom < 995)
                this.Top += moveSpeed;
        }

        public void MoveLeft()
        {
            //change current facing direction if needed and change the animation
            if (DirectionFacing != FaceLeft)
            {
                DirectionFacing = FaceLeft;
                this.Text = MoveLeftAnimation;
            }
            else if (this.Left > 5)
                this.Left -= moveSpeed;
        }

        public void MoveRight()
        {
            //change current facing direction if needed and change the animation
            if (DirectionFacing != FaceRight)
            {
                DirectionFacing = FaceRight;
                this.Text = MoveRightAnimation;
            }
            else if (this.Right < 1000)
                this.Left += moveSpeed;
        }

        //Handles the set up and shooting of the Airgun
        public void Shoot()
        {
            //Can only shoot if character is alive
            if (Alive == true)
            {
                //At shotTimer == 0, this is the beggining of the shot
                if (shotTimer == 0)
                {
                    //Reset variables needed for shot
                    shotStage = 0;
                    shotCollision = false;

                    //Put the shot  at the same position of character
                    MyAirgun[0].Location = this.Location;

                    //Match the airgun shot background to that of the character
                    for (int i = 0; i < MyAirgun.Length; i++)
                        MyAirgun[i].BackColor = this.BackColor;

                    //Put the shot at the proper location with proper animation depending on the direction facing
                    if (DirectionFacing == FaceLeft)
                    {
                        this.Text = ShootLeftAnimation;
                        MyAirgun[0].Text = AirgunHeadLeft;
                        MyAirgun[0].Left -= 10;
                    }
                    else
                    {
                        this.Text = ShootRightAnimation;
                        MyAirgun[0].Text = AirgunHeadRight;
                        MyAirgun[0].Left += 20;
                    }

                    MyAirgun[0].Top += 8;
                    MyAirgun[0].Visible = true;

                    shotTimer++;
                }
                else
                {
                    //Make sure that nothing has been hit by the airgun
                    if (shotCollision == false)
                    {
                        //At proper time increments, extend the shot
                        if (shotTimer % 10 == 0)
                        {
                            shotStage++;

                            if (shotStage < MyAirgun.Length)
                                ExtendShot();
                        }

                        shotTimer++;
                    }
                    //If something has been hit, make the head of the gun dissapear
                    else
                        MyAirgun[0].Visible = false;
                }
            }
        }

        //Entends the shot of the airgun
        private void ExtendShot()
        {
            //Take the next shot and put it in the proper location
            MyAirgun[shotStage].Location = this.Location;
            MyAirgun[shotStage].Top += 13;

            //Extend the Airgun in the proper direction and make the newest shot section visable
            for (int i = 0; i <= shotStage; i++)
            {
                if (DirectionFacing == FaceLeft)
                {
                    MyAirgun[i].Left -= tubeLength;
                }
                else
                {
                    MyAirgun[i].Left += tubeLength;
                }
            }
            MyAirgun[shotStage].Visible = true;
        }

        //Reset the shot and animation
        public void ShotReset()
        {
            shotTimer = 0;

            //Make all the sections of the Airgun invisable
            for (int i = 0; i < MyAirgun.Length; i++)
                MyAirgun[i].Visible = false;

            //Go back to the proper walking animation
            if (DirectionFacing == FaceLeft)
                this.Text = MoveLeftAnimation;     
            else
                this.Text = MoveRightAnimation;

            //reset variables needed for next shot
            targetHit = "";
            shootAirgun = false;
        }

        //Resets the character back to a default state
        public void Reset()
        {
            this.Visible = true;
            Alive = true;
            ShotReset();
            isHitCounter = 0;
        }

        //Changes the background of the characters based on the location on the map
        public void CheckBackground()
        {
            if (this.Top >= 240)
                this.BackColor = Color.Peru;
            else
                this.BackColor = Color.SkyBlue;
        }

        //Does the initial setup of the Airgun 
        public void SetupAirgun(int Size)
        {
            MyAirgun = new Label[Size];

            for (int i = 0; i < MyAirgun.Length; i++)
            {
                MyAirgun[i] = new Label();

                MyAirgun[i].Text = "-----";
                MyAirgun[i].Tag = "AirgunTube";
                MyAirgun[i].Visible = false;

                MyAirgun[i].AutoSize = true;
            }

            MyAirgun[0].Tag = "AirgunHead";
        }

        //Handles hitting a target
        public void TargetHit(string TargetName)
        {
            shotCollision = true;
            targetHit = TargetName;
        }

        //If character is hit, walk down the hit animations
        public void IsHit()
        {
            if(isHitCounter >= 0 && isHitCounter < 20)
                this.Text = HitAnimation0;
                
            isHitCounter++;

            if(isHitCounter >= 20 && isHitCounter < 40)
                this.Text = HitAnimation1;

            if (isHitCounter >= 40 && isHitCounter < 60)
                this.Text = HitAnimation2;

            if (isHitCounter >= 60 && isHitCounter < 80)
                this.Text = HitAnimation3;

            if (isHitCounter >= 80)
            {
                this.Text = HitAnimationBOOM;
                Alive = false;
            }
        }

        //If character is released from being hit, reverse the hit animations
        public void ReverseAnimation()
        {
            isHitCounter--;

            if (isHitCounter == 0)
            {
                if (DirectionFacing == FaceLeft)
                    this.Text = MoveLeftAnimation;
                else
                    this.Text = MoveRightAnimation;
            }

            if (isHitCounter > 0 && isHitCounter < 20)
                this.Text = HitAnimation0;

            if (isHitCounter >= 20 && isHitCounter < 40)
                this.Text = HitAnimation1;

            if (isHitCounter >= 40 && isHitCounter < 60)
                this.Text = HitAnimation2;

            if (isHitCounter >= 60 && isHitCounter < 80)
                this.Text = HitAnimation3;
        }
    }
}

