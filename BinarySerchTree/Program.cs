using BinarySerchTree;

BinarySerchTree<int> binarySearchTree = new BinarySerchTree<int>();
binarySearchTree.InsertData(56);
binarySearchTree.InsertData(30);
binarySearchTree.InsertData(70);
binarySearchTree.Display(binarySearchTree.GetRoot());
Console.WriteLine("\n");
Console.WriteLine("Count of Elements in Binary Search Tree is: " + binarySearchTree.GetSize());