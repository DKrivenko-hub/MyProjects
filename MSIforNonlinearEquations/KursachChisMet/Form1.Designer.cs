namespace KursachChisMet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_FileAdress = new System.Windows.Forms.TextBox();
            this.label_FileAdress = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Eps = new System.Windows.Forms.TextBox();
            this.label_Eps = new System.Windows.Forms.Label();
            this.label_help = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox_result = new System.Windows.Forms.RichTextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_FileAdress
            // 
            this.textBox_FileAdress.Location = new System.Drawing.Point(228, 88);
            this.textBox_FileAdress.Name = "textBox_FileAdress";
            this.textBox_FileAdress.Size = new System.Drawing.Size(560, 22);
            this.textBox_FileAdress.TabIndex = 0;
            this.textBox_FileAdress.Text = "D:\\Doc\'s\\Visual Studio 2017\\Projects\\KursachChisMet\\System.txt";
            // 
            // label_FileAdress
            // 
            this.label_FileAdress.AutoSize = true;
            this.label_FileAdress.Location = new System.Drawing.Point(69, 88);
            this.label_FileAdress.Name = "label_FileAdress";
            this.label_FileAdress.Size = new System.Drawing.Size(153, 17);
            this.label_FileAdress.TabIndex = 1;
            this.label_FileAdress.Text = "Введите путь к файлу";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Eps
            // 
            this.textBox_Eps.Location = new System.Drawing.Point(369, 164);
            this.textBox_Eps.Name = "textBox_Eps";
            this.textBox_Eps.Size = new System.Drawing.Size(100, 22);
            this.textBox_Eps.TabIndex = 0;
            this.textBox_Eps.Text = "0,0001";
            // 
            // label_Eps
            // 
            this.label_Eps.AutoSize = true;
            this.label_Eps.Location = new System.Drawing.Point(69, 169);
            this.label_Eps.Name = "label_Eps";
            this.label_Eps.Size = new System.Drawing.Size(132, 17);
            this.label_Eps.TabIndex = 1;
            this.label_Eps.Text = "Введите ε( εє(0;1))";
            this.label_Eps.UseMnemonic = false;
            // 
            // label_help
            // 
            this.label_help.Image = ((System.Drawing.Image)(resources.GetObject("label_help.Image")));
            this.label_help.Location = new System.Drawing.Point(834, 31);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(31, 44);
            this.label_help.TabIndex = 4;
            this.toolTip.SetToolTip(this.label_help, resources.GetString("label_help.ToolTip"));
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 5000000;
            this.toolTip.AutoPopDelay = 192640;
            this.toolTip.InitialDelay = 100;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 3852;
            this.toolTip.ShowAlways = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Помощь";
            // 
            // richTextBox_result
            // 
            this.richTextBox_result.Location = new System.Drawing.Point(933, 31);
            this.richTextBox_result.Name = "richTextBox_result";
            this.richTextBox_result.Size = new System.Drawing.Size(395, 389);
            this.richTextBox_result.TabIndex = 5;
            this.richTextBox_result.Text = "";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(1082, 9);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(86, 17);
            this.label_result.TabIndex = 6;
            this.label_result.Text = "Результаты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 474);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.richTextBox_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Eps);
            this.Controls.Add(this.label_FileAdress);
            this.Controls.Add(this.textBox_Eps);
            this.Controls.Add(this.textBox_FileAdress);
            this.Controls.Add(this.label_help);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FileAdress;
        private System.Windows.Forms.Label label_FileAdress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Eps;
        private System.Windows.Forms.Label label_Eps;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RichTextBox richTextBox_result;
        private System.Windows.Forms.Label label_result;
    }
}

