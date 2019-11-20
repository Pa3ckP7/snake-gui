namespace Snake_gui
{
    partial class SnakeSolo
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
            this.PbCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // PbCanvas
            // 
            this.PbCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PbCanvas.Location = new System.Drawing.Point(10, 65);
            this.PbCanvas.MaximumSize = new System.Drawing.Size(1168, 688);
            this.PbCanvas.MinimumSize = new System.Drawing.Size(1168, 688);
            this.PbCanvas.Name = "PbCanvas";
            this.PbCanvas.Size = new System.Drawing.Size(1168, 688);
            this.PbCanvas.TabIndex = 0;
            this.PbCanvas.TabStop = false;
            this.PbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PbCanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreText.Location = new System.Drawing.Point(162, 9);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(96, 55);
            this.ScoreText.TabIndex = 2;
            this.ScoreText.Text = "000";
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.UpdateScreen);
            // 
            // SnakeSolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbCanvas);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "SnakeSolo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeSolo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SnakeSolo_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeSolo_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SnakeSolo_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}