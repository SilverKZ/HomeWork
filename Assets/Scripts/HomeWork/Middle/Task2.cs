using System;
using UnityEngine;

namespace Middle
{
    public class Task2 : MonoBehaviour
    {
        private void Start()
        {
            int maxNumber = 10;
            int step = 3;
            string stringNumbers = GetStringNumbers(maxNumber, step);
            Debug.Log(stringNumbers);
        }

        private static string GetStringNumbers(int maxNumber, int step)
        {
            string stringNumbers = "";

            for (int i = 0; i <= maxNumber; i += step)
                stringNumbers += i + " ";

            return stringNumbers;
        }
    }
}

