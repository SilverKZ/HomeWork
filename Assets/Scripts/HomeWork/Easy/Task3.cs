using UnityEngine;

public class Task3 : MonoBehaviour
{
    private void Start()
    {
        int dayWeekNumber = 5;
        DayWeek dayWeek = GetDayWeek(dayWeekNumber);
        ShowDayWeek(dayWeek);
    }

    private static DayWeek GetDayWeek(int dayWeekNumber)
    {
        switch (dayWeekNumber)
        {
            case 1: return DayWeek.Monday;
            case 2: return DayWeek.Tuesday;
            case 3: return DayWeek.Wednesday;
            case 4: return DayWeek.Thursday;
            case 5: return DayWeek.Friday;
            case 6: return DayWeek.Saturday;
            case 7: return DayWeek.Sunday;
            default: return DayWeek.None;
        }
    }

    private static void ShowDayWeek(DayWeek dayWeek)
    {
        string dayWeekText = "";

        switch (dayWeek)
        {
            case DayWeek.Monday:
                dayWeekText = "�����������";
                break;
            case DayWeek.Tuesday:
                dayWeekText = "�������";
                break;
            case DayWeek.Wednesday:
                dayWeekText = "�����";
                break;
            case DayWeek.Thursday:
                dayWeekText = "�������";
                break;
            case DayWeek.Friday:
                dayWeekText = "�������";
                break;
            case DayWeek.Saturday:
                dayWeekText = "�������";
                break;
            case DayWeek.Sunday:
                dayWeekText = "�����������";
                break;
            case DayWeek.None:
                dayWeekText = "�� ���������";
                break;
        }

        Debug.Log(dayWeekText);
    }
}

enum DayWeek
{
    None,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
