
using UnityEngine;

public class Arrow : MonoBehaviour
{  

    [SerializeField] private float speed;
   
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    private void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }

  
}
