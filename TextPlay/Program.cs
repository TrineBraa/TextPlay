//Lag et enkelt kommandobasert program med følgende meny: 

//1.RotateText

//2.Change word

//    Etter brukeren har valgt 1 eller to skal de promptes for å skrive inn et ord. Ordet skal ta enten snus eller endres med følgende funksjoner

//1 -> En funksjon som tar en tekst som parameter og som returnerer teksten snudd i motsatt rekkefølge. For eksempel skal 'Terje' bli til 'ejreT.

//2 -> En funksjon som bytter ut alle 'e' med 'a' i tekst du sender inn


namespace TextPlay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "Choose your program, 1 for Rotate Text and 2 for ChangeWord, press 0 to exit the program");
                int answer = Int32.Parse(Console.ReadLine());
                if (answer == 0)
                {
                    break;
                }
                if (answer == 1)
                {
                    RotateText();
                }
                else if (answer == 2)
                {
                    ChangeWord();
                }
            }

            void RotateText()
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Write a Word or x to return to the main menu");
                    string rotateString = Console.ReadLine();
                    if (rotateString == "x")
                    {
                        break;
                    }

                    string BackwardString = "";
                    for (int i = rotateString.Length - 1; i>=0; i--)
                    {
                        BackwardString += rotateString[i];
                    }

                    Console.WriteLine(BackwardString);

                }
            }


//2 -> En funksjon som bytter ut alle 'e' med 'a' i tekst du sender inn


            void ChangeWord()
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Write a word to change, x to return to main menu");
                    string changeString = Console.ReadLine();
                    string newWord = "";
                    if (changeString == "x")
                    {
                        break;
                    }

                    for (int i = 0; i < changeString.Length; i++)
                    {
                        if (changeString[i] == 'e')
                        {
                            newWord += "a";
                        }
                        else
                        {
                            newWord += changeString[i];
                        }
                    }
                    Console.WriteLine(newWord);

                }
            }
        }
    }
}
