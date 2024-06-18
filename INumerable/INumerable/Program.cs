using System.Linq;
class Program
{
    
    public static float MoyenneTableau(IEnumerable<int> tab,int n)
    {

        IEnumerable<int> integersLowerThanFive = tab.Where((x) => x <= n);
        float moyenne = 0.0f;
        int nombreVal = 0;
        foreach (int value in integersLowerThanFive)
        {
            //Console.Write(value + " ");
            moyenne += value;
            nombreVal += 1;
        }

        return moyenne/nombreVal;
    }
    
    
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre un nombre n");
        int.TryParse(Console.ReadLine(), out int n);
        
        IEnumerable<int> integers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        foreach (int value in integers)
        {
            Console.Write(value + " ");
            
        }
        Console.WriteLine("La moyenne est de : " + MoyenneTableau(integers,n));
    }
}