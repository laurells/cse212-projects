public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data){
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data) {
            return true;
        }
        else if (value < Data && Left is not null) {
            return Left.Contains(value);
        }
        else if (value > Data && Right is not null) {
            return Right.Contains(value);
        }
        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        // return 0; // Replace this line with the correct return statement(s)
        if (this == null) {
            return 0;
        }

        int leftHeight = (Left == null) ? 0 : Left.GetHeight();
        int rightHeight = (Right == null) ? 0 : Right.GetHeight();

        // Return height of the current node
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
