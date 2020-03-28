using UnityEngine;

public class Player : MonoBehaviour, IHaveHealth
{
    [SerializeField] private int _Health = 100;
    
    [Range(1,1000)] public int MaxHealth = 100;

    public int Health
    {
        get { return _Health; }
        private set
        {
            _Health = Mathf.Clamp(value, 0, MaxHealth); 
            if (IsDead)
                Die();
        }
    }

    public bool IsDead { get => Health <= 0;  }

    private void OnValidate()
    {
        Health = _Health;
    }

    public void TakeDamage(int damageAmount)
    {
        Health -= damageAmount;
    }

    public void Heal(int healAmount)
    {
        Health += healAmount;
    }

    private void Die()
    {
        Debug.Log("Player is dead.");
    }
    
    [ContextMenu("Take Lethal Damage")]
    private void TakeLethalDamage()
    {
        TakeDamage(Health);
    }
}