namespace MemoryGameAssignment2
{
    partial class MatchingGame
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
            this.GamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.timeElpased = new System.Windows.Forms.Timer(this.components);
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.LightBlue;
            this.GamePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.GamePanel.ColumnCount = 4;
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePanel.Controls.Add(this.label16, 3, 3);
            this.GamePanel.Controls.Add(this.label15, 2, 3);
            this.GamePanel.Controls.Add(this.label14, 1, 3);
            this.GamePanel.Controls.Add(this.label13, 0, 3);
            this.GamePanel.Controls.Add(this.label12, 3, 2);
            this.GamePanel.Controls.Add(this.label11, 2, 2);
            this.GamePanel.Controls.Add(this.label10, 1, 2);
            this.GamePanel.Controls.Add(this.label9, 0, 2);
            this.GamePanel.Controls.Add(this.label8, 3, 1);
            this.GamePanel.Controls.Add(this.label7, 2, 1);
            this.GamePanel.Controls.Add(this.label6, 1, 1);
            this.GamePanel.Controls.Add(this.label5, 0, 1);
            this.GamePanel.Controls.Add(this.label4, 3, 0);
            this.GamePanel.Controls.Add(this.label3, 2, 0);
            this.GamePanel.Controls.Add(this.label2, 1, 0);
            this.GamePanel.Controls.Add(this.label1, 0, 0);
            this.GamePanel.Location = new System.Drawing.Point(175, 59);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.RowCount = 4;
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePanel.Size = new System.Drawing.Size(738, 628);
            this.GamePanel.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label16.Location = new System.Drawing.Point(555, 471);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 154);
            this.label16.TabIndex = 15;
            this.label16.Text = "c";
            this.label16.Click += new System.EventHandler(this.label_Click);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label15.Location = new System.Drawing.Point(372, 471);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 154);
            this.label15.TabIndex = 14;
            this.label15.Text = "c";
            this.label15.Click += new System.EventHandler(this.label_Click);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label14.Location = new System.Drawing.Point(189, 471);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 154);
            this.label14.TabIndex = 13;
            this.label14.Text = "c";
            this.label14.Click += new System.EventHandler(this.label_Click);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label13.Location = new System.Drawing.Point(6, 471);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 154);
            this.label13.TabIndex = 12;
            this.label13.Text = "c";
            this.label13.Click += new System.EventHandler(this.label_Click);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.Location = new System.Drawing.Point(555, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 153);
            this.label12.TabIndex = 11;
            this.label12.Text = "c";
            this.label12.Click += new System.EventHandler(this.label_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.Location = new System.Drawing.Point(372, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 153);
            this.label11.TabIndex = 10;
            this.label11.Text = "c";
            this.label11.Click += new System.EventHandler(this.label_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.Location = new System.Drawing.Point(189, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 153);
            this.label10.TabIndex = 9;
            this.label10.Text = "c";
            this.label10.Click += new System.EventHandler(this.label_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.Location = new System.Drawing.Point(6, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 153);
            this.label9.TabIndex = 8;
            this.label9.Text = "c";
            this.label9.Click += new System.EventHandler(this.label_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.Location = new System.Drawing.Point(555, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 153);
            this.label8.TabIndex = 7;
            this.label8.Text = "c";
            this.label8.Click += new System.EventHandler(this.label_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.Location = new System.Drawing.Point(372, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 153);
            this.label7.TabIndex = 6;
            this.label7.Text = "c";
            this.label7.Click += new System.EventHandler(this.label_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.Location = new System.Drawing.Point(189, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 153);
            this.label6.TabIndex = 5;
            this.label6.Text = "c";
            this.label6.Click += new System.EventHandler(this.label_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 153);
            this.label5.TabIndex = 4;
            this.label5.Text = "c";
            this.label5.Click += new System.EventHandler(this.label_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(555, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 153);
            this.label4.TabIndex = 3;
            this.label4.Text = "c";
            this.label4.Click += new System.EventHandler(this.label_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(372, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 153);
            this.label3.TabIndex = 2;
            this.label3.Text = "c";
            this.label3.Click += new System.EventHandler(this.label_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(189, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 153);
            this.label2.TabIndex = 1;
            this.label2.Text = "c";
            this.label2.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 153);
            this.label1.TabIndex = 0;
            this.label1.Text = "c";
            this.label1.Click += new System.EventHandler(this.label_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 600;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Location = new System.Drawing.Point(441, 735);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(91, 20);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "score score";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(647, 735);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(73, 20);
            this.lbl_timer.TabIndex = 2;
            this.lbl_timer.Text = "time time";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(384, 735);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 20);
            this.label17.TabIndex = 3;
            this.label17.Text = "Score";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(595, 735);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 20);
            this.label18.TabIndex = 4;
            this.label18.Text = "Timer";
            // 
            // timeElpased
            // 
            this.timeElpased.Interval = 1000;
            this.timeElpased.Tick += new System.EventHandler(this.timeElpased_Tick_1);
            // 
            // MatchingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 794);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.GamePanel);
            this.Name = "MatchingGame";
            this.Text = "Matching Game";
            this.Load += new System.EventHandler(this.MatchingGame_Load);
            this.GamePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GamePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.Timer gameTimer;
        public System.Windows.Forms.Timer timeElpased;
        public System.Windows.Forms.Label lbl_timer;
    }
}

