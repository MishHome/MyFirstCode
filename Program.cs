class Programm
{

    int X { get; set; }
    int Y { get; set; }
    
    
    static void Main(string[] args)
    {
       
        Programm myProg = new Programm();
        myProg.X = 1;
        myProg.Y = 2;
        int z = myProg.X + myProg.Y;

        string result = $"Результат сложения числа {myProg.X} и {myProg.Y} равен {z}";     
            
        Console.WriteLine(result);
        Console.ReadLine(); 
    }
}