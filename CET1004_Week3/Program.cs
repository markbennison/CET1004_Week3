using static CET1004_Week3.Menus;

namespace CET1004_Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuOption = Menus.GetMainMenuOption();

            while (menuOption > 0)
            {
                switch (menuOption)
                {
                    case 1:
                        Exercise1();
                        break;
                    case 2:
                        Exercise2();
                        break;
                }
            }

            void Exercise1()
            {
                Console.WriteLine("Please enter a number between 1 and 20:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            void Exercise2()
            {
                Console.WriteLine("Please enter a number a whole value number, positive or negative");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("The number is negative.");
					//Console.WriteLine("The number is " + number + 
					//    " and the Absolute Number is " + Math.Abs(number) + ".");

					Console.WriteLine("The number is {0} and the Absolute Number is {1}.",
                        number, Math.Abs(number));
				}
				else
                {
                    Console.WriteLine("The number is positive.");

				}

            }
        }
    }
}
