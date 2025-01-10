using UnityEngine;

public class DeadZone : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Health health = hitInfo.GetComponent<Health>();
        health.Die();
    }
}
