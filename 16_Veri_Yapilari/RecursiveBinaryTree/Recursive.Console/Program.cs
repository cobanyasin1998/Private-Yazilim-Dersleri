class Program
{
    static void Main(string[] args)
    {
        /*
        EXAMPLE
                     8
                 /       \
                3         10
              /   \         \
             1      6        14
                   /  \      /
                  4    7    13
         */

        var rootNode = new Node(8);

        AddNode(rootNode, 3);
        AddNode(rootNode, 10);
        AddNode(rootNode, 1);
        AddNode(rootNode, 6);
        AddNode(rootNode, 4);
        AddNode(rootNode, 7);
        AddNode(rootNode, 14);
        AddNode(rootNode, 13);

        Travers(rootNode);

        Console.ReadLine();

        void Travers(Node rootNode)
        {
            if (rootNode is null)
            {
                return;
            }
            Travers(rootNode.LeftNode);
            Console.WriteLine(rootNode.Val);
            Travers(rootNode.RightNode);
        }

        void AddNode(Node rootNode, int val)
        {
            if (val < rootNode.Val)
            {
                if (rootNode.LeftNode is null)
                {
                    rootNode.LeftNode = new Node(val);
                    return;
                }
                else
                {
                    AddNode(rootNode.LeftNode, val);
                }
            }
            else
            {
                if (rootNode.RightNode is null)
                {
                    rootNode.RightNode = new Node(val);
                    return;
                }
                else
                {
                    AddNode(rootNode.RightNode, val);
                }
            }
        }
    }



    public class Node
    {

        public Node(int val)
        {
            Val = val;

        }
        public int Val { get; init; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
    }

    public class UnUsed
    {
        public UnUsed()
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 90 };
            //var index = FindIndex_Iteration(numbers, 477, 0);
            var index = FindIndex_Recursive(numbers, 5, 0);

            Console.WriteLine($"Index: {index}");
            Console.ReadLine();
        }
        public static int FindIndex_Recursive(int[] numbers, int val, int startIndex)
        {
            //Exit Contidion
            if (startIndex >= numbers.Length)
            {
                return -1;
            }
            //Actual Process
            if (numbers[startIndex] == val)
            {
                return startIndex;
            }
            //Re-Calling
            return FindIndex_Recursive(numbers, val, startIndex + 1);

        }


        public static int FindIndex_Iteration(int[] numbers, int val, int startIndex)
        {
            for (int i = startIndex; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }
    }



}
public class Node
{

    public Node(int val)
    {
        Val = val;

    }
    public int Val { get; init; }
    public Node LeftNode { get; set; }
    public Node RightNode { get; set; }
}

public class UnUsed
{
    public UnUsed()
    {
        int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 90 };
        //var index = FindIndex_Iteration(numbers, 477, 0);
        var index = FindIndex_Recursive(numbers, 5, 0);

        Console.WriteLine($"Index: {index}");
        Console.ReadLine();
    }
    public static int FindIndex_Recursive(int[] numbers, int val, int startIndex)
    {
        //Exit Contidion
        if (startIndex >= numbers.Length)
        {
            return -1;
        }
        //Actual Process
        if (numbers[startIndex] == val)
        {
            return startIndex;
        }
        //Re-Calling
        return FindIndex_Recursive(numbers, val, startIndex + 1);

    }


    public static int FindIndex_Iteration(int[] numbers, int val, int startIndex)
    {
        for (int i = startIndex; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == val)
            {
                return i;
            }
        }
        return -1;
    }
}
