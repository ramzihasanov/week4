namespace ConsoleApp1
{
    internal class Program
    {
         static int CustomLastIndexOf(string source, char target)
        {
            for (int i = source.Length - 1; i >= 0; i--)
            {
                if (source[i] == target)
                    return i;
            }
            return -1;
        }

         static bool CustomContains(string source, string substring)
        {
            for (int i = 0; i <= source.Length - substring.Length; i++)
            {
                bool isMatch = true;
                for (int j = 0; j < substring.Length; j++)
                {
                    if (source[i + j] != substring[j])
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch)
                    return true;
            }
            return false;
        }

         static string CustomReplace(string source, char oldChar, char newChar)
        {
            char[] charArray = source.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == oldChar)
                    charArray[i] = newChar;
            }
            return new string(charArray);
        }

         static string CustomSubstring(string source, int startIndex, int length)
        {
            if (startIndex < 0)
                startIndex = 0;
            if (startIndex + length > source.Length)
                length = source.Length - startIndex;
            char[] resultArray = new char[length];
            for (int i = 0; i < length; i++)
            {
                resultArray[i] = source[startIndex + i];
            }
            return new string(resultArray);
        }

        static string CustomTrim(string source)
        {
            int startIndex = 0;
            while (startIndex < source.Length && char.IsWhiteSpace(source[startIndex]))
            {
                startIndex++;
            }

            int endIndex = source.Length - 1;
            while (endIndex >= 0 && char.IsWhiteSpace(source[endIndex]))
            {
                endIndex--;
            }

            if (endIndex < startIndex)
            {
                return string.Empty;
            }

            return CustomSubstring(source, startIndex, endIndex - startIndex + 1);
        }

        static void Main(string[] args)
        {
            string text = "Merhaba, dünya!";
            char targetChar = 'a';
            string searchSubstring = "dünya";
            char oldChar = 'a';
            char newChar = 'X';
            int startIndex = 4;
            int length = 5;

            int customLastIndex = CustomLastIndexOf(text, targetChar);
            bool customContains = CustomContains(text, searchSubstring);
            string customReplacedText = CustomReplace(text, oldChar, newChar);
            string customSubstring = CustomSubstring(text, startIndex, length);
            string customTrimmedText = CustomTrim("      hello world      ");

            Console.WriteLine("CustomLastIndexOf: " + customLastIndex);
            Console.WriteLine("CustomContains: " + customContains);
            Console.WriteLine("CustomReplace: " + customReplacedText);
            Console.WriteLine("CustomSubstring: " + customSubstring);
            Console.WriteLine("CustomTrim: " + customTrimmedText);
            Console.WriteLine("=================2ci task==============================");


            Worker worker = new Worker("remzi","hesenov");
            Worker worker1 = new Worker("eli", "eliyev");
            Department department = new Department();
            department.AddWorker(worker);
            department.AddWorker(worker1);
            department.ShowAllWorkers();

        }  
    }
}
