namespace VisBinaryTreeInputSearch.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            toolsPanel = new Panel();
            buttonStartCond = new Button();
            buttonLastCond = new Button();
            groupBoxElement = new GroupBox();
            labelResult = new Label();
            labelCondition = new Label();
            ConditionElementPictBox = new PictureBox();
            buttonStepForward = new Button();
            buttonStepBack = new Button();
            buttonGetIgniter = new Button();
            buttoFindTree = new Button();
            treePictBox = new PictureBox();
            _zoomTrackBar = new TrackBar();
            pictUpdate = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemSave = new ToolStripMenuItem();
            ToolStripMenuItemLoad = new ToolStripMenuItem();
            ToolStripMenuItemHelp = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            toolsPanel.SuspendLayout();
            groupBoxElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ConditionElementPictBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)treePictBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_zoomTrackBar).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolsPanel
            // 
            toolsPanel.BackColor = SystemColors.HighlightText;
            toolsPanel.BorderStyle = BorderStyle.FixedSingle;
            toolsPanel.Controls.Add(buttonStartCond);
            toolsPanel.Controls.Add(buttonLastCond);
            toolsPanel.Controls.Add(groupBoxElement);
            toolsPanel.Controls.Add(ConditionElementPictBox);
            toolsPanel.Controls.Add(buttonStepForward);
            toolsPanel.Controls.Add(buttonStepBack);
            toolsPanel.Controls.Add(buttonGetIgniter);
            toolsPanel.Controls.Add(buttoFindTree);
            toolsPanel.Dock = DockStyle.Top;
            toolsPanel.Location = new Point(0, 28);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Size = new Size(1472, 94);
            toolsPanel.TabIndex = 0;
            // 
            // buttonStartCond
            // 
            buttonStartCond.Location = new Point(3, 63);
            buttonStartCond.Name = "buttonStartCond";
            buttonStartCond.Size = new Size(160, 29);
            buttonStartCond.TabIndex = 12;
            buttonStartCond.Text = "Вернуться в начало";
            buttonStartCond.UseVisualStyleBackColor = true;
            buttonStartCond.Click += buttonStartCond_Click;
            // 
            // buttonLastCond
            // 
            buttonLastCond.Location = new Point(3, 32);
            buttonLastCond.Name = "buttonLastCond";
            buttonLastCond.Size = new Size(160, 29);
            buttonLastCond.TabIndex = 11;
            buttonLastCond.Text = "Дойти в конец";
            buttonLastCond.UseVisualStyleBackColor = true;
            buttonLastCond.Click += buttonLastCond_Click;
            // 
            // groupBoxElement
            // 
            groupBoxElement.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxElement.Controls.Add(labelResult);
            groupBoxElement.Controls.Add(labelCondition);
            groupBoxElement.Location = new Point(1150, 3);
            groupBoxElement.Name = "groupBoxElement";
            groupBoxElement.Size = new Size(197, 73);
            groupBoxElement.TabIndex = 10;
            groupBoxElement.TabStop = false;
            groupBoxElement.Text = "Элемент";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 46);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 1;
            labelResult.Text = "Результат:";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(6, 23);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(95, 20);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Сосотояние:";
            // 
            // ConditionElementPictBox
            // 
            ConditionElementPictBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ConditionElementPictBox.BorderStyle = BorderStyle.FixedSingle;
            ConditionElementPictBox.Location = new Point(1054, 1);
            ConditionElementPictBox.Name = "ConditionElementPictBox";
            ConditionElementPictBox.Size = new Size(90, 90);
            ConditionElementPictBox.TabIndex = 9;
            ConditionElementPictBox.TabStop = false;
            // 
            // buttonStepForward
            // 
            buttonStepForward.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonStepForward.BackgroundImage = Properties.Resources.arrowRight;
            buttonStepForward.BackgroundImageLayout = ImageLayout.Stretch;
            buttonStepForward.Location = new Point(1412, 3);
            buttonStepForward.Name = "buttonStepForward";
            buttonStepForward.Size = new Size(55, 55);
            buttonStepForward.TabIndex = 3;
            buttonStepForward.UseVisualStyleBackColor = true;
            buttonStepForward.Click += buttonStepForward_Click;
            // 
            // buttonStepBack
            // 
            buttonStepBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonStepBack.BackgroundImage = Properties.Resources.arrowLeft;
            buttonStepBack.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStepBack.Location = new Point(1353, 3);
            buttonStepBack.Name = "buttonStepBack";
            buttonStepBack.Size = new Size(55, 55);
            buttonStepBack.TabIndex = 2;
            buttonStepBack.UseVisualStyleBackColor = true;
            buttonStepBack.Click += buttonStepBack_Click;
            // 
            // buttonGetIgniter
            // 
            buttonGetIgniter.Location = new Point(3, 1);
            buttonGetIgniter.Name = "buttonGetIgniter";
            buttonGetIgniter.Size = new Size(160, 29);
            buttonGetIgniter.TabIndex = 1;
            buttonGetIgniter.Text = "Задать параметры";
            buttonGetIgniter.UseVisualStyleBackColor = true;
            buttonGetIgniter.Click += buttonGetIgniter_Click;
            // 
            // buttoFindTree
            // 
            buttoFindTree.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttoFindTree.Location = new Point(1353, 62);
            buttoFindTree.Name = "buttoFindTree";
            buttoFindTree.Size = new Size(114, 29);
            buttoFindTree.TabIndex = 0;
            buttoFindTree.Text = "Найти дерево";
            buttoFindTree.UseVisualStyleBackColor = true;
            buttoFindTree.Click += buttoFindTree_Click;
            // 
            // treePictBox
            // 
            treePictBox.BackColor = SystemColors.ControlLightLight;
            treePictBox.Dock = DockStyle.Fill;
            treePictBox.Location = new Point(0, 122);
            treePictBox.Name = "treePictBox";
            treePictBox.Size = new Size(1472, 610);
            treePictBox.TabIndex = 1;
            treePictBox.TabStop = false;
            treePictBox.MouseDown += treePictBox_MouseDown;
            treePictBox.MouseMove += treePictBox_MouseMove;
            treePictBox.MouseUp += treePictBox_MouseUp;
            // 
            // _zoomTrackBar
            // 
            _zoomTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _zoomTrackBar.AutoSize = false;
            _zoomTrackBar.BackColor = SystemColors.ControlLightLight;
            _zoomTrackBar.Location = new Point(1189, 699);
            _zoomTrackBar.Maximum = 200;
            _zoomTrackBar.Minimum = -90;
            _zoomTrackBar.Name = "_zoomTrackBar";
            _zoomTrackBar.Size = new Size(283, 33);
            _zoomTrackBar.TabIndex = 0;
            _zoomTrackBar.ValueChanged += trackBarZoom_ValueChanged;
            // 
            // pictUpdate
            // 
            pictUpdate.Enabled = true;
            pictUpdate.Interval = 10;
            pictUpdate.Tick += pictUpdate_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1472, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemSave, ToolStripMenuItemLoad, ToolStripMenuItemHelp });
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(65, 24);
            ToolStripMenuItem.Text = "Меню";
            // 
            // ToolStripMenuItemSave
            // 
            ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            ToolStripMenuItemSave.ShortcutKeys = Keys.Control | Keys.S;
            ToolStripMenuItemSave.Size = new Size(255, 26);
            ToolStripMenuItemSave.Text = "Сохранить";
            ToolStripMenuItemSave.Click += ToolStripMenuItemSave_Click;
            // 
            // ToolStripMenuItemLoad
            // 
            ToolStripMenuItemLoad.Name = "ToolStripMenuItemLoad";
            ToolStripMenuItemLoad.ShortcutKeys = Keys.Control | Keys.L;
            ToolStripMenuItemLoad.Size = new Size(255, 26);
            ToolStripMenuItemLoad.Text = "Загрузить";
            ToolStripMenuItemLoad.Click += ToolStripMenuItemLoad_Click;
            // 
            // ToolStripMenuItemHelp
            // 
            ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            ToolStripMenuItemHelp.ShortcutKeys = Keys.Control | Keys.I;
            ToolStripMenuItemHelp.Size = new Size(255, 26);
            ToolStripMenuItemHelp.Text = "Открыть справку";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 732);
            Controls.Add(_zoomTrackBar);
            Controls.Add(treePictBox);
            Controls.Add(toolsPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            SizeChanged += MainForm_SizeChanged;
            MouseWheel += MainForm_MouseWheel;
            toolsPanel.ResumeLayout(false);
            groupBoxElement.ResumeLayout(false);
            groupBoxElement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ConditionElementPictBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)treePictBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)_zoomTrackBar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel toolsPanel;
        private PictureBox treePictBox;
        private TrackBar _zoomTrackBar;
        private System.Windows.Forms.Timer pictUpdate;
        private Button buttoFindTree;
        private Button buttonGetIgniter;
        private Button buttonStepForward;
        private GroupBox groupBoxElement;
        private Label labelResult;
        private Label labelCondition;
        private PictureBox ConditionElementPictBox;
        private Button buttonStepBack;
        private Button buttonStartCond;
        private Button buttonLastCond;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemSave;
        private ToolStripMenuItem ToolStripMenuItemLoad;
        private ToolStripMenuItem ToolStripMenuItemHelp;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}