namespace aspmvccore6test1.Models
{
    public class Node
    {
        //T TYPE LET YOU CAN INPUT ANY TYPE VALUE
        public string? Value { get; set; }

        //Node will store to List and you can easy remove node and check node
        //it will remove easy on remove part
        public List<Node> Children { get; set; }
        //public T ttt { get; set; }

        public Node(string? value)
        {
            Value = value;
            Children = new List<Node>();
        }


    }
}
