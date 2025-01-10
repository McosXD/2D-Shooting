using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject theEndText;

    private void Start()
    {
        theEndText.SetActive(false); 
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Player"))
        {
            theEndText.SetActive(true);
        }
    }
}
