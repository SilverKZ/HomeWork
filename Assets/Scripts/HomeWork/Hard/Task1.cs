using UnityEngine;

namespace Hard
{
    public class Task1 : MonoBehaviour
    {
        private void Start()
        {
            string encodedText = "2like1I4games3play";
            string decodedText = Decode(encodedText);
            Debug.Log(encodedText);
            Debug.Log(decodedText);
        }

        private string Decode(string encodedText)
        {
            string textWithSeparators = InsertSeparators(encodedText);
            string[] strings = textWithSeparators.Split(' ');
            string[] decodeWords = SortWords(strings);
            return MergeWords(decodeWords);
        }

        private string InsertSeparators(string text)
        {
            string result = "";
            bool previousSymbolIsNumber = true;

            for (int i = 0; i < text.Length; i++)
            {
                string currentSymbol = text[i].ToString();
                bool currentSymbolIsNumber = int.TryParse(currentSymbol, out var number);

                if ((currentSymbolIsNumber && !previousSymbolIsNumber) || (!currentSymbolIsNumber && previousSymbolIsNumber))
                    result += " ";

                result += currentSymbol;
                previousSymbolIsNumber = currentSymbolIsNumber;
            }

            return result;
        }

        private string[] SortWords(string[] strings)
        {
            int step = 2;
            int divider = 2;
            string[] result = new string[strings.Length / divider];

            for (int i = 0; i < strings.Length; i += step)
            {
                int index = int.Parse(strings[i]) - 1;
                result[index] = strings[i + 1];
            }

            return result;
        }

        private string MergeWords(string[] words)
        {
            string result = "";

            foreach (string word in words)
                result += word + " ";

            return result;
        }
    }
}

