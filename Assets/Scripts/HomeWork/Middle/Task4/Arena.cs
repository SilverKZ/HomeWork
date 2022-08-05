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
            Debug.Log("Warriors attack each other");
            _firstWarrior.Attack(_secondWarrior);
            _secondWarrior.Attack(_firstWarrior);
        }

        if (_firstWarrior.IsLive)
            ShowWinResult(_firstWarrior, _secondWarrior);
        else if (_secondWarrior.IsLive)
            ShowWinResult(_secondWarrior, _firstWarrior);
        else
        {
            Debug.Log("Dead heat:");
            _firstWarrior.ShowInfo();
            _secondWarrior.ShowInfo();
        }
    }

    private void ShowWinResult(Warrior firstWarrior, Warrior secondWarrior)
    {
        Debug.Log("Won:");
        firstWarrior.ShowInfo();
        Debug.Log("Lost:");
        secondWarrior.ShowInfo();
    }
}

