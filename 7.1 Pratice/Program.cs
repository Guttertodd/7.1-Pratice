namespace _7._1_Pratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //    Console.WriteLine("Are we there yet?");



            //int pin = 12345;
            //int entry;
            //Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            //Console.WriteLine("ENTER YOUR PIN: ");
            //int.TryParse(Console.ReadLine(), out entry);
            //Console.WriteLine();

            //while (entry != pin)
            //{
            //    Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
            //    Console.WriteLine("ENTER YOUR PIN: ") ;
            //    int.TryParse(Console.ReadLine(), out entry);
            //    Console.WriteLine() ;
            //}
            //Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");

            //a while loop is simaler to an if statement because it continues to execute the code in the following block for however long the expression is true. 
            //a while loop is different to an if statement beacsue an if statement gives you once the possibility to do something or not (or something else). Whereas a while loop does things as long as the condition is true.
            //When deleting int.TryParse(Console.ReadLine(), out entry); inside the loop, it started spamming "INCORRECT PIN. TRY AGAIN." unlimmited times. This is because it doesen't go all the way back to the top evry time you enter the wrong pin, therefore it will keep repeting saying its the wrong pin.   


            int secretNumber = 6;
            int entry;
            Console.WriteLine("Welcome to the number guesssing game!");
            Console.WriteLine("Try to guess the secret number... it is somewhere between 1-20... Good luck!");
            Console.WriteLine("What is your first guess?");
            int.TryParse(Console.ReadLine(), out entry);
            Console.WriteLine();
        }
    }
}
