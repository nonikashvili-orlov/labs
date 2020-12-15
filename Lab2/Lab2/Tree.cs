using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Tree
    {
        // подкласс "элемент дерева"
        public class TreeNode
        {
            public int Value; // численное значение
            public int Count = 0; // сколько раз было добавлено данное численное значение
            public TreeNode Left; // левое поддерево
            public TreeNode Right; // правое поддерево
        }
        public TreeNode Node; // экземпляр класса "элемент дерева"

        public const string widthTree = "Дерево обойдено в ширину";
        public const string depthTree = "Дерево обойдено в глубину";

        public string DoDepthAlgorithm(Tree tree)
        {
            return depthTree;
            //реализация метода обхода в глубину
        }
        public string DoWidthAlogirthm(Tree tree)
        {
            return widthTree;
            //реализация метода обхода в ширину
        }
    }
}
