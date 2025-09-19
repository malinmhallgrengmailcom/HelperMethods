namespace UsefulMethods
{
    public static class HelperMethodsInput
    {
        //Prompts and takes user input for an integer, error manages these
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


        public static int UserInputInt(int minRange, int maxRange)
        {
            bool validInput = false;
            int result = 0;

            while (!validInput)
            {
                Console.WriteLine($"Please input a number between {minRange} and {maxRange - 1}:");
                validInput = int.TryParse(Console.ReadLine(), out result);

                if (!validInput || result < minRange || result >= maxRange)
                {
                    validInput = false;
                }
            }

            return result;
        }

        //public static string UserInputStringRange(int minRange, int maxRange)
        //{
        //    //TODO
        //}
    }

    public static class HelperMethodsFormat
    {
        public static string[] SplitBySpace(string inputString)
        {
            inputString = inputString.Trim();
            string[] splitString = inputString.Split(' ');

            return splitString;
        }

        //public static string DisplayNumberTruncated(float numberToTruncate, int amountFloatingPoints)
        //{
        //    //TODO
        //}

        //public static string DisplayNumberTruncated(double numberToTruncate, int amountFloatingPoints)
        //{
        //    //TODO
        //}

        //public static string DisplayNumberTruncated(decimal numberToTruncate, int amountFloatingPoints)
        //{
        //    //TODO
        //}
    }
}
