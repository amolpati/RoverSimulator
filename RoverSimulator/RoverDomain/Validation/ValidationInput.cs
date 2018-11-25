using System;
using System.Linq;

namespace RoverDomain.Validation
{
    public static class ValidationInput
    {

        public static int getValidatedNumber(string inputMessage, bool compare = false, int compareValue = 0)
        {
            string errorMessageNumber;

            int validatedNumber = 0;
            bool is_Validated = false;
            uint posValue = 0;
            while (!is_Validated)
            {
                string input = getInput(inputMessage);
                is_Validated = uint.TryParse(input, out posValue);
                validatedNumber = checked((int)posValue);
                errorMessageNumber = "Please enter positive integer value only";

                if (!is_Validated) Console.WriteLine(errorMessageNumber);
              
                else
                {
                    if (compare)
                    {
                        if (validatedNumber >= compareValue)
                        {
                            is_Validated = false;
                            errorMessageNumber = "Value should be less than size of Plateau";
                            Console.WriteLine(errorMessageNumber);

                        }
                    }
                }
            }

            return validatedNumber;
        }

        public static string getValidatedText(string inputMessage, string errorMessage, string[] validInputArray, bool singleInput = true)
        {
            bool is_Validated = false;
            string inputText = "";
            while (!is_Validated)
            {
                inputText = getInput(inputMessage);
                if (singleInput) is_Validated = validInputArray.Contains(inputText);
                else
                {
                    bool text_InValid = false;
                    foreach (char c in inputText)
                    {

                        if (!validInputArray.Contains(c.ToString())) text_InValid = true;
                    }
                    if (!text_InValid) is_Validated = true;
                }
                if (!is_Validated) Console.WriteLine(errorMessage);

            }
            return inputText;
        }

        public static string getInput(string inputMessage)
        {
            Console.WriteLine(inputMessage);
            string input = Console.ReadLine();
            return input;
        }

    }
}
