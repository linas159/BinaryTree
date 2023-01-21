using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTre
{
    public class Branch
    {
        public Branch left, right, middle; // A branch has 3 possibilies to go

        public Branch()
        {
            left = right = middle = null; // When branch is created all 3 possibilities are null
        }
    }

    public class BinaryTree
    {
        Branch root;

        int maxDepth(Branch root)
        {
            if (root == null) // If the "way" is null it means it does not exist and this function is over
                return 0;

            // RECURSIVELY find the depth of each subtree.
            int leftDepth = maxDepth(root.left);
            int middleDepth = maxDepth(root.middle);
            int rightDepth = maxDepth(root.right);
            

            // Get the largest depth.
            if (leftDepth > rightDepth)
            {
                if (leftDepth > middleDepth)
                    return (leftDepth + 1);
                else
                    return (middleDepth + 1);
            }
            else
            {
                if (rightDepth > middleDepth)
                    return (rightDepth + 1);
                else
                    return (middleDepth + 1);
            }
        }

        public static void Main()
        {
            // Creating a structure as in the example
            BinaryTree tree = new BinaryTree();
            tree.root = new Branch();
            tree.root.left = new Branch();
            tree.root.right = new Branch();
            tree.root.left.left = new Branch();
            tree.root.right.left = new Branch();
            tree.root.right.middle = new Branch();
            tree.root.right.right = new Branch();
            tree.root.right.left.left = new Branch();
            tree.root.right.middle.left = new Branch();
            tree.root.right.middle.right = new Branch();
            tree.root.right.middle.left.middle = new Branch();

            Console.WriteLine("Max depth: " + tree.maxDepth(tree.root)); // Finding maximum depth
            Console.ReadKey();
        }
    }
    
}
