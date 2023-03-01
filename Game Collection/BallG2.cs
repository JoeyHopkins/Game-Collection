using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game_Collection
{
    class BallG2 : Label
    {

        public int X, Y;
        int LastDirection;

        char MoveLeft = 'L', MoveRight = 'M', NoDirection = 'N';

        public int maxSpeed;

        public BallG2()
        {
            this.Size = new Size(15, 15);
            this.BackColor = Color.Aqua;
            this.Tag = "Ball";
            this.Visible = false;

            maxSpeed = 15;
        }

        public void MoveBall()
        {
            this.Left += X;
            this.Top += Y;
        }

        public void HitPlayer(int PlayerLeft, int PlayerRight, char currentDirection)
        {
            

            //Store last direction minimum in case bale ball isnt moving in the x direction
            if (X > 0)
                LastDirection = 1;
            if (X < 0)
                LastDirection = -1;


            //since ball hit the Player, reverse the y direction
            Y = -Y;



            //If the ball hits the corner of the player and both are moving in the same direction, double speed
            if ((PlayerLeft + 10 >= this.Left && currentDirection == MoveLeft && X < 0) || (PlayerRight - 10 <= this.Right && currentDirection == MoveRight && X > 0))
                X = X * 2;

            //If the ball hits the corner of the player and they are moving oppisite directions, reverse the direction of x and double speed
            if ((PlayerLeft + 10 >= this.Left && currentDirection == MoveLeft && X > 0) || (PlayerRight - 10 <= this.Right && currentDirection == MoveRight && X < 0))
                X = -X * 2;

            //If the player is not moving and the ball hits nearest corner, reverse the direction
            if ((PlayerLeft + 10 >= this.Left && currentDirection == NoDirection && X > 0) || (PlayerRight - 10 <= this.Right && currentDirection == NoDirection && X < 0))
            {
                X = -X / 2;
                Y -= 2;
            }

            //If ball hits edge mid section and ball and player are moving the same direction, increase the movement of the ball
            if ((PlayerLeft + 10 < this.Left && this.Right <= PlayerLeft + 35 && currentDirection == MoveLeft && X < 0) || (PlayerRight - 10 > this.Left && this.Right >= PlayerRight - 35 && currentDirection == MoveRight && X > 0))
            {
                if (X > 0)
                    X += 2;
                else
                    X -= 2;
            }


            //If ball hits edge mid section and ball and player are moving in the oppisite direction, decrease the movement of the ball
            if ((PlayerLeft + 10 < this.Left && this.Right <= PlayerLeft + 35 && currentDirection == MoveRight && X < 0) || (PlayerRight - 10 > this.Left && this.Right >= PlayerRight - 35 && currentDirection == MoveLeft && X > 0))
            {
                if (X > 0)
                    X -= 2;
                else
                    X += 2;
            }

            //If ball hits middle section and Ball and Player are moving the same direction, slightly increase the speed of the Ball
            if ((PlayerLeft + 35 < this.Left && this.Right < PlayerRight - 35 && currentDirection == MoveLeft && X < 0) || (PlayerLeft + 35 < this.Left && this.Right < PlayerRight - 35 && currentDirection == MoveRight && X > 0))
            {
                if (X > 0)
                    X += 1;
                else
                    X -= 1;
            }


            //If ball hits middle section and Ball and Player are moving in oppisite directions, slightly decrease the speed of the Ball
            if ((PlayerLeft + 35 < this.Left && this.Right < PlayerRight - 35 && currentDirection == MoveRight && X < 0) || (PlayerLeft + 35 < this.Left && this.Right < PlayerRight - 35 && currentDirection == MoveLeft && X > 0))
            {
                if (X > 0)
                    X -= 1;
                else
                    X += 1;
            }

            //if ball isnt moving in the left or right direction, reverse the direction and make it move
            if (X == 0)
                X = -LastDirection;


            //if X is faster then max speed make it max speed
            if (X > maxSpeed)
                X = maxSpeed;
            if (X < -maxSpeed)
                X = -maxSpeed;

            //if Y is faster then max speed, make it max speed
            if (Y > maxSpeed)
                Y = maxSpeed;
            if (Y < -maxSpeed)
                Y = -maxSpeed;

        }
            
    }

}
