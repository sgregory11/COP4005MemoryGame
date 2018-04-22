namespace MemoryGameAssignment2
{
    partial class HomePage
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
            this.btn_startGame = new System.Windows.Forms.Button();
            this.btn_viewHighScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_startGame
            // 
            this.btn_startGame.Location = new System.Drawing.Point(206, 179);
            this.btn_startGame.Name = "btn_startGame";
            this.btn_startGame.Size = new System.Drawing.Size(171, 59);
            this.btn_startGame.TabIndex = 0;
            this.btn_startGame.Text = "Start New Game";
            this.btn_startGame.UseVisualStyleBackColor = true;
            this.btn_startGame.Click += new System.EventHandler(this.btn_startGame_Click);
            // 
            // btn_viewHighScores
            // 
            this.btn_viewHighScores.Location = new System.Drawing.Point(457, 179);
            this.btn_viewHighScores.Name = "btn_viewHighScores";
            this.btn_viewHighScores.Size = new System.Drawing.Size(171, 59);
            this.btn_viewHighScores.TabIndex = 1;
            this.btn_viewHighScores.Text = "View High Scores";
            this.btn_viewHighScores.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 442);
            this.Controls.Add(this.btn_viewHighScores);
            this.Controls.Add(this.btn_startGame);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_startGame;
        private System.Windows.Forms.Button btn_viewHighScores;
    }
}