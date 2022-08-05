using UnityEngine;

public class Task5 : MonoBehaviour
{
    private void Start()
    {
        float firstNumber = 5.4f;
        float secondNumber = 3.6f;
        ShowNumberComparison(firstNumber, secondNumber);
    }

    private void ShowNumberComparison(float firstNumber, float secondNumber)
    {
        string msgResult;

        if (firstNumber > secondNumber)
            msgResult = $"Первое число ({firstNumber}) больше, второе число ({secondNumber}) меньше.";
        else if (firstNumber < secondNumber)
            msgResult = $"Второе число ({secondNumber}) больше, первое число ({firstNumber}) меньше.";
        else
            msgResult = $"Первое число ({firstNumber}) и второе число ({secondNumber}) равны.";

        Debug.Log(msgResult);
    }
}
