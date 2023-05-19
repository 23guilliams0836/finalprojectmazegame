namespace mazegamefinalproj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblGame = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSplunders = new System.Windows.Forms.Label();
            this.lblSplunderFlare = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(147, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnForward
            // 
            this.btnForward.Enabled = false;
            this.btnForward.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForward.Location = new System.Drawing.Point(286, 510);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(100, 39);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = "↑";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Visible = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRight.Location = new System.Drawing.Point(384, 555);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 39);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Visible = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeft.Location = new System.Drawing.Point(189, 555);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(100, 39);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Visible = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lblGame
            // 
            this.lblGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(147, 471);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(390, 50);
            this.lblGame.TabIndex = 4;
            this.lblGame.Text = "This crazy maze changes as you walk through it,\n are you prepared to spelunk this" +
    " dungeon?";
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(274, 568);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 43);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "PLUNDER!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSplunders
            // 
            this.lblSplunders.AutoSize = true;
            this.lblSplunders.Location = new System.Drawing.Point(32, 26);
            this.lblSplunders.Name = "lblSplunders";
            this.lblSplunders.Size = new System.Drawing.Size(0, 25);
            this.lblSplunders.TabIndex = 6;
            // 
            // lblSplunderFlare
            // 
            this.lblSplunderFlare.AutoSize = true;
            this.lblSplunderFlare.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSplunderFlare.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSplunderFlare.ForeColor = System.Drawing.Color.Brown;
            this.lblSplunderFlare.Location = new System.Drawing.Point(469, 54);
            this.lblSplunderFlare.Name = "lblSplunderFlare";
            this.lblSplunderFlare.Size = new System.Drawing.Size(0, 23);
            this.lblSplunderFlare.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit Score";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 770);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSplunderFlare);
            this.Controls.Add(this.lblSplunders);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnForward;
        private Button btnRight;
        private Button btnLeft;
        private Label lblGame;
        private Button btnStart;
        private Label lblSplunders;
        private Label lblSplunderFlare;
        private Button button1;
    }
}