using UnityEngine;

[RequireComponent(typeof(Warrior))]
class Arena : MonoBehaviour
{
    private Warrior _firstWarrior;
    private Warrior _secondWarrior;

    private void Start()
    {
        _firstWarrior = gameObject.AddComponent<Warrior>();
        _firstWarrior.Initialize("Ashrah");
        _secondWarrior = gameObject.AddComponent<Warrior>();
        _secondWarrior.Initialize("Darrius");
        StartBattle();
    }

    private void StartBattle()
    {
        while (_firstWarrior.IsLive && _secondWarrior.IsLive)
        {
            _firstWarrior.ShowInfo();
            _secondWarrior.ShowInfo();
            Debug.Log("Воины атакуют друг друга");
            _firstWarrior.Attack(_secondWarrior);
            _secondWarrior.Attack(_firstWarrior);
        }

        if (_firstWarrior.IsLive)
            ShowWinResult(_firstWarrior, _secondWarrior);
        else if (_secondWarrior.IsLive)
            ShowWinResult(_secondWarrior, _firstWarrior);
        else
        {
            Debug.Log("Ничья:");
            _firstWarrior.ShowInfo();
            _secondWarrior.ShowInfo();
        }
    }

    private void ShowWinResult(Warrior firstWarrior, Warrior secondWarrior)
    {
        Debug.Log("Победил:");
        firstWarrior.ShowInfo();
        Debug.Log("Проиграл:");
        secondWarrior.ShowInfo();
    }
}

