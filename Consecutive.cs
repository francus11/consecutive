namespace unequal_characters
{
    static public class Consecutive
    {
        static public int UnequalCharacters(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            if (text == "")
            {
                throw new ArgumentException(nameof(text));
            }

            List<char> list = new List<char>();
            int maxSequence = 0;
            for (int i = 0; i < text.Length - maxSequence; i++)
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
            return maxSequence;
        }

        static public int IdenticalLatinLetters(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            if (text == "")
            {
                throw new ArgumentException(nameof(text));
            }

            char compare = text[0];
            int maxSequence = 0;
            int currentSequence = 0;
            foreach (var c in text)
            {
                if (c == compare)
                {
                    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    {
                        currentSequence++;
                    }
                }
                else
                {
                    compare = c;

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }

                    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    {
                        currentSequence = 1;
                    }
                    else
                    {
                        currentSequence = 0;
                    }
                }
            }

            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }

            return maxSequence;
        }

        static public int IdenticalDigits(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            if (text == "")
            {
                throw new ArgumentException(nameof(text));
            }

            char compare = text[0];
            int maxSequence = 0;
            int currentSequence = 0;
            foreach (var c in text)
            {
                if (c == compare)
                {
                    if (char.IsDigit(c))
                    {
                        currentSequence++;
                    }
                }
                else
                {
                    compare = c;

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }

                    if (char.IsDigit(c))
                    {
                        currentSequence = 1;
                    }
                    else
                    {
                        currentSequence = 0;
                    }
                }
            }

            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }

            return maxSequence;
        }
    }
}
