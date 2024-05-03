namespace ifandelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 100;
            int b = 200;
            
            /* check the boolean condition */
            if (a == 100)
            {

                /* if condition is true then check the following */
                if (b == 200)
                {
                    /* if condition is true then print the following */
                    Console.WriteLine("väärtus a-l on 100 ja väärtus b-l on 200");
                }
            }
            else
            {
                Console.WriteLine("Goodbye, World!");
            }
            
            
            
        }
    }
    
}
