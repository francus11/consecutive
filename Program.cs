namespace unequal_characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write sequence of characters: ");

            string text = Console.ReadLine();

            List<char> list = new List<char>();
            int maxSequence = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int currentSequence = 0;
                list.Clear();
                foreach (var c in text[i..])
                {
                    if (!list.Contains(c))
                    {
                        list.Add(c);
                        currentSequence++;
                    }
                    else
                    {
                        if (currentSequence > maxSequence)
                        {
                            maxSequence = currentSequence;
                        }
                        currentSequence = 1;
                        list.Clear();
                        list.Add(c);
                    }
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
            }


            Console.WriteLine($"Max sequence of consecutive unequal characters contains {maxSequence} characters.");
        }
    }
}