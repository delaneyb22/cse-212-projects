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
    else if (value > Data) {
        // Insert to the right
        if (Right is null)
            Right = new Node(value);
        else
            Right.Insert(value);
    }
}

    public bool Contains(int value) {
    if (value < Data) {
        if (Left is null)
            return false;
        return Left.Contains(value);
    }
    else if (value > Data) {
        if (Right is null)
            return false;
        return Right.Contains(value);
    }
    else {
        return true;
    }
}

    public int GetHeight() {
    if (Left == null && Right == null) {
        return 1;
    } else if (Left == null) {
        return 1 + Right.GetHeight();
    } else if (Right == null) {
        return 1 + Left.GetHeight();
    } else {
        return 1 + Math.Max(Left.GetHeight(), Right.GetHeight());
    }
}
}