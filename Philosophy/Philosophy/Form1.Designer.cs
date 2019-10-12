namespace Philosophy
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start_game = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Music = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Start_game
            // 
            this.Start_game.BackColor = System.Drawing.SystemColors.ControlText;
            this.Start_game.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_game.ForeColor = System.Drawing.Color.White;
            this.Start_game.Location = new System.Drawing.Point(194, 90);
            this.Start_game.Name = "Start_game";
            this.Start_game.Size = new System.Drawing.Size(121, 35);
            this.Start_game.TabIndex = 0;
            this.Start_game.Text = "Start Game";
            this.Start_game.UseVisualStyleBackColor = false;
            this.Start_game.Click += new System.EventHandler(this.button1_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Black;
            this.Help.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Help.ForeColor = System.Drawing.SystemColors.Control;
            this.Help.Location = new System.Drawing.Point(194, 157);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(121, 35);
            this.Help.TabIndex = 0;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Transparent;
            this.Exit.Location = new System.Drawing.Point(194, 224);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 35);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Music
            // 
            this.Music.BackColor = System.Drawing.Color.Black;
            this.Music.Checked = true;
            this.Music.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Music.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Music.ForeColor = System.Drawing.Color.White;
            this.Music.Location = new System.Drawing.Point(395, 90);
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(102, 27);
            this.Music.TabIndex = 1;
            this.Music.Text = "Music on";
            this.Music.UseVisualStyleBackColor = false;
            this.Music.CheckedChanged += new System.EventHandler(this.Music_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Philosophy.Properties.Resources.MenuWall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(946, 644);
            this.Controls.Add(this.Music);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Start_game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dale of Philosophy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_game;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox Music;
    }
}

