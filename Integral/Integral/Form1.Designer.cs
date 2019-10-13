namespace Integral
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
            this.label_Function = new System.Windows.Forms.Label();
            this.textBox_Function = new System.Windows.Forms.TextBox();
            this.label_leftBoard = new System.Windows.Forms.Label();
            this.label_rightBoard = new System.Windows.Forms.Label();
            this.textBox_LeftBoard = new System.Windows.Forms.TextBox();
            this.textBox_RightBoard = new System.Windows.Forms.TextBox();
            this.button_DoIt = new System.Windows.Forms.Button();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.zedGraphControl_function = new ZedGraph.ZedGraphControl();
            this.label_Result = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_QuantityAuto = new System.Windows.Forms.RadioButton();
            this.radioButton_QuantityUsers = new System.Windows.Forms.RadioButton();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label_ExactVal = new System.Windows.Forms.Label();
            this.textBox_ExactVal = new System.Windows.Forms.TextBox();
            this.label_der = new System.Windows.Forms.Label();
            this.textBox_der = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Function
            // 
            this.label_Function.AutoSize = true;
            this.label_Function.Location = new System.Drawing.Point(64, 43);
            this.label_Function.Name = "label_Function";
            this.label_Function.Size = new System.Drawing.Size(67, 17);
            this.label_Function.TabIndex = 1;
            this.label_Function.Text = "Функция";
            // 
            // textBox_Function
            // 
            this.textBox_Function.Location = new System.Drawing.Point(156, 43);
            this.textBox_Function.Name = "textBox_Function";
            this.textBox_Function.Size = new System.Drawing.Size(202, 22);
            this.textBox_Function.TabIndex = 2;
            this.textBox_Function.Text = "(X-3)^2*(X^2+4)";
            // 
            // label_leftBoard
            // 
            this.label_leftBoard.AutoSize = true;
            this.label_leftBoard.Location = new System.Drawing.Point(64, 182);
            this.label_leftBoard.Name = "label_leftBoard";
            this.label_leftBoard.Size = new System.Drawing.Size(16, 17);
            this.label_leftBoard.TabIndex = 3;
            this.label_leftBoard.Text = "a";
            // 
            // label_rightBoard
            // 
            this.label_rightBoard.AutoSize = true;
            this.label_rightBoard.Location = new System.Drawing.Point(64, 220);
            this.label_rightBoard.Name = "label_rightBoard";
            this.label_rightBoard.Size = new System.Drawing.Size(16, 17);
            this.label_rightBoard.TabIndex = 3;
            this.label_rightBoard.Text = "b";
            // 
            // textBox_LeftBoard
            // 
            this.textBox_LeftBoard.Location = new System.Drawing.Point(177, 179);
            this.textBox_LeftBoard.Name = "textBox_LeftBoard";
            this.textBox_LeftBoard.Size = new System.Drawing.Size(100, 22);
            this.textBox_LeftBoard.TabIndex = 4;
            this.textBox_LeftBoard.Text = "-2";
            // 
            // textBox_RightBoard
            // 
            this.textBox_RightBoard.Location = new System.Drawing.Point(177, 215);
            this.textBox_RightBoard.Name = "textBox_RightBoard";
            this.textBox_RightBoard.Size = new System.Drawing.Size(100, 22);
            this.textBox_RightBoard.TabIndex = 4;
            this.textBox_RightBoard.Text = "2";
            // 
            // button_DoIt
            // 
            this.button_DoIt.Location = new System.Drawing.Point(133, 359);
            this.button_DoIt.Name = "button_DoIt";
            this.button_DoIt.Size = new System.Drawing.Size(144, 85);
            this.button_DoIt.TabIndex = 5;
            this.button_DoIt.Text = "Выполнить";
            this.button_DoIt.UseVisualStyleBackColor = true;
            this.button_DoIt.Click += new System.EventHandler(this.button_DoIt_Click);
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Location = new System.Drawing.Point(1088, 50);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.Size = new System.Drawing.Size(305, 475);
            this.richTextBox_Result.TabIndex = 6;
            this.richTextBox_Result.Text = "";
            // 
            // zedGraphControl_function
            // 
            this.zedGraphControl_function.Location = new System.Drawing.Point(539, 13);
            this.zedGraphControl_function.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl_function.Name = "zedGraphControl_function";
            this.zedGraphControl_function.ScrollGrace = 0D;
            this.zedGraphControl_function.ScrollMaxX = 0D;
            this.zedGraphControl_function.ScrollMaxY = 0D;
            this.zedGraphControl_function.ScrollMaxY2 = 0D;
            this.zedGraphControl_function.ScrollMinX = 0D;
            this.zedGraphControl_function.ScrollMinY = 0D;
            this.zedGraphControl_function.ScrollMinY2 = 0D;
            this.zedGraphControl_function.Size = new System.Drawing.Size(542, 512);
            this.zedGraphControl_function.TabIndex = 7;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(1201, 30);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(76, 17);
            this.label_Result.TabIndex = 8;
            this.label_Result.Text = "Результат";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_QuantityAuto);
            this.panel1.Controls.Add(this.radioButton_QuantityUsers);
            this.panel1.Location = new System.Drawing.Point(49, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 100);
            this.panel1.TabIndex = 9;
            // 
            // radioButton_QuantityAuto
            // 
            this.radioButton_QuantityAuto.AutoSize = true;
            this.radioButton_QuantityAuto.Location = new System.Drawing.Point(18, 45);
            this.radioButton_QuantityAuto.Name = "radioButton_QuantityAuto";
            this.radioButton_QuantityAuto.Size = new System.Drawing.Size(245, 21);
            this.radioButton_QuantityAuto.TabIndex = 0;
            this.radioButton_QuantityAuto.Text = "Стандартное колличесвто узлов";
            this.radioButton_QuantityAuto.UseVisualStyleBackColor = true;
            // 
            // radioButton_QuantityUsers
            // 
            this.radioButton_QuantityUsers.AutoSize = true;
            this.radioButton_QuantityUsers.Checked = true;
            this.radioButton_QuantityUsers.Location = new System.Drawing.Point(18, 18);
            this.radioButton_QuantityUsers.Name = "radioButton_QuantityUsers";
            this.radioButton_QuantityUsers.Size = new System.Drawing.Size(281, 21);
            this.radioButton_QuantityUsers.TabIndex = 0;
            this.radioButton_QuantityUsers.TabStop = true;
            this.radioButton_QuantityUsers.Text = "Пользовательское колличесвто узлов";
            this.radioButton_QuantityUsers.UseVisualStyleBackColor = true;
            this.radioButton_QuantityUsers.CheckedChanged += new System.EventHandler(this.radioButton_QuantityUsers_CheckedChanged);
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(392, 271);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(100, 22);
            this.textBox_Quantity.TabIndex = 10;
            // 
            // label_ExactVal
            // 
            this.label_ExactVal.AutoSize = true;
            this.label_ExactVal.Location = new System.Drawing.Point(63, 71);
            this.label_ExactVal.Name = "label_ExactVal";
            this.label_ExactVal.Size = new System.Drawing.Size(124, 17);
            this.label_ExactVal.TabIndex = 1;
            this.label_ExactVal.Text = "Точное значение";
            // 
            // textBox_ExactVal
            // 
            this.textBox_ExactVal.Location = new System.Drawing.Point(205, 71);
            this.textBox_ExactVal.Name = "textBox_ExactVal";
            this.textBox_ExactVal.Size = new System.Drawing.Size(202, 22);
            this.textBox_ExactVal.TabIndex = 2;
            this.textBox_ExactVal.Text = "157,86";
            // 
            // label_der
            // 
            this.label_der.AutoSize = true;
            this.label_der.Location = new System.Drawing.Point(63, 104);
            this.label_der.Name = "label_der";
            this.label_der.Size = new System.Drawing.Size(114, 17);
            this.label_der.TabIndex = 1;
            this.label_der.Text = "Производная(4)";
            // 
            // textBox_der
            // 
            this.textBox_der.Location = new System.Drawing.Point(205, 99);
            this.textBox_der.Name = "textBox_der";
            this.textBox_der.Size = new System.Drawing.Size(202, 22);
            this.textBox_der.TabIndex = 2;
            this.textBox_der.Text = "24";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 554);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.zedGraphControl_function);
            this.Controls.Add(this.richTextBox_Result);
            this.Controls.Add(this.button_DoIt);
            this.Controls.Add(this.textBox_RightBoard);
            this.Controls.Add(this.textBox_LeftBoard);
            this.Controls.Add(this.label_rightBoard);
            this.Controls.Add(this.label_leftBoard);
            this.Controls.Add(this.textBox_der);
            this.Controls.Add(this.label_der);
            this.Controls.Add(this.textBox_ExactVal);
            this.Controls.Add(this.label_ExactVal);
            this.Controls.Add(this.textBox_Function);
            this.Controls.Add(this.label_Function);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Function;
        private System.Windows.Forms.TextBox textBox_Function;
        private System.Windows.Forms.Label label_leftBoard;
        private System.Windows.Forms.Label label_rightBoard;
        private System.Windows.Forms.TextBox textBox_LeftBoard;
        private System.Windows.Forms.TextBox textBox_RightBoard;
        private System.Windows.Forms.Button button_DoIt;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private ZedGraph.ZedGraphControl zedGraphControl_function;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_QuantityAuto;
        private System.Windows.Forms.RadioButton radioButton_QuantityUsers;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label_ExactVal;
        private System.Windows.Forms.TextBox textBox_ExactVal;
        private System.Windows.Forms.Label label_der;
        private System.Windows.Forms.TextBox textBox_der;
    }
}

