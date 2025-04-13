static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Please enter a word to check: ");
            string word = Console.ReadLine();
            string lower = word.ToLower();
            if (lower == "exit")
            {
                Console.WriteLine("Exited program");
                break;
            }

            bool isPalindrome = true;
            for (int i = 0; i < (word.Length / 2); i++)
            {
                if (lower[i] != lower[word.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine($"Is Palindrome: {isPalindrome}");
        }
    }
