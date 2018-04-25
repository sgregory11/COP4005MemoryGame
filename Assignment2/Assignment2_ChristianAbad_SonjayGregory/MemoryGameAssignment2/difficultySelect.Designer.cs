namespace MemoryGameAssignment2
{
    partial class difficultySelect
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
            this.btn_sprEasy = new System.Windows.Forms.Button();
            this.btn_easy = new System.Windows.Forms.Button();
            this.btn_medium = new System.Windows.Forms.Button();
            this.btn_hard = new System.Windows.Forms.Button();
            this.btn_sprHard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sprEasy
            // 
            this.btn_sprEasy.Location = new System.Drawing.Point(35, 79);
            this.btn_sprEasy.Name = "btn_sprEasy";
            this.btn_sprEasy.Size = new System.Drawing.Size(95, 52);
            this.btn_sprEasy.TabIndex = 0;
            this.btn_sprEasy.Text = "Super Easy";
            this.btn_sprEasy.UseVisualStyleBackColor = true;
            this.btn_sprEasy.Click += new System.EventHandler(this.btn_sprEasy_Click);
            // 
            // btn_easy
            // 
            this.btn_easy.Location = new System.Drawing.Point(164, 79);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(95, 52);
            this.btn_easy.TabIndex = 1;
            this.btn_easy.Text = "Easy";
            this.btn_easy.UseVisualStyleBackColor = true;
            this.btn_easy.Click += new System.EventHandler(this.btn_easy_Click);
            // 
            // btn_medium
            // 
            this.btn_medium.Location = new System.Drawing.Point(293, 79);
            this.btn_medium.Name = "btn_medium";
            this.btn_medium.Size = new System.Drawing.Size(95, 52);
            this.btn_medium.TabIndex = 2;
            this.btn_medium.Text = "Medium";
            this.btn_medium.UseVisualStyleBackColor = true;
            this.btn_medium.Click += new System.EventHandler(this.btn_medium_Click);
            // 
            // btn_hard
            // 
            this.btn_hard.Location = new System.Drawing.Point(426, 79);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(95, 52);
            this.btn_hard.TabIndex = 3;
            this.btn_hard.Text = "Hard";
            this.btn_hard.UseVisualStyleBackColor = true;
            this.btn_hard.Click += new System.EventHandler(this.btn_hard_Click);
            // 
            // btn_sprHard
            // 
            this.btn_sprHard.Location = new System.Drawing.Point(553, 79);
            this.btn_sprHard.Name = "btn_sprHard";
            this.btn_sprHard.Size = new System.Drawing.Size(95, 52);
            this.btn_sprHard.TabIndex = 4;
            this.btn_sprHard.Text = "Super Hard";
            this.btn_sprHard.UseVisualStyleBackColor = true;
            this.btn_sprHard.Click += new System.EventHandler(this.btn_sprHard_Click);
            // 
            // difficultySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 225);
            this.Controls.Add(this.btn_sprHard);
            this.Controls.Add(this.btn_hard);
            this.Controls.Add(this.btn_medium);
            this.Controls.Add(this.btn_easy);
            this.Controls.Add(this.btn_sprEasy);
            this.Name = "difficultySelect";
            this.Text = "difficultySelect";
            this.Load += new System.EventHandler(this.difficultySelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_sprEasy;
        public System.Windows.Forms.Button btn_easy;
        public System.Windows.Forms.Button btn_medium;
        public System.Windows.Forms.Button btn_hard;
        public System.Windows.Forms.Button btn_sprHard;

    }
}