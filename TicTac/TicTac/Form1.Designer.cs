namespace TicTac
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
            this.Start_Game = new System.Windows.Forms.Button();
            this.WinsX_label = new System.Windows.Forms.Label();
            this.WinsO_label = new System.Windows.Forms.Label();
            this.label_scoreX = new System.Windows.Forms.Label();
            this.label_scoreO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_Game
            // 
            this.Start_Game.Location = new System.Drawing.Point(350, 42);
            this.Start_Game.Name = "Start_Game";
            this.Start_Game.Size = new System.Drawing.Size(75, 23);
            this.Start_Game.TabIndex = 0;
            this.Start_Game.Text = "Start_Game";
            this.Start_Game.UseVisualStyleBackColor = true;
            this.Start_Game.Click += new System.EventHandler(this.Start_Game_Click);
            // 
            // WinsX_label
            // 
            this.WinsX_label.AutoSize = true;
            this.WinsX_label.Location = new System.Drawing.Point(324, 129);
            this.WinsX_label.Name = "WinsX_label";
            this.WinsX_label.Size = new System.Drawing.Size(49, 13);
            this.WinsX_label.TabIndex = 1;
            this.WinsX_label.Text = "Побед Х";
            // 
            // WinsO_label
            // 
            this.WinsO_label.AutoSize = true;
            this.WinsO_label.Location = new System.Drawing.Point(323, 158);
            this.WinsO_label.Name = "WinsO_label";
            this.WinsO_label.Size = new System.Drawing.Size(50, 13);
            this.WinsO_label.TabIndex = 2;
            this.WinsO_label.Text = "Побед О";
            // 
            // label_scoreX
            // 
            this.label_scoreX.AutoSize = true;
            this.label_scoreX.Location = new System.Drawing.Point(424, 129);
            this.label_scoreX.Name = "label_scoreX";
            this.label_scoreX.Size = new System.Drawing.Size(13, 13);
            this.label_scoreX.TabIndex = 3;
            this.label_scoreX.Text = "0";
            // 
            // label_scoreO
            // 
            this.label_scoreO.AutoSize = true;
            this.label_scoreO.Location = new System.Drawing.Point(424, 158);
            this.label_scoreO.Name = "label_scoreO";
            this.label_scoreO.Size = new System.Drawing.Size(13, 13);
            this.label_scoreO.TabIndex = 4;
            this.label_scoreO.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 212);
            this.Controls.Add(this.label_scoreO);
            this.Controls.Add(this.label_scoreX);
            this.Controls.Add(this.WinsO_label);
            this.Controls.Add(this.WinsX_label);
            this.Controls.Add(this.Start_Game);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Game;
        private System.Windows.Forms.Label WinsX_label;
        private System.Windows.Forms.Label WinsO_label;
        private System.Windows.Forms.Label label_scoreX;
        private System.Windows.Forms.Label label_scoreO;
    }
}

