namespace FlappyBird_UsingWinform
{
    partial class frm_FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FlappyBird));
            this.Picbox_ground = new System.Windows.Forms.PictureBox();
            this.Picbox_bird = new System.Windows.Forms.PictureBox();
            this.Picbox_pipedown = new System.Windows.Forms.PictureBox();
            this.Picbox_pipeup = new System.Windows.Forms.PictureBox();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Picbox_pipedown1 = new System.Windows.Forms.PictureBox();
            this.Picbox_pipeup1 = new System.Windows.Forms.PictureBox();
            this.Picbox_point = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_pipedown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_pipeup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_point)).BeginInit();
            this.SuspendLayout();
            // 
            // Picbox_ground
            // 
            this.Picbox_ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Picbox_ground.Image = ((System.Drawing.Image)(resources.GetObject("Picbox_ground.Image")));
            this.Picbox_ground.Location = new System.Drawing.Point(0, 401);
            this.Picbox_ground.Name = "Picbox_ground";
            this.Picbox_ground.Size = new System.Drawing.Size(584, 60);
            this.Picbox_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox_ground.TabIndex = 0;
            this.Picbox_ground.TabStop = false;
            // 
            // Picbox_bird
            // 
            this.Picbox_bird.Image = ((System.Drawing.Image)(resources.GetObject("Picbox_bird.Image")));
            this.Picbox_bird.Location = new System.Drawing.Point(69, 199);
            this.Picbox_bird.Name = "Picbox_bird";
            this.Picbox_bird.Size = new System.Drawing.Size(42, 30);
            this.Picbox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox_bird.TabIndex = 0;
            this.Picbox_bird.TabStop = false;
            // 
            // Picbox_pipedown
            // 
            this.Picbox_pipedown.Image = ((System.Drawing.Image)(resources.GetObject("Picbox_pipedown.Image")));
            this.Picbox_pipedown.Location = new System.Drawing.Point(274, -24);
            this.Picbox_pipedown.Name = "Picbox_pipedown";
            this.Picbox_pipedown.Size = new System.Drawing.Size(70, 180);
            this.Picbox_pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox_pipedown.TabIndex = 0;
            this.Picbox_pipedown.TabStop = false;
            // 
            // Picbox_pipeup
            // 
            this.Picbox_pipeup.Image = ((System.Drawing.Image)(resources.GetObject("Picbox_pipeup.Image")));
            this.Picbox_pipeup.Location = new System.Drawing.Point(274, 276);
            this.Picbox_pipeup.Name = "Picbox_pipeup";
            this.Picbox_pipeup.Size = new System.Drawing.Size(70, 189);
            this.Picbox_pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox_pipeup.TabIndex = 0;
            this.Picbox_pipeup.TabStop = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Score.Location = new System.Drawing.Point(13, 13);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(29, 31);
            this.lbl_Score.TabIndex = 1;
            this.lbl_Score.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Picbox_pipedown1
            // 
            this.Picbox_pipedown1.Image = ((System.Drawing.Image)(resources.GetObject("Picbox_pipedown1.Image")));
            this.Picbox_pipedown1.Location = new System.Drawing.Point(486, -11);
            this.Picbox_pipedown1.Name = "Picbox_pipedown1";
            this.Picbox_pipedown1.Size = new System.Drawing.Size(70, 207);
            this.Picbox_pipedown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox_pipedown1.TabIndex = 0;
            this.Picbox_pipedown1.TabStop = false;
            // 
            // Picbox_pipeup1
            // 
            this.Picbox_pipeup1.Image = ((System.Drawing.Image)(resources.GetObject("Picbox_pipeup1.Image")));
            this.Picbox_pipeup1.Location = new System.Drawing.Point(486, 310);
            this.Picbox_pipeup1.Name = "Picbox_pipeup1";
            this.Picbox_pipeup1.Size = new System.Drawing.Size(70, 163);
            this.Picbox_pipeup1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox_pipeup1.TabIndex = 0;
            this.Picbox_pipeup1.TabStop = false;
            // 
            // Picbox_point
            // 
            this.Picbox_point.Image = ((System.Drawing.Image)(resources.GetObject("Picbox_point.Image")));
            this.Picbox_point.Location = new System.Drawing.Point(298, 211);
            this.Picbox_point.Name = "Picbox_point";
            this.Picbox_point.Size = new System.Drawing.Size(24, 18);
            this.Picbox_point.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox_point.TabIndex = 2;
            this.Picbox_point.TabStop = false;
            // 
            // frm_FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Picbox_point);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.Picbox_ground);
            this.Controls.Add(this.Picbox_pipeup1);
            this.Controls.Add(this.Picbox_pipedown1);
            this.Controls.Add(this.Picbox_pipeup);
            this.Controls.Add(this.Picbox_pipedown);
            this.Controls.Add(this.Picbox_bird);
            this.DoubleBuffered = true;
            this.Name = "frm_FlappyBird";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.frm_FlappyBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_pipedown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_pipeup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_point)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picbox_ground;
        private System.Windows.Forms.PictureBox Picbox_bird;
        private System.Windows.Forms.PictureBox Picbox_pipedown;
        private System.Windows.Forms.PictureBox Picbox_pipeup;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox Picbox_pipedown1;
        private System.Windows.Forms.PictureBox Picbox_pipeup1;
        private System.Windows.Forms.PictureBox Picbox_point;
    }
}

