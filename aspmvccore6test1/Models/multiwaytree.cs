using Microsoft.Extensions.Primitives;

namespace aspmvccore6test1.Models
{
    public class MultiTree<T>
    {
        ////public class kk
        ////{
        ////    public int value{get; set;}

        ////}

        ////public kk tt1 = new kk();

        ////public void fun1()
        ////{
        ////    tt1.value = 25;
        ////}

        //public class Node
        //{
        //    //T TYPE LET YOU CAN INPUT ANY TYPE VALUE
        //    public string? Value { get; set; }

        //    //Node will store to List and you can easy remove node and check node
        //    //it will remove easy on remove part
        //    public List<Node> Children { get; set; }
        //    //public T ttt { get; set; }

        //    public Node(string? value)
        //    {
        //        Value = value;
        //        Children = new List<Node>();
        //    }


        //}



        private Node root;

        public MultiTree()
        {
            root = null;
        }

        //public

        public void AddNode(string? value, string? parentValue)
        {
            Node newNode = new Node(value);

            if (root == null)
            {
                root = newNode;
                return;
            }
            T? convertpass = (T)Convert.ChangeType(parentValue, typeof(T));

            Node? parentNode = FindNode(root, convertpass);
            if (parentNode != null)
            {
                parentNode.Children.Add(newNode);
            }
            else
            {
                throw new ArgumentException("Parent node not found.");
            }
        }

        public void RemoveNode(T value)
        {
            if (root == null)
            {
                return;
            }

            if (root.Value.Equals(value))
            {
                root = null;
                return;
            }

            RemoveNode(root, value);
        }



        private bool RemoveNode(Node currentNode, T value)
        {
            foreach (Node child in currentNode.Children)
            {
                if (child.Value.Equals(value))
                {
                    currentNode.Children.Remove(child);
                    return true;
                }

                if (RemoveNode(child, value))
                {
                    return true;
                }
            }

            return false;
        }


        public void PrintTree()
        {
            //clear multiway tree global variable
            GVariable.multiwaytree_list.Clear();
            PrintNode(root, 0);
        }




        //PRINT ALL TREE

        private void PrintNode(Node node, int depth)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(new string('-', depth) + node.Value);
            GVariable.multiwaytree_list.Add(node.Value);

            foreach (Node child in node.Children)
            {
                PrintNode(child, depth + 1);
            }
        }

        private Node FindNode(Node currentNode, T value)
        {
            if (currentNode.Value.Equals(value))
            {
                return currentNode;
            }

            foreach (Node child in currentNode.Children)
            {
                Node foundNode = FindNode(child, value);
                if (foundNode != null)
                {
                    return foundNode;
                }
            }

            return null;
        }
    }
}
