using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VisBinaryTreeInputSearch.BinaryTreeP;

namespace VisBinaryTreeInputSearch.Drawing
{
    public class DrawingTree
    {


        private double _multiplierCoefficient = 1;

        private readonly int minimalSize = 100;

        private int realSize => (int)Math.Round(minimalSize * _multiplierCoefficient);

        public int  width, height;

        public int startXPos, startYPos;

        public DrawingTree(int  width, int height)
        {
            startXPos = width / 2;
            startYPos = (int)(height * 0.03 + realSize / 2);
        }

        public void setNewSize(int width, int height)
        {
            startXPos = width / 2;
            startYPos = (int)(height * 0.03 + realSize / 2);
        }

        private int GetFontSize(MyTreeNode node)
        {
            if (node.data.ToString().Length == 1)
            {
                return (int)(realSize / node.data.ToString().Length / 1.1);
            }
            else
            {
                return (int)(realSize / node.data.ToString().Length / 0.6);
            }


        }


        public void DrawUseNode(Graphics g, int data, int width, int height)
        {

            Pen pen = new(Color.DarkRed, 3);
            Brush brush = new SolidBrush(Color.LightYellow);

            width -= 5;
            height -= 5;

            g.FillEllipse(brush, 1, 1, width, height);
            g.DrawEllipse(pen, 1, 1, width, height);
            int coef;
            if ( data.ToString().Length ==1 ) 
            {
                coef = (int)(width / data.ToString().Length / 1.1);
            }
            else
            {
                coef = (int)(width / data.ToString().Length / 0.6);
            }
            using (Font font = new Font("Times New Roman", coef, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                Rectangle rectangle = new Rectangle(1, 1, width, width);
                TextRenderer.DrawText(g, data.ToString(), font, rectangle, pen.Color, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }


        }

        public void setMulCoef(int val)
        {
            if (val == -100)
            {
                _multiplierCoefficient = 1;
            }
            _multiplierCoefficient = 1 + (double)val / 100;  
        }

        public void TreeDraw(Graphics g, ConditionOfTree condition) 
        {
            if (_multiplierCoefficient == 0) 
            {
                return;
            }

            BinaryTree tree = condition.Tree;

            if(tree.head == null)
            {
                return;
            }
            int coef = GetFontSize(tree.head);
            if (coef == 0)
            {
                return;
            }
            Pen pen = new(Color.DarkBlue, 3);
            Brush brush = new SolidBrush(Color.LightBlue);

            if (tree.head._isChoosen)
            {
                pen.Color = Color.Red;
                brush = new SolidBrush(Color.LightYellow);
            }

            g.FillEllipse(brush, startXPos - realSize / 2, startYPos - realSize / 2, realSize, realSize);
            g.DrawEllipse(pen, startXPos - realSize / 2, startYPos - realSize / 2, realSize, realSize);

            
            using (Font font = new Font("Times New Roman", coef, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                Rectangle rectangle = new Rectangle(startXPos - realSize / 2, startYPos - realSize / 2, realSize, realSize);
                TextRenderer.DrawText(g, tree.head.data.ToString(), font, rectangle, pen.Color ,TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }

            if (tree.head._isChoosen)
            {
                pen.Color = Color.DarkBlue;
                brush = new SolidBrush(Color.LightBlue);
            }

            DrawingNodesRecursionLeftNode(g, tree.head.left, startXPos, startYPos, pen, brush);
            DrawingNodesRecursionRightNode(g, tree.head.right, startXPos, startYPos, pen, brush);
        }

        private void DrawingNodesRecursionLeftNode(Graphics g, MyTreeNode? node, int lastPosX, int lastPosY, Pen pen, Brush brush)
        {
            if (node == null)
            {
                return;
            }
            int coef = GetFontSize(node);
            if (coef == 0)
            {
                return;
            }

            if (node._isChoosen)
            {
                pen.Color = Color.Red;
                brush = new SolidBrush(Color.LightYellow);
            }

            int childs = MyTreeNode.GetRightChilds(node);
            int posX = lastPosX - realSize - childs * realSize;
            int posY = lastPosY + realSize;
            double gip = Math.Pow(Math.Pow(posX - lastPosX, 2) + Math.Pow(posY - lastPosY, 2), 0.5);

            double cos = (posX - lastPosX) / gip;
            double sin = (posY - lastPosY) / gip;
            int bufferPosX = lastPosX + (int)Math.Round(realSize / 2 * cos);
            int bufferPosY = lastPosY + (int)Math.Round(realSize / 2 * sin);
            g.DrawLine(pen, posX, posY, bufferPosX, bufferPosY);

            g.FillEllipse(brush, posX - realSize / 2, posY - realSize / 2, realSize, realSize);
            g.DrawEllipse(pen, posX - realSize / 2, posY - realSize / 2, realSize, realSize);

            
            using (Font font = new Font("Times New Roman", coef, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                Rectangle rectangle = new Rectangle(posX - realSize / 2, posY - realSize / 2, realSize, realSize);
                TextRenderer.DrawText(g, node.data.ToString(), font, rectangle, pen.Color, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }

            if (node._isChoosen)
            {
                pen.Color = Color.DarkBlue;
                brush = new SolidBrush(Color.LightBlue);
            }

            DrawingNodesRecursionLeftNode(g, node.left, posX, posY, pen, brush);
            DrawingNodesRecursionRightNode(g, node.right, posX, posY, pen, brush);
        }




        private void DrawingNodesRecursionRightNode(Graphics g, MyTreeNode? node, int lastPosX, int lastPosY, Pen pen, Brush brush)
        {
            if (node == null)
            {
                return;
            }
            int coef = GetFontSize(node);
            if (coef == 0)
            {
                return;
            }

            if (node._isChoosen)
            {
                pen.Color = Color.Red;
                brush = new SolidBrush(Color.LightYellow);
            }

            int childs = MyTreeNode.GetLeftChilds(node);
            int posX = lastPosX + realSize + childs * realSize;
            int posY = lastPosY + realSize;

            double gip = Math.Pow(Math.Pow(posX - lastPosX, 2) + Math.Pow(posY - lastPosY, 2), 0.5);

            double cos = (posX - lastPosX) / gip;
            double sin = (posY - lastPosY) / gip;
            int bufferPosX = lastPosX + (int)Math.Round(realSize / 2 * cos);
            int bufferPosY = lastPosY + (int)Math.Round(realSize / 2 * sin);
            g.DrawLine(pen, posX, posY, bufferPosX, bufferPosY);

            g.FillEllipse(brush, posX - realSize / 2, posY - realSize / 2, realSize, realSize);
            g.DrawEllipse(pen, posX - realSize / 2, posY - realSize / 2, realSize, realSize);
            using (Font font = new Font("Times New Roman", coef, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                Rectangle rectangle = new Rectangle(posX - realSize / 2, posY - realSize / 2, realSize, realSize);
                TextRenderer.DrawText(g, node.data.ToString(), font, rectangle, pen.Color, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }

            if (node._isChoosen)
            {
                pen.Color = Color.DarkBlue;
                brush = new SolidBrush(Color.LightBlue);
            }

            DrawingNodesRecursionLeftNode(g, node.left, posX, posY, pen, brush);
            DrawingNodesRecursionRightNode(g, node.right, posX, posY, pen, brush);
        }

    }
}
