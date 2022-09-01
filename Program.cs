namespace Treedatastructure
{
    public class Program
    {
        public static void Main()
        {
            Tree treeobj = new Tree();
            treeobj.Insert(56);
            treeobj.Insert(30);
            treeobj.Insert(70);

            Console.WriteLine("Preorder Transversal :Root-Left-right ");
            treeobj.Display(treeobj.ReturnRoot());
            Console.WriteLine("\n");

            Console.WriteLine("Post Transversal :Left-right-Root ");
            treeobj.Post(treeobj.ReturnRoot());
            Console.WriteLine("\n");

            Console.WriteLine("In order Transversal : Left-Root-Right");
            treeobj.Inorder(treeobj.ReturnRoot());
            Console.WriteLine("\n");
        }
    }
}
