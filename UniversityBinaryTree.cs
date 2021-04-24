using System;
using System.Collections.Generic;
using System.Text;

namespace University_binary_tree
{
    class UniversityBinaryTree
    {
        public NodePositionTree RootNode;

        public void AddPosition(NodePositionTree root, PositionTree create, String rootPositionName)
        {
            NodePositionTree node = new NodePositionTree();
            node.Position = create;
            if(RootNode == null)
            {
                RootNode = node;
                return;
            }
            if(root == null)
            {
                return;
            }
            if(root.Position.NameEmployed == rootPositionName)
            {
                if(root.Left == null)
                {
                    root.Left = node;
                    return;
                }
                root.Right = node;
                return;
            }
            AddPosition(root.Left, create, rootPositionName);
            AddPosition(root.Right, create, rootPositionName);
        }

        public void PrintTree(NodePositionTree from)
        {
            if(from == null)
            {
                return;
            }
            Console.WriteLine($"{from.Position.NameEmployed} : $ {from.Position.SalaryEmployed} ");
            PrintTree(from.Left);
            PrintTree(from.Right);
        }

        public float SumSalaries(NodePositionTree start)
        {
            if(start == null)
            {
                return 0;
            }
            return start.Position.SalaryEmployed + SumSalaries(start.Left) + SumSalaries(start.Right);
        }
    }
}
