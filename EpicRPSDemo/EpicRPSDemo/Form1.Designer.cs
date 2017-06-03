namespace EpicRPSDemo
{
    partial class GameForm
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.rockButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.winLosePanel = new System.Windows.Forms.Panel();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.winLoseLabel = new System.Windows.Forms.Label();
            this.compItemPic = new System.Windows.Forms.PictureBox();
            this.userItemPic = new System.Windows.Forms.PictureBox();
            this.userScorePic = new System.Windows.Forms.PictureBox();
            this.compScorePic = new System.Windows.Forms.PictureBox();
            this.winLosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compItemPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userItemPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userScorePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compScorePic)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(237, 300);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(110, 13);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "Please select an item:";
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(94, 356);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(75, 23);
            this.rockButton.TabIndex = 3;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // scissorsButton
            // 
            this.scissorsButton.Location = new System.Drawing.Point(248, 356);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(75, 23);
            this.scissorsButton.TabIndex = 4;
            this.scissorsButton.Text = "Scissors";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(408, 356);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(75, 23);
            this.paperButton.TabIndex = 5;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // winLosePanel
            // 
            this.winLosePanel.BackColor = System.Drawing.Color.White;
            this.winLosePanel.Controls.Add(this.playAgainButton);
            this.winLosePanel.Controls.Add(this.winLoseLabel);
            this.winLosePanel.Location = new System.Drawing.Point(84, 284);
            this.winLosePanel.Name = "winLosePanel";
            this.winLosePanel.Size = new System.Drawing.Size(400, 150);
            this.winLosePanel.TabIndex = 6;
            this.winLosePanel.Visible = false;
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(164, 72);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(75, 23);
            this.playAgainButton.TabIndex = 1;
            this.playAgainButton.Text = "Play Again?";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // winLoseLabel
            // 
            this.winLoseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.winLoseLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLoseLabel.Location = new System.Drawing.Point(0, 0);
            this.winLoseLabel.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.winLoseLabel.Name = "winLoseLabel";
            this.winLoseLabel.Size = new System.Drawing.Size(400, 69);
            this.winLoseLabel.TabIndex = 0;
            this.winLoseLabel.Text = "n/a";
            this.winLoseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLoseLabel.Click += new System.EventHandler(this.winLoseLabel_Click);
            // 
            // compItemPic
            // 
            this.compItemPic.Location = new System.Drawing.Point(372, 74);
            this.compItemPic.Name = "compItemPic";
            this.compItemPic.Size = new System.Drawing.Size(200, 200);
            this.compItemPic.TabIndex = 1;
            this.compItemPic.TabStop = false;
            // 
            // userItemPic
            // 
            this.userItemPic.Location = new System.Drawing.Point(12, 74);
            this.userItemPic.Name = "userItemPic";
            this.userItemPic.Size = new System.Drawing.Size(200, 200);
            this.userItemPic.TabIndex = 0;
            this.userItemPic.TabStop = false;
            // 
            // userScorePic
            // 
            this.userScorePic.Location = new System.Drawing.Point(12, 12);
            this.userScorePic.Name = "userScorePic";
            this.userScorePic.Size = new System.Drawing.Size(200, 50);
            this.userScorePic.TabIndex = 7;
            this.userScorePic.TabStop = false;
            // 
            // compScorePic
            // 
            this.compScorePic.Location = new System.Drawing.Point(372, 12);
            this.compScorePic.Name = "compScorePic";
            this.compScorePic.Size = new System.Drawing.Size(200, 50);
            this.compScorePic.TabIndex = 8;
            this.compScorePic.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.winLosePanel);
            this.Controls.Add(this.compScorePic);
            this.Controls.Add(this.userScorePic);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.compItemPic);
            this.Controls.Add(this.userItemPic);
            this.Name = "GameForm";
            this.Text = "Epic RPS";
            this.winLosePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compItemPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userItemPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userScorePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compScorePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userItemPic;
        private System.Windows.Forms.PictureBox compItemPic;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Panel winLosePanel;
        private System.Windows.Forms.Label winLoseLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.PictureBox userScorePic;
        private System.Windows.Forms.PictureBox compScorePic;
    }
}

