using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {

        //variables
        int gravity = 5;
        int pipeSpeed = 10;
        static int scoreCount = 0;
        [ThreadStatic]
        public static int tempScore = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            maketranspanent();
            
        }
        //create thread when you start program
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(Form1.scoreThread);
            thread.Start();
        }
        //counting the score
        private static void scorecount(int input)
        {
            tempScore += input;
            scoreCount = tempScore;
        }

        //The thread, that adding +1 score every sec
        public static void scoreThread()
        {
            while (true)
            {
                scorecount(1);
                Thread.Sleep(1000);
            }

        }
        //when press down space, bird jump
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //downkey press -> bird go down
                gravity = -5;
                bird.Image = Image.FromFile("birddownclap.png");
            }
        }
        //when erease space, bird goes down
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //downkey press -> bird go up
                gravity = 5;
                bird.Image = Image.FromFile("bird.png");
            }
        }

        //this is why everything move 
        private void timer1_Tick(object sender, EventArgs e)
        {
            birdMover();
            pipeMover();
            pipeCollide();
            pipeSpawn();
            scoreText.Text = scoreCount.ToString();
        }
        //bird movement sync
        private void birdMover()
        {
            bird.Top += gravity;
        }
        //moving pipes left
        private void pipeMover()
        {
            pipeTop1.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;
            pipeDown1.Left -= pipeSpeed;
            pipeDown2.Left -= pipeSpeed;
        }
        //checking when bird collide with any surface
        private void pipeCollide()
        {
            if (bird.Bounds.IntersectsWith(pipeTop1.Bounds) || bird.Bounds.IntersectsWith(pipeDown1.Bounds) 
                || bird.Bounds.IntersectsWith(pipeTop2.Bounds) || bird.Bounds.IntersectsWith(pipeDown2.Bounds) 
                || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }
                
        }
        //game end
        private void gameOver()
        {
            timer1.Stop();
            var result = MessageBox.Show("End of Game", "GameOver", MessageBoxButtons.OK);
        }
       //pipe spawning back
        private void pipeSpawn()
        {
            downPipes();
            topPipes();
        }
        //this is how spawning back the pipes
        private void downPipes()
        {
            if (pipeDown1.Left < -70)
            {
                pipeDown1.Left = random.Next(600, 800);
                if (pipeDown1.Bounds.IntersectsWith(pipeDown2.Bounds))
                {
                    pipeDown1.Left += 50;
                }
            }
            if (pipeDown2.Left < -70)
            {
                pipeDown2.Left = random.Next(600, 800);
                if (pipeDown2.Bounds.IntersectsWith(pipeDown1.Bounds))
                {
                    pipeDown2.Left += 50;
                }
            }
        }
        //this is how spawning back the pipes
        private void topPipes()
        {
            if (pipeTop1.Left < -70)
            {
                pipeTop1.Left = random.Next(600, 800);
                if (pipeTop1.Bounds.IntersectsWith(pipeTop2.Bounds))
                {
                    pipeTop1.Left += 50;
                }
            }
            if (pipeTop2.Left < -70)
            {
                pipeTop2.Left = random.Next(600, 800);
                if (pipeTop2.Bounds.IntersectsWith(pipeTop1.Bounds))
                {
                    pipeTop2.Left += 50;
                }
            }
        }
        //2D models border make transpanent
        private void maketranspanent()
        {
            bird.BackColor = Color.Transparent;
            pipeDown1.BackColor = Color.Transparent;
            pipeDown2.BackColor = Color.Transparent;
            pipeTop1.BackColor = Color.Transparent;
            pipeTop2.BackColor = Color.Transparent;
        }
    }
}
