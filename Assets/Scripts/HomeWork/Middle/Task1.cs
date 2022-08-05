using System;
using UnityEngine;

namespace Middle
{
    public class Task1 : MonoBehaviour
    {
        private void Start()
        {
            string numbers = "2 45 51 14 78 23 14";
            int maxNumber = GetMaxNumber(numbers);
            Debug.Log($"Строка чисел: {numbers}");
            Debug.Log($"Максимальное число: {maxNumber}");
        }

        private static int GetMaxNumber(string stringNumbers)
        {
            string[] stringsNumber = stringNumbers.Split(' ');
            int maxNumber = int.MinValue;

            for (int i = 0; i < stringsNumber.Length; i++)
            {
                int currentNumber = Convert.ToInt32(stringsNumber[i]);

                if (currentNumber > maxNumber)
                    maxNumber = currentNumber;
            }

            return maxNumber;
        }
    }
}

