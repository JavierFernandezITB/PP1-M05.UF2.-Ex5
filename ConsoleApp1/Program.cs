
using UtilsLib;

namespace myNamespace
{
    public class myClass
    {
        public static void Main()
        {
            Utils utils = new Utils();

            const string inputOption = "Que deseas hacer?";
            const string optionsMenu = "\t1. Validar si un número es impar.\n" +
                "\t2. Calcular la potencia de un número.\n" +
                "\t3. Mostrar un valor aleatorio.\n" +
                "\t4. Contar las vocales de un texto\n" +
                "\t5. Salir";

            bool mainMenuLoop = true;

            while (mainMenuLoop)
            {
                Console.Clear();
                Console.WriteLine(inputOption);
                Console.WriteLine(optionsMenu);
                switch (Convert.ToInt32(Console.ReadLine())) 
                {
                    case 1:
                        ValidateNum(utils);
                        break;
                    
                    case 5:
                        mainMenuLoop = false;
                        break;
                }
                utils.PressAnyKey();
            }
        }

        public static void ValidateNum(Utils utils)
        {
            const string isOdd = "El valor introducido es impar.";
            const string isNotOdd = "El valor introducido NO es impar.";
            const string askForValue = "Introduce un valor: ";

            Console.WriteLine(askForValue);
            Console.WriteLine(utils.IsOddNumber(Convert.ToInt32(Console.ReadLine())) ? isOdd : isNotOdd);
        }

        
    }
}