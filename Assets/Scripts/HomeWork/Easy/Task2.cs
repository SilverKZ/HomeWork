using UnityEngine;

public class Task2 : MonoBehaviour
{
    private void Start()
    {
        int firstNumber = 3;
        int secondNumber = 27;
        bool result = CheckDivisor(firstNumber, secondNumber);
        Debug.Log(result);
    }

    private bool CheckDivisor(int divisor, int dividend)
    {
        return (divisor == 0) ? false : dividend % divisor == 0;
    }
}
