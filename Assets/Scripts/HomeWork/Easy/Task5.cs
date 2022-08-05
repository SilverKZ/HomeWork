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
            msgResult = $"{firstNumber} > {secondNumber}";
        else if (firstNumber < secondNumber)
            msgResult = $"{secondNumber}) > {firstNumber}";
        else
            msgResult = $"{firstNumber} = {secondNumber}";

        Debug.Log(msgResult);
    }
}
