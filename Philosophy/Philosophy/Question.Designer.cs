namespace Philosophy
{
    partial class Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.label_question = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.C = new System.Windows.Forms.RadioButton();
            this.D = new System.Windows.Forms.RadioButton();
            this.E = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_question.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_question.Location = new System.Drawing.Point(0, -1);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(654, 227);
            this.label_question.TabIndex = 0;
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.A.Location = new System.Drawing.Point(12, 230);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(633, 50);
            this.A.TabIndex = 1;
            this.A.Text = "radioButton1";
            this.A.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.B.Location = new System.Drawing.Point(12, 270);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(633, 50);
            this.B.TabIndex = 1;
            this.B.Text = "radioButton1";
            this.B.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.C.Location = new System.Drawing.Point(12, 320);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(633, 50);
            this.C.TabIndex = 1;
            this.C.Text = "radioButton1";
            this.C.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.D.Location = new System.Drawing.Point(12, 370);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(633, 50);
            this.D.TabIndex = 1;
            this.D.Text = "radioButton1";
            this.D.UseVisualStyleBackColor = true;
            // 
            // E
            // 
            this.E.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.E.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.E.Location = new System.Drawing.Point(12, 420);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(633, 50);
            this.E.TabIndex = 1;
            this.E.Text = "radioButton1";
            this.E.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(657, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.E);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label_question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Question";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton D;
        private System.Windows.Forms.RadioButton E;
        private System.Windows.Forms.Button button1;
    }
}