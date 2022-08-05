using UnityEngine;

class Warrior : MonoBehaviour
{
    private string _name;
    private int _health;
    private int _minDamage;
    private int _maxDamage;

    public bool IsLive { get; private set; }

    public void Initialize(string name)
    {
        _name = name;
        _health = 100;
        _minDamage = 5;
        _maxDamage = 20;
        IsLive = true;
    }

    public void ShowInfo()
    {
        Debug.Log($"Warrior: {_name}, Health: {_health}");
    }

    public void Attack(Warrior enemy)
    {
        int damage = Random.Range(_minDamage, _maxDamage);
        enemy.Damage(damage);
    }

    public void Damage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
            IsLive = false;
    }
}

