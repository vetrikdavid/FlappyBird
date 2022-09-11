
namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.pipeDown1 = new System.Windows.Forms.PictureBox();
            this.pipeDown2 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pipeTop1
            // 
            this.pipeTop1.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop1.Image")));
            this.pipeTop1.Location = new System.Drawing.Point(202, -263);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(111, 370);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 0;
            this.pipeTop1.TabStop = false;
            // 
            // pipeDown1
            // 
            this.pipeDown1.Image = ((System.Drawing.Image)(resources.GetObject("pipeDown1.Image")));
            this.pipeDown1.Location = new System.Drawing.Point(162, 305);
            this.pipeDown1.Name = "pipeDown1";
            this.pipeDown1.Size = new System.Drawing.Size(106, 327);
            this.pipeDown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown1.TabIndex = 1;
            this.pipeDown1.TabStop = false;
            // 
            // pipeDown2
            // 
            this.pipeDown2.Image = ((System.Drawing.Image)(resources.GetObject("pipeDown2.Image")));
            this.pipeDown2.Location = new System.Drawing.Point(462, 305);
            this.pipeDown2.Name = "pipeDown2";
            this.pipeDown2.Size = new System.Drawing.Size(106, 327);
            this.pipeDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown2.TabIndex = 2;
            this.pipeDown2.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop2.Image")));
            this.pipeTop2.Location = new System.Drawing.Point(406, -263);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(111, 370);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 3;
            this.pipeTop2.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-17, 386);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1084, 90);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bird.BackgroundImage")));
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird.Location = new System.Drawing.Point(49, 155);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(57, 49);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 5;
            this.bird.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.scoreText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.scoreText.Location = new System.Drawing.Point(120, 424);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(59, 22);
            this.scoreText.TabIndex = 6;
            this.scoreText.Text = "label1";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.score.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(12, 424);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(107, 22);
            this.score.TabIndex = 7;
            this.score.Text = "Total Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 461);
            this.Controls.Add(this.score);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeDown2);
            this.Controls.Add(this.pipeDown1);
            this.Controls.Add(this.pipeTop1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.PictureBox pipeDown1;
        private System.Windows.Forms.PictureBox pipeDown2;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label score;
    }
}

