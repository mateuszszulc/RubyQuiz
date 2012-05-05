using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MadLibsChapter1
{
    class MadLibs
    {
        int fileNameNumber;
        public void run()
        {
            selectMadLibSource();
            prepareTokens();
            startGame();
            printResult();
        }

        private void printResult()
        {
            throw new NotImplementedException();
        }

        private void startGame()
        {
            throw new NotImplementedException();
        }

        private void prepareTokens()
        {
            throw new NotImplementedException();
        }

        private void selectMadLibSource()
        {
            //Possible extensions:
            //1. Reading user-prompts from file
            //2. multi-language support - resource files
            //3. Move whole logic to separate class responsible for 
            //user interactions, available file names etc.
            Console.WriteLine("Available MadLibs:");
            Console.WriteLine("1. Launch Hungers");
            Console.WriteLine("2. Gift Giving");

            int[] validNumbers = new int[] {1,2};
            fileNameNumber = userInputValidator(validNumbers);
        }

        private int userInputValidator(int[] validNumbers)
        {
            int userInputParsed = -1;
            while (!validNumbers.Contains(userInputParsed))
            {
                Console.WriteLine("Please enter valid file number");
                string userInput = Console.ReadLine();
                userInputParsed = int.Parse(userInput);
            }
            return userInputParsed;
        }
    }
}
