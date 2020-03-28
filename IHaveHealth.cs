public interface IHaveHealth
{
    int Health { get; }

    void TakeDamage(int damageAmount);
    void Heal(int healAmount);
}