using UnityEngine;
using System.Collections;

public class MoveUpDownWithWait : MonoBehaviour
{
    public float speed = 2.0f; 
    public float movementRange = 3.0f; 
    public float waitTime = 2.0f; 

    private float startY; 

    void Start()
    {
        startY = transform.position.y; 
        StartCoroutine(MoveUpAndDown()); 
    }

    IEnumerator MoveUpAndDown()
    {
        while (true) 
        {
            yield return StartCoroutine(MoveToPosition(startY + movementRange / 2));

            yield return new WaitForSeconds(waitTime);

            yield return StartCoroutine(MoveToPosition(startY - movementRange / 2));

            yield return new WaitForSeconds(waitTime);
        }
    }

    IEnumerator MoveToPosition(float targetY)
    {
        while (Mathf.Abs(transform.position.y - targetY) > 0.01f) 
        {
            float step = speed * Time.deltaTime; 
            transform.position = new Vector3(
                transform.position.x,
                Mathf.MoveTowards(transform.position.y, targetY, step),
                transform.position.z
            );
            yield return null; 
        }
    }
}
