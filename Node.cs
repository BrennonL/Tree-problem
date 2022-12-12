

namespace Tree
{

    public class Node
    {
        // variables declaration 
        public int Data {get; set;}
        public Node? Right {get; set;}
        public Node? Left {get; set;}

        public Node(int data)
        {
            this.Data = data;
        }


        ///<summery>
        /// This will add the value either to the left or the right based on if the value is greater
        ///that the current node
        ///</summery>
        public void Insert(int value)
        {
            if (value < Data)
            {
                if (Left is null)
                {
                    Left = new Node(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
            else
            {
                if (Right is null)
                {
                    Right = new Node(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
        }
    }
}