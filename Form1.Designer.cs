namespace Snake_gui
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
            this.label1 = new System.Windows.Forms.Label();
            this.SoloButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.Player2Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(104, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snake";
            // 
            // SoloButton
            // 
            this.SoloButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SoloButton.Location = new System.Drawing.Point(114, 204);
            this.SoloButton.Name = "SoloButton";
            this.SoloButton.Size = new System.Drawing.Size(159, 49);
            this.SoloButton.TabIndex = 1;
            this.SoloButton.Text = "Solo Play";
            this.SoloButton.UseVisualStyleBackColor = true;
            this.SoloButton.Click += new System.EventHandler(this.SoloButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuitButton.Location = new System.Drawing.Point(114, 348);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(159, 49);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Player2Button
            // 
            this.Player2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player2Button.Location = new System.Drawing.Point(114, 276);
            this.Player2Button.Name = "Player2Button";
            this.Player2Button.Size = new System.Drawing.Size(159, 49);
            this.Player2Button.TabIndex = 3;
            this.Player2Button.Text = "2 Player Versus";
            this.Player2Button.UseVisualStyleBackColor = true;
            this.Player2Button.Click += new System.EventHandler(this.Player2Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(300, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "by Pa3ckP7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player2Button);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.SoloButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 550);
            this.MinimumSize = new System.Drawing.Size(410, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SoloButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button Player2Button;
        private System.Windows.Forms.Label label2;
    }
}

