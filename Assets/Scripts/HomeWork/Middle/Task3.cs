using System;
using UnityEngine;

namespace Middle
{
    public class Task3 : MonoBehaviour
    {
        private void Start()
        {
            int[] positiveNumbers = { 1, 3, 4, 6 };
            int evenSum = EvenSum(positiveNumbers);
            Debug.Log(evenSum);
        }

        private static int EvenSum(int[] numbers)
        {
            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenSum += numbers[i];
            }

            if (evenSum == 0)
                evenSum = -1;

            return evenSum;
        }
    }
}

