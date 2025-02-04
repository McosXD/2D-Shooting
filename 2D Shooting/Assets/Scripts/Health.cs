using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Slider healthBar;

    public Transform spawnPoint;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Player took damage! Current health: " + currentHealth);
        UpdateHealthBar();
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void RestoreHealth(int healthR)
    {
        currentHealth += healthR;
        if (currentHealth >= 100)
        {
            currentHealth = maxHealth;
        }
        Debug.Log("Player health +40! Current health: " + currentHealth);
        UpdateHealthBar();
    }

    public void Die()
    {
        Debug.Log("Player died!");
        Respawn();
    }

    void Respawn()
    {
        transform.position = spawnPoint.position;
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        if (healthBar != null)
        {
            healthBar.value = (float)currentHealth / maxHealth;
        }
    }
}
