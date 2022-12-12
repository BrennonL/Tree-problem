using System.Collections;

namespace Tree;


public class BinarySearchTree : IEnumerable<int>
{
    private Node? _root;


    ///<summery>
    /// This function will add a value at the _root if the _root is void
    ///else it will call the node insert function
    ///</summery>
    public void Insert(int value)
    {
        if (_root is null)
        {
            _root = new Node(value);
        }
        else
        {
            _root.Insert(value);
        }
    }

    public void FindValue(int value)
    {
        // TODO 1
        // Fill out the function so that is displays an error message if the tree is 
        //empty. Else call SearchForValue

    }

    private void SearchForValue(Node? node, int value)
    {

        // TODO 1.5
        //Find the value using a recursion function

    }

    ///<summery>
    /// These three function more or less alow the BinarySearchTree to be looped through
    ///by adding each value to a list
    ///</summery>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<int> GetEnumerator()
    {
        var numbers = new List<int>();
        TraverseForward(_root, numbers);
        foreach (var number in numbers)
        {
            yield return number;
        }
    }

    public void TraverseForward(Node? node, List<int> Numbers)
    {
        if (node is not null)
        {
            TraverseForward(node.Right, Numbers);
            Numbers.Add(node.Data);
            TraverseForward(node.Left, Numbers);
        }
    }

    public override string ToString()
    {
        return "<Bst>{" + string.Join(", ", this) + "}";
    }
}
