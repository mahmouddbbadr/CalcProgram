namespace CalcProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double FirstNumber, SecondNumber, result;
            string Opertaion, CheckExit;
            
            bool cont = true;
            Console.WriteLine("welcome to my calculator");
            while (cont) 
            {
                
                do
                {
                    Console.WriteLine("enter first num");
                }
                while (!double.TryParse(Console.ReadLine(), out FirstNumber));
                do
                {
                    Console.WriteLine("enter sec num");
                }
                while ((!double.TryParse(Console.ReadLine(), out SecondNumber)));
                do
                {
                    Console.WriteLine("enter operation you want to perfrom");
                    Opertaion = Console.ReadLine();
                }
                while ((Opertaion != "+") && (Opertaion != "-") && (Opertaion != "*") && (Opertaion != "/") && (Opertaion != "%"));

                switch (Opertaion)
                {
                    case "+":
                        result = FirstNumber + SecondNumber;
                        Console.WriteLine($"{FirstNumber}{Opertaion}{SecondNumber} = {result}");
                        break;

                    case "-":
                        result = FirstNumber - SecondNumber;
                        Console.WriteLine($"{FirstNumber}{Opertaion}{SecondNumber} = {result}");
                        break;

                    case "/":
                        if (SecondNumber != 0)
                        {
                            result = FirstNumber / SecondNumber;
                            Console.WriteLine($"{FirstNumber}{Opertaion}{SecondNumber} = {result}");

                        }
                        else
                        {
                            Console.WriteLine("division by zero is not allowed");
                        }
                        break;

                    case "*":
                        result = FirstNumber * SecondNumber;
                        Console.WriteLine($"{FirstNumber}{Opertaion}{SecondNumber} = {result}");
                        break;

                    case "%":
                        result = FirstNumber % SecondNumber;
                        Console.WriteLine($"{FirstNumber}{Opertaion}{SecondNumber} = {result}");
                        break;


                }
                Console.WriteLine("press any word to continue or press exit to end");
                CheckExit = Console.ReadLine();
                if (CheckExit.ToLower() == "exit")
                {
                    cont = false;
                }

            }
            


        }
    }
}