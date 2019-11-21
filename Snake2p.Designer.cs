namespace Snake_gui
{
    partial class Snake2p
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
            this.ScoreText1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PbCanvas = new System.Windows.Forms.PictureBox();
            this.ScoreText2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText1
            // 
            this.ScoreText1.AutoSize = true;
            this.ScoreText1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreText1.Location = new System.Drawing.Point(1076, 9);
            this.ScoreText1.Name = "ScoreText1";
            this.ScoreText1.Size = new System.Drawing.Size(96, 55);
            this.ScoreText1.TabIndex = 5;
            this.ScoreText1.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player 2 Score:";
            // 
            // PbCanvas
            // 
            this.PbCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PbCanvas.Location = new System.Drawing.Point(8, 64);
            this.PbCanvas.MaximumSize = new System.Drawing.Size(1168, 688);
            this.PbCanvas.MinimumSize = new System.Drawing.Size(1168, 688);
            this.PbCanvas.Name = "PbCanvas";
            this.PbCanvas.Size = new System.Drawing.Size(1168, 688);
            this.PbCanvas.TabIndex = 3;
            this.PbCanvas.TabStop = false;
            this.PbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PbCanvas_Paint);
            // 
            // ScoreText2
            // 
            this.ScoreText2.AutoSize = true;
            this.ScoreText2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreText2.Location = new System.Drawing.Point(311, 9);
            this.ScoreText2.Name = "ScoreText2";
            this.ScoreText2.Size = new System.Drawing.Size(96, 55);
            this.ScoreText2.TabIndex = 6;
            this.ScoreText2.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(769, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 55);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player 1 Score:";
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.Update);
            // 
            // Snake2p
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreText2);
            this.Controls.Add(this.ScoreText1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbCanvas);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Snake2p";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake2p";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Snake2p_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake2p_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Snake2p_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbCanvas;
        private System.Windows.Forms.Label ScoreText2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer GameTimer;
    }
}