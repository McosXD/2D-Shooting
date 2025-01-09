using UnityEngine;

public class HealthRestore : MonoBehaviour
{
    private int healthR = 40;
    private Health player;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Health health = hitInfo.GetComponent<Health>();
        if (health != null)
        {
            health.RestoreHealth(healthR);
        }

        Destroy(gameObject);
    }
}
