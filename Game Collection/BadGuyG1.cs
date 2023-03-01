using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game_Collection
{
    class BadGuyG1 : PlayerG1
    {


        bool beginplay;


        Random rand = new Random(Guid.NewGuid().GetHashCode());
        int random;

        
        public BadGuyG1(string BadGuyName)
            :base()
        {
            this.Tag = "BadGuy";
            this.Name = BadGuyName;
            ChooseDirection();
        }



        

        private void ChooseDirection()
        {
            random = rand.Next() % 2;

            if (random == 0)
            {
                this.Text = MoveLeftAnimation;
                DirectionFacing = FaceLeft;
            }
            else
            {
                this.Text = MoveRightAnimation;
                DirectionFacing = FaceRight;
            }
        }


        public void BadGuyAI()
        {
                    
            MoveUp();


        }







        




    }
}
