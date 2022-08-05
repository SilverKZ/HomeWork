using UnityEngine;

public class Task4 : MonoBehaviour
{
    private void Start()
    {
        float weight = 5f;
        Debug.Log($"{weight} pounds = {PoundsToKilograms(weight)} kilograms");
        Debug.Log($"{weight} kilograms = {KilogramsToPounds(weight)} pounds");
    }

    private float KilogramsToPounds(float weight)
    {
        return weight / 0.453f;
    }

    private float PoundsToKilograms(float weight)
    {
        return weight * 0.453f;
    }
}
