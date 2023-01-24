using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SomeStructure
{
    public class Branch
    {
        public List<Branch> child = new List<Branch>(); // Branch can have ANY number of child branches
    }

    static Branch newBranch() // Branch constructor
    {
        Branch temp = new Branch();
        return temp;
    }

    class StructureAction
    {
        static int CalculateDepth(Branch root, int currentDepth) // Calculating max depth USING RECURSION
        {
            int maxDepth = currentDepth;
            foreach (var child in root.child) // Goes through every child
            {
                int childDepth = CalculateDepth(child, currentDepth + 1); // Recursion
                maxDepth = Math.Max(maxDepth, childDepth); // Compare current depth with max depth if bigger save as maxDepth
            }
            return maxDepth;
        }

        static void Main()
        {
            // Creating a structure as in the example
            Branch root = newBranch();// Creating root (first layer)
            root.child.Add(newBranch()); // Second layer
            root.child.Add(newBranch());
            (root.child[0]).child.Add(newBranch()); // Third layer
            (root.child[1]).child.Add(newBranch());
            (root.child[1]).child.Add(newBranch());
            (root.child[1]).child.Add(newBranch());
            ((root.child[1]).child[0]).child.Add(newBranch()); // Fourth layer
            ((root.child[1]).child[1]).child.Add(newBranch());
            ((root.child[1]).child[1]).child.Add(newBranch());
            (((root.child[1]).child[1]).child[0]).child.Add(newBranch()); // Fifth layer

            Console.WriteLine("Max depth: " + StructureAction.CalculateDepth(root, 1)); // Finding maximum depth
            Console.ReadKey();
        }
    }
}
