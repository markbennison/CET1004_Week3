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
                }
            }

            void Exercise1()
            {

            }
        }
    }
}
