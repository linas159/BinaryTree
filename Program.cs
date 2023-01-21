using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        public class Branch
        {
            List<Branch> branches;
            public Branch left, right, middle;

            public Branch()
            {
                left = right = middle = null;
            }
        }

    }
}
