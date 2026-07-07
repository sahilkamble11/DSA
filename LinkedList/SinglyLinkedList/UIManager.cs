namespace DSA.UIManager;
using DSA.LinkedList;

public class UIManager{
    LinkedList linkedList=new LinkedList();

    public void DisplayMenu()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("Linked List");
        Console.WriteLine("======================================");

        Console.WriteLine("1.Insert Node");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Update Value");
        Console.WriteLine("4.Delete Node");
        Console.WriteLine("5.Exit");

        Console.WriteLine("======================================");

        Console.Write("Enter Your Choice: ");
        int choice=int.Parse(Console.ReadLine());
        Console.WriteLine();
        HandleDisplayMenuChoices(choice);
    }
   
    public void DisplayChoice()
    {
        Console.Write("LinkedList: ");
        linkedList.DisplayNodes();
    }

    public void UpdateChoice()
    {
        Console.Write("Enter old Value: ");
        int oldValue=int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter new Value: ");
        int newValue=int.Parse(Console.ReadLine());
        linkedList.UpdateNode(oldValue,newValue);

        Console.Write("Updated ");
        DisplayChoice();
    }

    public void InsertChoice()
    {
        Console.Write("Enter data to Insert: ");
        int num=int.Parse(Console.ReadLine());
        linkedList.Insert(num);

        Console.Write("Updated ");
        DisplayChoice();
    }
    
    public void DeleteChoice()
    {
        Console.WriteLine("Insert data to be Deleted: ");
        int data=int.Parse(Console.ReadLine());
        linkedList.DeleteNode(data);

        Console.Write("Updated ");
        DisplayChoice();
    }
    public int HandleDisplayMenuChoices(int choice)
    {
        switch (choice)
        {
            case 1:
            InsertChoice();
            break;

            case 2:
            DisplayChoice();
            break;

            case 3:
            UpdateChoice();
            break;

            case 4:
            DeleteChoice();
            break;

            case 5:
            Environment.Exit(0);
            break;

        }
        return 0;
    }


}