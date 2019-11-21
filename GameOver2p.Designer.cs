namespace Snake_gui
{
    partial class GameOver2p
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
            this.QuitButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.RematchButton = new System.Windows.Forms.Button();
            this.Score1Text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MatchResultText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Score2Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuitButton.Location = new System.Drawing.Point(62, 343);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(168, 52);
            this.QuitButton.TabIndex = 11;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuButton.Location = new System.Drawing.Point(62, 285);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(168, 52);
            this.MenuButton.TabIndex = 10;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // RematchButton
            // 
            this.RematchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RematchButton.Location = new System.Drawing.Point(62, 227);
            this.RematchButton.Name = "RematchButton";
            this.RematchButton.Size = new System.Drawing.Size(168, 52);
            this.RematchButton.TabIndex = 9;
            this.RematchButton.Text = "Rematch";
            this.RematchButton.UseVisualStyleBackColor = true;
            this.RematchButton.Click += new System.EventHandler(this.RematchButton_Click);
            // 
            // Score1Text
            // 
            this.Score1Text.AutoSize = true;
            this.Score1Text.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score1Text.Location = new System.Drawing.Point(196, 120);
            this.Score1Text.Name = "Score1Text";
            this.Score1Text.Size = new System.Drawing.Size(48, 27);
            this.Score1Text.TabIndex = 8;
            this.Score1Text.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player1 Final Score:";
            // 
            // MatchResultText
            // 
            this.MatchResultText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MatchResultText.AutoSize = true;
            this.MatchResultText.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MatchResultText.Location = new System.Drawing.Point(24, 45);
            this.MatchResultText.Name = "MatchResultText";
            this.MatchResultText.Size = new System.Drawing.Size(222, 55);
            this.MatchResultText.TabIndex = 6;
            this.MatchResultText.Text = "Undefined";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Player2 Final Score:";
            // 
            // Score2Text
            // 
            this.Score2Text.AutoSize = true;
            this.Score2Text.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score2Text.Location = new System.Drawing.Point(196, 147);
            this.Score2Text.Name = "Score2Text";
            this.Score2Text.Size = new System.Drawing.Size(48, 27);
            this.Score2Text.TabIndex = 13;
            this.Score2Text.Text = "000";
            // 
            // GameOver2p
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.Score2Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.RematchButton);
            this.Controls.Add(this.Score1Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MatchResultText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(327, 489);
            this.MinimumSize = new System.Drawing.Size(327, 489);
            this.Name = "GameOver2p";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver2p";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameOver2p_FormClosed);
            this.Load += new System.EventHandler(this.GameOver2p_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button RematchButton;
        private System.Windows.Forms.Label Score1Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MatchResultText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score2Text;
    }
}