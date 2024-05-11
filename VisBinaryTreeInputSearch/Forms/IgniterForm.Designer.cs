namespace VisBinaryTreeInputSearch.Forms
{
    partial class IgniterForm
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
            radioButtonInsert = new RadioButton();
            radioButtonFind = new RadioButton();
            groupBoxOperationType = new GroupBox();
            groupBoxValue = new GroupBox();
            numericUpDownValue = new NumericUpDown();
            buttonSendIgniter = new Button();
            groupBoxOperationType.SuspendLayout();
            groupBoxValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValue).BeginInit();
            SuspendLayout();
            // 
            // radioButtonInsert
            // 
            radioButtonInsert.AutoSize = true;
            radioButtonInsert.Location = new Point(6, 26);
            radioButtonInsert.Name = "radioButtonInsert";
            radioButtonInsert.Size = new Size(83, 24);
            radioButtonInsert.TabIndex = 0;
            radioButtonInsert.TabStop = true;
            radioButtonInsert.Text = "Вставка";
            radioButtonInsert.UseVisualStyleBackColor = true;
            // 
            // radioButtonFind
            // 
            radioButtonFind.AutoSize = true;
            radioButtonFind.Location = new Point(6, 56);
            radioButtonFind.Name = "radioButtonFind";
            radioButtonFind.Size = new Size(73, 24);
            radioButtonFind.TabIndex = 1;
            radioButtonFind.TabStop = true;
            radioButtonFind.Text = "Поиск";
            radioButtonFind.UseVisualStyleBackColor = true;
            // 
            // groupBoxOperationType
            // 
            groupBoxOperationType.Controls.Add(radioButtonInsert);
            groupBoxOperationType.Controls.Add(radioButtonFind);
            groupBoxOperationType.Location = new Point(12, 12);
            groupBoxOperationType.Name = "groupBoxOperationType";
            groupBoxOperationType.Size = new Size(129, 86);
            groupBoxOperationType.TabIndex = 2;
            groupBoxOperationType.TabStop = false;
            groupBoxOperationType.Text = "Тип операции";
            // 
            // groupBoxValue
            // 
            groupBoxValue.Controls.Add(numericUpDownValue);
            groupBoxValue.Location = new Point(147, 12);
            groupBoxValue.Name = "groupBoxValue";
            groupBoxValue.Size = new Size(172, 58);
            groupBoxValue.TabIndex = 3;
            groupBoxValue.TabStop = false;
            groupBoxValue.Text = "Используемое число";
            // 
            // numericUpDownValue
            // 
            numericUpDownValue.Location = new Point(6, 25);
            numericUpDownValue.Name = "numericUpDownValue";
            numericUpDownValue.Size = new Size(160, 27);
            numericUpDownValue.TabIndex = 5;
            // 
            // buttonSendIgniter
            // 
            buttonSendIgniter.Location = new Point(147, 71);
            buttonSendIgniter.Name = "buttonSendIgniter";
            buttonSendIgniter.Size = new Size(172, 29);
            buttonSendIgniter.TabIndex = 4;
            buttonSendIgniter.Text = "Передать значения";
            buttonSendIgniter.UseVisualStyleBackColor = true;
            buttonSendIgniter.Click += buttonSendIgniter_Click;
            // 
            // IgniterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 104);
            Controls.Add(buttonSendIgniter);
            Controls.Add(groupBoxValue);
            Controls.Add(groupBoxOperationType);
            Name = "IgniterForm";
            Text = "Начальные параметры";
            groupBoxOperationType.ResumeLayout(false);
            groupBoxOperationType.PerformLayout();
            groupBoxValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownValue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButtonInsert;
        private RadioButton radioButtonFind;
        private GroupBox groupBoxOperationType;
        private GroupBox groupBoxValue;
        private Button buttonSendIgniter;
        private NumericUpDown numericUpDownValue;
    }
}