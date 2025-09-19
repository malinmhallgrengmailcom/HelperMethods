namespace UsefulMethods
{
    public static class HelperMethodsInput
    {
        public static int UserInputInt()
        {
            bool validInput = false;
            int result = 0;

            while (!validInput) 
            {
                Console.WriteLine("Please input a number:");
                validInput = int.TryParse(Console.ReadLine(), out result);
            }

            return result;
        }

        public static int UserInputIntRange(int minRange, int maxRange)
        {
            //TODO
        }

        public static string UserInputStringRange(int minRange, int maxRange)
        {
            //TODO
        }
    }

    public static class HelpperMethodsFormat
    {
        public static string[] SplitBySpace(string inputString)
        {
            inputString = inputString.Trim();
            string[] splitString = inputString.Split(' ');

            return splitString;
        }
    }
}
