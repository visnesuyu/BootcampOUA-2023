using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 10f; 
    public Vector3 target; 

    void Update()
    {
        
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);

        
        if (Vector3.Distance(transform.position, target) < 0.001f)
        {
            Destroy(gameObject);
        }
    }
}
