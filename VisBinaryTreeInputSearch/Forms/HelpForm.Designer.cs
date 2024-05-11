namespace VisBinaryTreeInputSearch.Forms
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            textBoxInfoTree = new TextBox();
            textBoxInfo = new TextBox();
            labelThanks = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInfoTree
            // 
            textBoxInfoTree.BorderStyle = BorderStyle.FixedSingle;
            textBoxInfoTree.Location = new Point(6, 26);
            textBoxInfoTree.Multiline = true;
            textBoxInfoTree.Name = "textBoxInfoTree";
            textBoxInfoTree.ReadOnly = true;
            textBoxInfoTree.Size = new Size(309, 242);
            textBoxInfoTree.TabIndex = 2;
            textBoxInfoTree.Text = resources.GetString("textBoxInfoTree.Text");
            // 
            // textBoxInfo
            // 
            textBoxInfo.BorderStyle = BorderStyle.FixedSingle;
            textBoxInfo.Location = new Point(321, 26);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(375, 49);
            textBoxInfo.TabIndex = 3;
            textBoxInfo.Text = "Данная программа реализует визуализацию добавления и поиска в бинарном дереве.";
            // 
            // labelThanks
            // 
            labelThanks.AutoSize = true;
            labelThanks.Location = new Point(412, 78);
            labelThanks.Name = "labelThanks";
            labelThanks.Size = new Size(185, 20);
            labelThanks.TabIndex = 4;
            labelThanks.Text = "Приятного пользования!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxInfoTree);
            groupBox1.Controls.Add(labelThanks);
            groupBox1.Controls.Add(textBoxInfo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(708, 274);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация";
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 289);
            Controls.Add(groupBox1);
            Name = "HelpForm";
            Text = "Справка";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxInfoTree;
        private TextBox textBoxInfo;
        private Label labelThanks;
        private GroupBox groupBox1;
    }
}