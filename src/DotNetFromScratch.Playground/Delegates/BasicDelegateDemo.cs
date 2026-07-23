using DotNetFromScratch.Delegates.BasicDelegates;

namespace DotNetFromScratch.Playground.Delegates
{
    public static class BasicDelegateDemo
    {
        public static void Run()
        {

            #region ------------------------------- Basic Delegates ----------------------------------------------
            MessageHandler msg = SayHello;
            msg();
            msg = PrintError;
            msg();

            MessageWithParameterHandler msgWithParam = PrintMessage;
            msgWithParam("How are you today?");

            CalculationHandler calc = Add;
            Console.WriteLine($"sum is: {calc(8,2)}");

            calc = Multiply;
            Console.WriteLine($"this time it's a multiply result: {calc(8,2)}");

            Console.WriteLine($"calculatedValue: {ExecuteCalculation(200,3800,Multiply)}");

            Console.WriteLine($"calculatedValue: {ExecuteCalculation(1200,800, Subtract)}");
            #endregion
            #region ------------------------------- MultiCast Delegates ------------------------------------------
            MessageHandler? multiHandler;
            multiHandler = SayHello;
            multiHandler += PrintError;
            Console.WriteLine("MultiCast delegate:");
            multiHandler();
            multiHandler -= SayHello;
            Console.WriteLine("after removing one method:");
            multiHandler();
            multiHandler -= PrintError;
            multiHandler?.Invoke(); //for handling null

            CalculationHandler multiCalc = Add;
            multiCalc += Multiply;
            multiCalc += Subtract;
            Console.WriteLine($"result for multi calculation is: {multiCalc(10,6)}");

            foreach(CalculationHandler calcItem in multiCalc.GetInvocationList())
            {
                Console.WriteLine($"calc item is : {calcItem(10,6)}");
            }
            #endregion
            #region ------------------------------- Anonymous Method ----------------------------------------------
            CalculationHandler divide = delegate (int firstNum, int secondNum)
            {
                return firstNum / secondNum;
            };
            Console.WriteLine($"Anonymous method result is: {divide(60,6)}");
            #endregion
            #region ------------------------------- Lambda Expression ----------------------------------------------
            CalculationHandler modLong = (int firstNum, int secondNum) =>
            {
                return firstNum % secondNum;
            };
            CalculationHandler modMid = (int firstNum, int secondNum) => firstNum % secondNum;
            CalculationHandler mod = (firstNum, secondNum) => firstNum % secondNum;
            Console.WriteLine($"Lambda mod result is {mod(22,10)}");

            MessageHandler msgLambda = () => Console.WriteLine("This is a test for lamba with no input/output");
            msgLambda();
            MessageWithParameterHandler msgWithParamLambda = msg => Console.WriteLine(msg);
            msgWithParamLambda("This is a test for one input lambda");
            #endregion

        }

        private static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        private static void PrintError()
        {
            Console.WriteLine("There is an Error");
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        private static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        private static int Multiply (int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }
        private static int Subtract (int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        private static int ExecuteCalculation(int firstNumber, int secondNumber, CalculationHandler calcMethod)
        {
            return calcMethod(firstNumber, secondNumber);
        }
    }
}
