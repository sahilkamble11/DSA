
namespace DSA.Main;
using DSA.UIManager;
class Program
{   

    public static void Main(String[] args)
    {
        UIManager uIManager=new UIManager();
        
        while(true)
        {
            uIManager.DisplayMenu();
            Console.ReadKey();
        }
    }
}