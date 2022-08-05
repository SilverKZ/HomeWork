using UnityEngine;

public class Task6 : MonoBehaviour
{
    private void Start()
    {
        int year = 1985;
        int century = YearToCentury(year);
        Debug.Log($"Year: {year}, Century: {century}");
    }

    private int YearToCentury(int year)
    {
        return year / 100 + 1;
    }
}
