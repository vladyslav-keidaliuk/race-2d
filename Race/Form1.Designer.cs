namespace Race
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.award = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadTrack3 = new System.Windows.Forms.PictureBox();
            this.roadTrack4 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.Start_button = new System.Windows.Forms.Button();
            this.Score_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Level_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadTrack3);
            this.panel1.Controls.Add(this.roadTrack4);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 1148);
            this.panel1.TabIndex = 0;
            // 
            // award
            // 
            this.award.Image = global::Race.Properties.Resources.LegendAward;
            this.award.Location = new System.Drawing.Point(118, 57);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(685, 422);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 3;
            this.award.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.Image = global::Race.Properties.Resources.YellowCar1;
            this.AI2.Location = new System.Drawing.Point(834, 217);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(101, 202);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 2;
            this.AI2.TabStop = false;
            this.AI2.Tag = "Right";
            // 
            // AI1
            // 
            this.AI1.Image = global::Race.Properties.Resources.YellowRedCar1;
            this.AI1.Location = new System.Drawing.Point(144, 57);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(101, 202);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 2;
            this.AI1.TabStop = false;
            this.AI1.Tag = "Left";
            // 
            // explosion
            // 
            this.explosion.Image = global::Race.Properties.Resources.fire1;
            this.explosion.Location = new System.Drawing.Point(159, 458);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(65, 91);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 2;
            this.explosion.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Race.Properties.Resources.BlueCarL12;
            this.player.Location = new System.Drawing.Point(411, 893);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(101, 202);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // roadTrack3
            // 
            this.roadTrack3.Location = new System.Drawing.Point(0, -1148);
            this.roadTrack3.Name = "roadTrack3";
            this.roadTrack3.Size = new System.Drawing.Size(1111, 1148);
            this.roadTrack3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack3.TabIndex = 1;
            this.roadTrack3.TabStop = false;
            // 
            // roadTrack4
            // 
            this.roadTrack4.Image = global::Race.Properties.Resources.roadWarn;
            this.roadTrack4.Location = new System.Drawing.Point(0, 0);
            this.roadTrack4.Name = "roadTrack4";
            this.roadTrack4.Size = new System.Drawing.Size(1111, 1148);
            this.roadTrack4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack4.TabIndex = 1;
            this.roadTrack4.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Location = new System.Drawing.Point(0, 0);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(100, 50);
            this.roadTrack1.TabIndex = 4;
            this.roadTrack1.TabStop = false;
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(463, 1205);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(213, 95);
            this.Start_button.TabIndex = 1;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Score_label
            // 
            this.Score_label.Location = new System.Drawing.Point(730, 1205);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(367, 95);
            this.Score_label.TabIndex = 2;
            this.Score_label.Text = "Score: 0";
            this.Score_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Level_label
            // 
            this.Level_label.Location = new System.Drawing.Point(79, 1205);
            this.Level_label.Name = "Level_label";
            this.Level_label.Size = new System.Drawing.Size(271, 95);
            this.Level_label.TabIndex = 3;
            this.Level_label.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1135, 1342);
            this.Controls.Add(this.Level_label);
            this.Controls.Add(this.Score_label);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox roadTrack3;

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox award;

        private System.Windows.Forms.PictureBox explosion;

        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox AI2;

        private System.Windows.Forms.PictureBox player;

        private System.Windows.Forms.PictureBox roadTrack1;

        private System.Windows.Forms.PictureBox roadTrack4;

        private System.Windows.Forms.Label Level_label;

        private System.Windows.Forms.Label Score_label;

        private System.Windows.Forms.Button Start_button;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}