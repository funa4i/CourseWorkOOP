﻿using VisBinaryTreeInputSearch.Drawing;
using VisBinaryTreeInputSearch.BinaryTreeP;
using VisBinaryTreeInputSearch.StorageConditons;
using VisBinaryTreeInputSearch.Starter;
using VisBinaryTreeInputSearch.Enums;
using VisBinaryTreeInputSearch.StarterPack;

namespace VisBinaryTreeInputSearch.Forms
{
    public partial class MainForm : Form
    {
        private DrawingTree _curDrawingTree;
        ConditionOfTree conditionOfTree;
        private bool _isMousePressed;

        private Manager _manager;
        private Storage? _storage;

        private int lastMousPosX;
        private int lastMousPosY;

        public MainForm()
        {
            InitializeComponent();
            _curDrawingTree = new DrawingTree(treePictBox.Width, treePictBox.Height);

        }

        private void trackBarZoom_ValueChanged(object sender, EventArgs e)
        {
            _curDrawingTree.setMulCoef(_zoomTrackBar.Value);
        }

        private void pictUpdate_Tick(object sender, EventArgs e)
        {
            if (conditionOfTree == null)
            {
                return;
            }
            Bitmap bitmap = new(treePictBox.Width, treePictBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            _curDrawingTree.TreeDraw(graphics, conditionOfTree);
            treePictBox.Image = bitmap;
        }

        private void treePictBox_MouseDown(object sender, MouseEventArgs e)
        {
            treePictBox.Cursor = Cursors.SizeAll;
            _isMousePressed = true;
            lastMousPosX = e.X;
            lastMousPosY = e.Y;
        }

        private void treePictBox_MouseUp(object sender, MouseEventArgs e)
        {
            treePictBox.Cursor = Cursors.Default;
            _isMousePressed = false;
        }

        private void treePictBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMousePressed)
            {
                _curDrawingTree.startXPos += e.X - lastMousPosX;
                _curDrawingTree.startYPos += e.Y - lastMousPosY;
                lastMousPosX = e.X;
                lastMousPosY = e.Y;
            }
        }

        private void MainForm_MouseWheel(object sendrm, MouseEventArgs e)
        {
            if (_zoomTrackBar.Value + e.Delta / 120 * 10 < _zoomTrackBar.Maximum && _zoomTrackBar.Value + e.Delta / 120 * 10 > _zoomTrackBar.Minimum)
            {
                _zoomTrackBar.Value += ((e.Delta / Math.Abs(e.Delta) * 10));
            }

        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                pictUpdate.Start();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                pictUpdate.Stop();
            }
            _curDrawingTree.setNewSize(treePictBox.Width, treePictBox.Height);

        }

        private void buttoFindTree_Click(object sender, EventArgs e)
        {
            _curDrawingTree.setNewSize(treePictBox.Width, treePictBox.Height);
        }

        private void SetStorage(Igniter igniter)
        {

            if (_storage == null || _storage.GetSize() == 0)
            {
                _manager = new Manager(new BinaryTree());
            }
            else
            {
                _manager = new Manager(_storage.SetLastPostion().Tree);
            }
            _storage = _manager.addIgniter(igniter);
            conditionOfTree = _storage?.SetNullPosition() ?? conditionOfTree;
            Bitmap bitmap = new Bitmap(ConditionElementPictBox.Width, ConditionElementPictBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            _curDrawingTree.DrawUseNode(graphics, igniter.data, ConditionElementPictBox.Width, ConditionElementPictBox.Height);
            ConditionElementPictBox.Image = bitmap;
            switch (igniter.act)
            {
                case EnumAct.Insert:
                    labelCondition.Text = "Состояние: Вставка";
                    labelResult.Text = "Результат: Успешно";
                    break;
                case EnumAct.Find:
                    labelCondition.Text = "Состоние: Поиск";
                    if (_manager.result)
                    {
                        labelResult.Text = "Результат: Найден";
                    }
                    else
                    {
                        labelResult.Text = "Результат: Отсутствует";
                    }
                    break;
            }
        }

        private void buttonGetIgniter_Click(object sender, EventArgs e)
        {
            IgniterForm form = new IgniterForm();
            form.AddDelegate(SetStorage);
            form.ShowDialog();
        }

        private void buttonStepForward_Click(object sender, EventArgs e)
        {
            if (_storage == null)
            {
                return;
            }
            conditionOfTree = _storage.GetNextCondtiont();
        }

        private void buttonStepBack_Click(object sender, EventArgs e)
        {
            if (_storage == null)
            {
                return;
            }
            conditionOfTree = _storage.GetPreviusCondition();
        }

        private void buttonLastCond_Click(object sender, EventArgs e)
        {
            if (_storage == null)
            {
                return;
            }
            conditionOfTree = _storage.SetLastPostion();
        }

        private void buttonStartCond_Click(object sender, EventArgs e)
        {
            if (_storage == null)
            {
                return;
            }
            conditionOfTree = _storage.SetNullPosition();
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            if (_storage == null)
            {
                MessageBox.Show("Не удалось сохранить: Дерево отсутствует");
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _storage.SaveConditions(saveFileDialog.FileName);
                MessageBox.Show("Дерево сохранено");
            }
        }

        private void ToolStripMenuItemLoad_Click(object sender, EventArgs e)
        {
            if (_storage == null)
            {
                _storage = new Storage();
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_storage.LoadConditions(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузка прошла успешно");
                    SetStorage(new Igniter(_storage.SetNullPosition().EnumAct, _storage.SetNullPosition().UseableData));
                    buttonLastCond_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Ошибка загрузки");
                }

            }
        }

        private void ToolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
                HelpForm form = new HelpForm();
                form.Show();  
        }
    }
}
